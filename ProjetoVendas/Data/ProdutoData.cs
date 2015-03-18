using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using ProjetoVendas.Model;

namespace ProjetoVendas.Data
{
    class ProdutoData
    {

        private VendasEntities db;
        private ObjectSet<Produto> produtos;

        public ProdutoData(VendasEntities db)
        {
            this.db = db;
            this.produtos = db.CreateObjectSet<Produto>();
        }

        public List<Produto> todosProdutos()
        {
            return produtos.ToList();
        }

        public string salvarProduto(Produto produto)
        {
            string erro = null;
            try
            {
                if (produto.IdProduto == 0)
                {
                    produtos.AddObject(produto);
                }
                else
                {
                    if (produto.EntityState == System.Data.EntityState.Detached)
                    {
                        produtos.Attach(produto);
                    }
                    db.ObjectStateManager.ChangeObjectState(produto, System.Data.EntityState.Modified);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirProduto(Produto produto)
        {
            string erro = null;
            try
            {
                produtos.DeleteObject(produto);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public List<Produto> pesquisarProdutoPorDescricao(string nome)
        {
            var lista = from p in todosProdutos()
                        where p.Descricao.ToLower().Contains(nome.ToLower())
                        select p;
            return lista.ToList();
        }

    }
}
