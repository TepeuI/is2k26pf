using System;
using System.Data;
using Capa_Modelo;

namespace Capa_Controlador
{
    public class Cls_Controlador_Sentencias
    {
        Cls_Sentencias_Comprobante_Compra modelo = new Cls_Sentencias_Comprobante_Compra();

        public bool InsertarComprobante(
            int fkIdEntregaCompra,
            int fkIdCliente,
            string nombreReceptor,
            DateTime fechaHoraEntrega,
            string observaciones,
            string estado)
        {
            return modelo.InsertarComprobanteCompra(
                fkIdEntregaCompra,
                fkIdCliente,
                nombreReceptor,
                fechaHoraEntrega,
                observaciones,
                estado
            );
        }

        public bool ActualizarComprobante(
            int pkIdComprobante,
            int fkIdEntregaCompra,
            int fkIdCliente,
            string nombreReceptor,
            DateTime fechaHoraEntrega,
            string observaciones,
            string estado)
        {
            return modelo.ActualizarComprobanteCompra(
                pkIdComprobante,
                fkIdEntregaCompra,
                fkIdCliente,
                nombreReceptor,
                fechaHoraEntrega,
                observaciones,
                estado
            );
        }

        public bool EliminarComprobante(int pkIdComprobante)
        {
            return modelo.EliminarComprobanteCompra(pkIdComprobante);
        }

        public DataTable MostrarComprobantes()
        {
            return modelo.MostrarComprobantesCompra();
        }

        public DataTable BuscarComprobante(int pkIdComprobante)
        {
            return modelo.BuscarComprobanteCompra(pkIdComprobante);
        }

        public DataTable fun_ObtenerIdComprobanteCompra()
        {
            return modelo.fun_ObtenerIdComprobanteCompra();
        }

        public DataTable fun_ObtenerIdEntregaCompra()
        {
            return modelo.fun_ObtenerIdEntregaCompra();
        }

        public DataTable fun_ObtenerIdCliente()
        {
            return modelo.fun_ObtenerIdCliente();
        }

        public DataTable Fun_Obtener_Detalle_Entrega_Compra(int I_Id_Entrega_Compra)
        {
            return modelo.Fun_Obtener_Detalle_Entrega_Compra(I_Id_Entrega_Compra);
        }
    }
}