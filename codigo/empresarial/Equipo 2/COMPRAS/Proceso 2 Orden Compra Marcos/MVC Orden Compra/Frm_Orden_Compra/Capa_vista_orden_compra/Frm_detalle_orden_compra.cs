using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_controlador_orden_compra;

namespace Capa_vista_orden_compra
{
    public partial class Frm_detalle_orden_compra : Form
    {
        Cls_controlador cont = new Cls_controlador();

        public Frm_detalle_orden_compra()
        {
            InitializeComponent();
            cargarProductos();
            cargarProveedores();
            cargarUnidadMedida();
            cargarBodegas();
            CalcularTotal();
            CalcularTotalresta();
            

         
            Cmb_tipoPago.Items.Add("");
            Cmb_tipoPago.Items.Add("Contado");
            Cmb_tipoPago.Items.Add("Credito");
            Cmb_tipoPago.SelectedIndex = 0;

            Txt_estado.Enabled = false;

            Txt_NumeroOrden.Text = cont.generarNumeroOrden();
            Txt_NumeroOrden.Enabled = false;

            Txt_estado.Enabled = false;
            

        }

        private void Gpo_Encabezado_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Proveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {




            if (Dgv_DetalleProductos.SelectedRows.Count > 0)
            {
                // Preguntar al usuario para evitar borrados accidentales
                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar la fila seleccionada?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    // Elimina la fila seleccionada
                    foreach (DataGridViewRow fila in Dgv_DetalleProductos.SelectedRows)
                    {
                        // Solo permite borrar si no es la fila nueva (la que está vacía al final)
                        if (!fila.IsNewRow)
                        {
                            Dgv_DetalleProductos.Rows.Remove(fila);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila completa haciendo clic en la parte izquierda.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {

            if (Cmb_producto.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(Txt_Cantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(Txt_PrecioUnitario.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Precio inválido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int idInventario = Convert.ToInt32(Cmb_producto.SelectedValue);
            string producto = Cmb_producto.Text;
            string unidad = Cmb_unidad.Text;

            decimal subtotal = cantidad * precio;


            Dgv_DetalleProductos.Rows.Add(idInventario, producto, unidad, cantidad, precio, subtotal, subtotal);
            CalcularTotal();

            Txt_Cantidad.Clear();
            Txt_PrecioUnitario.Clear();


        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {


            
            Txt_Cantidad.Clear();
            Txt_PrecioUnitario.Clear();
            
        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {

           
           
            Txt_Cantidad.Clear();
            Txt_PrecioUnitario.Clear();
            



        }

        private void Btn_Grabar_Click(object sender, EventArgs e)
        {


            if (Cmb_proveedor.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un proveedor.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Cmb_bodega.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una bodega.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Cmb_tipoPago.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione el tipo de pago.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hayFilas = false;
            foreach (DataGridViewRow fila in Dgv_DetalleProductos.Rows)
                if (!fila.IsNewRow) { hayFilas = true; break; }

            if (!hayFilas)
            {
                MessageBox.Show("Agregue al menos un producto al detalle.", "Atención",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ── Leer datos del encabezado ─────────────────────────
            try
            {
                int idProveedor = Convert.ToInt32(Cmb_proveedor.SelectedValue);
                int idBodega = Convert.ToInt32(Cmb_bodega.SelectedValue);
                string numero = Txt_NumeroOrden.Text.Trim();
                DateTime fecha = Dtp_fechaRegistro.Value;       
                DateTime fechaEntrega = Dtp_fecha_entrega.Value;
                string tipoPago = Cmb_tipoPago.SelectedItem.ToString().Trim().ToLower();

                int diasCredito = 0;
                if (tipoPago == "credito")
                {
                    if (!int.TryParse(Txt_diascredito.Text, out diasCredito) || diasCredito <= 0)
                    {
                        MessageBox.Show("Ingrese los días de crédito válidos.", "Atención",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // ── Calcular subtotal y total desde el grid ───────
                decimal subtotal = 0;
                foreach (DataGridViewRow fila in Dgv_DetalleProductos.Rows)
                {
                    if (fila.IsNewRow) continue;
                    if (decimal.TryParse(fila.Cells["ColumnSubtotal"].Value?.ToString(),
                                         out decimal sub))
                        subtotal += sub;
                }
                decimal total = subtotal;

                // ── Guardar encabezado ────────────────────────────
                int idOrden = cont.guardarOrdenCompra(idProveedor, idBodega, numero,
                                                       fecha, fechaEntrega, tipoPago,
                                                       diasCredito, subtotal, total);

                // ── Guardar detalle fila por fila ─────────────────
                foreach (DataGridViewRow fila in Dgv_DetalleProductos.Rows)
                {
                    if (fila.IsNewRow) continue;

                    int idInventario = Convert.ToInt32(fila.Cells["ColumnCodigo"].Value);
                    int cantidad = Convert.ToInt32(fila.Cells["ColumnCantidad"].Value);
                    decimal precio = Convert.ToDecimal(fila.Cells["ColumnPrecioUnitario"].Value);

                    cont.guardarDetalleOrdenCompra(idOrden, idInventario, cantidad, precio);
                }

                MessageBox.Show("¡Orden de compra guardada correctamente!",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ── Limpiar formulario y generar nuevo número ─────
                Dgv_DetalleProductos.Rows.Clear();
                Txt_NumeroOrden.Text = cont.generarNumeroOrden();
                Txt_total.Text = "0.00";
                Txt_diascredito.Clear();
                Cmb_tipoPago.SelectedIndex = 0;
                Txt_estado.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }




        //Cargar los poroveedores
        private void cargarProveedores()
        {
            Cmb_proveedor.DataSource = cont.getProveedores();
            Cmb_proveedor.DisplayMember = "cmp_Nombre_Proveedor";
            Cmb_proveedor.ValueMember = "pk_id_proveedor";
        }

        private void cargarUnidadMedida()
        {
            DataTable dt = cont.obtenerUnidadMedida();



            Cmb_unidad.DataSource = dt;
            Cmb_unidad.DisplayMember = "Nombre_Unidad";
            Cmb_unidad.ValueMember = "ID_Unidad";
        }


        private void cargarProductos()
        {
            Cmb_producto.DataSource = cont.getProductos();
            Cmb_producto.DisplayMember = "nombre_prod";
            Cmb_producto.ValueMember = "pk_inventario_id";
        }


        void cargarBodegas()
        {

            Cmb_bodega.DataSource = cont.llenarComboBodega();

            Cmb_bodega.DisplayMember = "Cmp_Nombre_Bodega";
            Cmb_bodega.ValueMember = "Pk_Id_Bodega";
        }

        private void Cmb_tipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = Cmb_tipoPago.SelectedItem?.ToString().Trim().ToLower();

            if (tipo == "contado")
            {
             
                Txt_diascredito.Enabled = false;
             
            }
            else if (tipo == "credito")
            {
                
                Txt_diascredito.Enabled = true;
                   
            }
            else
            {
             
                Txt_diascredito.Enabled = false;
                               
            }


            
        }




        /*---------------Sumar Cnapos datagrid----------------*/




        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in Dgv_DetalleProductos.Rows)
            {
                if (row.IsNewRow) continue;

                decimal subtotal;

                if (decimal.TryParse(row.Cells["ColumnTotal"].Value?.ToString(), out decimal valorTotal))
                {
                    total += valorTotal;
                }
            }

            Txt_total.Text = total.ToString("0.00");
        }


        private void CalcularTotalresta()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in Dgv_DetalleProductos.Rows)
            {
                if (row.IsNewRow) continue;

                int cantidad;
                decimal precio;

                if (!int.TryParse(row.Cells["ColumnCantidad"].Value?.ToString(), out cantidad))
                    continue;

                if (!decimal.TryParse(row.Cells["ColumnPrecioUnitario"].Value?.ToString(), out precio))
                    continue;

                total += cantidad * precio;
            }

            Txt_total.Text = total.ToString("0.00");
        }

        private void Txt_NumeroOrden_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Txt_estado.Text = "Pendiente";
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
           /* string numeroBusqueda = Txt_Buscar.Text.Trim(); // tu TextBox de búsqueda

            if (string.IsNullOrEmpty(numeroBusqueda))
            {
                // Si está vacío, cargar todos los registros
                Dgv_DetalleProductos.DataSource = cont.llenarTblDetalle();
                return;
            }

            DataTable resultado = cont.buscarOrdenPorNumero(numeroBusqueda);

            if (resultado.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró ninguna orden con ese número.",
                                "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dgv_DetalleProductos.DataSource = null;
                return;
            }

            Dgv_DetalleProductos.DataSource = resultado; */
        }
    }
}
    
