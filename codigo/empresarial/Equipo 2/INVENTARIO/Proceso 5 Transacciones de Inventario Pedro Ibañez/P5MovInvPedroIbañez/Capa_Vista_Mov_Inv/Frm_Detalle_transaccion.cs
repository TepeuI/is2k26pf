using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Mov_Inv;
using Capa_Modelo_Mov_Inv;

namespace Capa_Vista_Mov_Inv
{
    public partial class Frm_Detalle_transaccion : Form
    {
        public Frm_Detalle_transaccion()
        {
            InitializeComponent();
            fun_cargar_combos();
        }

        Cls_Mov_Inv_Controlador ctrl = new Cls_Mov_Inv_Controlador();
        Cls_Constructores construc = new Cls_Constructores();

        private void LimpiarControlesDetalle()
        {
            Cbo_ID_Inventario.SelectedIndex = -1;
            NUD_Cant_mov.Value = 1;
            DGV_DETALLE_MOVIMIENTO.Rows.Clear();
        }

        private void fun_cargar_combos()
        {
            DataTable dtIdInv = ctrl.fun_CargarIdInventario();
            Cbo_ID_Inventario.DataSource = dtIdInv;
            Cbo_ID_Inventario.DisplayMember = "INVENTARIO";
            Cbo_ID_Inventario.ValueMember = "pk_inventario_id";
            Cbo_ID_Inventario.SelectedIndex = -1;
        }

        private void Btn_Agregar_Detalle_Click(object sender, EventArgs e)
        {
            if (Cbo_ID_Inventario.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un producto", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (NUD_Cant_mov.Value > 5000)
            {
                MessageBox.Show("Valor de cantidad no puede ser mayor a 5000", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Capturar el ID (ValueMember)
            int idProducto = Convert.ToInt32(Cbo_ID_Inventario.SelectedValue);

            // Capturar el Nombre (DisplayMember)
            DataRowView filaSeleccionada = (DataRowView)Cbo_ID_Inventario.SelectedItem;
            string nombreProducto = filaSeleccionada["INVENTARIO"].ToString();

            // Capturar cantidad
            int cantidad = (int)NUD_Cant_mov.Value;

            // Agregar fila al DataGridView con las 3 columnas: ID, Nombre, Cantidad
            DGV_DETALLE_MOVIMIENTO.Rows.Add(idProducto, nombreProducto, cantidad);

            // Limpiar controles
            Cbo_ID_Inventario.SelectedIndex = -1;
            NUD_Cant_mov.Value = 1;
        }

        private void Btn_Remover_Detalle_Click(object sender, EventArgs e)
        {
            if (DGV_DETALLE_MOVIMIENTO.SelectedRows.Count > 0)
            {
                DGV_DETALLE_MOVIMIENTO.Rows.Remove(DGV_DETALLE_MOVIMIENTO.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_LIMPIAR_DETALE_Click(object sender, EventArgs e)
        {
            LimpiarControlesDetalle();
        }

        public List<Cls_Constructores> ObtenerDetalle()
        {
            List<Cls_Constructores> lista = new List<Cls_Constructores>();

            foreach (DataGridViewRow fila in DGV_DETALLE_MOVIMIENTO.Rows)
            {
                if (fila.IsNewRow) continue;

                Cls_Constructores item = new Cls_Constructores()
                {
                    CodigoProducto = Convert.ToInt32(fila.Cells[0].Value),   // Columna 0 = ID
                    Cantidad = Convert.ToInt32(fila.Cells[2].Value),   // Columna 2 = Cantidad
                };
                lista.Add(item);
            }
            return lista;
        }
    }
}
