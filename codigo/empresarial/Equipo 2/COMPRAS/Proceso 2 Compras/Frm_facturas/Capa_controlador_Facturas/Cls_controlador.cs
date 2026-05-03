using System;
using System.Data;
using Capa_modelo_factura;

using Capa_Controlador_CXP;
namespace Capa_controlador_Facturas
{
    public class Cls_controlador
    {

        Capa_modelo_factura.Cls_Sentencias sn = new Capa_modelo_factura.Cls_Sentencias();


        /*----------Cuentas por pagar-----------*/


        Cls_Compras_Controlador cxp = new Cls_Compras_Controlador();

        public DataTable llenarTblDetalle()
        {
            // Podrías agregar lógica de validación aquí si fuera necesario
            return sn.obtenerDetalles();
        }


        public DataTable getProveedores()
        {
            return sn.obtenerProveedores();
        }

        public DataTable getOrdenesCompra()
        {
            return sn.obtenerOrdenesCompra();
        }


        public DataTable obtenerUnidadMedida()
        {
            return sn.obtenerUnidadMedida();
        }


        public DataTable getProductos()
        {
            return sn.obtenerProductos();
        }



        public DataTable buscarCompra(string numero)
        {
            
            return sn.buscarCompraPorNumero(numero);
        }


        public DataTable obtenerDetalle(int id)
        {
            return sn.obtenerDetallePorCompra(id);
        }


        public int guardarCompra(int idProveedor, int idOrdenCompra, int idbodega, string serie,
                          string numero, DateTime fecha, string tipoPago,
                          decimal subtotal, decimal total,
                          int diasCredito, DateTime? fechaVencimiento)
        {
            return sn.guardarCompra(idProveedor, idOrdenCompra,idbodega, serie, numero, fecha,
                                     tipoPago, subtotal, total, diasCredito, fechaVencimiento);
        }

        public void guardarDetalleCompra(int idCompra, int idInventario,
                                          int cantidad, string unidad, decimal precio)
        {
            sn.guardarDetalleCompra(idCompra, idInventario, cantidad, unidad, precio);
        }

        public int obtenerIdInventario(string nombreProducto)
        {
            return sn.obtenerIdInventario(nombreProducto);
        }


        public decimal calcularTotalCompra(DataTable dtDetalle)
        {
            decimal total = 0;
            foreach (DataRow fila in dtDetalle.Rows)
            {
                
                total += Convert.ToDecimal(fila["Subtotal"]);
            }
            return total;
        }

        /*---------------Boton-Actualizar-------*/



        public void actualizarCompra(int idCompra, int idProveedor, int idOrdenCompra, string serie,
                                string numero, DateTime fecha, string tipoPago,
                                decimal subtotal, decimal total,
                                int diasCredito, DateTime? fechaVencimiento)
        {
            // Reutilizamos la lógica de validación que definimos antes
            string pagoValidado = tipoPago.Trim().ToLower();
            sn.actualizarCompra(idCompra, idProveedor, idOrdenCompra, serie, numero, fecha,
                                pagoValidado, subtotal, total, diasCredito, fechaVencimiento);
        }



        public void eliminarDetalleCompra(int idCompra)
        {
            sn.eliminarDetalleCompra(idCompra);
        }

        public DataTable llenarComboBodega()
        {
         
            return sn.obtenerBodegas();
        }




    }
}
