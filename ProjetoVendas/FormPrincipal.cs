using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoVendas.View.Cadastros;
using ProjetoVendas.View.Movimentacoes;
using ProjetoVendas.View.Relatorios;

namespace ProjetoVendas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormDepartamento().ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCliente().ShowDialog();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormVendedor().ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProdutos().ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormVendas().ShowDialog();
        }

        private void movimPorDeptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormMovimentacoesDepto().ShowDialog();
        }

        private void aniversariantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAniverssariante().ShowDialog();
        }

        private void produtosSemEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProdutosSemEstoque().ShowDialog();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormVendasReport().ShowDialog();
        }

    }
}
