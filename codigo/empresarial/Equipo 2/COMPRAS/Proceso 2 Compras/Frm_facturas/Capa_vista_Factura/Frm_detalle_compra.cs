using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_vista_Factura
{
    public partial class Frm_detalle_compra : Form
    {
        public Frm_detalle_compra()
        {
            InitializeComponent();


            Cmb_tipo.Items.Add("");
            Cmb_tipo.Items.Add("Contado");
            Cmb_tipo.Items.Add("Credito");
            Cmb_tipo.SelectedIndex = 0;


            Cmb_unidad.Items.Add("Lote");
            Cmb_unidad.Items.Add("Pieza");
            Cmb_unidad.Items.Add("Docena");
            Cmb_unidad.Items.Add("Libra");
            Cmb_unidad.Items.Add("Galón");
            Cmb_unidad.SelectedIndex = 0;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
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
            string Unidad = Cmb_unidad.Text;
            string precio = Txt_PrecioUnitario.Text;




            Dgv_DetalleProductos.Rows.Add(producto, cantidad, Unidad, precio);

        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {



            Txt_producto.Clear();
            Txt_Cantidad.Clear();
            Txt_PrecioUnitario.Clear();
            //Cmb_unidad.
            Txt_producto.Focus();
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
    }
}
