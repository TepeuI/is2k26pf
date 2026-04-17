using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Capa_Modelo_MOVINV
{
    public class Sentencias
    {
        Conexion con = new Conexion();

        // Este método traerá los datos de la tabla que le pidamos
        public DataTable ObtenerTabla(string tabla)
        {
            DataTable dt = new DataTable();
            try
            {
                // Usamos LIMIT 5 para que el Dashboard no se sature
                string sql = "SELECT * FROM " + tabla + " LIMIT 10;";
                MySqlDataAdapter adp = new MySqlDataAdapter(sql, con.conectar());
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                // Si algo falla con la tabla, esto nos avisará
                System.Windows.Forms.MessageBox.Show("Error en Sentencias: " + ex.Message);
            }
            return dt;
        }
    }
}