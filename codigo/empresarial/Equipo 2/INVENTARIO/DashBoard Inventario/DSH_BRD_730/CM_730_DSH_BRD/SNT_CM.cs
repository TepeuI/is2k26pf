using System;
using System.Data;
using System.Data.Odbc;

public class DSH_BRD_MOD
{
    // ── ULTIMOS MOVIMIENTOS ──────────────────────────────────────────────
    // Tablas: tbl_movimiento_inventario_encabezado (enc)
    //         tbl_movimiento_inventario_detalle    (det)
    //         tbl_inventario                       (inv)
    //         tbl_tipo_movimiento_inventario       (tip)
    public DataTable ObtenerUltimosMovimientos()
    {
        DataTable dt = new DataTable();
        try
        {
            using (OdbcConnection con = CNX.ObtenerConexion())
            {
                con.Open();
                string sql = @"
                    SELECT 
                        enc.fecha_transaccion       AS Fecha,
                        tip.efecto                  AS Tipo,
                        tip.nombre_tipo_inv         AS Movimiento,
                        inv.nombre_prod             AS Producto,
                        det.cantidad_transaccionada AS Cantidad,
                        enc.descripcion             AS Descripcion
                    FROM tbl_movimiento_inventario_encabezado enc
                    INNER JOIN tbl_movimiento_inventario_detalle det 
                        ON enc.pk_movimiento_id = det.fk_movimiento_id
                    INNER JOIN tbl_inventario inv 
                        ON det.fk_inventario_id = inv.pk_inventario_id
                    INNER JOIN tbl_tipo_movimiento_inventario tip 
                        ON enc.fk_tipo_movimiento_id = tip.pk_tipo_movimiento_id
                    ORDER BY enc.fecha_transaccion DESC
                    LIMIT 100";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, con);
                da.Fill(dt);
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener movimientos: " + ex.Message);
        }
        return dt;
    }

    // ── STOCK CRITICO ────────────────────────────────────────────────────
    // Tablas: tbl_existencias  (ex)
    //         tbl_inventario   (inv)
    //         tbl_bodega       (bod)
    // Stock crítico = productos con stock menor o igual a 50 (ajusta el umbral)
    public DataTable ObtenerStockCritico()
    {
        DataTable dt = new DataTable();
        try
        {
            using (OdbcConnection con = CNX.ObtenerConexion())
            {
                con.Open();
                string sql = @"
                SELECT 
                    inv.pk_inventario_id        AS Codigo,
                    inv.nombre_prod             AS Producto,
                    inv.tipo_producto           AS Tipo,
                    bod.Cmp_Nombre_Bodega       AS Bodega,
                    ex.stock                    AS Stock,
                    inv.precio_unitario         AS Precio_Unitario,
                    CASE 
                        WHEN ex.stock = 0    THEN 'SIN STOCK'
                        WHEN ex.stock <= 80  THEN 'CRÍTICO'
                        WHEN ex.stock <= 150 THEN 'BAJO'
                        WHEN ex.stock <= 300 THEN 'MEDIO'
                    END                         AS Nivel
                FROM tbl_existencias ex
                INNER JOIN tbl_inventario inv 
                    ON ex.fk_inventario_id = inv.pk_inventario_id
                INNER JOIN tbl_bodega bod 
                    ON ex.fk_bodega_id = bod.Pk_Id_Bodega
                WHERE ex.stock <= 300
                  AND inv.estado_producto = 'ACTIVO'
                  AND bod.Cmp_Estado_Bodega = 'Activo'
                ORDER BY ex.stock ASC";

                OdbcDataAdapter da = new OdbcDataAdapter(sql, con);
                da.Fill(dt);
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener stock crítico: " + ex.Message);
        }
        return dt;
    }
}