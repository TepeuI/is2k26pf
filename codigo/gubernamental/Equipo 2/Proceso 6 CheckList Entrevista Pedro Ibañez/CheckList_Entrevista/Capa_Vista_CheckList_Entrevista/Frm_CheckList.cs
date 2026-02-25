using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa_Vista_CheckList_Entrevista
{
    public partial class Frm_CheckList : Form
    {
        public Frm_CheckList()
        {
            InitializeComponent();
            DGV_PREGUNTAS_ENTREVISTA.RowsAdded += DGV_PREGUNTAS_ENTREVISTA_RowsAdded;
            DGV_PREGUNTAS_ENTREVISTA.RowsRemoved += DGV_PREGUNTAS_ENTREVISTA_RowsRemoved;
            Estado_Inicial_Controles();
            Estado_Inicial_Botones();
        }
        //AUMENTO AUTOMATICO DEL LABEL
        private void ActualizarTotal()
        {
            Lbl_Cant_Pregunta.Text =
            DGV_PREGUNTAS_ENTREVISTA.Rows
            .Cast<DataGridViewRow>()
            .Count(r => !r.IsNewRow)
            .ToString();
        }
        private void DGV_PREGUNTAS_ENTREVISTA_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ActualizarTotal();
        }
        private void DGV_PREGUNTAS_ENTREVISTA_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ActualizarTotal();
        }
        //===========================

        //ESTADOS Controles
        private void Estado_Inicial_Controles()
        {
            Cbo_Id_Entrevista.Enabled = false;
            CBO_DPI_SOLICITANTE.Enabled = false;
            DTP_FECHA_ENTREVISTA.Enabled = false;
            ChB_Estado.Enabled = false;
            ChB_Rechazado.Enabled = false;

        }

        private void Estado_Ingreso_Controles()
        {
            Cbo_Id_Entrevista.Enabled = true;
            CBO_DPI_SOLICITANTE.Enabled = true;
            DTP_FECHA_ENTREVISTA.Enabled = true;
            ChB_Estado.Enabled = true;
            ChB_Rechazado.Enabled = true;

        }
        //===========================

        //ESTADOS Botones
        private void Estado_Inicial_Botones()
        {
            Btn_Agregar_Entrevista.Enabled = true;
            Btn_Cancelar.Enabled = false;
            Btn_Modificar.Enabled = true;
            Btn_Reporte.Enabled = true;
            Btn_Ayuda.Enabled = true;
            Btn_Salir.Enabled = true;

            Btn_Agregar_Pregunta.Enabled = false;
            Btn_Remover_Pregunta.Enabled = false;
            BTN_LIMPIAR_PREG.Enabled = false;
            btn_Guardar.Enabled = false;

        }

        private void Estado_Ingreso_Botones()
        {
            Btn_Agregar_Entrevista.Enabled = false;
            Btn_Cancelar.Enabled = true;
            Btn_Modificar.Enabled = true;
            Btn_Reporte.Enabled = true;
            Btn_Ayuda.Enabled = true;
            Btn_Salir.Enabled = true;

            Btn_Agregar_Pregunta.Enabled = true;
            Btn_Remover_Pregunta.Enabled = true;
            BTN_LIMPIAR_PREG.Enabled = true;
            btn_Guardar.Enabled = true;

        }

        void LimpiarControles()
        {
            Cbo_Id_Entrevista.SelectedIndex = -1;
            CBO_DPI_SOLICITANTE.SelectedIndex = -1;
            DTP_FECHA_ENTREVISTA.Value = DateTime.Today;
            ChB_Estado.Checked = false;
            ChB_Rechazado.Checked = false;
        }
        //===========================
        private void ChB_Estado_CheckedChanged(object sender, EventArgs e)
        {
            ChB_Rechazado.Checked = false;
        }

        private void ChB_Rechazado_CheckedChanged(object sender, EventArgs e)
        {
            ChB_Estado.Checked = false;
        }

        private void Btn_Agregar_Pregunta_Click(object sender, EventArgs e)
        {
            Frm_Preguntas form_preguntas = new Frm_Preguntas(this);

            form_preguntas.ShowDialog();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AgregarPregunta(string id, string pregunta, string nivel)
        {
            DGV_PREGUNTAS_ENTREVISTA.Rows.Add(id, pregunta, nivel);
        }

        private void BTN_LIMPIAR_PREG_Click(object sender, EventArgs e)
        {
            DGV_PREGUNTAS_ENTREVISTA.Rows.Clear();
            ActualizarTotal();

        }

        private void Btn_Remover_Pregunta_Click(object sender, EventArgs e)
        {
            if (DGV_PREGUNTAS_ENTREVISTA.CurrentRow != null &&
        !DGV_PREGUNTAS_ENTREVISTA.CurrentRow.IsNewRow)
            {
                DGV_PREGUNTAS_ENTREVISTA.Rows.RemoveAt(
                    DGV_PREGUNTAS_ENTREVISTA.CurrentRow.Index
                );
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void Btn_Agregar_Entrevista_Click(object sender, EventArgs e)
        {
            Estado_Ingreso_Controles();
            Estado_Ingreso_Botones();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Estado_Inicial_Botones();
            LimpiarControles();
            Estado_Inicial_Controles();
        }

        private void BTN_LIMPIAR_ENCABEZADO_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
    }
}
