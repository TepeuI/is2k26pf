using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Ventas;

namespace Capa_Vista_Ventas
{
    public partial class Frm_Asignacion_Clientes : Form
    {
        Cls_Asignacion_Clientes_Controlador controlador = new Cls_Asignacion_Clientes_Controlador();
        public Frm_Asignacion_Clientes()
        {
            InitializeComponent();
            this.Load += Frm_Asignacion_Clientes_Load;
        }
        private void Frm_Asignacion_Clientes_Load(object sender, EventArgs e)
        {
            fun_EstadoInicial();
            fun_CargarVendedores();
            fun_CargarClientes();
            fun_CargarGrid();
        }
        private void fun_CargarVendedores()
        {
            Cbo_Id_Vendedor.DataSource = controlador.ObtenerVendedores();
            Cbo_Id_Vendedor.DisplayMember = "NombreCompleto";
            Cbo_Id_Vendedor.ValueMember = "Pk_Id_Vendedor";
            Cbo_Id_Vendedor.SelectedIndex = -1;
        }
        private void fun_CargarClientes()
        {
            Cbo_Id_Cliente.DataSource = controlador.ObtenerClientes();
            Cbo_Id_Cliente.DisplayMember = "NombreCompleto";
            Cbo_Id_Cliente.ValueMember = "Pk_Id_Cliente";
            Cbo_Id_Cliente.SelectedIndex = -1;
        }
        private void fun_CargarGrid()
        {
            Dgv_Asignacion_clientes.DataSource = controlador.ObtenerAsignacionesConNombres();
            //Ocultar columnas ID
            Dgv_Asignacion_clientes.Columns["Pk_Id_Vendedor"].Visible = false;
            Dgv_Asignacion_clientes.Columns["Pk_Id_Cliente"].Visible = false;

        }

        private void fun_EstadoInicial()
        {
            // 🔹 Habilitados
            Btn_Ingresar.Enabled = true;
            Btn_Modificar.Enabled = true;
            Btn_Eliminar.Enabled = true;
            Btn_Buscar.Enabled = true;
            Btn_Reporte.Enabled = true;
            Btn_Ayuda.Enabled = true;
            Btn_Salir.Enabled = true;

            // 🔹 Deshabilitados
            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = false;
        }
        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Btn_Guardar.Enabled = true;
            Btn_Cancelar.Enabled = true;

            Btn_Ingresar.Enabled = false;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Buscar.Enabled = false;
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Id_Vendedor.SelectedValue == null || Cbo_Id_Cliente.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar vendedor y cliente.");
                    return;
                }

                int idVendedor = Convert.ToInt32(Cbo_Id_Vendedor.SelectedValue);
                int idCliente = Convert.ToInt32(Cbo_Id_Cliente.SelectedValue);

                var resultado = controlador.GuardarAsignacion(idVendedor, idCliente);

                MessageBox.Show(resultado.message);

                if (resultado.success)
                {
                    fun_CargarGrid(); 
                    Cbo_Id_Vendedor.SelectedIndex = -1;
                    Cbo_Id_Cliente.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            {
                fun_EstadoInicial();

                Cbo_Id_Vendedor.SelectedIndex = -1;
                Cbo_Id_Cliente.SelectedIndex = -1;

                Cbo_Id_Cliente.Enabled = true;

                fun_CargarGrid();
            }
            try
            {
                //Limpiar combos
                Cbo_Id_Vendedor.SelectedIndex = -1;
                Cbo_Id_Cliente.SelectedIndex = -1;

                //Habilitar controles
                Cbo_Id_Cliente.Enabled = true;
                Cbo_Id_Vendedor.Enabled = true;

                //Limpiar DataGrid
                Dgv_Asignacion_clientes.DataSource = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_Asignacion_clientes.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar un registro.");
                    return;
                }

                int idVendedor = Convert.ToInt32(Dgv_Asignacion_clientes.CurrentRow.Cells["Pk_Id_Vendedor"].Value);
                int idCliente = Convert.ToInt32(Dgv_Asignacion_clientes.CurrentRow.Cells["Pk_Id_Cliente"].Value);

                DialogResult resultadoConfirmacion = MessageBox.Show(
                    "¿Está seguro de eliminar el registro seleccionado?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultadoConfirmacion == DialogResult.Yes)
                {
                    var resultado = controlador.EliminarAsignacion(idVendedor, idCliente);

                    MessageBox.Show(resultado.message);

                    if (resultado.success)
                    {
                        fun_CargarGrid(); // refrescar
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            {
                Btn_Cancelar.Enabled = true;
                Btn_Ingresar.Enabled = false;
                Btn_Modificar.Enabled = false;
                Btn_Eliminar.Enabled = false;
                Btn_Buscar.Enabled = false;
                Btn_Guardar.Enabled = false;
                Btn_Reporte.Enabled = true;
                Btn_Ayuda.Enabled = true;
                Btn_Salir.Enabled = true;
            }
            MessageBox.Show("Seleccione un vendedor.");

            //Bloquear cliente
            Cbo_Id_Cliente.Enabled = false;

            //Limpiar selección
            Cbo_Id_Vendedor.SelectedIndex = -1;
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cbo_Id_Vendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Id_Vendedor.SelectedValue != null)
                {
                    int idVendedor = Convert.ToInt32(Cbo_Id_Vendedor.SelectedValue);

                    DataTable dt = controlador.ObtenerClientesPorVendedor(idVendedor);

                    if (dt.Rows.Count > 0)
                    {
                        //Mostrar datos
                        Dgv_Asignacion_clientes.DataSource = dt;

                        //Ocultar IDs
                        Dgv_Asignacion_clientes.Columns["Pk_Id_Vendedor"].Visible = false;
                        Dgv_Asignacion_clientes.Columns["Pk_Id_Cliente"].Visible = false;
                    }
                    else
                    {
                        //Mensaje si no hay asignaciones
                        MessageBox.Show("Este vendedor no tiene clientes asignados.");

                        // Limpiar grid
                        Dgv_Asignacion_clientes.DataSource = null;
                    }
                }
            }
            catch
            {
            }
        }
    }
}
