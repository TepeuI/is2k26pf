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
    public partial class Frm_Ventas : Form
    {
        private int _idVenta = 0;
        private int _idCliente = 0;
        private decimal _montoTotal = 0;
        public Frm_Ventas()
        {
            InitializeComponent();
     
    }

        private void Frm_Ventas_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_detalle_venta_Click(object sender, EventArgs e)
        {
            Frm_Detalle_Ventas frm = new Frm_Detalle_Ventas();
            frm.ShowDialog();
        }
    }
}
