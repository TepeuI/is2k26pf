using Capa_Modelo_Compras;
using Capa_Modelo_CXP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controlador_Compras
{
    public class Cls_Devoluciones_Controlador
    {
        private readonly Cls_Devoluciones_Sentencias sentencias = new Cls_Devoluciones_Sentencias();

        public DataTable MostrarComprasParaDevolucion()
        {
            return sentencias.Fun_MostrarComprasParaDevolucion();
        }

        public DataTable MostrarDevoluciones()
        {
            return sentencias.Fun_MostrarDevoluciones();
        }

        public DataTable ObtenerIdsCompra()
        {
            return sentencias.Fun_ObtenerIdsCompra();
        }

        public DataTable ObtenerFacturas()
        {
            return sentencias.Fun_ObtenerFacturas();
        }

        public DataTable ObtenerProveedores()
        {
            return sentencias.Fun_ObtenerProveedores();
        }

        public DataTable BuscarCompraPorId(int idCompra)
        {
            return sentencias.Fun_BuscarCompraPorId(idCompra);
        }

        public DataTable ObtenerDetalleCompra(int idCompra)
        {
            return sentencias.Fun_ObtenerDetalleCompra(idCompra);
        }
    }
}
