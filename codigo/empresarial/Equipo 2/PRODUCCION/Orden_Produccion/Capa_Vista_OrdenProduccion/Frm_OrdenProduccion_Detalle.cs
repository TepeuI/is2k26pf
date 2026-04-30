using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_OrdenProduccion;

namespace Capa_Vista_OrdenProduccion
{
    public partial class Frm_OrdenProduccion_Detalle : Form
    {
        private Cls_ControladorOrdenP oControlador = new Cls_ControladorOrdenP();
        private int _idOrdenEditar = 0;
        public Frm_OrdenProduccion_Detalle()
        {
            InitializeComponent();

            Dgv_DetalleOrdenProduccion.Columns.Add("IdProducto", "ID Producto");
            Dgv_DetalleOrdenProduccion.Columns.Add("NombreProducto", "Producto");
            Dgv_DetalleOrdenProduccion.Columns.Add("CantidadSolicitada", "Cantidad Solicitada");
            Dgv_DetalleOrdenProduccion.Columns.Add("CantidadRecibida", "Cantidad Recibida");   
            
            LlenarCombos();
        }

        public Frm_OrdenProduccion_Detalle(int idOrden, string idVendedor, DateTime fechaEmi, DateTime fechaEst, string estado)
        {
            InitializeComponent();

            Dgv_DetalleOrdenProduccion.Columns.Add("IdProducto", "ID Producto");
            Dgv_DetalleOrdenProduccion.Columns.Add("NombreProducto", "Producto");
            Dgv_DetalleOrdenProduccion.Columns.Add("CantidadSolicitada", "Cantidad Solicitada");
            Dgv_DetalleOrdenProduccion.Columns.Add("CantidadRecibida", "Cantidad Recibida");

            LlenarCombos();

            _idOrdenEditar = idOrden;

            // Cargar datos al encabezado
            Txt_IDOrden.Text = idOrden.ToString();
            Cmb_Vendedor.SelectedValue = idVendedor;
            Dtp_FechaEmision.Value = fechaEmi;
            Dtp_FechaEntrega.Value = fechaEst;
            Cmb_Estado.SelectedItem = estado;

            // Cargar detalles al DataGridView
            CargarDetallesEnGrid(idOrden);

            //Activa/Desactiva controles
            ActivarControles(false);
        }

        private void ActivarControles(bool activo)
        {
            // Controles del encabezado
            Cmb_Vendedor.Enabled = activo;
            Dtp_FechaEmision.Enabled = activo;
            Dtp_FechaEntrega.Enabled = activo;
            Cmb_Estado.Enabled = activo;

            // Controles del detalle
            Cmb_Producto.Enabled = activo;
            Txt_CantidadSolicitada.Enabled = activo;

            // Botones de acción
            Btn_Aceptar.Enabled = activo; 
            Btn_Quitar.Enabled = activo; 
            Btn_Grabar.Enabled = activo;
        }

        private void LlenarCombos()
        {
            //Combo Vendedores
            Cmb_Vendedor.DataSource = oControlador.ObtenerVendedores();
            Cmb_Vendedor.DisplayMember = "NombreCompleto"; // El AS de MySQL
            Cmb_Vendedor.ValueMember = "Pk_Id_Vendedor";   // El ID real
            Cmb_Vendedor.SelectedIndex = -1;

            //Combo Productos
            Cmb_Producto.DataSource = oControlador.ObtenerProductos();
            Cmb_Producto.DisplayMember = "NombreProducto"; // El AS de MySQL
            Cmb_Producto.ValueMember = "pk_inventario_id"; // El ID real
            Cmb_Producto.SelectedIndex = -1;

            // 3. Combo Estado (Desde código ya que es Enum)
            Cmb_Estado.Items.Clear();
            Cmb_Estado.Items.AddRange(new string[] { "Emitida", "En Proceso", "Finalizada", "Recibida", "Cancelada" });
            Cmb_Estado.SelectedIndex = -1;
        }

        private void CargarDetallesEnGrid(int idOrden)
        {
            DataTable dtDetalles = oControlador.ObtenerDetallesPorId(idOrden);
            Dgv_DetalleOrdenProduccion.Rows.Clear();

            foreach (DataRow row in dtDetalles.Rows)
            {
                Dgv_DetalleOrdenProduccion.Rows.Add(
                    row["Fk_ID_Producto"].ToString(),           
                    row["NombreProducto"].ToString(),           
                    row["Cmp_Cantidad_Solicitada"].ToString(),  
                    row["Cmp_Cantidad_Recibida"].ToString()     
                );
            }
        }

        private void Btn_Grabar_Click(object sender, EventArgs e)
        {
            try
            {
                //Recopilar datos del Encabezado
                string sIdVendedor = Cmb_Vendedor.SelectedValue?.ToString();
                DateTime dEmision = Dtp_FechaEmision.Value;
                DateTime dEstimada = Dtp_FechaEntrega.Value;
                string sEstado = Cmb_Estado.SelectedItem?.ToString();

                //Recopilar datos del detalle
                List<(string, string)> lDetalles = new List<(string, string)>();

                foreach (DataGridViewRow fila in Dgv_DetalleOrdenProduccion.Rows)
                {
                    if (fila.IsNewRow) continue;

                    string sIdProd = fila.Cells["IdProducto"].Value.ToString();
                    string sCant = fila.Cells["CantidadSolicitada"].Value.ToString();

                    lDetalles.Add((sIdProd, sCant));
                }

                // Modo, si es editar o insertar
                if (_idOrdenEditar == 0)
                {
                    //Insertar
                    int idOrdenGenerada = oControlador.InsertarOrdenProduccion(sIdVendedor, dEmision, dEstimada, sEstado, lDetalles);

                    MessageBox.Show($"¡Orden de Producción No. {idOrdenGenerada} guardada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    //Editar
                    oControlador.ModificarOrdenProduccion(_idOrdenEditar, sIdVendedor, dEmision, dEstimada, sEstado, lDetalles);

                    MessageBox.Show($"¡Orden de Producción No. {_idOrdenEditar} modificada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            Cmb_Vendedor.SelectedIndex = -1;
            Cmb_Estado.SelectedIndex = -1;
            Dtp_FechaEmision.Value = DateTime.Now;
            Dtp_FechaEntrega.Value = DateTime.Now;
            Txt_CantidadSolicitada.Clear();
            Dgv_DetalleOrdenProduccion.Rows.Clear();
        }

        private void Btn_Quitar_Click(object sender, EventArgs e)
        {
            if (Dgv_DetalleOrdenProduccion.CurrentRow != null)
            {
                Dgv_DetalleOrdenProduccion.Rows.Remove(Dgv_DetalleOrdenProduccion.CurrentRow);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para quitar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            // Validaciones visuales rápidas
            if (Cmb_Producto.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(Txt_CantidadSolicitada.Text))
            {
                MessageBox.Show("Ingrese una cantidad solicitada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_CantidadSolicitada.Focus();
                return;
            }

            // Agregar al dgv
            Dgv_DetalleOrdenProduccion.Rows.Add(Cmb_Producto.SelectedValue.ToString(), Cmb_Producto.Text, Txt_CantidadSolicitada.Text);

            // Limpiar para el siguiente ingreso
            Txt_CantidadSolicitada.Clear();
            Cmb_Producto.SelectedIndex = -1;
        }

        //Evita que el usuario ponga letras en Cantidad Solicitada
        private void txtCantidadSolicitada_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números y la tecla de borrado (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_OrdenProduccion_Detalle_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            // Verificamos que realmente haya una orden cargada para editar
            if (_idOrdenEditar > 0)
            {
                // Desbloqueamos todos los textbox, combos y el botón Grabar
                ActivarControles(true);

                // Opcional: Bloqueamos el botón editar para que no lo vuelva a presionar
                Btn_Editar.Enabled = false;

                MessageBox.Show("Modo edición habilitado. Puede realizar sus cambios y presionar Grabar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay ninguna orden cargada para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

