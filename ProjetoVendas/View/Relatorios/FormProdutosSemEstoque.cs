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
    public partial class FormProdutosSemEstoque : Form
    {
        private ProdutoData produtoData;
        private MovimentacaoData movimentacaoData;

        public FormProdutosSemEstoque()
        {
            InitializeComponent();
            produtoData = new ProdutoData(new VendasEntities());
            movimentacaoData = new MovimentacaoData(new VendasEntities());
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            var lista = from p in produtoData.todosProdutos()
                        where movimentacaoData.estoqueProduto(p.IdProduto) <= 0
                        select new
                        {
                            Descricao = p.Descricao,
                            ValorCompra = p.ValorCompra,
                            ValorVenda = p.ValorVenda
                        };
            ReportDocument rpt = new ReportDocument();
            rpt.FileName = "Y:\\Joao\\DIURNO Projeto Vendas 061114\\ProjetoVendas\\ProjetoVendas\\View\\Relatorios\\ProdutosReport.rpt";
            rpt.SetDataSource(lista.ToList());
            rptProdutos.ReportSource = rpt;
        }
    }
}
