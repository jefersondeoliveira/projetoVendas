using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoVendas.Data;
using ProjetoVendas.Model;

namespace ProjetoVendas.View.Cadastros
{
    public partial class FormProdutos : Form
    {
        private Produto produto;
        private ProdutoData produtoData;
        private DepartamentoData departamentoData;

        public FormProdutos()
        {
            InitializeComponent();
            this.produtoData = new ProdutoData(new VendasEntities());
            this.departamentoData = new DepartamentoData(new VendasEntities());
            limparFormulario();
            atualizarTabela(produtoData.todosProdutos());
            aplicarEventos(txtCompra);
            aplicarEventos(txtVenda);
        }

        public void limparFormulario()
        {
            this.produto = new Produto();
            txtDescricao.Text = "";
            txtCompra.Text = "";
            txtVenda.Text = "";
            cbxDepto.DataSource = departamentoData.todosDepartamentos();
            cbxDepto.DisplayMember = "Descricao";
            cbxDepto.ValueMember = "IdDepartamento";
            cbxDepto.SelectedIndex = -1;
            txtPesquisar.Text = "";
        }

        public void obterProduto()
        {
            produto.Descricao = txtDescricao.Text;
            produto.ValorCompra = (float) Convert.ToDouble(txtCompra.Text.Replace("R$", "").Trim());
            produto.ValorVenda = (float) Convert.ToDouble(txtVenda.Text.Replace("R$", "").Trim());
            produto.IdDepartamento = (int) cbxDepto.SelectedValue;
        }

        public void atribuirProduto(Produto p)
        {
            produto = p;
            txtDescricao.Text = produto.Descricao;
            txtCompra.Text = produto.ValorCompra.ToString("C2");
            txtVenda.Text = produto.ValorVenda.ToString("C2");
            cbxDepto.SelectedValue = produto.IdDepartamento;
        }

        public void atualizarTabela(List<Produto> produtos)
        {
            var lista = from p in produtos
                        join d in departamentoData.todosDepartamentos()
                            on p.IdDepartamento equals d.IdDepartamento
                        select new
                        {
                            Produto = p,
                            Descricao = p.Descricao,
                            ValorCompra = p.ValorCompra.ToString("C2"),
                            ValorVenda = p.ValorVenda.ToString("C2"),
                            Departamento = d.Descricao
                        };
            dgvProdutos.DataSource = lista.ToList();
            dgvProdutos.Columns[0].Visible = false;
            dgvProdutos.Columns[1].HeaderText = "Produto";
            dgvProdutos.Columns[2].HeaderText = "R$ Compra";
            dgvProdutos.Columns[3].HeaderText = "R$ Venda";
            dgvProdutos.Columns[4].HeaderText = "Depto.";
            dgvProdutos.Columns[1].Width = 80;
            dgvProdutos.Columns[2].Width = 50;
            dgvProdutos.Columns[3].Width = 50;
            dgvProdutos.Columns[4].Width = 70;
        }

        public bool validar()
        {
            if (txtDescricao.Text == null || txtDescricao.Text == "")
            {
                MessageBox.Show("Digite uma descrição válido.");
                return false;
            }
            if (cbxDepto.SelectedValue == null || (int) cbxDepto.SelectedValue == 0)
            {
                MessageBox.Show("Selecione um departamento.");
                return false;
            }
            try
            {
                double valor = Convert.ToDouble(txtCompra.Text.Replace("R$", "").Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valor de compra não é um número válido.");
                return false;
            }
            try
            {
                double valor = Convert.ToDouble(txtVenda.Text.Replace("R$", "").Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valor de venda não é um número válido.");
                return false;
            }
            return true;
        }

        private void retornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = double.Parse(txt.Text).ToString("C2");
        }

        private void tirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }

        private void apenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }

        private void aplicarEventos(TextBox txt)
        {
            txt.Enter += tirarMascara;
            txt.Leave += retornarMascara;
            txt.KeyPress += apenasValorNumerico;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            atualizarTabela(produtoData.pesquisarProdutoPorDescricao(txtPesquisar.Text));
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto para editar!");
                return;
            }
            atribuirProduto((Produto)dgvProdutos.CurrentRow.Cells[0].Value);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto para excluir!");
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string erro = produtoData.excluirProduto((Produto)dgvProdutos.CurrentRow.Cells[0].Value);
                if (erro == null)
                {
                    MessageBox.Show("Excluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
                limparFormulario();
                atualizarTabela(produtoData.todosProdutos());
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                obterProduto();
                string erro = produtoData.salvarProduto(produto);
                if (erro == null)
                {
                    MessageBox.Show("Salvo com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
                limparFormulario();
                atualizarTabela(produtoData.todosProdutos());
            }
        }


    }
}
