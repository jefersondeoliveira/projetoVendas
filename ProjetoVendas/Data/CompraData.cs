using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using ProjetoVendas.Model;

namespace ProjetoVendas.Data
{
    class CompraData
    {

        private VendasEntities db;
        private ObjectSet<Compra> compras;

        public CompraData(VendasEntities db)
        {
            this.db = db;
            this.compras = db.CreateObjectSet<Compra>();
        }

        public List<Compra> todasCompras()
        {
            return compras.ToList();
        }

        public string salvarCompra(Compra compra)
        {
            string erro = null;
            try
            {
                if (compra.IdCompra == 0)
                {
                    compras.AddObject(compra);
                }
                else
                {
                    if (compra.EntityState == System.Data.EntityState.Detached)
                    {
                        compras.Attach(compra);
                    }
                    db.ObjectStateManager.ChangeObjectState(compra, System.Data.EntityState.Modified);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirCompra(Compra compra)
        {
            string erro = null;
            try
            {
                compras.DeleteObject(compra);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public float totalCompra(int idCompra)
        {
            ObjectSet<ItemCompra> itens = db.CreateObjectSet<ItemCompra>();
            ObjectSet<Produto> produtos = db.CreateObjectSet<Produto>();

            var lista = from i in itens.ToList()
                        join p in produtos.ToList()
                            on i.IdProduto equals p.IdProduto
                        select i.Quantidade * p.ValorVenda;

            return (float)lista.ToList().Sum();
        }


    }
}
