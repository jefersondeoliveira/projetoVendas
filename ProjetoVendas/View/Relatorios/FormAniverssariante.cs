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
using CrystalDecisions.CrystalReports.Engine;

namespace ProjetoVendas.View.Relatorios
{
    public partial class FormAniverssariante : Form
    {
        ClienteData clienteData;

        public FormAniverssariante()
        {
            InitializeComponent();
            clienteData = new ClienteData(new VendasEntities());
        }

        private void FormAniverssariante_Load(object sender, EventArgs e)
        {
            var lista = from c in clienteData.todosClientes()
                        where c.DataNascimento.Month == DateTime.Now.Month
                        select new
                        {
                            Nome = c.Nome,
                            DataNascimento = c.DataNascimento,
                            Idade = clienteData.calcularIdade(c.DataNascimento)
                        };
            ReportDocument rpt = new ReportDocument();
            rpt.FileName = "Y:\\Joao\\DIURNO Projeto Vendas 061114\\ProjetoVendas\\ProjetoVendas\\View\\Relatorios\\AniverssariantesReport.rpt";
            rpt.SetDataSource(lista.ToList());
            rptAniverssariantes.ReportSource = rpt;
        }
    }
}
