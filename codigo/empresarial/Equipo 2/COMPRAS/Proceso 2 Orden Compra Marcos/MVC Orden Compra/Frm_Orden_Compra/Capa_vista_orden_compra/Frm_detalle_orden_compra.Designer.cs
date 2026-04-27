
namespace Capa_vista_orden_compra
{
    partial class Frm_detalle_orden_compra
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
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Refrescar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Grabar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.Gpo_Encabezado = new System.Windows.Forms.GroupBox();
            this.Dtp_fecha_entrega = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.Cmb_tipoPago = new System.Windows.Forms.ComboBox();
            this.Dtp_fechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Txt_estado = new System.Windows.Forms.TextBox();
            this.Lbl_fechavencimiento = new System.Windows.Forms.Label();
            this.Lbl_tipoPago = new System.Windows.Forms.Label();
            this.Lbl_FechaEntrega = new System.Windows.Forms.Label();
            this.Lbl_fechaIngreso = new System.Windows.Forms.Label();
            this.Txt_NumeroOrden = new System.Windows.Forms.TextBox();
            this.Txt_Proveedor = new System.Windows.Forms.TextBox();
            this.Lbl_serieFactura = new System.Windows.Forms.Label();
            this.Txt_serieFactura = new System.Windows.Forms.TextBox();
            this.Lbl_numeroOrden = new System.Windows.Forms.Label();
            this.Lbl_Proveedor = new System.Windows.Forms.Label();
            this.Gpo_Detalle = new System.Windows.Forms.GroupBox();
            this.Txt_producto = new System.Windows.Forms.TextBox();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Lbl_Tipo = new System.Windows.Forms.Label();
            this.Lbl_CodigoCta = new System.Windows.Forms.Label();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Txt_PrecioUnitario = new System.Windows.Forms.TextBox();
            this.Lbl_DetalleProductos = new System.Windows.Forms.Label();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Dgv_DetalleProductos = new System.Windows.Forms.DataGridView();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_remover = new System.Windows.Forms.Button();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.Cmb_unidad = new System.Windows.Forms.ComboBox();
            this.Lbl_unidad = new System.Windows.Forms.Label();
            this.ColumnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gpo_Encabezado.SuspendLayout();
            this.Gpo_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DetalleProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = global::Capa_vista_orden_compra.Properties.Resources.sign_emergency_code_sos_61_icon_icons_com_57216;
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Salir.Location = new System.Drawing.Point(531, 20);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(86, 65);
            this.Btn_Salir.TabIndex = 50;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Refrescar
            // 
            this.Btn_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refrescar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refrescar.Image = global::Capa_vista_orden_compra.Properties.Resources.refresh_page_arrow_button_icon_icons_com_53909;
            this.Btn_Refrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refrescar.Location = new System.Drawing.Point(430, 20);
            this.Btn_Refrescar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Refrescar.Name = "Btn_Refrescar";
            this.Btn_Refrescar.Size = new System.Drawing.Size(96, 65);
            this.Btn_Refrescar.TabIndex = 49;
            this.Btn_Refrescar.Text = "Refrescar";
            this.Btn_Refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refrescar.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Image = global::Capa_vista_orden_compra.Properties.Resources.Cancel_icon_icons_com_73703;
            this.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Cancelar.Location = new System.Drawing.Point(332, 20);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(94, 65);
            this.Btn_Cancelar.TabIndex = 48;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Grabar
            // 
            this.Btn_Grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Grabar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Grabar.Image = global::Capa_vista_orden_compra.Properties.Resources.savetheapplication_guardar_2958;
            this.Btn_Grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Grabar.Location = new System.Drawing.Point(212, 20);
            this.Btn_Grabar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Grabar.Name = "Btn_Grabar";
            this.Btn_Grabar.Size = new System.Drawing.Size(117, 65);
            this.Btn_Grabar.TabIndex = 47;
            this.Btn_Grabar.Text = "Grabar";
            this.Btn_Grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Grabar.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Image = global::Capa_vista_orden_compra.Properties.Resources.compose_edit_modify_icon_177770;
            this.Btn_Editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Editar.Location = new System.Drawing.Point(109, 20);
            this.Btn_Editar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(99, 65);
            this.Btn_Editar.TabIndex = 46;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ingresar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.Image = global::Capa_vista_orden_compra.Properties.Resources.add_insert_new_plus_button_icon_142943;
            this.Btn_Ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Ingresar.Location = new System.Drawing.Point(9, 20);
            this.Btn_Ingresar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(95, 65);
            this.Btn_Ingresar.TabIndex = 45;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            // 
            // Gpo_Encabezado
            // 
            this.Gpo_Encabezado.Controls.Add(this.Dtp_fecha_entrega);
            this.Gpo_Encabezado.Controls.Add(this.Dtp_FechaVencimiento);
            this.Gpo_Encabezado.Controls.Add(this.Cmb_tipoPago);
            this.Gpo_Encabezado.Controls.Add(this.Dtp_fechaRegistro);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_estado);
            this.Gpo_Encabezado.Controls.Add(this.Txt_estado);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_fechavencimiento);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_tipoPago);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_FechaEntrega);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_fechaIngreso);
            this.Gpo_Encabezado.Controls.Add(this.Txt_NumeroOrden);
            this.Gpo_Encabezado.Controls.Add(this.Txt_Proveedor);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_serieFactura);
            this.Gpo_Encabezado.Controls.Add(this.Txt_serieFactura);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_numeroOrden);
            this.Gpo_Encabezado.Controls.Add(this.Lbl_Proveedor);
            this.Gpo_Encabezado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpo_Encabezado.Location = new System.Drawing.Point(9, 112);
            this.Gpo_Encabezado.Margin = new System.Windows.Forms.Padding(2);
            this.Gpo_Encabezado.Name = "Gpo_Encabezado";
            this.Gpo_Encabezado.Padding = new System.Windows.Forms.Padding(2);
            this.Gpo_Encabezado.Size = new System.Drawing.Size(827, 166);
            this.Gpo_Encabezado.TabIndex = 51;
            this.Gpo_Encabezado.TabStop = false;
            this.Gpo_Encabezado.Text = "EncabezadoOrden de Compra";
            this.Gpo_Encabezado.Enter += new System.EventHandler(this.Gpo_Encabezado_Enter);
            // 
            // Dtp_fecha_entrega
            // 
            this.Dtp_fecha_entrega.Location = new System.Drawing.Point(160, 80);
            this.Dtp_fecha_entrega.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp_fecha_entrega.Name = "Dtp_fecha_entrega";
            this.Dtp_fecha_entrega.Size = new System.Drawing.Size(116, 23);
            this.Dtp_fecha_entrega.TabIndex = 46;
            // 
            // Dtp_FechaVencimiento
            // 
            this.Dtp_FechaVencimiento.Location = new System.Drawing.Point(160, 121);
            this.Dtp_FechaVencimiento.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp_FechaVencimiento.Name = "Dtp_FechaVencimiento";
            this.Dtp_FechaVencimiento.Size = new System.Drawing.Size(116, 23);
            this.Dtp_FechaVencimiento.TabIndex = 45;
            // 
            // Cmb_tipoPago
            // 
            this.Cmb_tipoPago.FormattingEnabled = true;
            this.Cmb_tipoPago.Location = new System.Drawing.Point(392, 80);
            this.Cmb_tipoPago.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_tipoPago.Name = "Cmb_tipoPago";
            this.Cmb_tipoPago.Size = new System.Drawing.Size(116, 25);
            this.Cmb_tipoPago.TabIndex = 44;
            // 
            // Dtp_fechaRegistro
            // 
            this.Dtp_fechaRegistro.Location = new System.Drawing.Point(646, 44);
            this.Dtp_fechaRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.Dtp_fechaRegistro.Name = "Dtp_fechaRegistro";
            this.Dtp_fechaRegistro.Size = new System.Drawing.Size(110, 23);
            this.Dtp_fechaRegistro.TabIndex = 43;
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado.Location = new System.Drawing.Point(294, 127);
            this.Lbl_estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(51, 17);
            this.Lbl_estado.TabIndex = 42;
            this.Lbl_estado.Text = "Estado";
            // 
            // Txt_estado
            // 
            this.Txt_estado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estado.Location = new System.Drawing.Point(392, 127);
            this.Txt_estado.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(116, 23);
            this.Txt_estado.TabIndex = 39;
            this.Txt_estado.TextChanged += new System.EventHandler(this.Txt_estado_TextChanged);
            // 
            // Lbl_fechavencimiento
            // 
            this.Lbl_fechavencimiento.AutoSize = true;
            this.Lbl_fechavencimiento.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechavencimiento.Location = new System.Drawing.Point(15, 121);
            this.Lbl_fechavencimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_fechavencimiento.Name = "Lbl_fechavencimiento";
            this.Lbl_fechavencimiento.Size = new System.Drawing.Size(131, 17);
            this.Lbl_fechavencimiento.TabIndex = 37;
            this.Lbl_fechavencimiento.Text = "Fecha Vencimiento";
            // 
            // Lbl_tipoPago
            // 
            this.Lbl_tipoPago.AutoSize = true;
            this.Lbl_tipoPago.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoPago.Location = new System.Drawing.Point(294, 85);
            this.Lbl_tipoPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_tipoPago.Name = "Lbl_tipoPago";
            this.Lbl_tipoPago.Size = new System.Drawing.Size(94, 17);
            this.Lbl_tipoPago.TabIndex = 36;
            this.Lbl_tipoPago.Text = "Tipo de Pago";
            // 
            // Lbl_FechaEntrega
            // 
            this.Lbl_FechaEntrega.AutoSize = true;
            this.Lbl_FechaEntrega.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FechaEntrega.Location = new System.Drawing.Point(15, 80);
            this.Lbl_FechaEntrega.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_FechaEntrega.Name = "Lbl_FechaEntrega";
            this.Lbl_FechaEntrega.Size = new System.Drawing.Size(101, 17);
            this.Lbl_FechaEntrega.TabIndex = 34;
            this.Lbl_FechaEntrega.Text = "Fecha Entrega";
            // 
            // Lbl_fechaIngreso
            // 
            this.Lbl_fechaIngreso.AutoSize = true;
            this.Lbl_fechaIngreso.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechaIngreso.Location = new System.Drawing.Point(518, 44);
            this.Lbl_fechaIngreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_fechaIngreso.Name = "Lbl_fechaIngreso";
            this.Lbl_fechaIngreso.Size = new System.Drawing.Size(124, 17);
            this.Lbl_fechaIngreso.TabIndex = 33;
            this.Lbl_fechaIngreso.Text = "Fecha de Registro";
            // 
            // Txt_NumeroOrden
            // 
            this.Txt_NumeroOrden.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NumeroOrden.Location = new System.Drawing.Point(392, 38);
            this.Txt_NumeroOrden.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_NumeroOrden.Name = "Txt_NumeroOrden";
            this.Txt_NumeroOrden.Size = new System.Drawing.Size(116, 23);
            this.Txt_NumeroOrden.TabIndex = 32;
            // 
            // Txt_Proveedor
            // 
            this.Txt_Proveedor.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Proveedor.Location = new System.Drawing.Point(160, 41);
            this.Txt_Proveedor.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Proveedor.Name = "Txt_Proveedor";
            this.Txt_Proveedor.Size = new System.Drawing.Size(116, 23);
            this.Txt_Proveedor.TabIndex = 31;
            this.Txt_Proveedor.TextChanged += new System.EventHandler(this.Txt_Proveedor_TextChanged);
            // 
            // Lbl_serieFactura
            // 
            this.Lbl_serieFactura.AutoSize = true;
            this.Lbl_serieFactura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_serieFactura.Location = new System.Drawing.Point(519, 88);
            this.Lbl_serieFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_serieFactura.Name = "Lbl_serieFactura";
            this.Lbl_serieFactura.Size = new System.Drawing.Size(92, 17);
            this.Lbl_serieFactura.TabIndex = 26;
            this.Lbl_serieFactura.Text = "Serie Factura";
            // 
            // Txt_serieFactura
            // 
            this.Txt_serieFactura.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_serieFactura.Location = new System.Drawing.Point(646, 90);
            this.Txt_serieFactura.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_serieFactura.Name = "Txt_serieFactura";
            this.Txt_serieFactura.Size = new System.Drawing.Size(112, 23);
            this.Txt_serieFactura.TabIndex = 27;
            // 
            // Lbl_numeroOrden
            // 
            this.Lbl_numeroOrden.AutoSize = true;
            this.Lbl_numeroOrden.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_numeroOrden.Location = new System.Drawing.Point(294, 44);
            this.Lbl_numeroOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_numeroOrden.Name = "Lbl_numeroOrden";
            this.Lbl_numeroOrden.Size = new System.Drawing.Size(60, 17);
            this.Lbl_numeroOrden.TabIndex = 28;
            this.Lbl_numeroOrden.Text = "Numero";
            // 
            // Lbl_Proveedor
            // 
            this.Lbl_Proveedor.AutoSize = true;
            this.Lbl_Proveedor.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Proveedor.Location = new System.Drawing.Point(15, 41);
            this.Lbl_Proveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Proveedor.Name = "Lbl_Proveedor";
            this.Lbl_Proveedor.Size = new System.Drawing.Size(77, 17);
            this.Lbl_Proveedor.TabIndex = 30;
            this.Lbl_Proveedor.Text = "Proveedor";
            // 
            // Gpo_Detalle
            // 
            this.Gpo_Detalle.Controls.Add(this.Lbl_unidad);
            this.Gpo_Detalle.Controls.Add(this.Cmb_unidad);
            this.Gpo_Detalle.Controls.Add(this.Txt_producto);
            this.Gpo_Detalle.Controls.Add(this.Txt_Cantidad);
            this.Gpo_Detalle.Controls.Add(this.Lbl_Tipo);
            this.Gpo_Detalle.Controls.Add(this.Lbl_CodigoCta);
            this.Gpo_Detalle.Controls.Add(this.Lbl_Valor);
            this.Gpo_Detalle.Controls.Add(this.Txt_PrecioUnitario);
            this.Gpo_Detalle.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpo_Detalle.Location = new System.Drawing.Point(9, 282);
            this.Gpo_Detalle.Margin = new System.Windows.Forms.Padding(2);
            this.Gpo_Detalle.Name = "Gpo_Detalle";
            this.Gpo_Detalle.Padding = new System.Windows.Forms.Padding(2);
            this.Gpo_Detalle.Size = new System.Drawing.Size(797, 93);
            this.Gpo_Detalle.TabIndex = 52;
            this.Gpo_Detalle.TabStop = false;
            this.Gpo_Detalle.Text = "Detalle de Orden";
            // 
            // Txt_producto
            // 
            this.Txt_producto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_producto.Location = new System.Drawing.Point(18, 54);
            this.Txt_producto.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_producto.Name = "Txt_producto";
            this.Txt_producto.Size = new System.Drawing.Size(336, 23);
            this.Txt_producto.TabIndex = 34;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Cantidad.Location = new System.Drawing.Point(392, 56);
            this.Txt_Cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(98, 23);
            this.Txt_Cantidad.TabIndex = 33;
            // 
            // Lbl_Tipo
            // 
            this.Lbl_Tipo.AutoSize = true;
            this.Lbl_Tipo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo.Location = new System.Drawing.Point(409, 25);
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
            this.Lbl_CodigoCta.Location = new System.Drawing.Point(129, 25);
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
            this.Lbl_Valor.Location = new System.Drawing.Point(653, 25);
            this.Lbl_Valor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(103, 17);
            this.Lbl_Valor.TabIndex = 24;
            this.Lbl_Valor.Text = "Precio Unitario";
            // 
            // Txt_PrecioUnitario
            // 
            this.Txt_PrecioUnitario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PrecioUnitario.Location = new System.Drawing.Point(640, 54);
            this.Txt_PrecioUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_PrecioUnitario.Name = "Txt_PrecioUnitario";
            this.Txt_PrecioUnitario.Size = new System.Drawing.Size(129, 23);
            this.Txt_PrecioUnitario.TabIndex = 25;
            // 
            // Lbl_DetalleProductos
            // 
            this.Lbl_DetalleProductos.AutoSize = true;
            this.Lbl_DetalleProductos.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DetalleProductos.Location = new System.Drawing.Point(14, 393);
            this.Lbl_DetalleProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_DetalleProductos.Name = "Lbl_DetalleProductos";
            this.Lbl_DetalleProductos.Size = new System.Drawing.Size(157, 17);
            this.Lbl_DetalleProductos.TabIndex = 55;
            this.Lbl_DetalleProductos.Text = "Detalle de Productos";
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Agregar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Image = global::Capa_vista_orden_compra.Properties.Resources.add_insert_new_plus_button_icon_142943;
            this.Btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Agregar.Location = new System.Drawing.Point(736, 393);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(85, 64);
            this.Btn_Agregar.TabIndex = 54;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Dgv_DetalleProductos
            // 
            this.Dgv_DetalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DetalleProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProducto,
            this.ColumnCantidad,
            this.ColumnUnidad,
            this.ColumnPrecioUnitario});
            this.Dgv_DetalleProductos.Location = new System.Drawing.Point(16, 423);
            this.Dgv_DetalleProductos.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_DetalleProductos.Name = "Dgv_DetalleProductos";
            this.Dgv_DetalleProductos.RowHeadersWidth = 51;
            this.Dgv_DetalleProductos.RowTemplate.Height = 24;
            this.Dgv_DetalleProductos.Size = new System.Drawing.Size(674, 171);
            this.Dgv_DetalleProductos.TabIndex = 53;
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_limpiar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpiar.Image = global::Capa_vista_orden_compra.Properties.Resources.refresh_page_arrow_button_icon_icons_com_53909;
            this.Btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_limpiar.Location = new System.Drawing.Point(736, 547);
            this.Btn_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(85, 63);
            this.Btn_limpiar.TabIndex = 56;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Btn_remover
            // 
            this.Btn_remover.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_remover.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_remover.Image = global::Capa_vista_orden_compra.Properties.Resources.delete_remove_trash_icon_177304;
            this.Btn_remover.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_remover.Location = new System.Drawing.Point(736, 471);
            this.Btn_remover.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_remover.Name = "Btn_remover";
            this.Btn_remover.Size = new System.Drawing.Size(85, 59);
            this.Btn_remover.TabIndex = 57;
            this.Btn_remover.Text = "Remover";
            this.Btn_remover.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_remover.UseVisualStyleBackColor = true;
            this.Btn_remover.Click += new System.EventHandler(this.Btn_remover_Click);
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.Location = new System.Drawing.Point(64, 626);
            this.Lbl_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(47, 17);
            this.Lbl_Total.TabIndex = 47;
            this.Lbl_Total.Text = "Total: ";
            // 
            // Txt_total
            // 
            this.Txt_total.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_total.Location = new System.Drawing.Point(128, 623);
            this.Txt_total.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(131, 23);
            this.Txt_total.TabIndex = 47;
            // 
            // Cmb_unidad
            // 
            this.Cmb_unidad.FormattingEnabled = true;
            this.Cmb_unidad.Location = new System.Drawing.Point(509, 54);
            this.Cmb_unidad.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_unidad.Name = "Cmb_unidad";
            this.Cmb_unidad.Size = new System.Drawing.Size(116, 25);
            this.Cmb_unidad.TabIndex = 47;
            // 
            // Lbl_unidad
            // 
            this.Lbl_unidad.AutoSize = true;
            this.Lbl_unidad.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_unidad.Location = new System.Drawing.Point(518, 25);
            this.Lbl_unidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_unidad.Name = "Lbl_unidad";
            this.Lbl_unidad.Size = new System.Drawing.Size(107, 17);
            this.Lbl_unidad.TabIndex = 48;
            this.Lbl_unidad.Text = "Unidad Medida";
            // 
            // ColumnProducto
            // 
            this.ColumnProducto.HeaderText = "Producto";
            this.ColumnProducto.Name = "ColumnProducto";
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.Name = "ColumnCantidad";
            // 
            // ColumnUnidad
            // 
            this.ColumnUnidad.HeaderText = "Unidad de Medida";
            this.ColumnUnidad.Name = "ColumnUnidad";
            // 
            // ColumnPrecioUnitario
            // 
            this.ColumnPrecioUnitario.HeaderText = "Precio Unitario";
            this.ColumnPrecioUnitario.Name = "ColumnPrecioUnitario";
            // 
            // Frm_detalle_orden_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 665);
            this.Controls.Add(this.Txt_total);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.Btn_remover);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Lbl_DetalleProductos);
            this.Controls.Add(this.Btn_Agregar);
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
            this.Name = "Frm_detalle_orden_compra";
            this.Text = "Detalle Orden de Compra";
            this.Gpo_Encabezado.ResumeLayout(false);
            this.Gpo_Encabezado.PerformLayout();
            this.Gpo_Detalle.ResumeLayout(false);
            this.Gpo_Detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DetalleProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Refrescar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Grabar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.GroupBox Gpo_Encabezado;
        private System.Windows.Forms.DateTimePicker Dtp_FechaVencimiento;
        private System.Windows.Forms.ComboBox Cmb_tipoPago;
        private System.Windows.Forms.DateTimePicker Dtp_fechaRegistro;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.TextBox Txt_estado;
        private System.Windows.Forms.Label Lbl_fechavencimiento;
        private System.Windows.Forms.Label Lbl_tipoPago;
        private System.Windows.Forms.Label Lbl_FechaEntrega;
        private System.Windows.Forms.Label Lbl_fechaIngreso;
        private System.Windows.Forms.TextBox Txt_NumeroOrden;
        private System.Windows.Forms.TextBox Txt_Proveedor;
        private System.Windows.Forms.Label Lbl_serieFactura;
        private System.Windows.Forms.TextBox Txt_serieFactura;
        private System.Windows.Forms.Label Lbl_numeroOrden;
        private System.Windows.Forms.Label Lbl_Proveedor;
        private System.Windows.Forms.GroupBox Gpo_Detalle;
        private System.Windows.Forms.TextBox Txt_producto;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.Label Lbl_Tipo;
        private System.Windows.Forms.Label Lbl_CodigoCta;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.TextBox Txt_PrecioUnitario;
        private System.Windows.Forms.Label Lbl_DetalleProductos;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.DataGridView Dgv_DetalleProductos;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_entrega;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_remover;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.Label Lbl_unidad;
        private System.Windows.Forms.ComboBox Cmb_unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecioUnitario;
    }
}