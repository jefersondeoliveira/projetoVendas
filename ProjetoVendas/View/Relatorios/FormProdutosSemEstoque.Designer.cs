namespace ProjetoVendas.View.Relatorios
{
    partial class FormProdutosSemEstoque
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
            this.rptProdutos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptProdutos
            // 
            this.rptProdutos.ActiveViewIndex = -1;
            this.rptProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptProdutos.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptProdutos.Location = new System.Drawing.Point(0, 0);
            this.rptProdutos.Name = "rptProdutos";
            this.rptProdutos.Size = new System.Drawing.Size(651, 383);
            this.rptProdutos.TabIndex = 0;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 383);
            this.Controls.Add(this.rptProdutos);
            this.Name = "FormProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptProdutos;
    }
}