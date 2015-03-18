namespace ProjetoVendas.View.Relatorios
{
    partial class FormVendasReport
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
            this.rptVendas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptVendas
            // 
            this.rptVendas.ActiveViewIndex = -1;
            this.rptVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptVendas.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptVendas.Location = new System.Drawing.Point(0, 0);
            this.rptVendas.Name = "rptVendas";
            this.rptVendas.Size = new System.Drawing.Size(603, 468);
            this.rptVendas.TabIndex = 0;
            this.rptVendas.Load += new System.EventHandler(this.rptVendas_Load);
            // 
            // FormVendasReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 468);
            this.Controls.Add(this.rptVendas);
            this.Name = "FormVendasReport";
            this.Text = "Relatorio de Vendas";
            this.Load += new System.EventHandler(this.FormVendasReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptVendas;
    }
}