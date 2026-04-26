
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
            this.Dtp_FechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.Cmb_tipo = new System.Windows.Forms.ComboBox();
            this.Dtp_fechaCompra = new System.Windows.Forms.DateTimePicker();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Txt_ordenCompra = new System.Windows.Forms.TextBox();
            this.Txt_estado = new System.Windows.Forms.TextBox();
            this.Lbl_fechavencimiento = new System.Windows.Forms.Label();
            this.Lbl_tipoCompra = new System.Windows.Forms.Label();
            this.Lbl_OrdenCompra = new System.Windows.Forms.Label();
            this.Lbl_fechaCompra = new System.Windows.Forms.Label();
            this.Txt_NumeroFactura = new System.Windows.Forms.TextBox();
            this.Txt_Proveedor = new System.Windows.Forms.TextBox();
            this.Lbl_serieFactura = new System.Windows.Forms.Label();
            this.Txt_serieFactura = new System.Windows.Forms.TextBox();
            this.Lbl_numeroFactura = new System.Windows.Forms.Label();
            this.Lbl_Proveedor = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Gpo_Detalle = new System.Windows.Forms.GroupBox();
            this.Txt_producto = new System.Windows.Forms.TextBox();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Lbl_Tipo = new System.Windows.Forms.Label();
            this.Lbl_CodigoCta = new System.Windows.Forms.Label();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Txt_PrecioUnitario = new System.Windows.Forms.TextBox();
            this.Lbl_DetalleProductos = new System.Windows.Forms.Label();
            this.Btn_Quitar = new System.Windows.Forms.Button();
            this.Dgv_DetalleProductos = new System.Windows.Forms.DataGridView();
            this.Btn_Refrescar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Grabar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Gpo_Encabezado.SuspendLayout();
            this.Gpo_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DetalleProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // Gpo_Encabezado
            // 
            this.Gpo_Encabezado.Controls.Add(this.Dtp_FechaVencimiento);
            this.Gpo_Encabezado.Controls.Add(this.Cmb_tipo);
            this.Gpo_Encabezado.Controls.Add(this.Dtp_fechaCompra);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_estado);
            this.Gpo_Encabezado.Controls.Add(this.Txt_ordenCompra);
            this.Gpo_Encabezado.Controls.Add(this.Txt_estado);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_fechavencimiento);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_tipoCompra);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_OrdenCompra);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_fechaCompra);
            this.Gpo_Encabezado.Controls.Add(this.Txt_NumeroFactura);
            this.Gpo_Encabezado.Controls.Add(this.Txt_Proveedor);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_serieFactura);
            this.Gpo_Encabezado.Controls.Add(this.Txt_serieFactura);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_numeroFactura);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_Proveedor);
            this.Gpo_Encabezado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpo_Encabezado.Location = new System.Drawing.Point(15, 120);
            this.Gpo_Encabezado.Name = "Gpo_Encabezado";
            this.Gpo_Encabezado.Size = new System.Drawing.Size(1029, 180);
            this.Gpo_Encabezado.TabIndex = 45;
            this.Gpo_Encabezado.TabStop = false;
            this.Gpo_Encabezado.Text = "Encabezado Compra";
            // 
            // Dtp_FechaVencimiento
            // 
            this.Dtp_FechaVencimiento.Location = new System.Drawing.Point(507, 140);
            this.Dtp_FechaVencimiento.Name = "Dtp_FechaVencimiento";
            this.Dtp_FechaVencimiento.Size = new System.Drawing.Size(154, 27);
            this.Dtp_FechaVencimiento.TabIndex = 45;
            // 
            // Cmb_tipo
            // 
            this.Cmb_tipo.FormattingEnabled = true;
            this.Cmb_tipo.Location = new System.Drawing.Point(161, 147);
            this.Cmb_tipo.Name = "Cmb_tipo";
            this.Cmb_tipo.Size = new System.Drawing.Size(145, 28);
            this.Cmb_tipo.TabIndex = 44;
            // 
            // Dtp_fechaCompra
            // 
            this.Dtp_fechaCompra.Location = new System.Drawing.Point(161, 98);
            this.Dtp_fechaCompra.Name = "Dtp_fechaCompra";
            this.Dtp_fechaCompra.Size = new System.Drawing.Size(145, 27);
            this.Dtp_fechaCompra.TabIndex = 43;
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado.Location = new System.Drawing.Point(690, 145);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(62, 20);
            this.Lbl_estado.TabIndex = 42;
            this.Lbl_estado.Text = "Estado";
            // 
            // Txt_ordenCompra
            // 
            this.Txt_ordenCompra.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ordenCompra.Location = new System.Drawing.Point(507, 97);
            this.Txt_ordenCompra.Name = "Txt_ordenCompra";
            this.Txt_ordenCompra.Size = new System.Drawing.Size(154, 27);
            this.Txt_ordenCompra.TabIndex = 40;
            // 
            // Txt_estado
            // 
            this.Txt_estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estado.Location = new System.Drawing.Point(795, 144);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(154, 27);
            this.Txt_estado.TabIndex = 39;
            // 
            // Lbl_fechavencimiento
            // 
            this.Lbl_fechavencimiento.AutoSize = true;
            this.Lbl_fechavencimiento.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechavencimiento.Location = new System.Drawing.Point(323, 147);
            this.Lbl_fechavencimiento.Name = "Lbl_fechavencimiento";
            this.Lbl_fechavencimiento.Size = new System.Drawing.Size(161, 20);
            this.Lbl_fechavencimiento.TabIndex = 37;
            this.Lbl_fechavencimiento.Text = "Fecha Vencimiento";
            // 
            // Lbl_tipoCompra
            // 
            this.Lbl_tipoCompra.AutoSize = true;
            this.Lbl_tipoCompra.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoCompra.Location = new System.Drawing.Point(6, 147);
            this.Lbl_tipoCompra.Name = "Lbl_tipoCompra";
            this.Lbl_tipoCompra.Size = new System.Drawing.Size(136, 20);
            this.Lbl_tipoCompra.TabIndex = 36;
            this.Lbl_tipoCompra.Text = "Tipo de Compra";
            // 
            // Lbl_OrdenCompra
            // 
            this.Lbl_OrdenCompra.AutoSize = true;
            this.Lbl_OrdenCompra.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_OrdenCompra.Location = new System.Drawing.Point(323, 105);
            this.Lbl_OrdenCompra.Name = "Lbl_OrdenCompra";
            this.Lbl_OrdenCompra.Size = new System.Drawing.Size(152, 20);
            this.Lbl_OrdenCompra.TabIndex = 34;
            this.Lbl_OrdenCompra.Text = "Orden de Compra";
            // 
            // Lbl_fechaCompra
            // 
            this.Lbl_fechaCompra.AutoSize = true;
            this.Lbl_fechaCompra.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechaCompra.Location = new System.Drawing.Point(6, 100);
            this.Lbl_fechaCompra.Name = "Lbl_fechaCompra";
            this.Lbl_fechaCompra.Size = new System.Drawing.Size(148, 20);
            this.Lbl_fechaCompra.TabIndex = 33;
            this.Lbl_fechaCompra.Text = "Fecha de Compra";
            // 
            // Txt_NumeroFactura
            // 
            this.Txt_NumeroFactura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NumeroFactura.Location = new System.Drawing.Point(507, 48);
            this.Txt_NumeroFactura.Name = "Txt_NumeroFactura";
            this.Txt_NumeroFactura.Size = new System.Drawing.Size(154, 27);
            this.Txt_NumeroFactura.TabIndex = 32;
            // 
            // Txt_Proveedor
            // 
            this.Txt_Proveedor.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Proveedor.Location = new System.Drawing.Point(795, 48);
            this.Txt_Proveedor.Name = "Txt_Proveedor";
            this.Txt_Proveedor.Size = new System.Drawing.Size(154, 27);
            this.Txt_Proveedor.TabIndex = 31;
            // 
            // Lbl_serieFactura
            // 
            this.Lbl_serieFactura.AutoSize = true;
            this.Lbl_serieFactura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_serieFactura.Location = new System.Drawing.Point(6, 48);
            this.Lbl_serieFactura.Name = "Lbl_serieFactura";
            this.Lbl_serieFactura.Size = new System.Drawing.Size(112, 20);
            this.Lbl_serieFactura.TabIndex = 26;
            this.Lbl_serieFactura.Text = "Serie Factura";
            // 
            // Txt_serieFactura
            // 
            this.Txt_serieFactura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_serieFactura.Location = new System.Drawing.Point(158, 42);
            this.Txt_serieFactura.Name = "Txt_serieFactura";
            this.Txt_serieFactura.Size = new System.Drawing.Size(148, 27);
            this.Txt_serieFactura.TabIndex = 27;
            // 
            // Lbl_numeroFactura
            // 
            this.Lbl_numeroFactura.AutoSize = true;
            this.Lbl_numeroFactura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_numeroFactura.Location = new System.Drawing.Point(323, 51);
            this.Lbl_numeroFactura.Name = "Lbl_numeroFactura";
            this.Lbl_numeroFactura.Size = new System.Drawing.Size(135, 20);
            this.Lbl_numeroFactura.TabIndex = 28;
            this.Lbl_numeroFactura.Text = "Numero Factura";
            // 
            // Lbl_Proveedor
            // 
            this.Lbl_Proveedor.AutoSize = true;
            this.Lbl_Proveedor.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Proveedor.Location = new System.Drawing.Point(678, 51);
            this.Lbl_Proveedor.Name = "Lbl_Proveedor";
            this.Lbl_Proveedor.Size = new System.Drawing.Size(92, 20);
            this.Lbl_Proveedor.TabIndex = 30;
            this.Lbl_Proveedor.Text = "Proveedor";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = global::Capa_vista_Factura.Properties.Resources.sign_emergency_code_sos_61_icon_icons_com_57216;
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Salir.Location = new System.Drawing.Point(711, 23);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(114, 80);
            this.Btn_Salir.TabIndex = 44;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Gpo_Detalle
            // 
            this.Gpo_Detalle.Controls.Add(this.Txt_producto);
            this.Gpo_Detalle.Controls.Add(this.Txt_Cantidad);
            this.Gpo_Detalle.Controls.Add(this.Btn_Aceptar);
            this.Gpo_Detalle.Controls.Add(this.Lbl_Tipo);
            this.Gpo_Detalle.Controls.Add(this.Lbl_CodigoCta);
            this.Gpo_Detalle.Controls.Add(this.Lbl_Valor);
            this.Gpo_Detalle.Controls.Add(this.Txt_PrecioUnitario);
            this.Gpo_Detalle.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpo_Detalle.Location = new System.Drawing.Point(15, 333);
            this.Gpo_Detalle.Name = "Gpo_Detalle";
            this.Gpo_Detalle.Size = new System.Drawing.Size(1031, 115);
            this.Gpo_Detalle.TabIndex = 46;
            this.Gpo_Detalle.TabStop = false;
            this.Gpo_Detalle.Text = "Detalle de Compra";
            // 
            // Txt_producto
            // 
            this.Txt_producto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_producto.Location = new System.Drawing.Point(24, 66);
            this.Txt_producto.Name = "Txt_producto";
            this.Txt_producto.Size = new System.Drawing.Size(532, 27);
            this.Txt_producto.TabIndex = 34;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cantidad.Location = new System.Drawing.Point(583, 66);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(130, 27);
            this.Txt_Cantidad.TabIndex = 33;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.Location = new System.Drawing.Point(919, 31);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(100, 62);
            this.Btn_Aceptar.TabIndex = 32;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // Lbl_Tipo
            // 
            this.Lbl_Tipo.AutoSize = true;
            this.Lbl_Tipo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo.Location = new System.Drawing.Point(610, 31);
            this.Lbl_Tipo.Name = "Lbl_Tipo";
            this.Lbl_Tipo.Size = new System.Drawing.Size(80, 20);
            this.Lbl_Tipo.TabIndex = 21;
            this.Lbl_Tipo.Text = "Cantidad";
            // 
            // Lbl_CodigoCta
            // 
            this.Lbl_CodigoCta.AutoSize = true;
            this.Lbl_CodigoCta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodigoCta.Location = new System.Drawing.Point(240, 31);
            this.Lbl_CodigoCta.Name = "Lbl_CodigoCta";
            this.Lbl_CodigoCta.Size = new System.Drawing.Size(84, 20);
            this.Lbl_CodigoCta.TabIndex = 22;
            this.Lbl_CodigoCta.Text = "Producto ";
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valor.Location = new System.Drawing.Point(760, 31);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(127, 20);
            this.Lbl_Valor.TabIndex = 24;
            this.Lbl_Valor.Text = "Precio Unitario";
            // 
            // Txt_PrecioUnitario
            // 
            this.Txt_PrecioUnitario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PrecioUnitario.Location = new System.Drawing.Point(728, 66);
            this.Txt_PrecioUnitario.Name = "Txt_PrecioUnitario";
            this.Txt_PrecioUnitario.Size = new System.Drawing.Size(171, 27);
            this.Txt_PrecioUnitario.TabIndex = 25;
            // 
            // Lbl_DetalleProductos
            // 
            this.Lbl_DetalleProductos.AutoSize = true;
            this.Lbl_DetalleProductos.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DetalleProductos.Location = new System.Drawing.Point(21, 486);
            this.Lbl_DetalleProductos.Name = "Lbl_DetalleProductos";
            this.Lbl_DetalleProductos.Size = new System.Drawing.Size(196, 21);
            this.Lbl_DetalleProductos.TabIndex = 49;
            this.Lbl_DetalleProductos.Text = "Detalle de Productos";
            // 
            // Btn_Quitar
            // 
            this.Btn_Quitar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Quitar.Location = new System.Drawing.Point(944, 499);
            this.Btn_Quitar.Name = "Btn_Quitar";
            this.Btn_Quitar.Size = new System.Drawing.Size(100, 71);
            this.Btn_Quitar.TabIndex = 48;
            this.Btn_Quitar.Text = "Quitar";
            this.Btn_Quitar.UseVisualStyleBackColor = true;
            // 
            // Dgv_DetalleProductos
            // 
            this.Dgv_DetalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DetalleProductos.Location = new System.Drawing.Point(25, 520);
            this.Dgv_DetalleProductos.Name = "Dgv_DetalleProductos";
            this.Dgv_DetalleProductos.RowHeadersWidth = 51;
            this.Dgv_DetalleProductos.RowTemplate.Height = 24;
            this.Dgv_DetalleProductos.Size = new System.Drawing.Size(898, 285);
            this.Dgv_DetalleProductos.TabIndex = 47;
            // 
            // Btn_Refrescar
            // 
            this.Btn_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refrescar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refrescar.Image = global::Capa_vista_Factura.Properties.Resources.refresh_page_arrow_button_icon_icons_com_53909;
            this.Btn_Refrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refrescar.Location = new System.Drawing.Point(577, 23);
            this.Btn_Refrescar.Name = "Btn_Refrescar";
            this.Btn_Refrescar.Size = new System.Drawing.Size(128, 80);
            this.Btn_Refrescar.TabIndex = 43;
            this.Btn_Refrescar.Text = "Refrescar";
            this.Btn_Refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refrescar.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Image = global::Capa_vista_Factura.Properties.Resources.Cancel_icon_icons_com_73703;
            this.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Cancelar.Location = new System.Drawing.Point(446, 23);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(125, 80);
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
            this.Btn_Grabar.Location = new System.Drawing.Point(286, 23);
            this.Btn_Grabar.Name = "Btn_Grabar";
            this.Btn_Grabar.Size = new System.Drawing.Size(156, 80);
            this.Btn_Grabar.TabIndex = 41;
            this.Btn_Grabar.Text = "Grabar";
            this.Btn_Grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Grabar.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Image = global::Capa_vista_Factura.Properties.Resources.compose_edit_modify_icon_177770;
            this.Btn_Editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Editar.Location = new System.Drawing.Point(148, 23);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(132, 80);
            this.Btn_Editar.TabIndex = 40;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ingresar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.Image = global::Capa_vista_Factura.Properties.Resources.add_insert_new_plus_button_icon_142943;
            this.Btn_Ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Ingresar.Location = new System.Drawing.Point(15, 23);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(127, 80);
            this.Btn_Ingresar.TabIndex = 39;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            // 
            // Frm_detalle_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 743);
            this.Controls.Add(this.Lbl_DetalleProductos);
            this.Controls.Add(this.Btn_Quitar);
            this.Controls.Add(this.Dgv_DetalleProductos);
            this.Controls.Add(this.Gpo_Detalle);
            this.Controls.Add(this.Gpo_Encabezado);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Refrescar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Grabar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Ingresar);
            this.Name = "Frm_detalle_compra";
            this.Text = "Detalle de Compra";
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
        private System.Windows.Forms.TextBox Txt_ordenCompra;
        private System.Windows.Forms.TextBox Txt_estado;
        private System.Windows.Forms.Label Lbl_fechavencimiento;
        private System.Windows.Forms.Label Lbl_tipoCompra;
        private System.Windows.Forms.Label Lbl_OrdenCompra;
        private System.Windows.Forms.Label Lbl_fechaCompra;
        private System.Windows.Forms.TextBox Txt_NumeroFactura;
        private System.Windows.Forms.TextBox Txt_Proveedor;
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
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Label Lbl_Tipo;
        private System.Windows.Forms.Label Lbl_CodigoCta;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.TextBox Txt_PrecioUnitario;
        private System.Windows.Forms.Label Lbl_DetalleProductos;
        private System.Windows.Forms.Button Btn_Quitar;
        private System.Windows.Forms.DataGridView Dgv_DetalleProductos;
        private System.Windows.Forms.TextBox Txt_producto;
    }
}