
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GB_Detalle_Ventas = new System.Windows.Forms.GroupBox();
            this.Nud_Cant_Prod = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Cbo_Id_Inventario = new System.Windows.Forms.ComboBox();
            this.Lbl_Inventario = new System.Windows.Forms.Label();
            this.Dgv_Detalle_Venta = new System.Windows.Forms.DataGridView();
            this.Clm_Id_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Id_Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_precio_u = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Precio_sub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Costo_Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Pagar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GB_Detalle_Ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cant_Prod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Venta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 98);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalle Ventas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Vista_Ventas.Properties.Resources.shopping_commerce_flower_supermarket_sale_cart_icon_255564;
            this.pictureBox1.Location = new System.Drawing.Point(248, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // GB_Detalle_Ventas
            // 
            this.GB_Detalle_Ventas.Controls.Add(this.Btn_Pagar);
            this.GB_Detalle_Ventas.Controls.Add(this.Nud_Cant_Prod);
            this.GB_Detalle_Ventas.Controls.Add(this.Lbl_Cantidad);
            this.GB_Detalle_Ventas.Controls.Add(this.Cbo_Id_Inventario);
            this.GB_Detalle_Ventas.Controls.Add(this.Lbl_Inventario);
            this.GB_Detalle_Ventas.Controls.Add(this.Dgv_Detalle_Venta);
            this.GB_Detalle_Ventas.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Detalle_Ventas.Location = new System.Drawing.Point(13, 120);
            this.GB_Detalle_Ventas.Margin = new System.Windows.Forms.Padding(4);
            this.GB_Detalle_Ventas.Name = "GB_Detalle_Ventas";
            this.GB_Detalle_Ventas.Padding = new System.Windows.Forms.Padding(4);
            this.GB_Detalle_Ventas.Size = new System.Drawing.Size(1107, 438);
            this.GB_Detalle_Ventas.TabIndex = 45;
            this.GB_Detalle_Ventas.TabStop = false;
            this.GB_Detalle_Ventas.Text = "DETALLE";
            // 
            // Nud_Cant_Prod
            // 
            this.Nud_Cant_Prod.Location = new System.Drawing.Point(641, 42);
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
            this.Nud_Cant_Prod.Size = new System.Drawing.Size(95, 31);
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
            this.Lbl_Cantidad.Location = new System.Drawing.Point(441, 48);
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
            this.Cbo_Id_Inventario.Size = new System.Drawing.Size(215, 30);
            this.Cbo_Id_Inventario.TabIndex = 14;
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
            this.Dgv_Detalle_Venta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clm_Id_venta,
            this.Clm_Id_Inventario,
            this.Clm_Nombre_producto,
            this.Clm_precio_u,
            this.Clm_cantidad,
            this.Clm_Precio_sub,
            this.Clm_Costo_Subtotal});
            this.Dgv_Detalle_Venta.Location = new System.Drawing.Point(17, 156);
            this.Dgv_Detalle_Venta.Margin = new System.Windows.Forms.Padding(4);
            this.Dgv_Detalle_Venta.Name = "Dgv_Detalle_Venta";
            this.Dgv_Detalle_Venta.RowHeadersWidth = 51;
            this.Dgv_Detalle_Venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Detalle_Venta.Size = new System.Drawing.Size(1067, 254);
            this.Dgv_Detalle_Venta.TabIndex = 10;
            // 
            // Clm_Id_venta
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clm_Id_venta.DefaultCellStyle = dataGridViewCellStyle1;
            this.Clm_Id_venta.HeaderText = "Id";
            this.Clm_Id_venta.MinimumWidth = 6;
            this.Clm_Id_venta.Name = "Clm_Id_venta";
            this.Clm_Id_venta.Width = 125;
            // 
            // Clm_Id_Inventario
            // 
            this.Clm_Id_Inventario.HeaderText = "Id Inventario";
            this.Clm_Id_Inventario.MinimumWidth = 6;
            this.Clm_Id_Inventario.Name = "Clm_Id_Inventario";
            this.Clm_Id_Inventario.Width = 125;
            // 
            // Clm_Nombre_producto
            // 
            this.Clm_Nombre_producto.HeaderText = "Producto";
            this.Clm_Nombre_producto.MinimumWidth = 6;
            this.Clm_Nombre_producto.Name = "Clm_Nombre_producto";
            this.Clm_Nombre_producto.Width = 125;
            // 
            // Clm_precio_u
            // 
            this.Clm_precio_u.HeaderText = "Precio Unitario";
            this.Clm_precio_u.MinimumWidth = 6;
            this.Clm_precio_u.Name = "Clm_precio_u";
            this.Clm_precio_u.Width = 125;
            // 
            // Clm_cantidad
            // 
            this.Clm_cantidad.HeaderText = "Cantidad";
            this.Clm_cantidad.MinimumWidth = 6;
            this.Clm_cantidad.Name = "Clm_cantidad";
            this.Clm_cantidad.Width = 125;
            // 
            // Clm_Precio_sub
            // 
            this.Clm_Precio_sub.HeaderText = "Precio Subtotal";
            this.Clm_Precio_sub.MinimumWidth = 6;
            this.Clm_Precio_sub.Name = "Clm_Precio_sub";
            this.Clm_Precio_sub.Width = 125;
            // 
            // Clm_Costo_Subtotal
            // 
            this.Clm_Costo_Subtotal.HeaderText = "Costo Subtotal";
            this.Clm_Costo_Subtotal.MinimumWidth = 6;
            this.Clm_Costo_Subtotal.Name = "Clm_Costo_Subtotal";
            this.Clm_Costo_Subtotal.Width = 125;
            // 
            // Btn_Pagar
            // 
            this.Btn_Pagar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Pagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Pagar.Location = new System.Drawing.Point(890, 23);
            this.Btn_Pagar.Name = "Btn_Pagar";
            this.Btn_Pagar.Size = new System.Drawing.Size(182, 82);
            this.Btn_Pagar.TabIndex = 166;
            this.Btn_Pagar.Text = "Pagar";
            this.Btn_Pagar.UseVisualStyleBackColor = false;
            this.Btn_Pagar.Click += new System.EventHandler(this.Btn_Pagar_Click);
            // 
            // Frm_Detalle_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 585);
            this.Controls.Add(this.GB_Detalle_Ventas);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Detalle_Ventas";
            this.Text = "Detalle_Ventas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GB_Detalle_Ventas.ResumeLayout(false);
            this.GB_Detalle_Ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cant_Prod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Detalle_Venta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB_Detalle_Ventas;
        private System.Windows.Forms.NumericUpDown Nud_Cant_Prod;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.ComboBox Cbo_Id_Inventario;
        private System.Windows.Forms.Label Lbl_Inventario;
        private System.Windows.Forms.DataGridView Dgv_Detalle_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Id_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Id_Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_precio_u;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Precio_sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Costo_Subtotal;
        private System.Windows.Forms.Button Btn_Pagar;
    }
}