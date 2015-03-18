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
    public partial class FormVendedor : Form
    {
        private Vendedor vendedor;
        private VendedorData vendedorData;

        public FormVendedor()
        {
            InitializeComponent();
            this.vendedorData = new VendedorData(new VendasEntities());
            limparFormulario();
            atualizarTabela(vendedorData.todosVendedors());
        }

        public void limparFormulario()
        {
            this.vendedor = new Vendedor();
            txtNome.Text = "";
            mtxtCPF.Text = "";
            dtpDataAdmissao.Value = DateTime.Now;
            txtFuncao.Text = "";
            rdoFem.Checked = false;
            rdoMasc.Checked = false;
            txtPesquisar.Text = "";
        }

        public void obterVendedor()
        {
            vendedor.NomeVendedor = txtNome.Text;
            vendedor.CPF = mtxtCPF.Text.Replace(",", "").Replace(".", "").Replace("-", "");
            vendedor.DataAdmissao = dtpDataAdmissao.Value.Date;
            vendedor.Funcao = txtFuncao.Text;
            vendedor.Sexo = rdoMasc.Checked ? "M" : "F";
        }

        public void atribuirVendedor(Vendedor v)
        {
            vendedor = v;
            txtNome.Text = vendedor.NomeVendedor;
            mtxtCPF.Text = vendedor.CPF;
            dtpDataAdmissao.Value = vendedor.DataAdmissao.Date;
            txtFuncao.Text = vendedor.Funcao;
            rdoMasc.Checked = vendedor.Sexo == "M" ? true : false;
            rdoFem.Checked = vendedor.Sexo == "F" ? true : false;
        }

        public void atualizarTabela(List<Vendedor> vendedores)
        {
            dgvVendedores.DataSource = vendedores;
            dgvVendedores.Columns[0].Visible = false;
            dgvVendedores.Columns[2].Visible = false;
            dgvVendedores.Columns[3].Visible = false;
            dgvVendedores.Columns[6].Visible = false;
            dgvVendedores.Columns[1].HeaderText = "Nome do Vendedor";
            dgvVendedores.Columns[4].HeaderText = "Data de Admissão";
            dgvVendedores.Columns[5].HeaderText = "Função";
            dgvVendedores.Columns[1].Width = 120;
            dgvVendedores.Columns[4].Width = 75;
            dgvVendedores.Columns[5].Width = 75;
        }

        public bool validar()
        {
            if (txtNome.Text == null || txtNome.Text == "")
            {
                MessageBox.Show("Digite um nome válido.");
                return false;
            }
            if (mtxtCPF.Text == null || mtxtCPF.Text == "" || mtxtCPF.Text.Replace(",", "").Replace(".", "").Replace("-", "").Length != 11)
            {
                MessageBox.Show("Digite um CPF válido.");
                return false;
            }
            if (dtpDataAdmissao.Value == null || dtpDataAdmissao.Value.Date < new DateTime(2005, 10, 01))
            {
                MessageBox.Show("Selecione uma data maior que a data de admissão (01/10/2005).");
                return false;
            }
            if (txtFuncao.Text == null || txtFuncao.Text == "")
            {
                MessageBox.Show("Digite uma função válido.");
                return false;
            }
            if (!rdoMasc.Checked && !rdoFem.Checked)
            {
                MessageBox.Show("Selecione um sexo.");
                return false;
            }
            return true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvVendedores.CurrentRow == null)
            {
                MessageBox.Show("Selecione um vendedor para editar!");
                return;
            }
            atribuirVendedor((Vendedor)dgvVendedores.CurrentRow.DataBoundItem);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvVendedores.CurrentRow == null)
            {
                MessageBox.Show("Selecione um vendedor para excluir!");
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string erro = vendedorData.excluirVendedor((Vendedor)dgvVendedores.CurrentRow.DataBoundItem);
                if (erro == null)
                {
                    MessageBox.Show("Excluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
                limparFormulario();
                atualizarTabela(vendedorData.todosVendedors());
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                obterVendedor();
                string erro = vendedorData.salvarVendedor(vendedor);
                if (erro == null)
                {
                    MessageBox.Show("Salvo com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
                limparFormulario();
                atualizarTabela(vendedorData.todosVendedors());
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            atualizarTabela(vendedorData.pesquisarVendedorPorNome(txtPesquisar.Text));
        }
    }
}
