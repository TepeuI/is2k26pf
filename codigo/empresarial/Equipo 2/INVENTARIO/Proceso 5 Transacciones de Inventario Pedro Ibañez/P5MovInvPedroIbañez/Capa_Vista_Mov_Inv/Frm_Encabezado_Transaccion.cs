using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Mov_Inv;
using Capa_Modelo_Mov_Inv;

namespace Capa_Vista_Mov_Inv
{
    public partial class Frm_Encabezado_Transaccion : Form
    {
        public Frm_Encabezado_Transaccion()
        {
            InitializeComponent();
            fun_cargar_combos();
            EstadoInicialControles();
            EstadoInicialBotones();
        }

        Cls_Mov_Inv_Controlador ctrl = new Cls_Mov_Inv_Controlador();
        private Frm_Detalle_transaccion frmDetalle;

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EstadoInicialControles()
        {
            Cbo_Id_Movimiento.Enabled = false;
            CBO_ID_Tipo_Movimiento.Enabled = false;
            Cbo_IDBodega.Enabled = false;
            DTP_FECHA_Movimiento.Enabled = false;
            txt_descripcion.Enabled = false;

        }

        private void EstadoInicialBotones()
        {
            Btn_Agregar_Movimiento.Enabled = true;
            Btn_Cancelar.Enabled = false;
            Btn_Modificar.Enabled = true;
            btn_buscar.Enabled = true;
            BTN_LIMPIAR_ENCABEZADO.Enabled = true;
            Btn_Reporte.Enabled = true;
            Btn_Ayuda.Enabled = true;
            btn_Guardar.Enabled = false;
            Btn_detalle.Enabled = false;
        }

        private void EstadoControlesUso()
        {
            Cbo_Id_Movimiento.Enabled = true;
            CBO_ID_Tipo_Movimiento.Enabled = true;
            Cbo_IDBodega.Enabled = true;
            DTP_FECHA_Movimiento.Enabled = true;
            txt_descripcion.Enabled = true;
        }

        private void EstadoBotonesUso()
        {
            Btn_Agregar_Movimiento.Enabled = false;
            Btn_Cancelar.Enabled = true;
            Btn_Modificar.Enabled = false;
            btn_buscar.Enabled = false;
            BTN_LIMPIAR_ENCABEZADO.Enabled = true;
            Btn_Reporte.Enabled = false;
            Btn_Ayuda.Enabled = false;
            btn_Guardar.Enabled = true;
            Btn_detalle.Enabled = true;
        }

        private void LimpiarControlesEncabezado()
        {
            Cbo_Id_Movimiento.SelectedIndex = -1;
            CBO_ID_Tipo_Movimiento.SelectedIndex = -1;
            DTP_FECHA_Movimiento.Value = DateTime.Today;
            txt_descripcion.Text = "";

        }



        //Cargar ComBoBoxes
        private void fun_cargar_combos()
        {
            DataTable dtIDMovInv = ctrl.fun_CargarIdsMovimiento();
            Cbo_Id_Movimiento.DataSource = dtIDMovInv;
            Cbo_Id_Movimiento.DisplayMember = "pk_movimiento_id";
            Cbo_Id_Movimiento.ValueMember = "pk_movimiento_id";
            Cbo_Id_Movimiento.SelectedIndex = -1;

            DataTable dtIdTypeMov = ctrl.fun_CargarIdTypeMov();
            CBO_ID_Tipo_Movimiento.DataSource = dtIdTypeMov;
            CBO_ID_Tipo_Movimiento.DisplayMember = "TipoMov";
            CBO_ID_Tipo_Movimiento.ValueMember = "pk_tipo_movimiento_id";
            CBO_ID_Tipo_Movimiento.SelectedIndex = -1;

            DataTable dtIdBod = ctrl.fun_CargarIdBodega();
            Cbo_IDBodega.DataSource = dtIdBod;
            Cbo_IDBodega.DisplayMember = "BODEGA";
            Cbo_IDBodega.ValueMember = "Pk_Id_Bodega";
            Cbo_IDBodega.SelectedIndex = -1;
        }


        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Agregar_Movimiento_Click(object sender, EventArgs e)
        {
            EstadoControlesUso();
            EstadoBotonesUso();
        }

        private void BTN_LIMPIAR_ENCABEZADO_Click(object sender, EventArgs e)
        {
            LimpiarControlesEncabezado();
        }


        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            EstadoInicialControles();
            EstadoInicialBotones();
            LimpiarControlesEncabezado();
        }


        private bool verificar_controles()
        {
            // Validaciones

            if (Cbo_Id_Movimiento.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un id de movimiento valido", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Cbo_IDBodega.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un id de bodega valido", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (CBO_ID_Tipo_Movimiento.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un tipo de movimiento", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_descripcion.Text))
            {
                MessageBox.Show("Ingresa una descripción", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }



        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            bool Verificacion = verificar_controles();
            if (Verificacion)
            {
                // Verificar que el detalle fue abierto
                if (frmDetalle == null)
                {
                    MessageBox.Show("Debe abrir y agregar el detalle primero.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idBodega = Convert.ToInt32(Cbo_IDBodega.SelectedValue);
                int idTipoMovimiento = Convert.ToInt32(CBO_ID_Tipo_Movimiento.SelectedValue);
                DateTime fechaMovimiento = DTP_FECHA_Movimiento.Value;
                string descripcion = txt_descripcion.Text.Trim();

                // Obtener detalle desde la instancia del formulario
                List<Cls_Constructores> detalle = frmDetalle.ObtenerDetalle();

                if (detalle.Count == 0)
                {
                    MessageBox.Show("El detalle está vacío.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool resultado = ctrl.fun_GuardarMovimiento(idBodega, idTipoMovimiento,
                                                             fechaMovimiento, descripcion, detalle);
                if (resultado)
                {
                    MessageBox.Show("Movimiento guardado correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControlesEncabezado();
                }
                else
                {
                    MessageBox.Show("Error al guardar el movimiento", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Btn_detalle_Click(object sender, EventArgs e)
        {
            frmDetalle = new Frm_Detalle_transaccion();
            frmDetalle.Show();
        }

    }
    }





