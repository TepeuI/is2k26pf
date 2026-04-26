using System;
using System.Data;
using Capa_Modelo_CXP;

namespace Capa_Controlador_CXP
{
    public class Cls_Compras_Controlador
    {
        private readonly Cls_Compras_Sentencias snc = new Cls_Compras_Sentencias();

        public DataTable ObtenerCuentasPendientes()
        {
            return snc.Fun_ObtenerCuentasPendientes();
        }

        public DataTable BuscarCuentasPorFactura(string numeroFactura)
        {
            if (string.IsNullOrWhiteSpace(numeroFactura))
                return snc.Fun_ObtenerCuentasPendientes();

            return snc.Fun_BuscarCuentasPorFactura(numeroFactura.Trim());
        }

        public decimal CalcularSaldo(decimal saldoActual, decimal pago)
        {
            decimal saldo = saldoActual - pago;
            return saldo < 0 ? 0 : saldo;
        }

        public string ObtenerEstado(decimal saldoNuevo)
        {
            return saldoNuevo <= 0 ? "pagado" : "parcial";
        }

        public string RegistrarPago(
            string idCompraText,
            string saldoActualText,
            string montoPagoText,
            string noDocumento)
        {
            if (!int.TryParse(idCompraText, out int idCompra))
                return "Debe seleccionar una compra pendiente de pago.";

            if (!decimal.TryParse(saldoActualText, out decimal saldoActual))
                return "Saldo pendiente inválido.";

            if (!decimal.TryParse(montoPagoText, out decimal montoPago) || montoPago <= 0)
                return "Debe ingresar un monto de pago mayor a 0.";

            if (montoPago > saldoActual)
                return "El pago no puede ser mayor al saldo pendiente.";

            if (string.IsNullOrWhiteSpace(noDocumento))
                noDocumento = "PAGO-CXP-" + DateTime.Now.ToString("yyyyMMddHHmmss");

            decimal saldoNuevo = CalcularSaldo(saldoActual, montoPago);

            int filas = snc.RegistrarPago(idCompra, montoPago, saldoNuevo, noDocumento);

            if (filas > 0)
                return "Pago registrado correctamente.";

            return "Error al registrar el pago.";
        }
    }
}