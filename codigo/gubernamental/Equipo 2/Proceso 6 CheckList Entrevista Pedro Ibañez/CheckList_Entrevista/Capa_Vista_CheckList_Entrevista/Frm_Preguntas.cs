using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_CheckList_Entrevista;
namespace Capa_Vista_CheckList_Entrevista
{
    public partial class Frm_Preguntas : Form
    {
        public Frm_Preguntas()
        {
            InitializeComponent();
            cargar_preguntas();
        }

        private void cargar_preguntas()
        {
            Cls_Controlador_CheckList ctrl = new Cls_Controlador_CheckList();
            DataTable dtpreguntas = ctrl.fun_datos_pregunta();
            DGV_PREGUNTAS_REP.DataSource = dtpreguntas;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
