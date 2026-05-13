
namespace Capa_Vista_Ventas
{
    partial class Frm_BalanceAntiguedad
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel_Filtro         = new System.Windows.Forms.Panel();
            this.lbl_FechaDesde       = new System.Windows.Forms.Label();
            this.dtp_FechaDesde       = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaHasta       = new System.Windows.Forms.Label();
            this.dtp_FechaHasta       = new System.Windows.Forms.DateTimePicker();
            this.btn_Generar          = new System.Windows.Forms.Button();
            this.btn_Cerrar           = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel_Filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Filtro
            // 
            this.panel_Filtro.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Filtro.Controls.Add(this.btn_Cerrar);
            this.panel_Filtro.Controls.Add(this.btn_Generar);
            this.panel_Filtro.Controls.Add(this.dtp_FechaHasta);
            this.panel_Filtro.Controls.Add(this.lbl_FechaHasta);
            this.panel_Filtro.Controls.Add(this.dtp_FechaDesde);
            this.panel_Filtro.Controls.Add(this.lbl_FechaDesde);
            this.panel_Filtro.Dock     = System.Windows.Forms.DockStyle.Top;
            this.panel_Filtro.Location = new System.Drawing.Point(0, 0);
            this.panel_Filtro.Name     = "panel_Filtro";
            this.panel_Filtro.Size     = new System.Drawing.Size(1100, 52);
            this.panel_Filtro.TabIndex = 0;
            // 
            // lbl_FechaDesde
            // 
            this.lbl_FechaDesde.AutoSize = true;
            this.lbl_FechaDesde.Font     = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_FechaDesde.Location = new System.Drawing.Point(12, 17);
            this.lbl_FechaDesde.Name     = "lbl_FechaDesde";
            this.lbl_FechaDesde.Size     = new System.Drawing.Size(79, 15);
            this.lbl_FechaDesde.TabIndex = 0;
            this.lbl_FechaDesde.Text     = "Fecha Desde:";
            // 
            // dtp_FechaDesde
            // 
            this.dtp_FechaDesde.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaDesde.Location = new System.Drawing.Point(100, 14);
            this.dtp_FechaDesde.Name     = "dtp_FechaDesde";
            this.dtp_FechaDesde.Size     = new System.Drawing.Size(130, 22);
            this.dtp_FechaDesde.TabIndex = 1;
            // 
            // lbl_FechaHasta
            // 
            this.lbl_FechaHasta.AutoSize = true;
            this.lbl_FechaHasta.Font     = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_FechaHasta.Location = new System.Drawing.Point(250, 17);
            this.lbl_FechaHasta.Name     = "lbl_FechaHasta";
            this.lbl_FechaHasta.Size     = new System.Drawing.Size(73, 15);
            this.lbl_FechaHasta.TabIndex = 2;
            this.lbl_FechaHasta.Text     = "Fecha Hasta:";
            // 
            // dtp_FechaHasta
            // 
            this.dtp_FechaHasta.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaHasta.Location = new System.Drawing.Point(332, 14);
            this.dtp_FechaHasta.Name     = "dtp_FechaHasta";
            this.dtp_FechaHasta.Size     = new System.Drawing.Size(130, 22);
            this.dtp_FechaHasta.TabIndex = 3;
            // 
            // btn_Generar
            // 
            this.btn_Generar.BackColor        = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btn_Generar.FlatStyle        = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Generar.Font             = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Generar.ForeColor        = System.Drawing.Color.White;
            this.btn_Generar.Location         = new System.Drawing.Point(484, 12);
            this.btn_Generar.Name             = "btn_Generar";
            this.btn_Generar.Size             = new System.Drawing.Size(150, 28);
            this.btn_Generar.TabIndex         = 4;
            this.btn_Generar.Text             = "Generar Reporte";
            this.btn_Generar.UseVisualStyleBackColor = false;
            this.btn_Generar.Click           += new System.EventHandler(this.btn_Generar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor        = System.Drawing.Color.FromArgb(192, 0, 0);
            this.btn_Cerrar.FlatStyle        = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Font             = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Cerrar.ForeColor        = System.Drawing.Color.White;
            this.btn_Cerrar.Location         = new System.Drawing.Point(648, 12);
            this.btn_Cerrar.Name             = "btn_Cerrar";
            this.btn_Cerrar.Size             = new System.Drawing.Size(90, 28);
            this.btn_Cerrar.TabIndex         = 5;
            this.btn_Cerrar.Text             = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click           += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Dock            = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location        = new System.Drawing.Point(0, 52);
            this.crystalReportViewer1.Name            = "crystalReportViewer1";
            this.crystalReportViewer1.Size            = new System.Drawing.Size(1100, 598);
            this.crystalReportViewer1.TabIndex        = 6;
            // 
            // Frm_BalanceAntiguedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel_Filtro);
            this.Name                = "Frm_BalanceAntiguedad";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "Balance de Antigüedad de Saldo - Cuentas por Cobrar";
            this.panel_Filtro.ResumeLayout(false);
            this.panel_Filtro.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel                          panel_Filtro;
        private System.Windows.Forms.Label                          lbl_FechaDesde;
        private System.Windows.Forms.DateTimePicker                 dtp_FechaDesde;
        private System.Windows.Forms.Label                          lbl_FechaHasta;
        private System.Windows.Forms.DateTimePicker                 dtp_FechaHasta;
        private System.Windows.Forms.Button                         btn_Generar;
        private System.Windows.Forms.Button                         btn_Cerrar;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer  crystalReportViewer1;
    }
}
