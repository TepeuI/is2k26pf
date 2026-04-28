
namespace Capa_Vista_Ventas
{
    partial class Frm_Detalle_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Detalle_Ventas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_Ventas = new System.Windows.Forms.GroupBox();
            this.Cbo_Estado = new System.Windows.Forms.ComboBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Cbo_Id_Sucursal = new System.Windows.Forms.ComboBox();
            this.Lbl_Id_Sucursal = new System.Windows.Forms.Label();
            this.Cbo_Id_Venta = new System.Windows.Forms.ComboBox();
            this.Dtp_Fecha_Venta = new System.Windows.Forms.DateTimePicker();
            this.Cbo_Id_Cliente = new System.Windows.Forms.ComboBox();
            this.Lbl_Fecha_Venta = new System.Windows.Forms.Label();
            this.Lbl_Id_Cliente = new System.Windows.Forms.Label();
            this.Lbl_IDVenta = new System.Windows.Forms.Label();
            this.Txt_Saldo_Total = new System.Windows.Forms.TextBox();
            this.lbl_Saldo_Total = new System.Windows.Forms.Label();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Guardar_Ventas = new System.Windows.Forms.Button();
            this.Btn_buscar_Ventas = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Modificar_Ventas = new System.Windows.Forms.Button();
            this.Btn_Reporte_Ventas = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_Cancelar_Ventas = new System.Windows.Forms.Button();
            this.Btn_Ingresar_Ventas = new System.Windows.Forms.Button();
            this.GB_Detalle_Ventas = new System.Windows.Forms.GroupBox();
            this.Btn_Limpiar_Detalle_Ventas = new System.Windows.Forms.Button();
            this.Btn_Remover_Detalle_Ventas = new System.Windows.Forms.Button();
            this.Btn_Agregar_Detalle_Ventas = new System.Windows.Forms.Button();
            this.Cbo_Id_Bodega = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Pagar = new System.Windows.Forms.Button();
            this.Nud_Cant_Prod = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Cbo_Id_Inventario = new System.Windows.Forms.ComboBox();
            this.Lbl_Inventario = new System.Windows.Forms.Label();
            this.Dgv_Detalle_Venta = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.GB_Ventas.SuspendLayout();
            this.GB_Detalle_Ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cant_Prod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Venta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 98);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "710 - Ventas";
            // 
            // GB_Ventas
            // 
            this.GB_Ventas.Controls.Add(this.Cbo_Estado);
            this.GB_Ventas.Controls.Add(this.Lbl_Estado);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Sucursal);
            this.GB_Ventas.Controls.Add(this.Lbl_Id_Sucursal);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Venta);
            this.GB_Ventas.Controls.Add(this.Dtp_Fecha_Venta);
            this.GB_Ventas.Controls.Add(this.Cbo_Id_Cliente);
            this.GB_Ventas.Controls.Add(this.Lbl_Fecha_Venta);
            this.GB_Ventas.Controls.Add(this.Lbl_Id_Cliente);
            this.GB_Ventas.Controls.Add(this.Lbl_IDVenta);
            this.GB_Ventas.Font = new System.Drawing.Font("Rockwell", 10F);
            this.GB_Ventas.Location = new System.Drawing.Point(13, 200);
            this.GB_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.GB_Ventas.Name = "GB_Ventas";
            this.GB_Ventas.Padding = new System.Windows.Forms.Padding(4);
            this.GB_Ventas.Size = new System.Drawing.Size(1032, 137);
            this.GB_Ventas.TabIndex = 43;
            this.GB_Ventas.TabStop = false;
            this.GB_Ventas.Text = "Encabezado de Venta";
            // 
            // Cbo_Estado
            // 
            this.Cbo_Estado.FormattingEnabled = true;
            this.Cbo_Estado.Location = new System.Drawing.Point(821, 88);
            this.Cbo_Estado.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Estado.MaxLength = 13;
            this.Cbo_Estado.Name = "Cbo_Estado";
            this.Cbo_Estado.Size = new System.Drawing.Size(163, 28);
            this.Cbo_Estado.TabIndex = 15;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.Location = new System.Drawing.Point(723, 96);
            this.Lbl_Estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(67, 20);
            this.Lbl_Estado.TabIndex = 14;
            this.Lbl_Estado.Text = "Estado:";
            // 
            // Cbo_Id_Sucursal
            // 
            this.Cbo_Id_Sucursal.FormattingEnabled = true;
            this.Cbo_Id_Sucursal.Location = new System.Drawing.Point(137, 96);
            this.Cbo_Id_Sucursal.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Sucursal.MaxLength = 13;
            this.Cbo_Id_Sucursal.Name = "Cbo_Id_Sucursal";
            this.Cbo_Id_Sucursal.Size = new System.Drawing.Size(365, 28);
            this.Cbo_Id_Sucursal.TabIndex = 13;
            // 
            // Lbl_Id_Sucursal
            // 
            this.Lbl_Id_Sucursal.AutoSize = true;
            this.Lbl_Id_Sucursal.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Sucursal.Location = new System.Drawing.Point(13, 100);
            this.Lbl_Id_Sucursal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_Sucursal.Name = "Lbl_Id_Sucursal";
            this.Lbl_Id_Sucursal.Size = new System.Drawing.Size(100, 20);
            this.Lbl_Id_Sucursal.TabIndex = 12;
            this.Lbl_Id_Sucursal.Text = "Id Sucursal:";
            // 
            // Cbo_Id_Venta
            // 
            this.Cbo_Id_Venta.FormattingEnabled = true;
            this.Cbo_Id_Venta.Location = new System.Drawing.Point(104, 32);
            this.Cbo_Id_Venta.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Venta.Name = "Cbo_Id_Venta";
            this.Cbo_Id_Venta.Size = new System.Drawing.Size(119, 28);
            this.Cbo_Id_Venta.TabIndex = 8;
            // 
            // Dtp_Fecha_Venta
            // 
            this.Dtp_Fecha_Venta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Fecha_Venta.Location = new System.Drawing.Point(808, 33);
            this.Dtp_Fecha_Venta.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_Fecha_Venta.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.Dtp_Fecha_Venta.MinDate = new System.DateTime(1912, 1, 1, 0, 0, 0, 0);
            this.Dtp_Fecha_Venta.Name = "Dtp_Fecha_Venta";
            this.Dtp_Fecha_Venta.Size = new System.Drawing.Size(176, 27);
            this.Dtp_Fecha_Venta.TabIndex = 6;
            // 
            // Cbo_Id_Cliente
            // 
            this.Cbo_Id_Cliente.FormattingEnabled = true;
            this.Cbo_Id_Cliente.Location = new System.Drawing.Point(408, 34);
            this.Cbo_Id_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Cliente.MaxLength = 13;
            this.Cbo_Id_Cliente.Name = "Cbo_Id_Cliente";
            this.Cbo_Id_Cliente.Size = new System.Drawing.Size(268, 28);
            this.Cbo_Id_Cliente.TabIndex = 5;
            this.Cbo_Id_Cliente.SelectedIndexChanged += new System.EventHandler(this.Cbo_Id_Cliente_SelectedIndexChanged);
            // 
            // Lbl_Fecha_Venta
            // 
            this.Lbl_Fecha_Venta.AutoSize = true;
            this.Lbl_Fecha_Venta.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Venta.Location = new System.Drawing.Point(729, 36);
            this.Lbl_Fecha_Venta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Fecha_Venta.Name = "Lbl_Fecha_Venta";
            this.Lbl_Fecha_Venta.Size = new System.Drawing.Size(61, 20);
            this.Lbl_Fecha_Venta.TabIndex = 2;
            this.Lbl_Fecha_Venta.Text = "Fecha:";
            // 
            // Lbl_Id_Cliente
            // 
            this.Lbl_Id_Cliente.AutoSize = true;
            this.Lbl_Id_Cliente.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Id_Cliente.Location = new System.Drawing.Point(308, 36);
            this.Lbl_Id_Cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Id_Cliente.Name = "Lbl_Id_Cliente";
            this.Lbl_Id_Cliente.Size = new System.Drawing.Size(91, 20);
            this.Lbl_Id_Cliente.TabIndex = 1;
            this.Lbl_Id_Cliente.Text = "Id Cliente:";
            // 
            // Lbl_IDVenta
            // 
            this.Lbl_IDVenta.AutoSize = true;
            this.Lbl_IDVenta.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IDVenta.Location = new System.Drawing.Point(8, 32);
            this.Lbl_IDVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_IDVenta.Name = "Lbl_IDVenta";
            this.Lbl_IDVenta.Size = new System.Drawing.Size(79, 20);
            this.Lbl_IDVenta.TabIndex = 0;
            this.Lbl_IDVenta.Text = "Id Venta:";
            // 
            // Txt_Saldo_Total
            // 
            this.Txt_Saldo_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Txt_Saldo_Total.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Saldo_Total.Location = new System.Drawing.Point(548, 429);
            this.Txt_Saldo_Total.Name = "Txt_Saldo_Total";
            this.Txt_Saldo_Total.ReadOnly = true;
            this.Txt_Saldo_Total.Size = new System.Drawing.Size(213, 29);
            this.Txt_Saldo_Total.TabIndex = 23;
            this.Txt_Saldo_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Saldo_Total
            // 
            this.lbl_Saldo_Total.AutoSize = true;
            this.lbl_Saldo_Total.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saldo_Total.Location = new System.Drawing.Point(444, 433);
            this.lbl_Saldo_Total.Name = "lbl_Saldo_Total";
            this.lbl_Saldo_Total.Size = new System.Drawing.Size(100, 20);
            this.lbl_Saldo_Total.TabIndex = 22;
            this.lbl_Saldo_Total.Text = "Saldo Total:";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.Location = new System.Drawing.Point(550, 108);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(121, 84);
            this.Btn_Eliminar.TabIndex = 63;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Guardar_Ventas
            // 
            this.Btn_Guardar_Ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_Guardar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar_Ventas.Image")));
            this.Btn_Guardar_Ventas.Location = new System.Drawing.Point(292, 108);
            this.Btn_Guardar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Guardar_Ventas.Name = "Btn_Guardar_Ventas";
            this.Btn_Guardar_Ventas.Size = new System.Drawing.Size(121, 84);
            this.Btn_Guardar_Ventas.TabIndex = 62;
            this.Btn_Guardar_Ventas.Text = "GUARDAR";
            this.Btn_Guardar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Guardar_Ventas.UseVisualStyleBackColor = false;
            this.Btn_Guardar_Ventas.Click += new System.EventHandler(this.Btn_Guardar_Ventas_Click);
            // 
            // Btn_buscar_Ventas
            // 
            this.Btn_buscar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscar_Ventas.Image")));
            this.Btn_buscar_Ventas.Location = new System.Drawing.Point(682, 108);
            this.Btn_buscar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_buscar_Ventas.Name = "Btn_buscar_Ventas";
            this.Btn_buscar_Ventas.Size = new System.Drawing.Size(121, 84);
            this.Btn_buscar_Ventas.TabIndex = 61;
            this.Btn_buscar_Ventas.Text = "BUSCAR";
            this.Btn_buscar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_buscar_Ventas.UseVisualStyleBackColor = true;
            this.Btn_buscar_Ventas.Click += new System.EventHandler(this.Btn_buscar_Ventas_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.Location = new System.Drawing.Point(1074, 108);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(121, 84);
            this.Btn_Salir.TabIndex = 60;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            // 
            // Btn_Modificar_Ventas
            // 
            this.Btn_Modificar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Modificar_Ventas.Image")));
            this.Btn_Modificar_Ventas.Location = new System.Drawing.Point(163, 108);
            this.Btn_Modificar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Modificar_Ventas.Name = "Btn_Modificar_Ventas";
            this.Btn_Modificar_Ventas.Size = new System.Drawing.Size(121, 84);
            this.Btn_Modificar_Ventas.TabIndex = 59;
            this.Btn_Modificar_Ventas.Text = "MODIFICAR";
            this.Btn_Modificar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar_Ventas.UseVisualStyleBackColor = true;
            this.Btn_Modificar_Ventas.Click += new System.EventHandler(this.Btn_Modificar_Ventas_Click);
            // 
            // Btn_Reporte_Ventas
            // 
            this.Btn_Reporte_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reporte_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Reporte_Ventas.Image")));
            this.Btn_Reporte_Ventas.Location = new System.Drawing.Point(811, 108);
            this.Btn_Reporte_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Reporte_Ventas.Name = "Btn_Reporte_Ventas";
            this.Btn_Reporte_Ventas.Size = new System.Drawing.Size(121, 84);
            this.Btn_Reporte_Ventas.TabIndex = 58;
            this.Btn_Reporte_Ventas.Text = "REPORTE";
            this.Btn_Reporte_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte_Ventas.UseVisualStyleBackColor = true;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayuda.Image")));
            this.Btn_Ayuda.Location = new System.Drawing.Point(940, 108);
            this.Btn_Ayuda.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(121, 84);
            this.Btn_Ayuda.TabIndex = 57;
            this.Btn_Ayuda.Text = "AYUDA";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar_Ventas
            // 
            this.Btn_Cancelar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar_Ventas.Image")));
            this.Btn_Cancelar_Ventas.Location = new System.Drawing.Point(421, 108);
            this.Btn_Cancelar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cancelar_Ventas.Name = "Btn_Cancelar_Ventas";
            this.Btn_Cancelar_Ventas.Size = new System.Drawing.Size(121, 84);
            this.Btn_Cancelar_Ventas.TabIndex = 56;
            this.Btn_Cancelar_Ventas.Text = "CANCELAR";
            this.Btn_Cancelar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Cancelar_Ventas.UseVisualStyleBackColor = true;
            this.Btn_Cancelar_Ventas.Click += new System.EventHandler(this.Btn_Cancelar_Ventas_Click);
            // 
            // Btn_Ingresar_Ventas
            // 
            this.Btn_Ingresar_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ingresar_Ventas.Image")));
            this.Btn_Ingresar_Ventas.Location = new System.Drawing.Point(34, 108);
            this.Btn_Ingresar_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Ingresar_Ventas.Name = "Btn_Ingresar_Ventas";
            this.Btn_Ingresar_Ventas.Size = new System.Drawing.Size(121, 84);
            this.Btn_Ingresar_Ventas.TabIndex = 55;
            this.Btn_Ingresar_Ventas.Text = "INGRESAR";
            this.Btn_Ingresar_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ingresar_Ventas.UseVisualStyleBackColor = true;
            this.Btn_Ingresar_Ventas.Click += new System.EventHandler(this.Btn_Ingresar_Ventas_Click);
            // 
            // GB_Detalle_Ventas
            // 
            this.GB_Detalle_Ventas.Controls.Add(this.Btn_Limpiar_Detalle_Ventas);
            this.GB_Detalle_Ventas.Controls.Add(this.Btn_Remover_Detalle_Ventas);
            this.GB_Detalle_Ventas.Controls.Add(this.Btn_Agregar_Detalle_Ventas);
            this.GB_Detalle_Ventas.Controls.Add(this.Txt_Saldo_Total);
            this.GB_Detalle_Ventas.Controls.Add(this.Cbo_Id_Bodega);
            this.GB_Detalle_Ventas.Controls.Add(this.lbl_Saldo_Total);
            this.GB_Detalle_Ventas.Controls.Add(this.label2);
            this.GB_Detalle_Ventas.Controls.Add(this.Btn_Pagar);
            this.GB_Detalle_Ventas.Controls.Add(this.Nud_Cant_Prod);
            this.GB_Detalle_Ventas.Controls.Add(this.Lbl_Cantidad);
            this.GB_Detalle_Ventas.Controls.Add(this.Cbo_Id_Inventario);
            this.GB_Detalle_Ventas.Controls.Add(this.Lbl_Inventario);
            this.GB_Detalle_Ventas.Controls.Add(this.Dgv_Detalle_Venta);
            this.GB_Detalle_Ventas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Detalle_Ventas.Location = new System.Drawing.Point(13, 345);
            this.GB_Detalle_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.GB_Detalle_Ventas.Name = "GB_Detalle_Ventas";
            this.GB_Detalle_Ventas.Padding = new System.Windows.Forms.Padding(4);
            this.GB_Detalle_Ventas.Size = new System.Drawing.Size(1215, 478);
            this.GB_Detalle_Ventas.TabIndex = 64;
            this.GB_Detalle_Ventas.TabStop = false;
            this.GB_Detalle_Ventas.Text = "Detalle de ventas";
            // 
            // Btn_Limpiar_Detalle_Ventas
            // 
            this.Btn_Limpiar_Detalle_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar_Detalle_Ventas.Image")));
            this.Btn_Limpiar_Detalle_Ventas.Location = new System.Drawing.Point(1031, 355);
            this.Btn_Limpiar_Detalle_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Limpiar_Detalle_Ventas.Name = "Btn_Limpiar_Detalle_Ventas";
            this.Btn_Limpiar_Detalle_Ventas.Size = new System.Drawing.Size(151, 98);
            this.Btn_Limpiar_Detalle_Ventas.TabIndex = 171;
            this.Btn_Limpiar_Detalle_Ventas.Text = "LIMPIAR";
            this.Btn_Limpiar_Detalle_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Limpiar_Detalle_Ventas.UseVisualStyleBackColor = true;
            // 
            // Btn_Remover_Detalle_Ventas
            // 
            this.Btn_Remover_Detalle_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Remover_Detalle_Ventas.Image")));
            this.Btn_Remover_Detalle_Ventas.Location = new System.Drawing.Point(1031, 238);
            this.Btn_Remover_Detalle_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Remover_Detalle_Ventas.Name = "Btn_Remover_Detalle_Ventas";
            this.Btn_Remover_Detalle_Ventas.Size = new System.Drawing.Size(151, 98);
            this.Btn_Remover_Detalle_Ventas.TabIndex = 170;
            this.Btn_Remover_Detalle_Ventas.Text = "REMOVER";
            this.Btn_Remover_Detalle_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Remover_Detalle_Ventas.UseVisualStyleBackColor = true;
            // 
            // Btn_Agregar_Detalle_Ventas
            // 
            this.Btn_Agregar_Detalle_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Detalle_Ventas.Image")));
            this.Btn_Agregar_Detalle_Ventas.Location = new System.Drawing.Point(1031, 122);
            this.Btn_Agregar_Detalle_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Agregar_Detalle_Ventas.Name = "Btn_Agregar_Detalle_Ventas";
            this.Btn_Agregar_Detalle_Ventas.Size = new System.Drawing.Size(151, 98);
            this.Btn_Agregar_Detalle_Ventas.TabIndex = 169;
            this.Btn_Agregar_Detalle_Ventas.Text = "AGREGAR";
            this.Btn_Agregar_Detalle_Ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Agregar_Detalle_Ventas.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Detalle_Ventas.Click += new System.EventHandler(this.Btn_Agregar_Detalle_Ventas_Click);
            // 
            // Cbo_Id_Bodega
            // 
            this.Cbo_Id_Bodega.FormattingEnabled = true;
            this.Cbo_Id_Bodega.Location = new System.Drawing.Point(141, 95);
            this.Cbo_Id_Bodega.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Bodega.Name = "Cbo_Id_Bodega";
            this.Cbo_Id_Bodega.Size = new System.Drawing.Size(361, 30);
            this.Cbo_Id_Bodega.TabIndex = 168;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 167;
            this.label2.Text = "Id Bodega:";
            // 
            // Btn_Pagar
            // 
            this.Btn_Pagar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Pagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Pagar.Location = new System.Drawing.Point(1039, 48);
            this.Btn_Pagar.Name = "Btn_Pagar";
            this.Btn_Pagar.Size = new System.Drawing.Size(143, 46);
            this.Btn_Pagar.TabIndex = 166;
            this.Btn_Pagar.Text = "Pagar";
            this.Btn_Pagar.UseVisualStyleBackColor = false;
            this.Btn_Pagar.Click += new System.EventHandler(this.Btn_Pagar_Click);
            // 
            // Nud_Cant_Prod
            // 
            this.Nud_Cant_Prod.Location = new System.Drawing.Point(860, 44);
            this.Nud_Cant_Prod.Margin = new System.Windows.Forms.Padding(4);
            this.Nud_Cant_Prod.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Nud_Cant_Prod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_Cant_Prod.Name = "Nud_Cant_Prod";
            this.Nud_Cant_Prod.Size = new System.Drawing.Size(74, 31);
            this.Nud_Cant_Prod.TabIndex = 17;
            this.Nud_Cant_Prod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad.Location = new System.Drawing.Point(692, 48);
            this.Lbl_Cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(160, 20);
            this.Lbl_Cantidad.TabIndex = 15;
            this.Lbl_Cantidad.Text = "Cantidad Producto:";
            // 
            // Cbo_Id_Inventario
            // 
            this.Cbo_Id_Inventario.FormattingEnabled = true;
            this.Cbo_Id_Inventario.Location = new System.Drawing.Point(137, 41);
            this.Cbo_Id_Inventario.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Id_Inventario.Name = "Cbo_Id_Inventario";
            this.Cbo_Id_Inventario.Size = new System.Drawing.Size(365, 30);
            this.Cbo_Id_Inventario.TabIndex = 14;
            this.Cbo_Id_Inventario.SelectedIndexChanged += new System.EventHandler(this.Cbo_Id_Inventario_SelectedIndexChanged);
            // 
            // Lbl_Inventario
            // 
            this.Lbl_Inventario.AutoSize = true;
            this.Lbl_Inventario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Inventario.Location = new System.Drawing.Point(13, 48);
            this.Lbl_Inventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Inventario.Name = "Lbl_Inventario";
            this.Lbl_Inventario.Size = new System.Drawing.Size(113, 20);
            this.Lbl_Inventario.TabIndex = 13;
            this.Lbl_Inventario.Text = "Id Inventario:";
            // 
            // Dgv_Detalle_Venta
            // 
            this.Dgv_Detalle_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Detalle_Venta.Location = new System.Drawing.Point(34, 149);
            this.Dgv_Detalle_Venta.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Detalle_Venta.Name = "Dgv_Detalle_Venta";
            this.Dgv_Detalle_Venta.RowHeadersWidth = 51;
            this.Dgv_Detalle_Venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Detalle_Venta.Size = new System.Drawing.Size(917, 254);
            this.Dgv_Detalle_Venta.TabIndex = 10;
            this.Dgv_Detalle_Venta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Detalle_Venta_CellContentClick);
            // 
            // Frm_Detalle_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1256, 836);
            this.Controls.Add(this.GB_Detalle_Ventas);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.GB_Ventas);
            this.Controls.Add(this.Btn_Guardar_Ventas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_buscar_Ventas);
            this.Controls.Add(this.Btn_Ingresar_Ventas);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Cancelar_Ventas);
            this.Controls.Add(this.Btn_Modificar_Ventas);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.Btn_Reporte_Ventas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Detalle_Ventas";
            this.Text = "Detalle Ventas";
            this.Load += new System.EventHandler(this.Frm_Detalle_Ventas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GB_Ventas.ResumeLayout(false);
            this.GB_Ventas.PerformLayout();
            this.GB_Detalle_Ventas.ResumeLayout(false);
            this.GB_Detalle_Ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cant_Prod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Venta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB_Ventas;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha_Venta;
        private System.Windows.Forms.ComboBox Cbo_Id_Cliente;
        private System.Windows.Forms.Label Lbl_Fecha_Venta;
        private System.Windows.Forms.Label Lbl_Id_Cliente;
        private System.Windows.Forms.ComboBox Cbo_Id_Sucursal;
        private System.Windows.Forms.Label Lbl_Id_Sucursal;
        private System.Windows.Forms.ComboBox Cbo_Estado;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.TextBox Txt_Saldo_Total;
        private System.Windows.Forms.Label lbl_Saldo_Total;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Guardar_Ventas;
        private System.Windows.Forms.Button Btn_buscar_Ventas;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Modificar_Ventas;
        private System.Windows.Forms.Button Btn_Reporte_Ventas;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Cancelar_Ventas;
        private System.Windows.Forms.Button Btn_Ingresar_Ventas;
        private System.Windows.Forms.GroupBox GB_Detalle_Ventas;
        private System.Windows.Forms.ComboBox Cbo_Id_Bodega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Pagar;
        private System.Windows.Forms.NumericUpDown Nud_Cant_Prod;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.ComboBox Cbo_Id_Inventario;
        private System.Windows.Forms.Label Lbl_Inventario;
        private System.Windows.Forms.DataGridView Dgv_Detalle_Venta;
        private System.Windows.Forms.Button Btn_Limpiar_Detalle_Ventas;
        private System.Windows.Forms.Button Btn_Remover_Detalle_Ventas;
        private System.Windows.Forms.Button Btn_Agregar_Detalle_Ventas;
        private System.Windows.Forms.ComboBox Cbo_Id_Venta;
        private System.Windows.Forms.Label Lbl_IDVenta;
    }
}