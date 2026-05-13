-- ============================================================
-- Stored Procedure: sp_BalanceAntiguedadCxC
-- Descripción    : Genera el Balance de Antigüedad de Saldo
--                  de Cuentas por Cobrar filtrado por rango
--                  de fechas de emisión de deuda.
-- Parámetros     :
--   p_FechaDesde DATE  – Fecha de inicio (inclusiva)
--   p_FechaHasta DATE  – Fecha de corte  (inclusiva)
-- Columnas de salida:
--   Pk_Id_Cliente, NombreCliente, NIT
--   IdCxC, NoVenta
--   FechaDeuda, FechaVencimiento
--   MontoTotal, TotalPagado, SaldoPendiente
--   DiasVencidos, RangoAntiguedad
--   MontoCorriente, Monto1a30, Monto31a60, Monto61a90, MontoMas90
-- ============================================================

DELIMITER $$

DROP PROCEDURE IF EXISTS sp_BalanceAntiguedadCxC $$

CREATE PROCEDURE sp_BalanceAntiguedadCxC(
    IN p_FechaDesde DATE,
    IN p_FechaHasta DATE
)
BEGIN
    SELECT
        c.Pk_Id_Cliente,
        CONCAT(c.Cmp_Nombre, ' ', c.Cmp_Apellido)       AS NombreCliente,
        c.Cmp_CuioNit                                    AS NIT,
        cxc.Pk_Id_Cuenta_Por_Cobrar                      AS IdCxC,
        cxc.Fk_Id_Venta                                  AS NoVenta,
        DATE(cxc.Cmp_Fecha_De_Deuda)                     AS FechaDeuda,
        DATE(cxc.Cmp_Fecha_Vencimiento)                  AS FechaVencimiento,
        CAST(cxc.Cmp_Monto_Total AS DECIMAL(18,2))       AS MontoTotal,
        CAST(pagos.TotalPagado   AS DECIMAL(18,2))        AS TotalPagado,
        CAST(
            cxc.Cmp_Monto_Total - pagos.TotalPagado
        AS DECIMAL(18,2))                                AS SaldoPendiente,
        GREATEST(0, DATEDIFF(
            p_FechaHasta,
            DATE(cxc.Cmp_Fecha_Vencimiento)
        ))                                               AS DiasVencidos,
        CASE
            WHEN DATEDIFF(p_FechaHasta, DATE(cxc.Cmp_Fecha_Vencimiento)) <= 0
                THEN 'Corriente'
            WHEN DATEDIFF(p_FechaHasta, DATE(cxc.Cmp_Fecha_Vencimiento)) <= 30
                THEN '1-30 días'
            WHEN DATEDIFF(p_FechaHasta, DATE(cxc.Cmp_Fecha_Vencimiento)) <= 60
                THEN '31-60 días'
            WHEN DATEDIFF(p_FechaHasta, DATE(cxc.Cmp_Fecha_Vencimiento)) <= 90
                THEN '61-90 días'
            ELSE 'Más de 90 días'
        END                                              AS RangoAntiguedad,
        -- Monto por rango (columnas horizontales en el reporte)
        CAST(CASE
            WHEN DATEDIFF(p_FechaHasta, DATE(cxc.Cmp_Fecha_Vencimiento)) <= 0
                THEN cxc.Cmp_Monto_Total - pagos.TotalPagado
            ELSE 0
        END AS DECIMAL(18,2))                            AS MontoCorriente,
        CAST(CASE
            WHEN DATEDIFF(p_FechaHasta, DATE(cxc.Cmp_Fecha_Vencimiento)) BETWEEN 1 AND 30
                THEN cxc.Cmp_Monto_Total - pagos.TotalPagado
            ELSE 0
        END AS DECIMAL(18,2))                            AS Monto1a30,
        CAST(CASE
            WHEN DATEDIFF(p_FechaHasta, DATE(cxc.Cmp_Fecha_Vencimiento)) BETWEEN 31 AND 60
                THEN cxc.Cmp_Monto_Total - pagos.TotalPagado
            ELSE 0
        END AS DECIMAL(18,2))                            AS Monto31a60,
        CAST(CASE
            WHEN DATEDIFF(p_FechaHasta, DATE(cxc.Cmp_Fecha_Vencimiento)) BETWEEN 61 AND 90
                THEN cxc.Cmp_Monto_Total - pagos.TotalPagado
            ELSE 0
        END AS DECIMAL(18,2))                            AS Monto61a90,
        CAST(CASE
            WHEN DATEDIFF(p_FechaHasta, DATE(cxc.Cmp_Fecha_Vencimiento)) > 90
                THEN cxc.Cmp_Monto_Total - pagos.TotalPagado
            ELSE 0
        END AS DECIMAL(18,2))                            AS MontoMas90
    FROM tbl_cuentas_por_cobrar cxc
    INNER JOIN tbl_clientes c
        ON c.Pk_Id_Cliente = cxc.FK_Id_Cliente
    LEFT JOIN (
        -- Suma de pagos registrados hasta la fecha de corte por cada CxC
        SELECT
            d.Fk_Id_Cuenta_Por_Cobrar,
            COALESCE(SUM(d.Cmp_Monto_Pagado), 0) AS TotalPagado
        FROM tbl_cuentas_por_cobrar_detalle d
        WHERE d.Cmp_Fecha_Pago <= p_FechaHasta
        GROUP BY d.Fk_Id_Cuenta_Por_Cobrar
    ) pagos ON pagos.Fk_Id_Cuenta_Por_Cobrar = cxc.Pk_Id_Cuenta_Por_Cobrar
    WHERE DATE(cxc.Cmp_Fecha_De_Deuda) BETWEEN p_FechaDesde AND p_FechaHasta
      AND cxc.Cmp_Estado = 'Activo'
    HAVING SaldoPendiente > 0
    ORDER BY NombreCliente, FechaVencimiento;
END $$

DELIMITER ;
