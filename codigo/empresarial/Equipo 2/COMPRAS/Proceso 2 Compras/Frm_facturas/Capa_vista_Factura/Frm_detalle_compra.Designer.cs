
namespace Capa_vista_Factura
{
    partial class Frm_detalle_compra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gpo_Encabezado = new System.Windows.Forms.GroupBox();
            this.Lbl_diascredito = new System.Windows.Forms.Label();
            this.Txt_diascredito = new System.Windows.Forms.TextBox();
            this.Cmb_ordencompra = new System.Windows.Forms.ComboBox();
            this.Cmb_proveedor = new System.Windows.Forms.ComboBox();
            this.Dtp_FechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.Cmb_tipo = new System.Windows.Forms.ComboBox();
            this.Dtp_fechaCompra = new System.Windows.Forms.DateTimePicker();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Txt_estado = new System.Windows.Forms.TextBox();
            this.Lbl_fechavencimiento = new System.Windows.Forms.Label();
            this.Lbl_tipoCompra = new System.Windows.Forms.Label();
            this.Lbl_OrdenCompra = new System.Windows.Forms.Label();
            this.Lbl_fechaCompra = new System.Windows.Forms.Label();
            this.Txt_NumeroFactura = new System.Windows.Forms.TextBox();
            this.Lbl_serieFactura = new System.Windows.Forms.Label();
            this.Txt_serieFactura = new System.Windows.Forms.TextBox();
            this.Lbl_numeroFactura = new System.Windows.Forms.Label();
            this.Lbl_Proveedor = new System.Windows.Forms.Label();
            this.Gpo_Detalle = new System.Windows.Forms.GroupBox();
            this.Cmb_producto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_unidad = new System.Windows.Forms.ComboBox();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Lbl_Tipo = new System.Windows.Forms.Label();
            this.Lbl_CodigoCta = new System.Windows.Forms.Label();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Txt_PrecioUnitario = new System.Windows.Forms.TextBox();
            this.Lbl_DetalleProductos = new System.Windows.Forms.Label();
            this.Dgv_DetalleProductos = new System.Windows.Forms.DataGridView();
            this.ColumnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUniad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Btn_remover = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Refrescar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Grabar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Gpo_Encabezado.SuspendLayout();
            this.Gpo_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DetalleProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpo_Encabezado
            // 
            this.Gpo_Encabezado.Controls.Add(this.Lbl_diascredito);
            this.Gpo_Encabezado.Controls.Add(this.Txt_diascredito);
            this.Gpo_Encabezado.Controls.Add(this.Cmb_ordencompra);
            this.Gpo_Encabezado.Controls.Add(this.Cmb_proveedor);
            this.Gpo_Encabezado.Controls.Add(this.Dtp_FechaVencimiento);
            this.Gpo_Encabezado.Controls.Add(this.Cmb_tipo);
            this.Gpo_Encabezado.Controls.Add(this.Dtp_fechaCompra);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_estado);
            this.Gpo_Encabezado.Controls.Add(this.Txt_estado);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_fechavencimiento);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_tipoCompra);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_OrdenCompra);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_fechaCompra);
            this.Gpo_Encabezado.Controls.Add(this.Txt_NumeroFactura);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_serieFactura);
            this.Gpo_Encabezado.Controls.Add(this.Txt_serieFactura);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_numeroFactura);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_Proveedor);
            this.Gpo_Encabezado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpo_Encabezado.Location = new System.Drawing.Point(11, 98);
            this.Gpo_Encabezado.Margin = new System.Windows.Forms.Padding(2);
            this.Gpo_Encabezado.Name = "Gpo_Encabezado";
            this.Gpo_Encabezado.Padding = new System.Windows.Forms.Padding(2);
            this.Gpo_Encabezado.Size = new System.Drawing.Size(883, 160);
            this.Gpo_Encabezado.TabIndex = 45;
            this.Gpo_Encabezado.TabStop = false;
            this.Gpo_Encabezado.Text = "Encabezado Compra";
            // 
            // Lbl_diascredito
            // 
            this.Lbl_diascredito.AutoSize = true;
            this.Lbl_diascredito.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_diascredito.Location = new System.Drawing.Point(292, 124);
            this.Lbl_diascredito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_diascredito.Name = "Lbl_diascredito";
            this.Lbl_diascredito.Size = new System.Drawing.Size(89, 17);
            this.Lbl_diascredito.TabIndex = 49;
            this.Lbl_diascredito.Text = "Dias Credito";
            // 
            // Txt_diascredito
            // 
            this.Txt_diascredito.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_diascredito.Location = new System.Drawing.Point(422, 122);
            this.Txt_diascredito.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_diascredito.Name = "Txt_diascredito";
            this.Txt_diascredito.Size = new System.Drawing.Size(131, 23);
            this.Txt_diascredito.TabIndex = 48;
            // 
            // Cmb_ordencompra
            // 
            this.Cmb_ordencompra.FormattingEnabled = true;
            this.Cmb_ordencompra.Location = new System.Drawing.Point(422, 83);
            this.Cmb_ordencompra.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_ordencompra.Name = "Cmb_ordencompra";
            this.Cmb_ordencompra.Size = new System.Drawing.Size(140, 25);
            this.Cmb_ordencompra.TabIndex = 47;
            this.Cmb_ordencompra.SelectedIndexChanged += new System.EventHandler(this.Cmb_ordencompra_SelectedIndexChanged);
            // 
            // Cmb_proveedor
            // 
            this.Cmb_proveedor.FormattingEnabled = true;
            this.Cmb_proveedor.Location = new System.Drawing.Point(680, 46);
            this.Cmb_proveedor.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_proveedor.Name = "Cmb_proveedor";
            this.Cmb_proveedor.Size = new System.Drawing.Size(185, 25);
            this.Cmb_proveedor.TabIndex = 46;
            this.Cmb_proveedor.SelectedIndexChanged += new System.EventHandler(this.Cmb_proveedor_SelectedIndexChanged);
            // 
            // Dtp_FechaVencimiento
            // 
            this.Dtp_FechaVencimiento.Location = new System.Drawing.Point(725, 119);
            this.Dtp_FechaVencimiento.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp_FechaVencimiento.Name = "Dtp_FechaVencimiento";
            this.Dtp_FechaVencimiento.Size = new System.Drawing.Size(140, 23);
            this.Dtp_FechaVencimiento.TabIndex = 45;
            // 
            // Cmb_tipo
            // 
            this.Cmb_tipo.FormattingEnabled = true;
            this.Cmb_tipo.Location = new System.Drawing.Point(141, 120);
            this.Cmb_tipo.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_tipo.Name = "Cmb_tipo";
            this.Cmb_tipo.Size = new System.Drawing.Size(128, 25);
            this.Cmb_tipo.TabIndex = 44;
            this.Cmb_tipo.SelectedIndexChanged += new System.EventHandler(this.Cmb_tipo_SelectedIndexChanged_1);
            // 
            // Dtp_fechaCompra
            // 
            this.Dtp_fechaCompra.Location = new System.Drawing.Point(141, 81);
            this.Dtp_fechaCompra.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp_fechaCompra.Name = "Dtp_fechaCompra";
            this.Dtp_fechaCompra.Size = new System.Drawing.Size(128, 23);
            this.Dtp_fechaCompra.TabIndex = 43;
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado.Location = new System.Drawing.Point(585, 89);
            this.Lbl_estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(51, 17);
            this.Lbl_estado.TabIndex = 42;
            this.Lbl_estado.Text = "Estado";
            // 
            // Txt_estado
            // 
            this.Txt_estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estado.Location = new System.Drawing.Point(724, 86);
            this.Txt_estado.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(141, 23);
            this.Txt_estado.TabIndex = 39;
            // 
            // Lbl_fechavencimiento
            // 
            this.Lbl_fechavencimiento.AutoSize = true;
            this.Lbl_fechavencimiento.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechavencimiento.Location = new System.Drawing.Point(585, 122);
            this.Lbl_fechavencimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_fechavencimiento.Name = "Lbl_fechavencimiento";
            this.Lbl_fechavencimiento.Size = new System.Drawing.Size(131, 17);
            this.Lbl_fechavencimiento.TabIndex = 37;
            this.Lbl_fechavencimiento.Text = "Fecha Vencimiento";
            // 
            // Lbl_tipoCompra
            // 
            this.Lbl_tipoCompra.AutoSize = true;
            this.Lbl_tipoCompra.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoCompra.Location = new System.Drawing.Point(4, 119);
            this.Lbl_tipoCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_tipoCompra.Name = "Lbl_tipoCompra";
            this.Lbl_tipoCompra.Size = new System.Drawing.Size(115, 17);
            this.Lbl_tipoCompra.TabIndex = 36;
            this.Lbl_tipoCompra.Text = "Tipo de Compra";
            // 
            // Lbl_OrdenCompra
            // 
            this.Lbl_OrdenCompra.AutoSize = true;
            this.Lbl_OrdenCompra.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_OrdenCompra.Location = new System.Drawing.Point(292, 83);
            this.Lbl_OrdenCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_OrdenCompra.Name = "Lbl_OrdenCompra";
            this.Lbl_OrdenCompra.Size = new System.Drawing.Size(128, 17);
            this.Lbl_OrdenCompra.TabIndex = 34;
            this.Lbl_OrdenCompra.Text = "Orden de Compra";
            // 
            // Lbl_fechaCompra
            // 
            this.Lbl_fechaCompra.AutoSize = true;
            this.Lbl_fechaCompra.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechaCompra.Location = new System.Drawing.Point(4, 81);
            this.Lbl_fechaCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_fechaCompra.Name = "Lbl_fechaCompra";
            this.Lbl_fechaCompra.Size = new System.Drawing.Size(124, 17);
            this.Lbl_fechaCompra.TabIndex = 33;
            this.Lbl_fechaCompra.Text = "Fecha de Compra";
            // 
            // Txt_NumeroFactura
            // 
            this.Txt_NumeroFactura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NumeroFactura.Location = new System.Drawing.Point(422, 40);
            this.Txt_NumeroFactura.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_NumeroFactura.Name = "Txt_NumeroFactura";
            this.Txt_NumeroFactura.Size = new System.Drawing.Size(140, 23);
            this.Txt_NumeroFactura.TabIndex = 32;
            // 
            // Lbl_serieFactura
            // 
            this.Lbl_serieFactura.AutoSize = true;
            this.Lbl_serieFactura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_serieFactura.Location = new System.Drawing.Point(4, 39);
            this.Lbl_serieFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_serieFactura.Name = "Lbl_serieFactura";
            this.Lbl_serieFactura.Size = new System.Drawing.Size(92, 17);
            this.Lbl_serieFactura.TabIndex = 26;
            this.Lbl_serieFactura.Text = "Serie Factura";
            // 
            // Txt_serieFactura
            // 
            this.Txt_serieFactura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_serieFactura.Location = new System.Drawing.Point(138, 35);
            this.Txt_serieFactura.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_serieFactura.Name = "Txt_serieFactura";
            this.Txt_serieFactura.Size = new System.Drawing.Size(131, 23);
            this.Txt_serieFactura.TabIndex = 27;
            // 
            // Lbl_numeroFactura
            // 
            this.Lbl_numeroFactura.AutoSize = true;
            this.Lbl_numeroFactura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_numeroFactura.Location = new System.Drawing.Point(292, 43);
            this.Lbl_numeroFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_numeroFactura.Name = "Lbl_numeroFactura";
            this.Lbl_numeroFactura.Size = new System.Drawing.Size(111, 17);
            this.Lbl_numeroFactura.TabIndex = 28;
            this.Lbl_numeroFactura.Text = "Numero Factura";
            // 
            // Lbl_Proveedor
            // 
            this.Lbl_Proveedor.AutoSize = true;
            this.Lbl_Proveedor.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Proveedor.Location = new System.Drawing.Point(585, 46);
            this.Lbl_Proveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Proveedor.Name = "Lbl_Proveedor";
            this.Lbl_Proveedor.Size = new System.Drawing.Size(77, 17);
            this.Lbl_Proveedor.TabIndex = 30;
            this.Lbl_Proveedor.Text = "Proveedor";
            // 
            // Gpo_Detalle
            // 
            this.Gpo_Detalle.Controls.Add(this.Cmb_producto);
            this.Gpo_Detalle.Controls.Add(this.label1);
            this.Gpo_Detalle.Controls.Add(this.Cmb_unidad);
            this.Gpo_Detalle.Controls.Add(this.Txt_Cantidad);
            this.Gpo_Detalle.Controls.Add(this.Lbl_Tipo);
            this.Gpo_Detalle.Controls.Add(this.Lbl_CodigoCta);
            this.Gpo_Detalle.Controls.Add(this.Lbl_Valor);
            this.Gpo_Detalle.Controls.Add(this.Txt_PrecioUnitario);
            this.Gpo_Detalle.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpo_Detalle.Location = new System.Drawing.Point(11, 271);
            this.Gpo_Detalle.Margin = new System.Windows.Forms.Padding(2);
            this.Gpo_Detalle.Name = "Gpo_Detalle";
            this.Gpo_Detalle.Padding = new System.Windows.Forms.Padding(2);
            this.Gpo_Detalle.Size = new System.Drawing.Size(883, 93);
            this.Gpo_Detalle.TabIndex = 46;
            this.Gpo_Detalle.TabStop = false;
            this.Gpo_Detalle.Text = "Detalle de Compra";
            // 
            // Cmb_producto
            // 
            this.Cmb_producto.FormattingEnabled = true;
            this.Cmb_producto.Location = new System.Drawing.Point(8, 54);
            this.Cmb_producto.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_producto.Name = "Cmb_producto";
            this.Cmb_producto.Size = new System.Drawing.Size(349, 25);
            this.Cmb_producto.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Unidad de medida";
            // 
            // Cmb_unidad
            // 
            this.Cmb_unidad.FormattingEnabled = true;
            this.Cmb_unidad.Location = new System.Drawing.Point(386, 52);
            this.Cmb_unidad.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_unidad.Name = "Cmb_unidad";
            this.Cmb_unidad.Size = new System.Drawing.Size(132, 25);
            this.Cmb_unidad.TabIndex = 46;
            this.Cmb_unidad.SelectedIndexChanged += new System.EventHandler(this.Cmb_unidad_SelectedIndexChanged);
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cantidad.Location = new System.Drawing.Point(525, 52);
            this.Txt_Cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(98, 23);
            this.Txt_Cantidad.TabIndex = 33;
            // 
            // Lbl_Tipo
            // 
            this.Lbl_Tipo.AutoSize = true;
            this.Lbl_Tipo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo.Location = new System.Drawing.Point(532, 25);
            this.Lbl_Tipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Tipo.Name = "Lbl_Tipo";
            this.Lbl_Tipo.Size = new System.Drawing.Size(67, 17);
            this.Lbl_Tipo.TabIndex = 21;
            this.Lbl_Tipo.Text = "Cantidad";
            // 
            // Lbl_CodigoCta
            // 
            this.Lbl_CodigoCta.AutoSize = true;
            this.Lbl_CodigoCta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodigoCta.Location = new System.Drawing.Point(118, 25);
            this.Lbl_CodigoCta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_CodigoCta.Name = "Lbl_CodigoCta";
            this.Lbl_CodigoCta.Size = new System.Drawing.Size(70, 17);
            this.Lbl_CodigoCta.TabIndex = 22;
            this.Lbl_CodigoCta.Text = "Producto ";
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valor.Location = new System.Drawing.Point(654, 25);
            this.Lbl_Valor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(103, 17);
            this.Lbl_Valor.TabIndex = 24;
            this.Lbl_Valor.Text = "Precio Unitario";
            // 
            // Txt_PrecioUnitario
            // 
            this.Txt_PrecioUnitario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PrecioUnitario.Location = new System.Drawing.Point(644, 54);
            this.Txt_PrecioUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_PrecioUnitario.Name = "Txt_PrecioUnitario";
            this.Txt_PrecioUnitario.Size = new System.Drawing.Size(129, 23);
            this.Txt_PrecioUnitario.TabIndex = 25;
            // 
            // Lbl_DetalleProductos
            // 
            this.Lbl_DetalleProductos.AutoSize = true;
            this.Lbl_DetalleProductos.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DetalleProductos.Location = new System.Drawing.Point(16, 395);
            this.Lbl_DetalleProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_DetalleProductos.Name = "Lbl_DetalleProductos";
            this.Lbl_DetalleProductos.Size = new System.Drawing.Size(157, 17);
            this.Lbl_DetalleProductos.TabIndex = 49;
            this.Lbl_DetalleProductos.Text = "Detalle de Productos";
            // 
            // Dgv_DetalleProductos
            // 
            this.Dgv_DetalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DetalleProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProducto,
            this.ColumnUniad,
            this.ColumnCantidad,
            this.ColumnPrecio,
            this.ColumnSubtotal});
            this.Dgv_DetalleProductos.Location = new System.Drawing.Point(19, 422);
            this.Dgv_DetalleProductos.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_DetalleProductos.Name = "Dgv_DetalleProductos";
            this.Dgv_DetalleProductos.RowHeadersWidth = 51;
            this.Dgv_DetalleProductos.RowTemplate.Height = 24;
            this.Dgv_DetalleProductos.Size = new System.Drawing.Size(710, 196);
            this.Dgv_DetalleProductos.TabIndex = 47;
            // 
            // ColumnProducto
            // 
            this.ColumnProducto.HeaderText = "Producto";
            this.ColumnProducto.Name = "ColumnProducto";
            // 
            // ColumnUniad
            // 
            this.ColumnUniad.HeaderText = "Unidad de Medida";
            this.ColumnUniad.Name = "ColumnUniad";
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.Name = "ColumnCantidad";
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio Unitario";
            this.ColumnPrecio.Name = "ColumnPrecio";
            // 
            // ColumnSubtotal
            // 
            this.ColumnSubtotal.HeaderText = "Subtotal";
            this.ColumnSubtotal.Name = "ColumnSubtotal";
            // 
            // Txt_total
            // 
            this.Txt_total.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_total.Location = new System.Drawing.Point(149, 641);
            this.Txt_total.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(131, 23);
            this.Txt_total.TabIndex = 50;
            this.Txt_total.TextChanged += new System.EventHandler(this.Txt_total_TextChanged);
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.Location = new System.Drawing.Point(85, 644);
            this.Lbl_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(47, 17);
            this.Lbl_Total.TabIndex = 51;
            this.Lbl_Total.Text = "Total: ";
            // 
            // Btn_remover
            // 
            this.Btn_remover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_remover.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_remover.Image = global::Capa_vista_Factura.Properties.Resources.delete_remove_trash_icon_177304;
            this.Btn_remover.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_remover.Location = new System.Drawing.Point(779, 489);
            this.Btn_remover.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_remover.Name = "Btn_remover";
            this.Btn_remover.Size = new System.Drawing.Size(85, 54);
            this.Btn_remover.TabIndex = 60;
            this.Btn_remover.Text = "Remover";
            this.Btn_remover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_remover.UseVisualStyleBackColor = true;
            this.Btn_remover.Click += new System.EventHandler(this.Btn_remover_Click);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_limpiar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpiar.Image = global::Capa_vista_Factura.Properties.Resources.refresh_page_arrow_button_icon_icons_com_53909;
            this.Btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_limpiar.Location = new System.Drawing.Point(779, 565);
            this.Btn_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(85, 56);
            this.Btn_limpiar.TabIndex = 59;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Agregar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Image = global::Capa_vista_Factura.Properties.Resources.add_insert_new_plus_button_icon_142943;
            this.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Agregar.Location = new System.Drawing.Point(779, 411);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(85, 59);
            this.Btn_Agregar.TabIndex = 58;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = global::Capa_vista_Factura.Properties.Resources.sign_emergency_code_sos_61_icon_icons_com_57216;
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Salir.Location = new System.Drawing.Point(633, 19);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(86, 65);
            this.Btn_Salir.TabIndex = 44;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Refrescar
            // 
            this.Btn_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refrescar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refrescar.Image = global::Capa_vista_Factura.Properties.Resources.refresh_page_arrow_button_icon_icons_com_53909;
            this.Btn_Refrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refrescar.Location = new System.Drawing.Point(433, 19);
            this.Btn_Refrescar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Refrescar.Name = "Btn_Refrescar";
            this.Btn_Refrescar.Size = new System.Drawing.Size(96, 65);
            this.Btn_Refrescar.TabIndex = 43;
            this.Btn_Refrescar.Text = "Refrescar";
            this.Btn_Refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refrescar.UseVisualStyleBackColor = true;
            this.Btn_Refrescar.Click += new System.EventHandler(this.Btn_Refrescar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Image = global::Capa_vista_Factura.Properties.Resources.Cancel_icon_icons_com_73703;
            this.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Cancelar.Location = new System.Drawing.Point(334, 19);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(94, 65);
            this.Btn_Cancelar.TabIndex = 42;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Grabar
            // 
            this.Btn_Grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Grabar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Grabar.Image = global::Capa_vista_Factura.Properties.Resources.savetheapplication_guardar_2958;
            this.Btn_Grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Grabar.Location = new System.Drawing.Point(214, 19);
            this.Btn_Grabar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Grabar.Name = "Btn_Grabar";
            this.Btn_Grabar.Size = new System.Drawing.Size(117, 65);
            this.Btn_Grabar.TabIndex = 41;
            this.Btn_Grabar.Text = "Grabar";
            this.Btn_Grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Grabar.UseVisualStyleBackColor = true;
            this.Btn_Grabar.Click += new System.EventHandler(this.Btn_Grabar_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Image = global::Capa_vista_Factura.Properties.Resources.compose_edit_modify_icon_177770;
            this.Btn_Editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Editar.Location = new System.Drawing.Point(111, 19);
            this.Btn_Editar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(99, 65);
            this.Btn_Editar.TabIndex = 40;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ingresar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.Image = global::Capa_vista_Factura.Properties.Resources.add_insert_new_plus_button_icon_142943;
            this.Btn_Ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Ingresar.Location = new System.Drawing.Point(11, 19);
            this.Btn_Ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(95, 65);
            this.Btn_Ingresar.TabIndex = 39;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.Image = global::Capa_vista_Factura.Properties.Resources.android_search_icon_icons_com_50501;
            this.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Buscar.Location = new System.Drawing.Point(533, 19);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(96, 65);
            this.Btn_Buscar.TabIndex = 61;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Frm_detalle_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 681);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Btn_remover);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Txt_total);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.Lbl_DetalleProductos);
            this.Controls.Add(this.Dgv_DetalleProductos);
            this.Controls.Add(this.Gpo_Detalle);
            this.Controls.Add(this.Gpo_Encabezado);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Refrescar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Grabar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Ingresar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_detalle_compra";
            this.Text = "Detalle de Compra";
            this.Load += new System.EventHandler(this.Frm_detalle_compra_Load);
            this.Gpo_Encabezado.ResumeLayout(false);
            this.Gpo_Encabezado.PerformLayout();
            this.Gpo_Detalle.ResumeLayout(false);
            this.Gpo_Detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DetalleProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpo_Encabezado;
        private System.Windows.Forms.DateTimePicker Dtp_FechaVencimiento;
        private System.Windows.Forms.ComboBox Cmb_tipo;
        private System.Windows.Forms.DateTimePicker Dtp_fechaCompra;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.TextBox Txt_estado;
        private System.Windows.Forms.Label Lbl_fechavencimiento;
        private System.Windows.Forms.Label Lbl_tipoCompra;
        private System.Windows.Forms.Label Lbl_OrdenCompra;
        private System.Windows.Forms.Label Lbl_fechaCompra;
        private System.Windows.Forms.TextBox Txt_NumeroFactura;
        private System.Windows.Forms.Label Lbl_serieFactura;
        private System.Windows.Forms.TextBox Txt_serieFactura;
        private System.Windows.Forms.Label Lbl_numeroFactura;
        private System.Windows.Forms.Label Lbl_Proveedor;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Refrescar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Grabar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.GroupBox Gpo_Detalle;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.Label Lbl_Tipo;
        private System.Windows.Forms.Label Lbl_CodigoCta;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.TextBox Txt_PrecioUnitario;
        private System.Windows.Forms.Label Lbl_DetalleProductos;
        private System.Windows.Forms.DataGridView Dgv_DetalleProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_unidad;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.Button Btn_remover;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.ComboBox Cmb_ordencompra;
        private System.Windows.Forms.ComboBox Cmb_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUniad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubtotal;
        private System.Windows.Forms.TextBox Txt_diascredito;
        private System.Windows.Forms.ComboBox Cmb_producto;
        private System.Windows.Forms.Label Lbl_diascredito;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}