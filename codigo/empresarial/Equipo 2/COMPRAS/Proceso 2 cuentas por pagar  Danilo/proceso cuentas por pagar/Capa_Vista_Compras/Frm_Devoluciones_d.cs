using Capa_Controlador_Compras;
using Capa_Controlador_CXP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Capa_Vista_Compras
{

    public partial class Frm_Devoluciones_d : Form
    {
        private readonly Cls_Devoluciones_Controlador controlador = new Cls_Devoluciones_Controlador();
        private int idCompraRecibida = 0;

        public Frm_Devoluciones_d()
        {
            InitializeComponent();
            this.Load += Frm_Devoluciones_d_Load;
            Btn_refrescar.Click += Btn_refrescar_Click;
            Btn_limpiar.Click += Btn_limpiar_Click;
            Btn_salir.Click += Btn_salir_Click;
            Cbo_id_compra.SelectionChangeCommitted += Cbo_id_compra_SelectionChangeCommitted;
        }

        public Frm_Devoluciones_d(int idCompra)
        {
            InitializeComponent();
            idCompraRecibida = idCompra;

            this.Load += Frm_Devoluciones_d_Load;
            Btn_refrescar.Click += Btn_refrescar_Click;
            Btn_limpiar.Click += Btn_limpiar_Click;
            Btn_salir.Click += Btn_salir_Click;
            Cbo_id_compra.SelectionChangeCommitted += Cbo_id_compra_SelectionChangeCommitted;
        }

        private void Frm_Devoluciones_d_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarValoresIniciales();

            if (idCompraRecibida > 0)
            {
                CargarCompra(idCompraRecibida);
                CargarDetalleCompra(idCompraRecibida);
            }
        }

        private void CargarValoresIniciales()
        {
            try
            {
                Cbo_motivo.Items.Clear();
                Cbo_motivo.Items.Add("Producto dañado");
                Cbo_motivo.Items.Add("Producto equivocado");
                Cbo_motivo.Items.Add("Exceso de compra");
                Cbo_motivo.Items.Add("Garantía");
                Cbo_motivo.Items.Add("Otro");

                Cbo_tipo_devolucion.Items.Clear();
                Cbo_tipo_devolucion.Items.Add("efectivo");
                Cbo_tipo_devolucion.Items.Add("credito");
                Cbo_tipo_devolucion.Items.Add("producto");
                Cbo_tipo_devolucion.Items.Add("ajuste");

                Txt_estado.Text = "pendiente";
                Txt_valor_monetario.Text = "0.00";

                Dtp_fecha_devolucion.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar valores iniciales: " + ex.Message);
            }
        }

        private void CargarCombos()
        {
            try
            {
                Cbo_id_compra.DataSource = controlador.ObtenerIdsCompra();
                Cbo_id_compra.DisplayMember = "pk_id_compra";
                Cbo_id_compra.ValueMember = "pk_id_compra";
                Cbo_id_compra.SelectedIndex = -1;

                Cbo_numero_factura.DataSource = controlador.ObtenerFacturas();
                Cbo_numero_factura.DisplayMember = "cmp_numero_factura";
                Cbo_numero_factura.ValueMember = "cmp_numero_factura";
                Cbo_numero_factura.SelectedIndex = -1;

                Cbo_proveedor.DataSource = controlador.ObtenerProveedores();
                Cbo_proveedor.DisplayMember = "cmp_Nombre_Proveedor";
                Cbo_proveedor.ValueMember = "pk_id_proveedor";
                Cbo_proveedor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
        }

        private void CargarCompra(int idCompra)
        {
            try
            {
                DataTable dt = controlador.BuscarCompraPorId(idCompra);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró la compra seleccionada.");
                    return;
                }

                DataRow fila = dt.Rows[0];

                Cbo_id_compra.SelectedValue = Convert.ToInt32(fila["IdCompra"]);
                Cbo_numero_factura.SelectedValue = fila["NumeroFactura"].ToString();
                Cbo_proveedor.SelectedValue = Convert.ToInt32(fila["IdProveedor"]);

                if (fila["FechaCompra"] != DBNull.Value)
                {
                    Dtp_fecha_facturacion.Value = Convert.ToDateTime(fila["FechaCompra"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos de compra: " + ex.Message);
            }
        }

        private void CargarDetalleCompra(int idCompra)
        {
            try
            {
                Dgv_detalle_devolucion.DataSource = controlador.ObtenerDetalleCompra(idCompra);
                Dgv_detalle_devolucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dgv_detalle_devolucion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Dgv_detalle_devolucion.MultiSelect = false;
                Dgv_detalle_devolucion.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle de compra: " + ex.Message);
            }
        }

        private void Btn_refrescar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_id_compra.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una compra.");
                    return;
                }

                int idCompra = Convert.ToInt32(Cbo_id_compra.SelectedValue);

                CargarCompra(idCompra);
                CargarDetalleCompra(idCompra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al refrescar: " + ex.Message);
            }
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            Cbo_id_compra.SelectedIndex = -1;
            Cbo_numero_factura.SelectedIndex = -1;
            Cbo_proveedor.SelectedIndex = -1;

            Txt_id_devolucion.Clear();
            Txt_estado.Text = "pendiente";
            Txt_valor_monetario.Text = "0.00";

            Cbo_motivo.SelectedIndex = -1;
            Cbo_tipo_devolucion.SelectedIndex = -1;

            Dtp_fecha_facturacion.Value = DateTime.Now;
            Dtp_fecha_devolucion.Value = DateTime.Now;

            Dgv_detalle_devolucion.DataSource = null;
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cbo_id_compra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_id_compra.SelectedValue == null)
                    return;

                int idCompra = Convert.ToInt32(Cbo_id_compra.SelectedValue);

                CargarCompra(idCompra);
                CargarDetalleCompra(idCompra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar compra: " + ex.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
       
    
}
