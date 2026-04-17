using System.Data;
using Capa_Modelo_MOVINV;

namespace Capa_Controlador_MOVINV
{
    public class Controlador_Dashboard
    {
        Sentencias sn = new Sentencias();

        public DataTable LlenarGridControlador(string tabla)
        {
            return sn.ObtenerTabla(tabla);
        }
    }
}