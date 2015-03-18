namespace ProjetoVendas.View.Relatorios
{
    partial class FormAniverssariante
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
            this.rptAniverssariantes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptAniverssariantes
            // 
            this.rptAniverssariantes.ActiveViewIndex = -1;
            this.rptAniverssariantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptAniverssariantes.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptAniverssariantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptAniverssariantes.Location = new System.Drawing.Point(0, 0);
            this.rptAniverssariantes.Name = "rptAniverssariantes";
            this.rptAniverssariantes.Size = new System.Drawing.Size(700, 451);
            this.rptAniverssariantes.TabIndex = 0;
            // 
            // FormAniverssariante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 451);
            this.Controls.Add(this.rptAniverssariantes);
            this.Name = "FormAniverssariante";
            this.Text = "FormAniverssariante";
            this.Load += new System.EventHandler(this.FormAniverssariante_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptAniverssariantes;
    }
}