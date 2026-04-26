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
    public partial class Frm_ordencompra : Form
    {
        public Frm_ordencompra()
        {
            InitializeComponent();
        }

        private void Dgv_orden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Frm_detalle_orden_compra frmDetalleorden = new Frm_detalle_orden_compra();
            frmDetalleorden.ShowDialog();
        }
    }
}
