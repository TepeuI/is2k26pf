using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_modelo_orden_compra;

namespace Capa_controlador_orden_compra
{
    public class Cls_controlador
    {


        Cls_Sentencias sn = new Cls_Sentencias();

        public DataTable llenarTblDetalle()
        {
            // Podrías agregar lógica de validación aquí si fuera necesario
            return sn.obtenerDetalles();
        }



        public int guardarOrdenCompra(int proveedor, string numero, DateTime fecha,
        DateTime fechaEntrega, string tipoPago, int diasCredito,
        decimal subtotal, decimal total, string estado)
        {
            return sn.insertarOrdenCompra(proveedor, numero, fecha,
                fechaEntrega, tipoPago, diasCredito, subtotal, total, estado);
        }

        public void guardarDetalle(int idOrden, int cantidad, decimal precio)
        {
            sn.insertarDetalleOrden(idOrden,  cantidad, precio);
        }  


    }
}
