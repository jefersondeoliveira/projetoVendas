using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using ProjetoVendas.Data;
using ProjetoVendas.Model;

namespace ProjetoVendas.View.Relatorios
{
    public partial class FormVendasReport : Form
    {
        VendaData vendaData;
        VendedorData vendedorData;
        VendasEntities db;

        public FormVendasReport()
        {
            InitializeComponent();
            db = new VendasEntities();
            vendaData = new VendaData(db);
            vendedorData = new VendedorData(db);
        }

        private void FormVendasReport_Load(object sender, EventArgs e)
        {
            var lista = from v in vendaData.todasVendas()
                        join vd in vendedorData.todosVendedors()
                            on v.IdVendedor equals vd.IdVendedor
                        select new
                        {
                            Vendedor = vd.NomeVendedor,
                            DataVenda = v.DataVenda,
                            QtdItemVenda = vendaData.qtdItemVenda(v.IdVenda).ToString()
                        };
            ReportDocument rpt = new ReportDocument();
            rpt.FileName = "Y:\\visual\\Prova 3\\ProjetoVendas\\ProjetoVendas\\View\\Relatorios\\VendasReport.rpt";
            rpt.SetDataSource(lista.ToList());
            rptVendas.ReportSource = rpt;
        }

        private void rptVendas_Load(object sender, EventArgs e)
        {

        }

    }
}
