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
    public partial class Frm_Movimientos_Inventario : Form
    {
        Cls_Controlador_Encabezado ctrl = new Cls_Controlador_Encabezado();
        
        public Frm_Movimientos_Inventario()
        {
            InitializeComponent();
            fun_CargarDGV();
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

        private void fun_CargarDGV()
        {
            try
            {
                DataTable dtMovimientos = ctrl.fun_CargarMovimientos();
                Dgv_Encabezado_Movimiento_Inventarios.DataSource = dtMovimientos;

                // Personalizar encabezados de columnas
                Dgv_Encabezado_Movimiento_Inventarios.Columns["ID"].HeaderText = "ID Movimiento";
                Dgv_Encabezado_Movimiento_Inventarios.Columns["ID_Tipo"].HeaderText = "ID Tipo";
                Dgv_Encabezado_Movimiento_Inventarios.Columns["Tipo_Movimiento"].HeaderText = "Tipo Movimiento";
                Dgv_Encabezado_Movimiento_Inventarios.Columns["Fecha"].HeaderText = "Fecha";
                Dgv_Encabezado_Movimiento_Inventarios.Columns["Descripcion"].HeaderText = "Descripción";

                Dgv_Encabezado_Movimiento_Inventarios.AllowUserToAddRows = false;
                Dgv_Encabezado_Movimiento_Inventarios.ReadOnly = true;
                Dgv_Encabezado_Movimiento_Inventarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dgv_Encabezado_Movimiento_Inventarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dgv_Encabezado_Movimiento_Inventarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar clic en encabezado
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow fila = Dgv_Encabezado_Movimiento_Inventarios.Rows[e.RowIndex];

                // Guardar datos en la clase
                Cls_Constructor_Encabezado Encab = new Cls_Constructor_Encabezado()
                {
                    ID = Convert.ToInt32(fila.Cells["ID"].Value),
                    IdTipoMovimiento = Convert.ToInt32(fila.Cells["ID_Tipo"].Value),
                    TipoMovimiento = fila.Cells["Tipo_Movimiento"].Value.ToString(),
                    Fecha = Convert.ToDateTime(fila.Cells["Fecha"].Value),
                    Descripcion = fila.Cells["Descripcion"].Value.ToString()
                };

                // Abrir formulario y enviar datos
                Frm_Encabezado_Transaccion frmEncabezado = new Frm_Encabezado_Transaccion(Encab);
                frmEncabezado.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            fun_CargarDGV();
        }
    }
}
