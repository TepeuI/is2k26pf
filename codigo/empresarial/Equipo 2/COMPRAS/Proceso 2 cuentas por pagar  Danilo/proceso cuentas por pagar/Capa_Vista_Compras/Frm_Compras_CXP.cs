using System;
using System.Globalization;
using System.Windows.Forms;
using Capa_Controlador_CXP;

namespace Capa_Vista_CXP
{
    public partial class Frm_Compras_CXP : Form
    {
        private readonly Cls_Compras_Controlador cm = new Cls_Compras_Controlador();

        public Frm_Compras_CXP()
        {
            InitializeComponent();

            this.Load += Frm_Compras_CXP_Load;

            Btn_buscar.Click += Btn_buscar_Click;
            Btn_grabar.Click += Btn_grabar_Click;
            Btn_editar.Click += Btn_editar_Click;
            Btn_refrescar.Click += Btn_refrescar_Click;
            Btn_imprimir.Click += Btn_imprimir_Click;
            Btn_salir.Click += Btn_salir_Click;
            Btn_limpiar.Click += Btn_limpiar_Click;
            Btn_aceptar.Click += Btn_aceptar_Click;

            Dgv_compras.CellClick += Dgv_compras_CellClick;
            Txt_adelanto.TextChanged += Txt_adelanto_TextChanged;
        }

        private void Frm_Compras_CXP_Load(object sender, EventArgs e)
        {
            PrepararFormulario();
            CargarCuentasPendientes();
        }

        private void PrepararFormulario()
        {
            Txt_id.ReadOnly = true;
            Txt_numero.ReadOnly = false;
            Txt_orden.ReadOnly = true;
            Txt_total.ReadOnly = true;
            Txt_saldo.ReadOnly = true;
            Txt_estado.ReadOnly = true;

            Cbo_proveedor.Enabled = false;
            Dtp_fecha.Enabled = false;

            Btn_editar.Enabled = false;

            LimpiarCampos();
        }

        private void CargarCuentasPendientes()
        {
            Dgv_compras.DataSource = cm.ObtenerCuentasPendientes();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            if (Dgv_compras.Columns.Count > 0)
            {
                Dgv_compras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dgv_compras.ReadOnly = true;
                Dgv_compras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Dgv_compras.MultiSelect = false;
                Dgv_compras.AllowUserToAddRows = false;
                Dgv_compras.RowHeadersVisible = false;

                Dgv_compras.Columns["IdCompra"].HeaderText = "Id Compra";
                Dgv_compras.Columns["NumeroFactura"].HeaderText = "No. Factura";
                Dgv_compras.Columns["FechaFactura"].HeaderText = "Fecha";
                Dgv_compras.Columns["Proveedor"].HeaderText = "Proveedor";
                Dgv_compras.Columns["IdOrdenCompra"].HeaderText = "Orden Compra";
                Dgv_compras.Columns["TotalCompra"].HeaderText = "Total";
                Dgv_compras.Columns["TotalPagado"].HeaderText = "Pagado";
                Dgv_compras.Columns["SaldoPendiente"].HeaderText = "Saldo";
                Dgv_compras.Columns["Estado"].HeaderText = "Estado";
            }
        }

        private decimal ConvertirDecimal(string texto)
        {
            decimal valor;

            if (!decimal.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
            {
                decimal.TryParse(texto, out valor);
            }

            return valor;
        }

        private void CalcularSaldoTemporal()
        {
            decimal saldoActual = ConvertirDecimal(Txt_saldo.Text);
            decimal pago = ConvertirDecimal(Txt_adelanto.Text);

            if (pago < 0)
            {
                MessageBox.Show("El pago no puede ser negativo.");
                Txt_adelanto.Text = "0";
                return;
            }

            if (pago > saldoActual)
            {
                MessageBox.Show("El pago no puede ser mayor al saldo pendiente.");
                Txt_adelanto.Text = "0";
                return;
            }

            decimal saldoNuevo = cm.CalcularSaldo(saldoActual, pago);
            Txt_estado.Text = cm.ObtenerEstado(saldoNuevo);
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Dgv_compras.DataSource = cm.BuscarCuentasPorFactura(Txt_numero.Text);
            ConfigurarGrid();
        }

        private void Btn_grabar_Click(object sender, EventArgs e)
        {
            RegistrarPago();
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            RegistrarPago();
        }

        private void RegistrarPago()
        {
            string mensaje = cm.RegistrarPago(
                Txt_id.Text,
                Txt_saldo.Text,
                Txt_adelanto.Text,
                Txt_documento.Text
            );

            MessageBox.Show(mensaje);

            if (mensaje == "Pago registrado correctamente.")
            {
                CargarCuentasPendientes();
                LimpiarCampos();
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La edición de pagos todavía no está habilitada.");
        }

        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            CargarCuentasPendientes();
            LimpiarCampos();
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se llamará el reporte de cuentas por pagar.");
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Txt_adelanto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_adelanto.Text))
            {
                CalcularSaldoTemporal();
            }
        }

        private void Dgv_compras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow fila = Dgv_compras.Rows[e.RowIndex];

                Txt_id.Text = fila.Cells["IdCompra"].Value?.ToString() ?? "";
                Txt_numero.Text = fila.Cells["NumeroFactura"].Value?.ToString() ?? "";
                Cbo_proveedor.Text = fila.Cells["Proveedor"].Value?.ToString() ?? "";
                Txt_orden.Text = fila.Cells["IdOrdenCompra"].Value?.ToString() ?? "";
                Txt_total.Text = fila.Cells["TotalCompra"].Value?.ToString() ?? "0";
                Txt_saldo.Text = fila.Cells["SaldoPendiente"].Value?.ToString() ?? "0";
                Txt_estado.Text = fila.Cells["Estado"].Value?.ToString() ?? "pendiente";

                if (fila.Cells["FechaFactura"].Value != null)
                {
                    DateTime fecha;

                    if (DateTime.TryParse(fila.Cells["FechaFactura"].Value.ToString(), out fecha))
                    {
                        Dtp_fecha.Value = fecha;
                    }
                }

                Txt_adelanto.Text = "0";
                Txt_documento.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del grid: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            Txt_id.Clear();
            Txt_numero.Clear();
            Txt_orden.Clear();
            Txt_total.Text = "0";
            Txt_adelanto.Text = "0";
            Txt_saldo.Text = "0";
            Txt_estado.Text = "pendiente";
            Txt_documento.Clear();
            Cbo_proveedor.Text = "";
            Dtp_fecha.Value = DateTime.Now;
        }
    }
}