using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Ventas
{
    public partial class Frm_Ventas_Generales : Form
    {
        public Frm_Ventas_Generales()
        {
            InitializeComponent();
        }

        private void Btn_Agregar_Ventas_Click(object sender, EventArgs e)
        {
            Frm_Detalle_Ventas detalle_Ventas = new Frm_Detalle_Ventas();
            detalle_Ventas.ShowDialog();
        }
    }
}
