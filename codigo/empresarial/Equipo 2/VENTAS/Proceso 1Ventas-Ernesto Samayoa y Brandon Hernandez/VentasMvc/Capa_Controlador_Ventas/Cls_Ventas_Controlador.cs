using System;
using System.Data;
using Capa_Modelo_Ventas;

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
        //OBTENER INVENTARIOS PARA GRID (COMBOBOX)
        public DataTable ObtenerInventarioGrid()
        {
            return dao.ObtenerInventarioGrid();
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
        public (string tipoCliente, float descuento) ObtenerTipoYDescuento(int iCantidad)
        {
            if (iCantidad >= 1 && iCantidad <= 11)
                return ("Publico", 0f);

            if (iCantidad >= 12 && iCantidad <= 47)
                return ("Mayorista", 0.15f);

            return ("Distribuidor", 0.25f);
        }

        //CALCULAR SUBTOTAL CON DESCUENTO APLICADO
        public float CalcularSubtotalConDescuento(float fPrecio, int iCantidad)
        {
            var resultado = ObtenerTipoYDescuento(iCantidad);

            float subtotal = fPrecio * iCantidad;
            float descuentoAplicado = subtotal * resultado.descuento;

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

        public bool GuardarVenta(DateTime dCmp_Fecha_Venta, int iFk_Id_Cliente, int iFk_Id_Sucusal, string sCmp_Estado_Venta, string sCmp_Tipo_Operacion, float fSaldototal, DataTable detalle)
        {
            if (detalle.Rows.Count == 0)
                return false;

            return dao.GuardarVentaCompleta(dCmp_Fecha_Venta, iFk_Id_Cliente, iFk_Id_Sucusal,  sCmp_Estado_Venta, sCmp_Tipo_Operacion, fSaldototal, detalle);
        }
    }
}