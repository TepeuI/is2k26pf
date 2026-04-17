using System;
using MySql.Data.MySqlClient;

namespace Capa_Modelo_MOVINV
{
    public class Conexion
    {
        public MySqlConnection conectar()
        {
            
            string cadena = "server=localhost; user id=root; password=Acces0F3R; database=bd_logistica";
            return new MySqlConnection(cadena);
        }
    }
}