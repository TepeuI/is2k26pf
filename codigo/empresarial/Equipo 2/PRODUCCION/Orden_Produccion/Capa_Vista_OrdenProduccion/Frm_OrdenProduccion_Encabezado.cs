using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_OrdenProduccion;

namespace Capa_Vista_OrdenProduccion
{
    public partial class Frm_OrdenProduccion_Encabezado : Form
    {
        private Cls_ControladorOrdenP oControlador = new Cls_ControladorOrdenP();
        public Frm_OrdenProduccion_Encabezado()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Frm_Ordenes_Encabezados_Load(object sender, EventArgs e)
        {
            Dgv_EncabezadoOrdenP.DataSource = oControlador.ObtenerEncabezados();
        }

        // Evento de doble clic en el DataGridView
        private void dgvEncabezados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar clic en los headers
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = Dgv_EncabezadoOrdenP.Rows[e.RowIndex];

                // Extraer datos de la fila seleccionada
                int idOrden = Convert.ToInt32(fila.Cells["Pk_ID_OrdenProduccion"].Value);
                string idVendedor = fila.Cells["Fk_ID_Vendedor"].Value.ToString();
                DateTime fechaEmision = Convert.ToDateTime(fila.Cells["Cmp_Fecha_Emision"].Value);
                DateTime fechaEstimada = Convert.ToDateTime(fila.Cells["Cmp_Fecha_Estimada_Entrega"].Value);
                string estado = fila.Cells["Cmp_Estado"].Value.ToString();

                // Llamar al formulario de detalles usando el constructor sobrecargado
                Frm_OrdenProduccion_Detalle frmDetalles = new Frm_OrdenProduccion_Detalle(idOrden, idVendedor, fechaEmision, fechaEstimada, estado);

                //bloquear controles
                // frmDetalles.DeshabilitarControles(); 

                frmDetalles.ShowDialog(); // ShowDialog lo abre como ventana modal

                //Refrescar
                Dgv_EncabezadoOrdenP.DataSource = oControlador.ObtenerEncabezados();
            }
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Frm_OrdenProduccion_Detalle FrmDetalle = new Frm_OrdenProduccion_Detalle();
            FrmDetalle.ShowDialog();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (Dgv_EncabezadoOrdenP.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una orden de la lista para borrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idOrdenStr = Dgv_EncabezadoOrdenP.CurrentRow.Cells["Pk_ID_OrdenProduccion"].Value.ToString();

            // Confirmación
            DialogResult dialogo = MessageBox.Show($"¿Está completamente seguro que desea eliminar la Orden No. {idOrdenStr} y todos sus detalles? Esta acción no se puede deshacer.", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogo == DialogResult.Yes)
            {
                try
                {
                    oControlador.EliminarOrden(idOrdenStr);
                    MessageBox.Show("Orden eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refrescar el DGV
                    Dgv_EncabezadoOrdenP.DataSource = oControlador.ObtenerEncabezados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Pnl_Botones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
