
namespace Capa_Vista_Mov_Inv
{
    partial class Frm_Detalle_transaccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Detalle_transaccion));
            this.GB_Detalle = new System.Windows.Forms.GroupBox();
            this.NUD_Cant_mov = new System.Windows.Forms.NumericUpDown();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Cbo_ID_Inventario = new System.Windows.Forms.ComboBox();
            this.Lbl_Inventario = new System.Windows.Forms.Label();
            this.BTN_LIMPIAR_DETALE = new System.Windows.Forms.Button();
            this.Btn_Remover_Detalle = new System.Windows.Forms.Button();
            this.Btn_Agregar_Detalle = new System.Windows.Forms.Button();
            this.DGV_DETALLE_MOVIMIENTO = new System.Windows.Forms.DataGridView();
            this.Clm_ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Cant_mov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DETALLE_MOVIMIENTO)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Detalle
            // 
            this.GB_Detalle.Controls.Add(this.NUD_Cant_mov);
            this.GB_Detalle.Controls.Add(this.Lbl_Cantidad);
            this.GB_Detalle.Controls.Add(this.Cbo_ID_Inventario);
            this.GB_Detalle.Controls.Add(this.Lbl_Inventario);
            this.GB_Detalle.Controls.Add(this.BTN_LIMPIAR_DETALE);
            this.GB_Detalle.Controls.Add(this.Btn_Remover_Detalle);
            this.GB_Detalle.Controls.Add(this.Btn_Agregar_Detalle);
            this.GB_Detalle.Controls.Add(this.DGV_DETALLE_MOVIMIENTO);
            this.GB_Detalle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Detalle.Location = new System.Drawing.Point(12, 87);
            this.GB_Detalle.Name = "GB_Detalle";
            this.GB_Detalle.Size = new System.Drawing.Size(830, 433);
            this.GB_Detalle.TabIndex = 28;
            this.GB_Detalle.TabStop = false;
            this.GB_Detalle.Text = "DETALLE";
            // 
            // NUD_Cant_mov
            // 
            this.NUD_Cant_mov.Location = new System.Drawing.Point(545, 111);
            this.NUD_Cant_mov.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NUD_Cant_mov.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Cant_mov.Name = "NUD_Cant_mov";
            this.NUD_Cant_mov.Size = new System.Drawing.Size(120, 26);
            this.NUD_Cant_mov.TabIndex = 17;
            this.NUD_Cant_mov.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad.Location = new System.Drawing.Point(418, 116);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(112, 16);
            this.Lbl_Cantidad.TabIndex = 15;
            this.Lbl_Cantidad.Text = "Cantidad Movida:";
            // 
            // Cbo_ID_Inventario
            // 
            this.Cbo_ID_Inventario.FormattingEnabled = true;
            this.Cbo_ID_Inventario.Location = new System.Drawing.Point(148, 111);
            this.Cbo_ID_Inventario.Name = "Cbo_ID_Inventario";
            this.Cbo_ID_Inventario.Size = new System.Drawing.Size(162, 27);
            this.Cbo_ID_Inventario.TabIndex = 14;
            // 
            // Lbl_Inventario
            // 
            this.Lbl_Inventario.AutoSize = true;
            this.Lbl_Inventario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Inventario.Location = new System.Drawing.Point(17, 116);
            this.Lbl_Inventario.Name = "Lbl_Inventario";
            this.Lbl_Inventario.Size = new System.Drawing.Size(85, 16);
            this.Lbl_Inventario.TabIndex = 13;
            this.Lbl_Inventario.Text = "Id Inventario:";
            // 
            // BTN_LIMPIAR_DETALE
            // 
            this.BTN_LIMPIAR_DETALE.Image = ((System.Drawing.Image)(resources.GetObject("BTN_LIMPIAR_DETALE.Image")));
            this.BTN_LIMPIAR_DETALE.Location = new System.Drawing.Point(261, 19);
            this.BTN_LIMPIAR_DETALE.Name = "BTN_LIMPIAR_DETALE";
            this.BTN_LIMPIAR_DETALE.Size = new System.Drawing.Size(113, 80);
            this.BTN_LIMPIAR_DETALE.TabIndex = 12;
            this.BTN_LIMPIAR_DETALE.Text = "LIMPIAR";
            this.BTN_LIMPIAR_DETALE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_LIMPIAR_DETALE.UseVisualStyleBackColor = true;
            this.BTN_LIMPIAR_DETALE.Click += new System.EventHandler(this.BTN_LIMPIAR_DETALE_Click);
            // 
            // Btn_Remover_Detalle
            // 
            this.Btn_Remover_Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Remover_Detalle.Image")));
            this.Btn_Remover_Detalle.Location = new System.Drawing.Point(142, 19);
            this.Btn_Remover_Detalle.Name = "Btn_Remover_Detalle";
            this.Btn_Remover_Detalle.Size = new System.Drawing.Size(113, 80);
            this.Btn_Remover_Detalle.TabIndex = 11;
            this.Btn_Remover_Detalle.Text = "REMOVER";
            this.Btn_Remover_Detalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Remover_Detalle.UseVisualStyleBackColor = true;
            this.Btn_Remover_Detalle.Click += new System.EventHandler(this.Btn_Remover_Detalle_Click);
            // 
            // Btn_Agregar_Detalle
            // 
            this.Btn_Agregar_Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Detalle.Image")));
            this.Btn_Agregar_Detalle.Location = new System.Drawing.Point(20, 19);
            this.Btn_Agregar_Detalle.Name = "Btn_Agregar_Detalle";
            this.Btn_Agregar_Detalle.Size = new System.Drawing.Size(116, 80);
            this.Btn_Agregar_Detalle.TabIndex = 9;
            this.Btn_Agregar_Detalle.Text = "AGREGAR";
            this.Btn_Agregar_Detalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Agregar_Detalle.UseVisualStyleBackColor = true;
            this.Btn_Agregar_Detalle.Click += new System.EventHandler(this.Btn_Agregar_Detalle_Click);
            // 
            // DGV_DETALLE_MOVIMIENTO
            // 
            this.DGV_DETALLE_MOVIMIENTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DETALLE_MOVIMIENTO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clm_ID_Producto,
            this.Clm_Producto,
            this.Clm_Cantidad});
            this.DGV_DETALLE_MOVIMIENTO.Location = new System.Drawing.Point(20, 161);
            this.DGV_DETALLE_MOVIMIENTO.Name = "DGV_DETALLE_MOVIMIENTO";
            this.DGV_DETALLE_MOVIMIENTO.RowHeadersWidth = 51;
            this.DGV_DETALLE_MOVIMIENTO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DETALLE_MOVIMIENTO.Size = new System.Drawing.Size(789, 254);
            this.DGV_DETALLE_MOVIMIENTO.TabIndex = 10;
            // 
            // Clm_ID_Producto
            // 
            this.Clm_ID_Producto.HeaderText = "ID Producto";
            this.Clm_ID_Producto.MinimumWidth = 6;
            this.Clm_ID_Producto.Name = "Clm_ID_Producto";
            this.Clm_ID_Producto.Width = 125;
            // 
            // Clm_Producto
            // 
            this.Clm_Producto.HeaderText = "Producto";
            this.Clm_Producto.MinimumWidth = 6;
            this.Clm_Producto.Name = "Clm_Producto";
            this.Clm_Producto.Width = 125;
            // 
            // Clm_Cantidad
            // 
            this.Clm_Cantidad.HeaderText = "Cantidad";
            this.Clm_Cantidad.MinimumWidth = 6;
            this.Clm_Cantidad.Name = "Clm_Cantidad";
            this.Clm_Cantidad.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 80);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "DETALLE MOVIMIENTO DE INVENTARIO";
            // 
            // Frm_Detalle_transaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GB_Detalle);
            this.Name = "Frm_Detalle_transaccion";
            this.Text = "Frm_Detalle_transaccion";
            this.GB_Detalle.ResumeLayout(false);
            this.GB_Detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Cant_mov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DETALLE_MOVIMIENTO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Detalle;
        private System.Windows.Forms.NumericUpDown NUD_Cant_mov;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.ComboBox Cbo_ID_Inventario;
        private System.Windows.Forms.Label Lbl_Inventario;
        private System.Windows.Forms.Button BTN_LIMPIAR_DETALE;
        private System.Windows.Forms.Button Btn_Remover_Detalle;
        private System.Windows.Forms.Button Btn_Agregar_Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Cantidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DGV_DETALLE_MOVIMIENTO;
    }
}