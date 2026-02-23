using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
namespace Capa_Modelo_CheckList_Entrevista
{
    public class Cls_Sentencias_Preguntas
    {
        Cls_ConexionMYSQL conexion = new Cls_ConexionMYSQL();

        public DataTable fn_obtener_preguntas()
        {
            DataTable dt_preguntas = new DataTable();

            OdbcConnection conn = conexion.conexion();

            try
            {
                string sSql = @"SELECT 
                                pk_pregunta_id, 
                                Cmp_Enunciado_Pregunta, 
                                Cmp_Nivel 
                                FROM tbl_preguntas;";

                OdbcDataAdapter da = new OdbcDataAdapter(sSql, conn);

                da.Fill(dt_preguntas);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener preguntas: " + ex.Message);
            }
            finally
            {
                conexion.desconexion(conn);
            }

            return dt_preguntas;
        }
    }
}
