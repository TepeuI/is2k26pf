using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Capa_Modelo_OrdenProduccion;
using System.Data;

//Kenph Luna 29/04/2026
namespace Capa_Controlador_OrdenProduccion
{
    public class Cls_ControladorOrdenP
    {
        private Cls_ProduccionDAO oProduccionDAO = new Cls_ProduccionDAO();

        //Metodo para Insertar
        public int InsertarOrdenProduccion(string sIdVendedor, DateTime dFechaEmision, DateTime dFechaEstimada, string sEstado, List<(string sIdProducto, string sCantidad)> lDetallesCrudos)
        {
            //Validaciones de Encabezado
            if (string.IsNullOrWhiteSpace(sIdVendedor) || !int.TryParse(sIdVendedor, out int iIdVendedor) || iIdVendedor <= 0)
            {
                throw new ArgumentException("El Vendedor seleccionado no es válido.");
            }

            if (dFechaEstimada.Date < dFechaEmision.Date)
            {
                throw new ArgumentException("La Fecha Estimada de Entrega no puede ser menor a la Fecha de Emisión.");
            }

            // Validación del ENUM
            var estadosValidos = new List<string> { "Emitida", "En Proceso", "Finalizada", "Recibida", "Cancelada" };
            if (!estadosValidos.Contains(sEstado))
            {
                throw new ArgumentException("El Estado seleccionado no es válido en el sistema.");
            }

            // Validaciones de Detalle
            if (lDetallesCrudos == null || lDetallesCrudos.Count == 0)
            {
                throw new ArgumentException("Debe ingresar al menos un producto en el detalle de la orden.");
            }

            List<(int iIdProducto, int iCantidadSolicitada)> lDetallesValidados = new List<(int, int)>();

            foreach (var det in lDetallesCrudos)
            {
                // Validar valores nulos
                if (string.IsNullOrWhiteSpace(det.sIdProducto) || string.IsNullOrWhiteSpace(det.sCantidad))
                    throw new ArgumentException("Existen campos vacíos en el detalle de productos.");

                // Validar que el ID del producto sea un número válido
                if (!int.TryParse(det.sIdProducto, out int iIdProd) || iIdProd <= 0)
                    throw new ArgumentException($"El producto con ID '{det.sIdProducto}' no es válido.");

                // Validar Cantidad
                if (!Regex.IsMatch(det.sCantidad, @"^\d+$"))
                    throw new ArgumentException("La cantidad debe contener únicamente números enteros positivos.");

                if (!int.TryParse(det.sCantidad, out int iCant) || iCant <= 0)
                    throw new ArgumentException("La cantidad solicitada debe ser mayor a cero y no puede ser negativa.");

                lDetallesValidados.Add((iIdProd, iCant));
            }

            // se inserta en DAO
            try
            {
                return oProduccionDAO.InsertarOrdenProduccion(iIdVendedor, dFechaEmision, dFechaEstimada, sEstado, lDetallesValidados);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la base de datos: " + ex.Message);
            }
        }

        // Método para Modificar
        public void ModificarOrdenProduccion(int idOrden, string sIdVendedor, DateTime dFechaEmision, DateTime dFechaEstimada, string sEstado, List<(string sIdProducto, string sCantidad)> lDetallesCrudos)
        {
            if (idOrden <= 0) throw new ArgumentException("ID de orden inválido.");

            //Validaciones de Encabezado
            if (string.IsNullOrWhiteSpace(sIdVendedor) || !int.TryParse(sIdVendedor, out int iIdVendedor) || iIdVendedor <= 0)
            {
                throw new ArgumentException("El Vendedor seleccionado no es válido.");
            }

            if (dFechaEstimada.Date < dFechaEmision.Date)
            {
                throw new ArgumentException("La Fecha Estimada de Entrega no puede ser menor a la Fecha de Emisión.");
            }

            // Validación del ENUM
            var estadosValidos = new List<string> { "Emitida", "En Proceso", "Finalizada", "Recibida", "Cancelada" };
            if (!estadosValidos.Contains(sEstado))
            {
                throw new ArgumentException("El Estado seleccionado no es válido en el sistema.");
            }

            // Validaciones de Detalle
            if (lDetallesCrudos == null || lDetallesCrudos.Count == 0)
            {
                throw new ArgumentException("Debe ingresar al menos un producto en el detalle de la orden.");
            }

            List<(int iIdProducto, int iCantidadSolicitada)> lDetallesValidados = new List<(int, int)>();

            foreach (var det in lDetallesCrudos)
            {
                // Validar valores nulos
                if (string.IsNullOrWhiteSpace(det.sIdProducto) || string.IsNullOrWhiteSpace(det.sCantidad))
                    throw new ArgumentException("Existen campos vacíos en el detalle de productos.");

                // Validar que el ID del producto sea un número válido
                if (!int.TryParse(det.sIdProducto, out int iIdProd) || iIdProd <= 0)
                    throw new ArgumentException($"El producto con ID '{det.sIdProducto}' no es válido.");

                // Validar Cantidad
                if (!Regex.IsMatch(det.sCantidad, @"^\d+$"))
                    throw new ArgumentException("La cantidad debe contener únicamente números enteros positivos.");

                if (!int.TryParse(det.sCantidad, out int iCant) || iCant <= 0)
                    throw new ArgumentException("La cantidad solicitada debe ser mayor a cero y no puede ser negativa.");

                lDetallesValidados.Add((iIdProd, iCant));
            }

            try
            {
                oProduccionDAO.ActualizarOrdenProduccion(idOrden, iIdVendedor, dFechaEmision, dFechaEstimada, sEstado, lDetallesValidados);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en BD: " + ex.Message);
            }
        }

        // Método para Eliminar
        public void EliminarOrden(string sIdOrden)
        {
            if (!int.TryParse(sIdOrden, out int idOrden) || idOrden <= 0)
            {
                throw new ArgumentException("Seleccione una orden válida para eliminar.");
            }

            try
            {
                oProduccionDAO.EliminarOrdenProduccion(idOrden);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en BD: " + ex.Message);
            }
        }




        //Obtener Datos
        public DataTable ObtenerVendedores()
        {
            return oProduccionDAO.ObtenerDatos(Cls_SentenciasSQL.sObtenerVendedores);
        }

        public DataTable ObtenerProductos()
        {
            return oProduccionDAO.ObtenerDatos(Cls_SentenciasSQL.sObtenerProductos);
        }

        public DataTable ObtenerEncabezados()
        {
            return oProduccionDAO.ObtenerDatos(Cls_SentenciasSQL.sObtenerEncabezados);
        }

        public DataTable ObtenerDetallesPorId(int idOrden)
        {
            return oProduccionDAO.ObtenerDetalles(idOrden);
        }
    }
}
