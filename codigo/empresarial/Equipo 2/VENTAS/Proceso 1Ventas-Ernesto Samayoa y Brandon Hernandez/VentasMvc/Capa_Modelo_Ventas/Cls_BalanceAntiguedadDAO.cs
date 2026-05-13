using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Ventas
{
    public class Cls_BalanceAntiguedadDAO
    {
        /// <summary>
        /// Ejecuta el stored procedure sp_BalanceAntiguedadCxC y devuelve
        /// un DataTable con el balance de antigüedad de saldo de CxC.
        /// </summary>
        /// <param name="fechaDesde">Fecha de inicio del período (inclusiva).</param>
        /// <param name="fechaHasta">Fecha de corte del período (inclusiva).</param>
        /// <returns>DataTable con los registros de antigüedad.</returns>
        public DataTable ObtenerBalanceAntiguedad(DateTime fechaDesde, DateTime fechaHasta)
        {
            Cls_ConexionBD conexionBD = new Cls_ConexionBD();
            OdbcConnection conn = null;

            try
            {
                conn = conexionBD.AbrirConexion();

                string query = "CALL sp_BalanceAntiguedadCxC(?, ?)";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.Add("p_FechaDesde", OdbcType.Date).Value = fechaDesde.Date;
                    cmd.Parameters.Add("p_FechaHasta", OdbcType.Date).Value = fechaHasta.Date;

                    OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                    DataTable dt = new DataTable("BalanceAntiguedad");
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                    conexionBD.desconexion(conn);
            }
        }
    }
}
