using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Mov_Inv
{
    public partial class Frm_Movimientos_Inventario : Form
    {
        public Frm_Movimientos_Inventario()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Frm_Encabezado_Transaccion Trans = new Frm_Encabezado_Transaccion();
            Trans.ShowDialog();
        }
    }
}
