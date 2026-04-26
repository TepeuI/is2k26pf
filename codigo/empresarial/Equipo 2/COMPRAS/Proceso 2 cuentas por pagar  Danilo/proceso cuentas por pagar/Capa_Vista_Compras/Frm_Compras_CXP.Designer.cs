namespace Capa_Vista_Compras
{
    partial class Frm_Compras_CXP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Cbo_proveedor = new System.Windows.Forms.ComboBox();
            this.Txt_numero = new System.Windows.Forms.TextBox();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_estado = new System.Windows.Forms.TextBox();
            this.Txt_saldo = new System.Windows.Forms.TextBox();
            this.Txt_adelanto = new System.Windows.Forms.TextBox();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.Txt_orden = new System.Windows.Forms.TextBox();
            this.Dgv_compras = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_compras = new System.Windows.Forms.Label();
            this.Btn_Grabar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_Refrescar = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_compras)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de facturacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proveedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id orden de compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total de la compra:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adelanto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Saldo Pendiente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Dtp_fecha);
            this.groupBox1.Controls.Add(this.Cbo_proveedor);
            this.groupBox1.Controls.Add(this.Txt_numero);
            this.groupBox1.Controls.Add(this.Txt_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 120);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la compra";
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.Location = new System.Drawing.Point(345, 26);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(200, 23);
            this.Dtp_fecha.TabIndex = 13;
            // 
            // Cbo_proveedor
            // 
            this.Cbo_proveedor.FormattingEnabled = true;
            this.Cbo_proveedor.Location = new System.Drawing.Point(347, 68);
            this.Cbo_proveedor.Name = "Cbo_proveedor";
            this.Cbo_proveedor.Size = new System.Drawing.Size(121, 25);
            this.Cbo_proveedor.TabIndex = 12;
            // 
            // Txt_numero
            // 
            this.Txt_numero.Location = new System.Drawing.Point(93, 68);
            this.Txt_numero.Name = "Txt_numero";
            this.Txt_numero.Size = new System.Drawing.Size(100, 23);
            this.Txt_numero.TabIndex = 11;
            // 
            // Txt_id
            // 
            this.Txt_id.Location = new System.Drawing.Point(93, 26);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(100, 23);
            this.Txt_id.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Aceptar);
            this.groupBox2.Controls.Add(this.Txt_estado);
            this.groupBox2.Controls.Add(this.Txt_saldo);
            this.groupBox2.Controls.Add(this.Txt_adelanto);
            this.groupBox2.Controls.Add(this.Txt_total);
            this.groupBox2.Controls.Add(this.Txt_orden);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(12, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 121);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de pago";
            // 
            // Txt_estado
            // 
            this.Txt_estado.Location = new System.Drawing.Point(423, 79);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(100, 23);
            this.Txt_estado.TabIndex = 12;
            // 
            // Txt_saldo
            // 
            this.Txt_saldo.Location = new System.Drawing.Point(423, 44);
            this.Txt_saldo.Name = "Txt_saldo";
            this.Txt_saldo.Size = new System.Drawing.Size(100, 23);
            this.Txt_saldo.TabIndex = 12;
            // 
            // Txt_adelanto
            // 
            this.Txt_adelanto.Location = new System.Drawing.Point(423, 15);
            this.Txt_adelanto.Name = "Txt_adelanto";
            this.Txt_adelanto.Size = new System.Drawing.Size(100, 23);
            this.Txt_adelanto.TabIndex = 12;
            // 
            // Txt_total
            // 
            this.Txt_total.Location = new System.Drawing.Point(148, 77);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(100, 23);
            this.Txt_total.TabIndex = 12;
            // 
            // Txt_orden
            // 
            this.Txt_orden.Location = new System.Drawing.Point(148, 26);
            this.Txt_orden.Name = "Txt_orden";
            this.Txt_orden.Size = new System.Drawing.Size(100, 23);
            this.Txt_orden.TabIndex = 12;
            // 
            // Dgv_compras
            // 
            this.Dgv_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_compras.Location = new System.Drawing.Point(12, 470);
            this.Dgv_compras.Name = "Dgv_compras";
            this.Dgv_compras.Size = new System.Drawing.Size(570, 166);
            this.Dgv_compras.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Lbl_compras);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 60);
            this.panel1.TabIndex = 34;
            // 
            // Lbl_compras
            // 
            this.Lbl_compras.AutoSize = true;
            this.Lbl_compras.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl_compras.Font = new System.Drawing.Font("Rockwell", 18F);
            this.Lbl_compras.Location = new System.Drawing.Point(22, 19);
            this.Lbl_compras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_compras.Name = "Lbl_compras";
            this.Lbl_compras.Size = new System.Drawing.Size(324, 27);
            this.Lbl_compras.TabIndex = 31;
            this.Lbl_compras.Text = "715 - CUENTAS POR PAGAR";
            // 
            // Btn_Grabar
            // 
            this.Btn_Grabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Grabar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Grabar.Image = global::Capa_Vista_Compras.Properties.Resources.savetheapplication_guardar_2958;
            this.Btn_Grabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Grabar.Location = new System.Drawing.Point(133, 88);
            this.Btn_Grabar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Grabar.Name = "Btn_Grabar";
            this.Btn_Grabar.Size = new System.Drawing.Size(117, 65);
            this.Btn_Grabar.TabIndex = 35;
            this.Btn_Grabar.Text = "Grabar";
            this.Btn_Grabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Grabar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Capa_Vista_Compras.Properties.Resources.android_search_icon_icons_com_50501;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(12, 88);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 65);
            this.button2.TabIndex = 36;
            this.button2.Text = "Buscar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Capa_Vista_Compras.Properties.Resources.sign_emergency_code_sos_61_icon_icons_com_57216;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(547, 88);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 65);
            this.button3.TabIndex = 37;
            this.button3.Text = "Salir";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Imprimir.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Imprimir.Image = global::Capa_Vista_Compras.Properties.Resources.print_black_printer_tool_symbol_icon_icons_com_54467;
            this.Btn_Imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Imprimir.Location = new System.Drawing.Point(457, 88);
            this.Btn_Imprimir.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(86, 65);
            this.Btn_Imprimir.TabIndex = 38;
            this.Btn_Imprimir.Text = "Imprimir";
            this.Btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Image = global::Capa_Vista_Compras.Properties.Resources.compose_edit_modify_icon_177770;
            this.Btn_Editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Editar.Location = new System.Drawing.Point(254, 88);
            this.Btn_Editar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(99, 65);
            this.Btn_Editar.TabIndex = 41;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Image = global::Capa_Vista_Compras.Properties.Resources.help_question_16768;
            this.Btn_ayuda.Location = new System.Drawing.Point(799, 79);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(49, 44);
            this.Btn_ayuda.TabIndex = 42;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // Btn_Refrescar
            // 
            this.Btn_Refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Refrescar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Refrescar.Image = global::Capa_Vista_Compras.Properties.Resources.refresh_page_arrow_button_icon_icons_com_53909;
            this.Btn_Refrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refrescar.Location = new System.Drawing.Point(357, 88);
            this.Btn_Refrescar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Refrescar.Name = "Btn_Refrescar";
            this.Btn_Refrescar.Size = new System.Drawing.Size(96, 65);
            this.Btn_Refrescar.TabIndex = 43;
            this.Btn_Refrescar.Text = "Refrescar";
            this.Btn_Refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refrescar.UseVisualStyleBackColor = true;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.Location = new System.Drawing.Point(574, 44);
            this.Btn_Aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(75, 50);
            this.Btn_Aceptar.TabIndex = 33;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(574, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 33;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Frm_Compras_CXP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 647);
            this.Controls.Add(this.Btn_Refrescar);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Imprimir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_Grabar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgv_compras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Compras_CXP";
            this.Text = "Frm_Compras";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_compras)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.ComboBox Cbo_proveedor;
        private System.Windows.Forms.TextBox Txt_numero;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_estado;
        private System.Windows.Forms.TextBox Txt_saldo;
        private System.Windows.Forms.TextBox Txt_adelanto;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.TextBox Txt_orden;
        private System.Windows.Forms.DataGridView Dgv_compras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_compras;
        private System.Windows.Forms.Button Btn_Grabar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_Refrescar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Aceptar;
    }
}