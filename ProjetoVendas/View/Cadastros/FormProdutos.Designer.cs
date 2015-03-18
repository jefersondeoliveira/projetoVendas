namespace ProjetoVendas.View.Cadastros
{
    partial class FormProdutos
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
            this.lblCompra = new System.Windows.Forms.Label();
            this.lblDepto = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.lblVenda = new System.Windows.Forms.Label();
            this.grpValores = new System.Windows.Forms.GroupBox();
            this.cbxDepto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grpValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(7, 22);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(46, 13);
            this.lblCompra.TabIndex = 30;
            this.lblCompra.Text = "Compra:";
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Location = new System.Drawing.Point(12, 40);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(77, 13);
            this.lblDepto.TabIndex = 29;
            this.lblDepto.Text = "Departamento:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(10, 13);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 28;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(10, 327);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisa.TabIndex = 27;
            this.lblPesquisa.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(81, 324);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(247, 20);
            this.txtPesquisar.TabIndex = 26;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(74, 10);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(254, 20);
            this.txtDescricao.TabIndex = 25;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(253, 353);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(172, 353);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(91, 353);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(10, 353);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(10, 118);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(318, 200);
            this.dgvProdutos.TabIndex = 20;
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(53, 19);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(100, 20);
            this.txtCompra.TabIndex = 31;
            // 
            // txtVenda
            // 
            this.txtVenda.Location = new System.Drawing.Point(209, 19);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(100, 20);
            this.txtVenda.TabIndex = 33;
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Location = new System.Drawing.Point(159, 22);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(41, 13);
            this.lblVenda.TabIndex = 32;
            this.lblVenda.Text = "Venda:";
            // 
            // grpValores
            // 
            this.grpValores.Controls.Add(this.txtCompra);
            this.grpValores.Controls.Add(this.txtVenda);
            this.grpValores.Controls.Add(this.lblVenda);
            this.grpValores.Controls.Add(this.lblCompra);
            this.grpValores.Location = new System.Drawing.Point(13, 65);
            this.grpValores.Name = "grpValores";
            this.grpValores.Size = new System.Drawing.Size(315, 47);
            this.grpValores.TabIndex = 34;
            this.grpValores.TabStop = false;
            this.grpValores.Text = "Valores";
            // 
            // cbxDepto
            // 
            this.cbxDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDepto.FormattingEnabled = true;
            this.cbxDepto.Location = new System.Drawing.Point(95, 37);
            this.cbxDepto.Name = "cbxDepto";
            this.cbxDepto.Size = new System.Drawing.Size(233, 21);
            this.cbxDepto.TabIndex = 35;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 386);
            this.Controls.Add(this.cbxDepto);
            this.Controls.Add(this.grpValores);
            this.Controls.Add(this.lblDepto);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "FormProdutos";
            this.Text = "Formulário de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grpValores.ResumeLayout(false);
            this.grpValores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.GroupBox grpValores;
        private System.Windows.Forms.ComboBox cbxDepto;

    }
}