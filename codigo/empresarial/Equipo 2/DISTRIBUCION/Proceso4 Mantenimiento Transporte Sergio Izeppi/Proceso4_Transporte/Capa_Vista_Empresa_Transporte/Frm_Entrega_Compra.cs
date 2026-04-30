using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Emp_Transp;

namespace Capa_Vista_Empresa_Transporte
{
    public partial class Frm_Entrega_Compra : Form
    {
        Cls_Emp_Transp_Controlador controlador = new Cls_Emp_Transp_Controlador();

        int iCodigoEntrega = -1;

        int iCodigoCompraOriginal = 0;
        int iCodigoTransporteOriginal = 0;

        string sDireccionOriginal = "";
        string sFechaOriginal = "";
        string sEstadoOriginal = "";

        public Frm_Entrega_Compra()
        {
            InitializeComponent();
        }

        private void Frm_Entrega_Compra_Load(object sender, EventArgs e)
        {
            pro_CargarDatos2();

            Dgv_Entrega_Compra.Columns.Clear();
            Dgv_Entrega_Compra.Columns.Add("identregacompra", "ID Entrega de Compra");
            Dgv_Entrega_Compra.Columns.Add("idordencompra", "ID Orden de Compra");
            Dgv_Entrega_Compra.Columns.Add("idtransporte", "ID del Transporte");
            Dgv_Entrega_Compra.Columns.Add("direccion", "Direccion");
            Dgv_Entrega_Compra.Columns.Add("fecha", "Fecha");
            Dgv_Entrega_Compra.Columns.Add("estadoentrega", "Estado");

            Dgv_Entrega_Compra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Entrega_Compra.AllowUserToAddRows = false;

            pro_DatosCompras();
        }

        private void pro_CargarDatos2()
        {
            Cbo_Estado_Entrega.DataSource = null;
            Cbo_Estado_Entrega.Items.Clear();

            Cbo_Estado_Entrega.Items.Add("Estado");

            Cbo_Estado_Entrega.Items.Add("Pendiente");
            Cbo_Estado_Entrega.Items.Add("En_Camino");
            Cbo_Estado_Entrega.Items.Add("Entregado");

            Cbo_Estado_Entrega.SelectedIndex = 0;
        }

        private void pro_DatosCompras()
        {
            try
            {
                DataTable tabla = controlador.fun_DatosCompra();
                Dgv_Entrega_Compra.Rows.Clear();

                foreach (DataRow fila in tabla.Rows)
                {
                    int iIndice = Dgv_Entrega_Compra.Rows.Add();

                    Dgv_Entrega_Compra.Rows[iIndice].Cells["identregacompra"].Value = fila["codigo"];
                    Dgv_Entrega_Compra.Rows[iIndice].Cells["idordencompra"].Value = fila["compra"];
                    Dgv_Entrega_Compra.Rows[iIndice].Cells["idtransporte"].Value = fila["transporte"];
                    Dgv_Entrega_Compra.Rows[iIndice].Cells["direccion"].Value = fila["direccion"];
                    Dgv_Entrega_Compra.Rows[iIndice].Cells["fecha"].Value = fila["fecha"];
                    Dgv_Entrega_Compra.Rows[iIndice].Cells["estadoentrega"].Value = fila["estado"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            int iCodigoCompra = Convert.ToInt32(Txt_ID_Transporte.Text);
            int iCodigoTransporte = Convert.ToInt32(Txt_ID_Compra.Text);
            string sDireccion = Txt_Direccion.Text;
            string sFecha = DTP_Fecha.Value.ToString("yyyy-MM-dd");
            string sEstado = Cbo_Estado_Entrega.Text;

            // 2. VALIDAR CAMPOS VACÍOS
            if (string.IsNullOrWhiteSpace(Txt_ID_Transporte.Text) ||
                    string.IsNullOrWhiteSpace(Txt_ID_Compra.Text) ||
                    string.IsNullOrWhiteSpace(Txt_Direccion.Text) ||
                    Cbo_Estado_Entrega.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar todos los campos obligatorios", "Campos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(Txt_ID_Transporte.Text, out iCodigoCompra))
            {
                MessageBox.Show("ID de Compra no es válido");
                return;
            }

            if (!int.TryParse(Txt_ID_Compra.Text, out iCodigoTransporte))
            {
                MessageBox.Show("ID de Transporte no es válido");
                return;
            }

            if (controlador.fun_ExisteEntregaCompra(iCodigoCompra))
            {
                MessageBox.Show("Esta orden de compra ya tiene una entrega registrada");
                return;
            }

            sDireccion = Txt_Direccion.Text.Trim();
            sEstado = Cbo_Estado_Entrega.Text;
            // Usamos Value.ToString para que MySQL reciba la fecha correctamente
            sFecha = DTP_Fecha.Value.ToString("yyyy-MM-dd");

            // 4. CONFIRMACIÓN
            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro que desea registrar esta entrega de compra?",
                "Confirmar Registro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.No) return;

            // 5. PROCESO DE GUARDADO
            try
            {
                // Llamada al método de tu controlador
                controlador.pro_GuardarCompra(
                    iCodigoCompra,
                    iCodigoTransporte,
                    sDireccion,
                    sFecha,
                    sEstado
                );

                MessageBox.Show("Entrega registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // LIMPIAR CAMPOS
                Txt_ID_Transporte.Clear();
                Txt_ID_Compra.Clear();
                Txt_Direccion.Clear();
                DTP_Fecha.Value = DateTime.Now;
                Cbo_Estado_Entrega.SelectedIndex = 0;

                // RECARGAR GRID
                pro_DatosCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la entrega: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dgv_Entrega_Compra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = Dgv_Entrega_Compra.Rows[e.RowIndex];

            if (fila == null) return;

            // OBTENER DATOS
            int iCodigoEntrega = Convert.ToInt32(fila.Cells["identregacompra"].Value);

            int iCodigoCompra = Convert.ToInt32(fila.Cells["idordencompra"].Value);
            int iCodigoTransporte = Convert.ToInt32(fila.Cells["idtransporte"].Value);
            string sDireccion = fila.Cells["direccion"].Value?.ToString() ?? "";
            string sFecha = fila.Cells["fecha"].Value?.ToString() ?? "";
            string sEstado = fila.Cells["estadoentrega"].Value?.ToString() ?? "";


            // PASAR A CONTROLES
            Txt_ID_Transporte.Text = iCodigoCompra.ToString();
            Txt_ID_Compra.Text = iCodigoTransporte.ToString();
            Txt_Direccion.Text = sDireccion;
            DTP_Fecha.Text = sFecha;

            Cbo_Estado_Entrega.Text = sEstado;

            // GUARDAR ORIGINALES
            iCodigoCompraOriginal = iCodigoCompra;
            iCodigoTransporteOriginal = iCodigoTransporte;
            sDireccionOriginal = sDireccion;
            sFechaOriginal = sFecha;
            sEstadoOriginal = sEstado;

            // GUARDAR ID
            this.iCodigoEntrega = iCodigoEntrega;
        }

        private void pro_Actualizar(int iCodigoCompra, int iCodigoTransporte, string sDireccion, string sFecha, string sEstado)
        {
            try
            {
                bool bCambio = false;

                // VERIFICAR SI HUBO CAMBIOS
                if (iCodigoCompra != iCodigoCompraOriginal ||
                    iCodigoTransporte != iCodigoTransporteOriginal ||
                    !sDireccion.Equals(sDireccionOriginal, StringComparison.OrdinalIgnoreCase) ||
                    !sFecha.Equals(sFechaOriginal, StringComparison.OrdinalIgnoreCase) ||
                    !sEstado.Equals(sEstadoOriginal, StringComparison.OrdinalIgnoreCase))
                {
                    controlador.pro_ModificarCompra(
                        this.iCodigoEntrega,
                        iCodigoCompra,
                        iCodigoTransporte,
                        sDireccion,
                        sFecha,
                        sEstado
                    );

                    bCambio = true;
                }

                if (bCambio)
                {
                    MessageBox.Show("Entrega actualizada correctamente");

                    // LIMPIAR CAMPOS
                    Txt_ID_Transporte.Clear();
                    Txt_ID_Compra.Clear();
                    Txt_Direccion.Clear();
                    DTP_Fecha.Value = DateTime.Now;
                    Cbo_Estado_Entrega.SelectedIndex = 0;

                    // REINICIAR ID
                    iCodigoEntrega = -1;

                    // RECARGAR GRID
                    pro_DatosCompras();
                }
                else
                {
                    MessageBox.Show("No se ha cambiado ningún dato");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            string sDireccion = Txt_Direccion.Text;
            string sFecha = DTP_Fecha.Value.ToString("yyyy-MM-dd");
            string sEstado = Cbo_Estado_Entrega.Text;

            // VALIDAR SELECCIÓN
            if (iCodigoEntrega < 0)
            {
                MessageBox.Show("Seleccione primero una entrega");
                return;
            }

            // VALIDAR CAMPOS
            if (string.IsNullOrWhiteSpace(Txt_ID_Transporte.Text) ||
                string.IsNullOrWhiteSpace(Txt_ID_Compra.Text) ||
                string.IsNullOrWhiteSpace(sDireccion))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            // VALIDAR ID COMPRA
            if (!int.TryParse(Txt_ID_Compra.Text, out int iCodigoCompra))
            {
                MessageBox.Show("Ingrese un ID de compra válido");
                return;
            }

            // VALIDAR ID TRANSPORTE
            if (!int.TryParse(Txt_ID_Transporte.Text, out int iCodigoTransporte))
            {
                MessageBox.Show("Ingrese un ID de transporte válido");
                return;
            }

            // CONFIRMACIÓN
            DialogResult resultado = MessageBox.Show(
                "¿Desea actualizar la entrega?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
                return;

            // LLAMAR MÉTODO ACTUALIZAR
            pro_Actualizar(
                iCodigoCompra,
                iCodigoTransporte,
                sDireccion,
                sFecha,
                sEstado
            );
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (iCodigoEntrega < 0)
            {
                MessageBox.Show("Seleccione primero la fila del transporte que desea eliminar");
                return;
            }
            DialogResult resultado = MessageBox.Show(
               "¿Desea eliminar la entrega de la compra?",
               "Confirmación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );
            if (resultado == DialogResult.No)
                return;
            try
            {
                controlador.pro_EliminarCompra(iCodigoEntrega);
                MessageBox.Show("Dato eliminado correctamente");
                Txt_ID_Transporte.Clear();
                Txt_ID_Compra.Clear();
                Txt_Direccion.Clear();
                DTP_Fecha.Value = DateTime.Now;
                Cbo_Estado_Entrega.SelectedIndex = 0;

                // REINICIAR ID
                iCodigoEntrega = -1;

                // RECARGAR GRID
                pro_DatosCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Txt_ID_Transporte.Clear();
            Txt_ID_Compra.Clear();
            Txt_Direccion.Clear();
            DTP_Fecha.Value = DateTime.Now;
            Cbo_Estado_Entrega.SelectedIndex = 0;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
