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

            //Txt_estado.ReadOnly = true;

            Cmb_tipoPago.Items.Add("");
            Cmb_tipoPago.Items.Add("Contado");
            Cmb_tipoPago.Items.Add("Credito");
            Cmb_tipoPago.SelectedIndex = 0;

            Cmb_unidad.Items.Add("Lote");
            Cmb_unidad.Items.Add("Pieza");
            Cmb_unidad.Items.Add("Docena");
            Cmb_unidad.Items.Add("Libra");
            Cmb_unidad.Items.Add("Galón");
            Cmb_unidad.SelectedIndex = 0;




            Dgv_DetalleProductos.Columns.Clear();

            
            Dgv_DetalleProductos.Columns.Add("Producto", "Producto");
            Dgv_DetalleProductos.Columns.Add("Unidad", "Unidad");
            Dgv_DetalleProductos.Columns.Add("Cantidad", "Cantidad");
            Dgv_DetalleProductos.Columns.Add("Precio", "Precio");

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


            if (string.IsNullOrEmpty(Txt_producto.Text) || string.IsNullOrEmpty(Txt_Cantidad.Text))
            {
                MessageBox.Show("Por favor, complete los campos necesarios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string producto = Txt_producto.Text;
            string Unidad = Cmb_unidad.Text;
            string cantidad = Txt_Cantidad.Text;
            string precio = Txt_PrecioUnitario.Text;




            Dgv_DetalleProductos.Rows.Add(producto, Unidad, cantidad, precio);



        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {


            Txt_producto.Clear();
            Txt_Cantidad.Clear();
            Txt_PrecioUnitario.Clear();
            Txt_producto.Focus();
        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {

            Txt_Proveedor.Clear();
            Txt_NumeroOrden.Clear();
            //  Cmb_tipoPago.Clear();
            Txt_serieFactura.Clear();
            Txt_producto.Clear();
            Txt_Cantidad.Clear();
            // Cmb_unidad.Clear();
            Txt_PrecioUnitario.Clear();
            // Dgv_DetalleProductos.Clear();



        }

        private void Btn_Grabar_Click(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show("INICIO PROCESO");

                int proveedor;
                if (!int.TryParse(Txt_Proveedor.Text, out proveedor))
                {
                    MessageBox.Show("Proveedor inválido");
                    return;
                }

                string numero = Txt_NumeroOrden.Text;
                DateTime fecha = Dtp_fechaRegistro.Value;
                DateTime fechaEntrega = Dtp_fecha_entrega.Value;
                string tipoPago = Cmb_tipoPago.Text;

                int diasCredito;
                if (!int.TryParse(Txt_diascredito.Text, out diasCredito))
                {
                    MessageBox.Show("Días de crédito inválido");
                    return;
                }

                string estado = Txt_estado.Text;

                MessageBox.Show("Encabezado OK");

                decimal subtotal = 0;
                int filaIndex = 0;

                // 🔹 CALCULAR TOTAL
                foreach (DataGridViewRow row in Dgv_DetalleProductos.Rows)
                {
                    if (row.IsNewRow) continue;

                    var valCant = row.Cells["Cantidad"].Value;
                    var valPrecio = row.Cells["Precio"].Value;

                    int cantidad;
                    decimal precio;

                    if (!int.TryParse(valCant?.ToString(), out cantidad))
                    {
                        MessageBox.Show($"ERROR en Cantidad en fila {filaIndex}");
                        continue;
                    }

                    if (!decimal.TryParse(valPrecio?.ToString(), out precio))
                    {
                        MessageBox.Show($"ERROR en Precio en fila {filaIndex}");
                        continue;
                    }

                    subtotal += cantidad * precio;
                    filaIndex++;
                }

                MessageBox.Show("Subtotal calculado: " + subtotal);

                decimal total = subtotal;

                // 🔹 GUARDAR ENCABEZADO
                int idOrden = cont.guardarOrdenCompra(
                    proveedor, numero, fecha,
                    fechaEntrega, tipoPago, diasCredito,
                    subtotal, total, estado
                );

                MessageBox.Show("Encabezado guardado ID: " + idOrden);

                //  GUARDAR DETALLE
                filaIndex = 0;

                foreach (DataGridViewRow row in Dgv_DetalleProductos.Rows)
                {
                    if (row.IsNewRow) continue;

                    MessageBox.Show($"Guardando fila: {filaIndex}");

                    var valCant = row.Cells["Cantidad"].Value;
                    var valPrecio = row.Cells["Precio"].Value;

                    MessageBox.Show($"Cantidad: {valCant} | Precio: {valPrecio}");

                    int cantidad;
                    decimal precio;

                    if (!int.TryParse(valCant?.ToString(), out cantidad))
                    {
                        MessageBox.Show($"ERROR Cantidad en fila {filaIndex}");
                        continue;
                    }

                    if (!decimal.TryParse(valPrecio?.ToString(), out precio))
                    {
                        MessageBox.Show($"ERROR Precio en fila {filaIndex}");
                        continue;
                    }

                    // se guarda el detalle
                    cont.guardarDetalle(idOrden, cantidad, precio);

                    MessageBox.Show($"Fila {filaIndex} guardada");

                    filaIndex++;
                }

                MessageBox.Show("✅ Orden guardada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("💥 ERROR GENERAL: " + ex.Message + "\n\n" + ex.StackTrace);
            }













        }







    }
}
    
