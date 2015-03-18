namespace ProjetoVendas
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aniversariantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosSemEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimPorDeptoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgVendas = new System.Windows.Forms.PictureBox();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentoToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.vendedorToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            this.departamentoToolStripMenuItem.Click += new System.EventHandler(this.departamentoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            this.vendedorToolStripMenuItem.Click += new System.EventHandler(this.vendedorToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aniversariantesToolStripMenuItem,
            this.produtosSemEstoqueToolStripMenuItem,
            this.movimPorDeptoToolStripMenuItem,
            this.vendasToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // aniversariantesToolStripMenuItem
            // 
            this.aniversariantesToolStripMenuItem.Name = "aniversariantesToolStripMenuItem";
            this.aniversariantesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.aniversariantesToolStripMenuItem.Text = "Aniversariantes";
            this.aniversariantesToolStripMenuItem.Click += new System.EventHandler(this.aniversariantesToolStripMenuItem_Click);
            // 
            // produtosSemEstoqueToolStripMenuItem
            // 
            this.produtosSemEstoqueToolStripMenuItem.Name = "produtosSemEstoqueToolStripMenuItem";
            this.produtosSemEstoqueToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.produtosSemEstoqueToolStripMenuItem.Text = "Produtos sem Estoque";
            this.produtosSemEstoqueToolStripMenuItem.Click += new System.EventHandler(this.produtosSemEstoqueToolStripMenuItem_Click);
            // 
            // movimPorDeptoToolStripMenuItem
            // 
            this.movimPorDeptoToolStripMenuItem.Name = "movimPorDeptoToolStripMenuItem";
            this.movimPorDeptoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.movimPorDeptoToolStripMenuItem.Text = "Movim. por Depto.";
            this.movimPorDeptoToolStripMenuItem.Click += new System.EventHandler(this.movimPorDeptoToolStripMenuItem_Click);
            // 
            // imgVendas
            // 
            this.imgVendas.Image = global::ProjetoVendas.Properties.Resources.vendas;
            this.imgVendas.Location = new System.Drawing.Point(0, 27);
            this.imgVendas.Name = "imgVendas";
            this.imgVendas.Size = new System.Drawing.Size(292, 248);
            this.imgVendas.TabIndex = 1;
            this.imgVendas.TabStop = false;
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            this.vendasToolStripMenuItem1.Click += new System.EventHandler(this.vendasToolStripMenuItem1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.imgVendas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Controle de Vendas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgVendas;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aniversariantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosSemEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimPorDeptoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
    }
}

