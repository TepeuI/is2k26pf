using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Ventas
{
    public partial class Frm_Clientes : Form
    {
        public Frm_Clientes()
        {
            InitializeComponent();
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config = new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_empleados"
            };
            string[] columnas = {
<<<<<<< HEAD
                    "Tbl_Clientes",
                    "Pk_Id_Cliente",
                    "Cmp_CuioNit",
                    "Cmp_Nombre",
                    "Cmp_Apellido",
                    "Cmp_Telefono",
                    "Cmp_Correo",
                    "Cmp_Saldo_Total",
                    "Cmp_Direccion",
                    "Cmp_Tipo",
                    "Cmp_Estado"
=======
                        "Tbl_Clientes",
                        "Pk_Id_Cliente",
                        "Cmp_CuioNit",
                        "Cmp_Nombre",
                        "Cmp_Apellido",
                        "Cmp_Telefono",
                        "Cmp_Correo",
                        "Cmp_Saldo_Total",
                        "Cmp_Direccion",
                        "Fk_Id_Tipo_Cliente",
                        "Cmp_Estado"

                     };

            string[] sEtiquetas = {
                        "ID",
                        "Cui/Nit",
                        "Nombre Cliente",
                        "Apellido Cliente",
                        "Teléfono",
                        "Correo",
                        "Saldo Total",
                        "Dirección",
                        "ID Tipo Cliente",
                        "Estado"
                     };

            // ─── CONFIGURACIÓN FK ────────────────────────────────────────────────
            List<Cls_ConfiguracionFK> fks = new List<Cls_ConfiguracionFK>
                {
                    new Cls_ConfiguracionFK
                    {
                        CampoFK         = "Fk_Id_Tipo_Cliente",
                        TablaReferencia = "Tbl_Tipo_Cliente",
                        CampoPK         = "Id_Tipo_Cliente",
                        CampoMostrar    = "Cmp_Tipo",

                        CamposEditables = new List<Cls_CampoEditable>
                        {
                            new Cls_CampoEditable { NombreCampo = "Cmp_Descripcion",  Etiqueta = "Descripcion", SoloLectura = true  },


                        }
                    },


>>>>>>> 98e060909a38870e0ca53b2cca3cb5a56b5db867
                };

            string[] sEtiquetas = {
                    "Código Cliente",
                    "CUI/NIT",
                    "Nombre",
                    "Apellido",
                    "Telefono",
                    "Correo",
                    "Saldo Total",
                    "Dirección",
                    "Tipo",
                    "Estado"
                };
            int id_aplicacion = 702;
            int id_Modulo = 44;
            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_Modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();

        }
    }
}
