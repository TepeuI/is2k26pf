using Capa_Controlador_Compras;
using Capa_Controlador_CXP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa_Vista_Compras
{

    public partial class Frm_inicio_devoluciones_d : Form
    {
        private readonly Cls_Devoluciones_Controlador controlador = new Cls_Devoluciones_Controlador();

       

        public Frm_inicio_devoluciones_d()
        {
            InitializeComponent();

            this.Load += Frm_inicio_devoluciones_d_Load;
            Btn_ingresar.Click += Btn_ingresar_Click;
            Btn_refrescar.Click += Btn_refrescar_Click;
            Btn_salir.Click += Btn_salir_Click;
        }

        private void Frm_inicio_devoluciones_d_Load(object sender, EventArgs e)
        {
            CargarCompras();
        }

        private void CargarCompras()
        {
            try
            {
                Dgv_devoluciones.DataSource = controlador.MostrarComprasParaDevolucion();
                Dgv_devoluciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dgv_devoluciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Dgv_devoluciones.MultiSelect = false;
                Dgv_devoluciones.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar compras para devolución: " + ex.Message);
            }
        }

        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            CargarCompras();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dgv_devoluciones.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una compra para continuar.");
                    return;
                }

                int idCompra = Convert.ToInt32(Dgv_devoluciones.CurrentRow.Cells["IdCompra"].Value);

                Frm_Devoluciones_d frm = new Frm_Devoluciones_d(idCompra);
                frm.ShowDialog();

                CargarCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la devolución: " + ex.Message);
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
