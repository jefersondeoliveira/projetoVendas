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
    public partial class FormDepartamento : Form
    {
        private Departamento departamento;
        private DepartamentoData departamentoData;

        public FormDepartamento()
        {
            InitializeComponent();
            this.departamentoData = new DepartamentoData(new VendasEntities());
            limparFormulario();
            atualizarTabela();
        }

        public void limparFormulario()
        {
            this.departamento = new Departamento();
            txtDescricao.Text = "";
        }

        public void obterDepartamento()
        {
            departamento.Descricao = txtDescricao.Text;
        }

        public void atribuirDepartamento(Departamento d)
        {
            departamento = d;
            txtDescricao.Text = d.Descricao;
        }

        public void atualizarTabela() 
        {
            dgvDepartamentos.DataSource = departamentoData.todosDepartamentos();
            dgvDepartamentos.Columns[0].Visible = false;
            dgvDepartamentos.Columns[2].Visible = false;
            dgvDepartamentos.Columns[1].HeaderText = "Departamento";
            dgvDepartamentos.Columns[1].Width = 270;
        }

        public bool validar()
        {
            if (txtDescricao.Text == null || txtDescricao.Text == "")
            {
                MessageBox.Show("Digite uma descrição válida.");
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
            if (dgvDepartamentos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um departamento para editar!");
                return;
            }
            atribuirDepartamento((Departamento)dgvDepartamentos.CurrentRow.DataBoundItem);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvDepartamentos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um departamento para excluir!");
                return;
            }
            if (MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string erro = departamentoData.excluirDepartamento((Departamento)dgvDepartamentos.CurrentRow.DataBoundItem);
                if (erro == null) 
                {
                    MessageBox.Show("Excluído com sucesso!");
                } 
                else 
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
                limparFormulario();
                atualizarTabela();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                obterDepartamento();
                string erro = departamentoData.salvarDepartamento(departamento);
                if (erro == null)
                {
                    MessageBox.Show("Salvo com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro: " + erro);
                }
                limparFormulario();
                atualizarTabela();
            }
        }
        
    }
}
