using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Capa_Controlador_Ventas;

namespace Capa_Vista_Ventas
{
    public partial class Frm_BalanceAntiguedad : Form
    {
        private readonly Cls_BalanceAntiguedad_Controlador _controlador =
            new Cls_BalanceAntiguedad_Controlador();

        public Frm_BalanceAntiguedad()
        {
            InitializeComponent();
            // Valores predeterminados: primer día del mes actual hasta hoy
            dtp_FechaDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtp_FechaHasta.Value = DateTime.Today;
        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaDesde = dtp_FechaDesde.Value.Date;
                DateTime fechaHasta = dtp_FechaHasta.Value.Date;

                DataTable dt = _controlador.ObtenerReporte(fechaDesde, fechaHasta);

                if (dt == null)
                    return;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron registros con saldo pendiente para el período seleccionado.",
                        "Sin datos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    crystalReportViewer1.ReportSource = null;
                    return;
                }

                string rptPath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Rpt_BalanceAntiguedad.rpt");

                if (!File.Exists(rptPath))
                {
                    MessageBox.Show(
                        "No se encontró el archivo del reporte:\n" + rptPath +
                        "\n\nCree el archivo Rpt_BalanceAntiguedad.rpt en Visual Studio " +
                        "y colóquelo en el directorio de salida del proyecto.",
                        "Reporte no encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                ReportDocument rd = new ReportDocument();
                rd.Load(rptPath);
                rd.SetDataSource(dt);

                // Pasar las fechas del filtro como parámetros del reporte
                try
                {
                    rd.SetParameterValue("FechaDesde", fechaDesde);
                    rd.SetParameterValue("FechaHasta", fechaHasta);
                }
                catch
                {
                    // Los parámetros son opcionales; continuar si no están definidos en el .rpt
                }

                crystalReportViewer1.ReportSource = rd;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el reporte:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
