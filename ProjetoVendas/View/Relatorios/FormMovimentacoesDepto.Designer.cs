namespace ProjetoVendas.View.Relatorios
{
    partial class FormMovimentacoesDepto
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
            this.rptMovimentacoes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptMovimentacoes
            // 
            this.rptMovimentacoes.ActiveViewIndex = -1;
            this.rptMovimentacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptMovimentacoes.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptMovimentacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptMovimentacoes.Location = new System.Drawing.Point(0, 0);
            this.rptMovimentacoes.Name = "rptMovimentacoes";
            this.rptMovimentacoes.Size = new System.Drawing.Size(686, 432);
            this.rptMovimentacoes.TabIndex = 0;
            // 
            // FormMovimentacoesDepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 432);
            this.Controls.Add(this.rptMovimentacoes);
            this.Name = "FormMovimentacoesDepto";
            this.Text = "Movimentações por Departamento";
            this.Load += new System.EventHandler(this.FormMovimentacoesDepto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptMovimentacoes;
    }
}