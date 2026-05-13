using System;
using System.Data;
using System.Windows.Forms;
using Capa_Modelo_Ventas;

namespace Capa_Controlador_Ventas
{
    public class Cls_BalanceAntiguedad_Controlador
    {
        private readonly Cls_BalanceAntiguedadDAO _dao = new Cls_BalanceAntiguedadDAO();

        /// <summary>
        /// Valida las fechas y obtiene el DataTable del balance de antigüedad de CxC.
        /// </summary>
        /// <param name="fechaDesde">Fecha de inicio del período.</param>
        /// <param name="fechaHasta">Fecha de corte del período.</param>
        /// <returns>DataTable con los datos o null si las fechas son inválidas.</returns>
        public DataTable ObtenerReporte(DateTime fechaDesde, DateTime fechaHasta)
        {
            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show(
                    "La Fecha Desde no puede ser mayor que la Fecha Hasta.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return null;
            }

            try
            {
                return _dao.ObtenerBalanceAntiguedad(fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al obtener el balance de antigüedad:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
