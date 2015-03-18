using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using ProjetoVendas.Model;

namespace ProjetoVendas.Data
{
    class VendaData
    {

        private VendasEntities db;
        private ObjectSet<Venda> vendas;

        public VendaData(VendasEntities db)
        {
            this.db = db;
            this.vendas = db.CreateObjectSet<Venda>();
        }

        public List<Venda> todasVendas()
        {
            return vendas.ToList();
        }

        public string salvarVenda(Venda venda)
        {
            string erro = null;
            try
            {
                if (venda.IdVenda == 0)
                {
                    vendas.AddObject(venda);
                }
                else
                {
                    if (venda.EntityState == System.Data.EntityState.Detached)
                    {
                        vendas.Attach(venda);
                    }
                    db.ObjectStateManager.ChangeObjectState(venda, System.Data.EntityState.Modified);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirVenda(Venda venda)
        {
            string erro = null;
            try
            {
                vendas.DeleteObject(venda);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public float totalVenda(int idVenda)
        {
            ObjectSet<ItemVenda> itens = db.CreateObjectSet<ItemVenda>();
            ObjectSet<Produto> produtos = db.CreateObjectSet<Produto>();

            var lista = from i in itens.ToList()
                        join p in produtos.ToList()
                            on i.IdProduto equals p.IdProduto
                        where i.IdVenda == idVenda
                        select i.Quantidade * p.ValorVenda;

            return (float)lista.ToList().Sum();
        }

        public int qtdItemVenda(int idVenda)
        {
            ObjectSet<ItemVenda> itens = db.CreateObjectSet<ItemVenda>();

            var lista = from i in itens.ToList()
                        where i.IdVenda.Equals(idVenda)
                        select i.Quantidade;

            return (int) lista.ToList().Sum();
        }

    }
}
