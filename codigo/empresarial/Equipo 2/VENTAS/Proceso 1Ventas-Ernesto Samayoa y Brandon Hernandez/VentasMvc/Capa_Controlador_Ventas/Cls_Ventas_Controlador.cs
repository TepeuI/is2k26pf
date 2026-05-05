using System;
using System.Data;
using Capa_Modelo_Ventas;
using Capa_Controlador_Mov_Inv;
using System.Linq;

namespace Capa_Controlador_Ventas
{
    public class Cls_Ventas_Controlador
    {
        private Cls_VentasDAO dao = new Cls_VentasDAO();
        //OBTENER CLIENTES (COMBOBOX)
        public DataTable ObtenerClientes()
        {
            return dao.ObtenerClientes();
        }
        //OBTENER SUCURSALES (COMBOBOX)
        public DataTable ObtenerSucursales()
        {
            return dao.ObtenerSucursales();
        }
        //OBTENER INVENTARIO (COMBOBOX)
        public DataTable ObtenerInventario()
        {
            return dao.ObtenerInventario();
        }
        //OBTENER BODEGAS (COMBOBOX)
        public DataTable ObtenerBodegas()
        {
            return dao.ObtenerBodegas();
        }
        //OBTENER INVENTARIOS PARA GRID
        public DataTable ObtenerInventarioGrid()
        {
            return dao.ObtenerInventarioGrid();
        }

        //OBTENER ESTADOVENTA PARA COMBOBOX
        public DataTable ObtenerEstadoVenta()
        {
            return dao.ObtenerEstadoVenta();
        }

        //OBTENER Tipo operacion PARA COMBOBOX
        public DataTable ObtenerTipoOperacion()
        {
            return dao.ObtenerTipoOperacion();
        }



        //ID venta
        public int ObtenerSiguienteIdVenta()
        {
            return dao.ObtenerSiguienteIdVenta();
        }

        //Validar la asignaciones de vendedores cliente
        public (bool tieneVendedor, string Cmp_NombreVendedor) ValidarClienteVendedor(int iFk_Id_Cliente)
        {
            DataTable dt = dao.ObtenerVendedorDeCliente(iFk_Id_Cliente);

            if (dt.Rows.Count > 0)
            {
                string Cmp_NombreVendedor = dt.Rows[0]["Vendedor"].ToString();
                return (true, Cmp_NombreVendedor);
            }

            return (false, "");
        }

        //PARA VENTAS GENERALES
        public DataTable ObtenerListadoVentas()
        {
            return dao.ObtenerListadoVentas();
        }


        //NUEVO METODO PARA APLICAR DESCUENTO POR TIPO DE CLIENTE
        public (string sTipoCliente, float fDescuento) ObtenerDescuentoCliente(int iFk_Id_Cliente, float fCantidad)
        {
            return dao.ObtenerDescuentoCliente(iFk_Id_Cliente, fCantidad);
        }

        //CALCULAR SUBTOTAL CON DESCUENTO APLICADO
        public float CalcularSubtotal(float fPrecio, float fCantidad, float fDescuento)
        {
            float subtotal = fPrecio * fCantidad;
            float descuentoAplicado = subtotal * fDescuento;

            return subtotal - descuentoAplicado;
        }

        //CALCULAR SUBTOTAL SIN DESCUENTO APLICADO
        /*public float CalcularSubtotal(float fPrecio, int iCantidad)
        {
            return fPrecio * iCantidad;
        }*/

        public float CalcularTotal(DataTable dt)
        {
            float fSaldototal = 0;

            foreach (DataRow row in dt.Rows)
            {
                fSaldototal += Convert.ToSingle(row["Subtotal"]);
            }

            return fSaldototal;
        }
        //OBTENER BODEGAS POR PRODUCTO
        public DataTable ObtenerBodegasPorProducto(int pk_inventario_id)
        {
            return dao.ObtenerBodegasPorProducto(pk_inventario_id);
        }


        //GUARDAR VENTA-COTIZACION-PEDIDO
        public bool GuardarVenta(DateTime dCmp_Fecha_Venta, int iFk_Id_Cliente, int iFk_Id_Sucursal,
          string sCmp_Estado_Venta, string sCmp_Tipo_Operacion, float fCmp_Saldo_Total,
          DataTable detalle, DateTime dFecha_Especial, DateTime dCmp_Fecha_Vencimiento, bool bEsVenta)
        {
            // Mapear DataTable a lista de tuplas para el movimiento de inventario
            var detalleInventario = detalle.AsEnumerable()
                .Select(row => (
                    idInventario: row.Field<int>("IdProducto"),
                    idBodega: row.Field<int>("IdBodega"),
                    cantidad: row.Field<float>("Cantidad"),
                    1
                    //idUnidad: row.Field<int>("Id_Unidad")
                ))
                .ToList();

            Cls_Mov_Inv_Controlador inventario = new Cls_Mov_Inv_Controlador();
            bool actualizacionStock = inventario.fun_GuardarMovimiento(
                3,
                dCmp_Fecha_Venta,
                "Venta",
                detalleInventario
            );

            return dao.GuardarVentaCompleta(dCmp_Fecha_Venta, iFk_Id_Cliente, iFk_Id_Sucursal,
                sCmp_Estado_Venta, sCmp_Tipo_Operacion, fCmp_Saldo_Total, detalle,
                dFecha_Especial, dCmp_Fecha_Vencimiento, bEsVenta);
        }
    }
}