using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_CheckList_Entrevista;
namespace Capa_Controlador_CheckList_Entrevista
{
    public class Cls_Controlador_CheckList
    {
        public DataTable fun_datos_pregunta()
        {

            Cls_Sentencias_Preguntas mdl = new Cls_Sentencias_Preguntas();

            DataTable dt = mdl.fn_obtener_preguntas();

            return dt;
        }
    }
}
