using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_CheckList_Entrevista;
namespace Capa_Vista_Migracion
{
    public partial class Frm_Mdi : Form
    {
        public Frm_Mdi()
        {
            InitializeComponent();
        }

        private void catálogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void preguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Preguntas Frm = new Frm_Preguntas();
            Frm.ShowDialog();
        }

        private void checkListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CheckList chklist = new Frm_CheckList();
            chklist.ShowDialog();
        }
    }
}
