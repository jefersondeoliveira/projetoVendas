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

namespace ProjetoVendas.View.Movimentacoes
{
    public partial class FormVendas : Form
    {
        private Venda venda;
        private ClienteData clienteData;
        private VendedorData vendedorData;
        private VendaData vendaData;

        public FormVendas()
        {
            InitializeComponent();
            clienteData = new ClienteData(new VendasEntities());
            vendedorData = new VendedorData(new VendasEntities());
            vendaData = new VendaData(new VendasEntities());
            atualizarTabelaVendas();
            tabVenda.Enabled = false;
        }

        public void atualizarTabelaVendas()
        {
            var lista = from v in vendaData.todasVendas()
                        join c in clienteData.todosClientes()
                            on v.IdCliente equals c.IdCliente
                        join vd in vendedorData.todosVendedors()
                            on v.IdVendedor equals vd.IdVendedor
                        select new
                        {
                            Venda = v,
                            Cliente = c.Nome,
                            Vendedor = vd.NomeVendedor,
                            TotalVenda = vendaData.totalVenda(v.IdVenda).ToString("C2")
                        };
            dgvVendas.DataSource = lista.ToList();
            dgvVendas.Columns[0].Visible = false;
            dgvVendas.Columns[1].Width = 125;
            dgvVendas.Columns[2].Width = 125;
            dgvVendas.Columns[3].HeaderText = "Total da Venda";
        }

        private void tabPrincipal_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !e.TabPage.Enabled;
        }

        /*public void limparFormulario()
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
        }*/
    }
}
