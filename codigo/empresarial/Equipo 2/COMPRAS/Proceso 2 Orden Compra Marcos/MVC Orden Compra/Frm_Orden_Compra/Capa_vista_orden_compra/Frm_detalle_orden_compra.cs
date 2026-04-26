using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_vista_orden_compra
{
    public partial class Frm_detalle_orden_compra : Form
    {
        public Frm_detalle_orden_compra()
        {
            InitializeComponent();

            Txt_estado.ReadOnly = true;

            Cmb_tipoPago.Items.Add("");
            Cmb_tipoPago.Items.Add("Contado");
            Cmb_tipoPago.Items.Add("Credito");
            Cmb_tipoPago.SelectedIndex = 0;

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
            string cantidad = Txt_Cantidad.Text;
            string precio = Txt_PrecioUnitario.Text;
           



            Dgv_DetalleProductos.Rows.Add(producto, cantidad, precio);



        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {


            Txt_producto.Clear();
            Txt_Cantidad.Clear();
            Txt_PrecioUnitario.Clear();
            Txt_producto.Focus();
        }
    }







}
    
