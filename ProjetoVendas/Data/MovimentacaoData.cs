using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using ProjetoVendas.Model;

namespace ProjetoVendas.Data
{
    class MovimentacaoData
    {

        private VendasEntities db;
        private ObjectSet<Movimentacao> movimentacaos;

        public MovimentacaoData(VendasEntities db)
        {
            this.db = db;
            this.movimentacaos = db.CreateObjectSet<Movimentacao>();
        }

        public List<Movimentacao> todasMovimentacaos()
        {
            return movimentacaos.ToList();
        }

        public string salvarMovimentacao(Movimentacao movimentacao)
        {
            string erro = null;
            try
            {
                if (movimentacao.IdMovimentacao == 0)
                {
                    movimentacaos.AddObject(movimentacao);
                }
                else
                {
                    if (movimentacao.EntityState == System.Data.EntityState.Detached)
                    {
                        movimentacaos.Attach(movimentacao);
                    }
                    db.ObjectStateManager.ChangeObjectState(movimentacao, System.Data.EntityState.Modified);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirMovimentacao(Movimentacao movimentacao)
        {
            string erro = null;
            try
            {
                movimentacaos.DeleteObject(movimentacao);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public float estoqueProduto(int idProduto)
        {
            ObjectSet<Movimentacao> movimentacoes = db.CreateObjectSet<Movimentacao>();
            var entradas = from m in movimentacoes
                           where m.Tipo == "E" && m.IdProduto == idProduto
                           select m.Quantidade;
            var saidas = from m in movimentacoes
                         where m.Tipo == "S" && m.IdProduto == idProduto
                         select m.Quantidade;
            return entradas.ToList().Sum() - saidas.ToList().Sum();
        }

    }
}
