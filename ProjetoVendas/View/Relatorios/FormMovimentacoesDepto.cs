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
    public partial class FormMovimentacoesDepto : Form
    {

        private DepartamentoData departamentoData;

        public FormMovimentacoesDepto()
        {
            InitializeComponent();
            departamentoData = new DepartamentoData(new VendasEntities());
        }

        private void FormMovimentacoesDepto_Load(object sender, EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();
            rpt.FileName = "D:\\DSIA\\ProjetoVendas\\ProjetoVendas\\View\\Relatorios\\DeptoReport.rpt";
            var lista = from d in departamentoData.todosDepartamentos()
                        select new
                        {
                            Departamento = d.Descricao,
                            Quantidade = departamentoData.quantidadeVendidaPorDepto(d.IdDepartamento)
                        };
            rpt.SetDataSource(lista.ToList());
            rptMovimentacoes.ReportSource = rpt;
        }
    }
}
