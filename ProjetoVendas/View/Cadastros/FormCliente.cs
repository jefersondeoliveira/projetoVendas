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
    public partial class FormCliente : Form
    {
        private Cliente cliente;
        private ClienteData clienteData;

        public FormCliente()
        {
            InitializeComponent();
            this.clienteData = new ClienteData(new VendasEntities());
            limparFormulario();
            atualizarTabela(clienteData.todosClientes());
        }

        public void limparFormulario()
        {
            this.cliente = new Cliente();
            txtNome.Text = "";
            mtxtCPF.Text = "";
            dtpDataNasc.Value = DateTime.Now;
            txtPesquisar.Text = "";
        }

        public void obterCliente()
        {
            cliente.Nome = txtNome.Text;
            cliente.CPF = mtxtCPF.Text.Replace(",", "").Replace(".", "").Replace("-", "");
            cliente.DataNascimento = dtpDataNasc.Value.Date;
        }

        public void atribuirCliente(Cliente c)
        {
            cliente = c;
            txtNome.Text = cliente.Nome;
            mtxtCPF.Text = cliente.CPF;
            dtpDataNasc.Value = cliente.DataNascimento.Date;
        }

        public void atualizarTabela(List<Cliente> clientes)
        {
            dgvClientes.DataSource = clientes;
            dgvClientes.Columns[0].Visible = false;
            dgvClientes.Columns[4].Visible = false;
            dgvClientes.Columns[1].HeaderText = "Nome do Cliente";
            dgvClientes.Columns[3].HeaderText = "Data de Nascimento";
            dgvClientes.Columns[1].Width = 120;
            dgvClientes.Columns[2].Width = 75;
            dgvClientes.Columns[3].Width = 75;
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
            if (dtpDataNasc.Value == null || dtpDataNasc.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Selecione uma data válida.");
                return false;
            }
            return true;
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            atualizarTabela(clienteData.pesquisarClientePorNome(txtPesquisar.Text));
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente para editar!");
                return;
            }
            atribuirCliente((Cliente)dgvClientes.CurrentRow.DataBoundItem);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente para excluir!");
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string erro = clienteData.excluirCliente((Cliente)dgvClientes.CurrentRow.DataBoundItem);
                if (erro == null)
                {
                    MessageBox.Show("Excluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
                limparFormulario();
                atualizarTabela(clienteData.todosClientes());
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                obterCliente();
                string erro = clienteData.salvarCliente(cliente);
                if (erro == null)
                {
                    MessageBox.Show("Salvo com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
                limparFormulario();
                atualizarTabela(clienteData.todosClientes());
            }
        }


    }
}
