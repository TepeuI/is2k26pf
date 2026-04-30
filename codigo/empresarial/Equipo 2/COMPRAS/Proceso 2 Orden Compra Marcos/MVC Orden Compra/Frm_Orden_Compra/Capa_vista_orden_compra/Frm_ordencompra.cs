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
    public partial class Frm_ordencompra : Form
    {

        Cls_controlador cont = new Cls_controlador();


        private void Frm_ordencompra_Load(object sender, EventArgs e)
        {
         
            llenarDataGridView();

        }


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


        public void llenarDataGridView()
        {

          
                // MENSAJE 1: ¿Se está ejecutando el método?
                MessageBox.Show("PASO 1: El método llenarDataGridView se ha iniciado.");

                try
                {
                    // MENSAJE 2: Antes de llamar al controlador
                    MessageBox.Show("PASO 2: Llamando al controlador...");
                    DataTable dt = cont.llenarTblDetalle();

                    // MENSAJE 3: ¿Qué regresó el controlador?
                    if (dt == null)
                    {
                        MessageBox.Show("PASO 3: ¡ERROR! El DataTable regresó NULO. Revisa la conexión u ODBC.");
                        return;
                    }

                    MessageBox.Show("PASO 4: El DataTable no es nulo. Cantidad de filas: " + dt.Rows.Count);

                    if (dt.Rows.Count > 0)
                    {
                        Dgv_orden.DataSource = dt;
                        MessageBox.Show("PASO 5: Datos asignados al DataGridView con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("PASO 5: El DataTable está VACÍO (0 filas). Revisa los datos en Workbench con INNER JOIN.");
                        Dgv_orden.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    // MENSAJE DE ERROR CRÍTICO
                    MessageBox.Show("PASO EXTRA: Ocurrió una excepción: " + ex.Message + "\n\nStack: " + ex.StackTrace);
                }
            }
       


        }
       
    }

