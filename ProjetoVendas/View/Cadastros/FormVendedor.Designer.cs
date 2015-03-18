namespace ProjetoVendas.View.Cadastros
{
    partial class FormVendedor
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
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dtpDataAdmissao = new System.Windows.Forms.DateTimePicker();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rdoMasc = new System.Windows.Forms.RadioButton();
            this.rdoFem = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            this.grpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(12, 90);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(96, 13);
            this.lblDataNasc.TabIndex = 32;
            this.lblDataNasc.Text = "Data de Admissão:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(10, 38);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 31;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 30;
            this.lblNome.Text = "Nome:";
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(10, 325);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisa.TabIndex = 29;
            this.lblPesquisa.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(81, 322);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(247, 20);
            this.txtPesquisar.TabIndex = 28;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // dtpDataAdmissao
            // 
            this.dtpDataAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAdmissao.Location = new System.Drawing.Point(123, 83);
            this.dtpDataAdmissao.Name = "dtpDataAdmissao";
            this.dtpDataAdmissao.Size = new System.Drawing.Size(205, 20);
            this.dtpDataAdmissao.TabIndex = 27;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(51, 35);
            this.mtxtCPF.Mask = "000,000,000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(148, 20);
            this.mtxtCPF.TabIndex = 26;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(51, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(277, 20);
            this.txtNome.TabIndex = 25;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(253, 351);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(172, 351);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(91, 351);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(10, 351);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AllowUserToAddRows = false;
            this.dgvVendedores.AllowUserToDeleteRows = false;
            this.dgvVendedores.AllowUserToResizeColumns = false;
            this.dgvVendedores.AllowUserToResizeRows = false;
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedores.Location = new System.Drawing.Point(10, 116);
            this.dgvVendedores.MultiSelect = false;
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.ReadOnly = true;
            this.dgvVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendedores.Size = new System.Drawing.Size(318, 200);
            this.dgvVendedores.TabIndex = 20;
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Location = new System.Drawing.Point(10, 61);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(43, 13);
            this.lblFuncao.TabIndex = 34;
            this.lblFuncao.Text = "Função";
            // 
            // txtFuncao
            // 
            this.txtFuncao.Location = new System.Drawing.Point(59, 58);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(140, 20);
            this.txtFuncao.TabIndex = 33;
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rdoFem);
            this.grpSexo.Controls.Add(this.rdoMasc);
            this.grpSexo.Location = new System.Drawing.Point(205, 35);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(123, 43);
            this.grpSexo.TabIndex = 35;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo:";
            // 
            // rdoMasc
            // 
            this.rdoMasc.AutoSize = true;
            this.rdoMasc.Location = new System.Drawing.Point(6, 19);
            this.rdoMasc.Name = "rdoMasc";
            this.rdoMasc.Size = new System.Drawing.Size(54, 17);
            this.rdoMasc.TabIndex = 0;
            this.rdoMasc.TabStop = true;
            this.rdoMasc.Text = "Masc.";
            this.rdoMasc.UseVisualStyleBackColor = true;
            // 
            // rdoFem
            // 
            this.rdoFem.AutoSize = true;
            this.rdoFem.Location = new System.Drawing.Point(66, 19);
            this.rdoFem.Name = "rdoFem";
            this.rdoFem.Size = new System.Drawing.Size(56, 17);
            this.rdoFem.TabIndex = 1;
            this.rdoFem.TabStop = true;
            this.rdoFem.Text = "Femin.";
            this.rdoFem.UseVisualStyleBackColor = true;
            // 
            // FormVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 381);
            this.Controls.Add(this.grpSexo);
            this.Controls.Add(this.lblFuncao);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dtpDataAdmissao);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvVendedores);
            this.Name = "FormVendedor";
            this.Text = "Cadastro de Vendedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DateTimePicker dtpDataAdmissao;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgvVendedores;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rdoFem;
        private System.Windows.Forms.RadioButton rdoMasc;
    }
}