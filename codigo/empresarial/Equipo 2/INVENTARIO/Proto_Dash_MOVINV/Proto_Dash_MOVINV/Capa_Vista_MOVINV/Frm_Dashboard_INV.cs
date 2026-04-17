using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_MOVINV; // Referencia al controlador

namespace Capa_Vista_MOVINV
{
    public partial class Frm_Dashboard_INV : Form
    {
        // Instanciamos el controlador para pedirle los datos
        Controlador_Dashboard logic = new Controlador_Dashboard();

        public Frm_Dashboard_INV()
        {
            InitializeComponent();
            CargarGrids(); // Lo llamamos aquí para que cargue al abrir
        }

        private void CargarGrids()
        {
            try
            {
                DataTable dt = logic.LlenarGridControlador("tbl_tipo_movimiento_inventario");

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgv_Historial.DataSource = dt;

                    // --- CONFIGURACIÓN VISUAL (Solo si hay datos) ---
                    dgv_Historial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dgv_Historial.Columns[0].HeaderText = "ID";
                    dgv_Historial.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    dgv_Historial.Columns[1].HeaderText = "Movimiento";
                    dgv_Historial.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    dgv_Historial.Columns[2].HeaderText = "Efecto";
                    dgv_Historial.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    dgv_Historial.Columns[3].HeaderText = "Estado";
                    dgv_Historial.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    // Un toque extra: que no puedan editar el grid directamente
                    dgv_Historial.ReadOnly = true;
                    dgv_Historial.RowHeadersVisible = false; // Quita la flechita de la izquierda
                }
                else
                {
                    MessageBox.Show("No se encontraron registros.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}