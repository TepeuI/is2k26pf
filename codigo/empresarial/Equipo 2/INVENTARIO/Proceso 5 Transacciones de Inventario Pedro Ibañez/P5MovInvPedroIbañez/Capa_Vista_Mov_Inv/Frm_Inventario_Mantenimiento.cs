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
    public partial class Frm_Inventario_Mantenimiento : Form
    {
        public Frm_Inventario_Mantenimiento()
        {
            InitializeComponent();
            fun_cargar_combos();
        }

        Cls_Controlador_Inv ctrl = new Cls_Controlador_Inv();


                    //Cargar ComBoBoxes
        private void fun_cargar_combos()
        {
            DataTable dtIDInv = ctrl.fun_CargarInventarios();
            Cbo_Id_Inventario.DataSource = dtIDInv;
            Cbo_Id_Inventario.DisplayMember = "INVENTARIO";
            Cbo_Id_Inventario.ValueMember = "pk_inventario_id";
            Cbo_Id_Inventario.SelectedIndex = -1;

            DataTable dtIdLine = ctrl.fun_CargarLinea();
            Cbo_Linea.DataSource = dtIdLine;
            Cbo_Linea.DisplayMember = "LINEA";
            Cbo_Linea.ValueMember = "pk_id_linea";
            Cbo_Linea.SelectedIndex = -1;

            DataTable dtIdmarc = ctrl.fun_CargarMarca();
            Cbo_Marca.DataSource = dtIdmarc;
            Cbo_Marca.DisplayMember = "MARCA";
            Cbo_Marca.ValueMember = "ID_Marca";
            Cbo_Marca.SelectedIndex = -1;


            DataTable dttipProd = ctrl.fun_CargarTipoProd();
            Cbo_MPoPF.DataSource = dttipProd;
            Cbo_MPoPF.DisplayMember = "TipoVis";
            Cbo_MPoPF.ValueMember = "Tipo";
            Cbo_MPoPF.SelectedIndex = -1;

            DataTable dtestado = ctrl.fun_CargarEstado();
            Cbo_EstadoProducto.DataSource = dtestado;
            Cbo_EstadoProducto.DisplayMember = "STATE";
            Cbo_EstadoProducto.ValueMember = "STATE";
            Cbo_EstadoProducto.SelectedIndex = -1;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
