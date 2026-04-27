using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_CXP
{
    public class Cls_Compras_Sentencias
    {
        private readonly Cls_Conexion conexion = new Cls_Conexion();

        public DataTable Fun_ObtenerCuentasPendientes()
        {
            string sql = @"
                SELECT 
                    c.pk_id_compra AS IdCompra,
                    c.cmp_numero_factura AS NumeroFactura,
                    c.cmp_fecha AS FechaFactura,
                    p.cmp_Nombre_Proveedor AS Proveedor,
                    IFNULL(c.fk_id_orden_compra, 0) AS IdOrdenCompra,
                    cxp.cmp_monto_total AS TotalCompra,
                    IFNULL(SUM(det.cmp_monto_pagado), 0) AS TotalPagado,
                    cxp.cmp_monto_total - IFNULL(SUM(det.cmp_monto_pagado), 0) AS SaldoPendiente,
                    cxp.cmp_estado AS Estado
                FROM tbl_cuentas_por_pagar cxp
                INNER JOIN tbl_compra c 
                    ON cxp.fk_id_compra = c.pk_id_compra
                INNER JOIN tbl_proveedores p 
                    ON c.fk_id_proveedor = p.pk_id_proveedor
                LEFT JOIN tbl_cuentas_por_pagar_detalle det 
                    ON det.fk_id_cuenta_por_pagar = cxp.pk_id_cuenta_por_pagar
                WHERE cxp.cmp_estado IN ('pendiente', 'parcial')
                GROUP BY 
                    c.pk_id_compra,
                    c.cmp_numero_factura,
                    c.cmp_fecha,
                    p.cmp_Nombre_Proveedor,
                    c.fk_id_orden_compra,
                    cxp.cmp_monto_total,
                    cxp.cmp_estado
                ORDER BY c.pk_id_compra DESC";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcDataAdapter da = new OdbcDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt;
            }
        }

        public DataTable Fun_BuscarCuentasPorFactura(string numeroFactura)
        {
            string sql = @"
                SELECT 
                    c.pk_id_compra AS IdCompra,
                    c.cmp_numero_factura AS NumeroFactura,
                    c.cmp_fecha AS FechaFactura,
                    p.cmp_Nombre_Proveedor AS Proveedor,
                    IFNULL(c.fk_id_orden_compra, 0) AS IdOrdenCompra,
                    cxp.cmp_monto_total AS TotalCompra,
                    IFNULL(SUM(det.cmp_monto_pagado), 0) AS TotalPagado,
                    cxp.cmp_monto_total - IFNULL(SUM(det.cmp_monto_pagado), 0) AS SaldoPendiente,
                    cxp.cmp_estado AS Estado
                FROM tbl_cuentas_por_pagar cxp
                INNER JOIN tbl_compra c 
                    ON cxp.fk_id_compra = c.pk_id_compra
                INNER JOIN tbl_proveedores p 
                    ON c.fk_id_proveedor = p.pk_id_proveedor
                LEFT JOIN tbl_cuentas_por_pagar_detalle det 
                    ON det.fk_id_cuenta_por_pagar = cxp.pk_id_cuenta_por_pagar
                WHERE cxp.cmp_estado IN ('pendiente', 'parcial')
                  AND c.cmp_numero_factura LIKE ?
                GROUP BY 
                    c.pk_id_compra,
                    c.cmp_numero_factura,
                    c.cmp_fecha,
                    p.cmp_Nombre_Proveedor,
                    c.fk_id_orden_compra,
                    cxp.cmp_monto_total,
                    cxp.cmp_estado
                ORDER BY c.pk_id_compra DESC";

            using (OdbcConnection conn = conexion.conexion())
            {
                OdbcCommand cmd = new OdbcCommand(sql, conn);
                cmd.Parameters.Add("numeroFactura", OdbcType.VarChar).Value = "%" + numeroFactura + "%";

                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.desconexion(conn);
                return dt;
            }
        }

        public int RegistrarPago(int idCompra, decimal montoPago, decimal saldoNuevo, string noDocumento)
        {
            using (OdbcConnection conn = conexion.conexion())
            using (OdbcTransaction trans = conn.BeginTransaction())
            {
                try
                {
                    int idCxp = 0;

                    string sqlBuscarCxp = @"
                        SELECT pk_id_cuenta_por_pagar
                        FROM tbl_cuentas_por_pagar
                        WHERE fk_id_compra = ?
                          AND cmp_estado IN ('pendiente', 'parcial')";

                    using (OdbcCommand cmd = new OdbcCommand(sqlBuscarCxp, conn, trans))
                    {
                        cmd.Parameters.Add("fk_id_compra", OdbcType.Int).Value = idCompra;

                        object resultado = cmd.ExecuteScalar();

                        if (resultado == null)
                        {
                            trans.Rollback();
                            return 0;
                        }

                        idCxp = Convert.ToInt32(resultado);
                    }

                    string tipoOperacion = saldoNuevo <= 0 ? "pago_total" : "abono";
                    string estadoNuevo = saldoNuevo <= 0 ? "pagado" : "parcial";

                    string sqlDetalle = @"
                        INSERT INTO tbl_cuentas_por_pagar_detalle
                        (
                            fk_id_cuenta_por_pagar,
                            cmp_tipo_operacion,
                            cmp_no_documento,
                            cmp_fecha,
                            cmp_monto_pagado,
                            cmp_saldo_pendiente
                        )
                        VALUES (?, ?, ?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(sqlDetalle, conn, trans))
                    {
                        cmd.Parameters.Add("fk_id_cuenta_por_pagar", OdbcType.Int).Value = idCxp;
                        cmd.Parameters.Add("cmp_tipo_operacion", OdbcType.VarChar).Value = tipoOperacion;
                        cmd.Parameters.Add("cmp_no_documento", OdbcType.VarChar).Value = noDocumento;
                        cmd.Parameters.Add("cmp_fecha", OdbcType.Date).Value = DateTime.Now.Date;
                        cmd.Parameters.Add("cmp_monto_pagado", OdbcType.Double).Value = Convert.ToDouble(montoPago);
                        cmd.Parameters.Add("cmp_saldo_pendiente", OdbcType.Double).Value = Convert.ToDouble(saldoNuevo);
                        cmd.ExecuteNonQuery();
                    }

                    string sqlActualizarCxp = @"
                        UPDATE tbl_cuentas_por_pagar
                        SET cmp_estado = ?
                        WHERE pk_id_cuenta_por_pagar = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sqlActualizarCxp, conn, trans))
                    {
                        cmd.Parameters.Add("cmp_estado", OdbcType.VarChar).Value = estadoNuevo;
                        cmd.Parameters.Add("pk_id_cuenta_por_pagar", OdbcType.Int).Value = idCxp;
                        cmd.ExecuteNonQuery();
                    }

                    string sqlActualizarCompra = @"
                        UPDATE tbl_compra
                        SET cmp_estado = ?
                        WHERE pk_id_compra = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sqlActualizarCompra, conn, trans))
                    {
                        cmd.Parameters.Add("cmp_estado", OdbcType.VarChar).Value = estadoNuevo;
                        cmd.Parameters.Add("pk_id_compra", OdbcType.Int).Value = idCompra;
                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    conexion.desconexion(conn);
                    return 1;
                }
                catch
                {
                    trans.Rollback();
                    conexion.desconexion(conn);
                    return 0;
                }
            }
        }
    }
}