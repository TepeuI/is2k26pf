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
    public partial class Frm_factura : Form
    {
        public Frm_factura()
        {
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        // configuracion botones
        private void ConfigurarBotonesInicio()
        {
            Btn_Ingresar.Enabled = true;
            Btn_Editar.Enabled = true;
            
            Btn_Imprimir.Enabled = true;
            Btn_Refrescar.Enabled = true;
//            Btn_Salir.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {

               
                Frm_detalle_compra frmDetalleCompra =  new Frm_detalle_compra();
                frmDetalleCompra.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle de Compra: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lbl_compras_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
