using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Capa_controlador_orden_compra;

namespace Capa_modelo_orden_compra
{
    public class Cls_Sentencias
    {


        // Instancia de tu clase de conexión (suponiendo que se llama Cls_Conexion)
        Cls_Conexion cn = new Cls_Conexion();


        public DataTable obtenerDetalles()
        {
            DataTable dt = new DataTable();
            // Combinamos las tablas para traer el nombre del producto en lugar de solo el ID
            string sql = @"SELECT 
    O.pk_id_orden_compra AS Orden,
    O.cmp_numero AS NumeroOrden,
    O.cmp_fecha AS Fecha,
    O.cmp_fecha_entrega AS FechaEntrega,
    PR.cmp_Nombre_Proveedor AS Proveedor,
    O.cmp_tipo_pago AS TipoPago,
    O.cmp_estado AS Estado,
    I.nombre_prod AS Producto,
    D.cmp_cantidad AS Cantidad,
    D.cmp_precio AS Precio,
    (D.cmp_cantidad * D.cmp_precio) AS Total
FROM tbl_detalle_orden_compra D
INNER JOIN tbl_orden_compra O
    ON D.fk_id_orden_compra = O.pk_id_orden_compra
INNER JOIN tbl_inventario I
    ON D.fk_inventario_id = I.pk_inventario_id
INNER JOIN tbl_proveedores PR
    ON O.fk_id_proveedor = PR.pk_id_proveedor
ORDER BY O.cmp_fecha DESC;";

            OdbcConnection conn = cn.conexion();
            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conn);
                dataTable.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en sentencia: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
            return dt;
        }






        //Insertar datos



        public int insertarOrdenCompra(int proveedor, string numero, DateTime fecha,
        DateTime fechaEntrega, string tipoPago, int diasCredito,
        decimal subtotal, decimal total, string estado)
        {
            int idGenerado = 0;

            string sql = @"INSERT INTO tbl_orden_compra 
        (fk_id_proveedor, cmp_numero, cmp_fecha, cmp_fecha_entrega, 
         cmp_tipo_pago, cmp_dias_credito, cmp_subtotal, cmp_total, cmp_estado)
        VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?); SELECT LAST_INSERT_ID();";

            OdbcConnection conn = cn.conexion();

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conn);

                cmd.Parameters.AddWithValue("@proveedor", proveedor);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@fechaEntrega", fechaEntrega);
                cmd.Parameters.AddWithValue("@tipoPago", tipoPago);
                cmd.Parameters.AddWithValue("@diasCredito", diasCredito);
                cmd.Parameters.AddWithValue("@subtotal", subtotal);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@estado", estado);

                idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar orden: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }

            return idGenerado;
        }

        public void insertarDetalleOrden(int idOrden, 
            int cantidad, decimal precio)
        {
            string sql = @"INSERT INTO tbl_detalle_orden_compra
        (fk_id_orden_compra, fk_inventario_id, cmp_cantidad, cmp_precio)
        VALUES (?, ?, ?, ?)";

            OdbcConnection conn = cn.conexion();

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conn);

                cmd.Parameters.AddWithValue("@orden", idOrden);                
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@precio", precio);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en detalle: " + ex.Message);
            }
            finally
            {
                cn.desconexion(conn);
            }
        }


























    }
}
