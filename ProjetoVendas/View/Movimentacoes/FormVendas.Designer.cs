namespace ProjetoVendas.View.Movimentacoes
{
    partial class FormVendas
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
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabListagem = new System.Windows.Forms.TabPage();
            this.tabVenda = new System.Windows.Forms.TabPage();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tabPrincipal.SuspendLayout();
            this.tabListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabListagem);
            this.tabPrincipal.Controls.Add(this.tabVenda);
            this.tabPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(415, 294);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabPrincipal_Selecting);
            // 
            // tabListagem
            // 
            this.tabListagem.Controls.Add(this.btnNovo);
            this.tabListagem.Controls.Add(this.btnEditar);
            this.tabListagem.Controls.Add(this.dgvVendas);
            this.tabListagem.Location = new System.Drawing.Point(4, 22);
            this.tabListagem.Name = "tabListagem";
            this.tabListagem.Padding = new System.Windows.Forms.Padding(3);
            this.tabListagem.Size = new System.Drawing.Size(407, 268);
            this.tabListagem.TabIndex = 0;
            this.tabListagem.Text = "Lista";
            this.tabListagem.UseVisualStyleBackColor = true;
            // 
            // tabVenda
            // 
            this.tabVenda.Location = new System.Drawing.Point(4, 22);
            this.tabVenda.Name = "tabVenda";
            this.tabVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabVenda.Size = new System.Drawing.Size(407, 268);
            this.tabVenda.TabIndex = 1;
            this.tabVenda.Text = "Venda";
            this.tabVenda.UseVisualStyleBackColor = true;
            // 
            // dgvVendas
            // 
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(6, 6);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.Size = new System.Drawing.Size(398, 222);
            this.dgvVendas.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(311, 239);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar Venda";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(216, 239);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(89, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Nova Venda";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 318);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "FormVendas";
            this.Text = "Formulário de Vendas";
            this.tabPrincipal.ResumeLayout(false);
            this.tabListagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabListagem;
        private System.Windows.Forms.TabPage tabVenda;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvVendas;
    }
}