using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using ProjetoVendas.Model;

namespace ProjetoVendas.Data
{
    class DepartamentoData
    {

        private VendasEntities db;
        private ObjectSet<Departamento> departamentos;

        public DepartamentoData(VendasEntities db)
        {
            this.db = db;
            this.departamentos = db.CreateObjectSet<Departamento>();
        }

        public List<Departamento> todosDepartamentos()
        {
            return departamentos.ToList();
        }

        public string salvarDepartamento(Departamento departamento)
        {
            string erro = null;
            try
            {
                if (departamento.IdDepartamento == 0)
                {
                    departamentos.AddObject(departamento);
                }
                else
                {
                    if (departamento.EntityState == System.Data.EntityState.Detached)
                    {
                        departamentos.Attach(departamento);
                    }
                    db.ObjectStateManager.ChangeObjectState(departamento, System.Data.EntityState.Modified);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirDepartamento(Departamento departamento)
        {
            string erro = null;
            try
            {
                departamentos.DeleteObject(departamento);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public int quantidadeVendidaPorDepto(int idDepartamento)
        {
            ObjectSet<Produto> produtos = db.CreateObjectSet<Produto>();
            ObjectSet<Movimentacao> movimentacoes = db.CreateObjectSet<Movimentacao>();
            var lista = from d in todosDepartamentos()
                        join p in produtos.ToList()
                            on d.IdDepartamento equals p.IdDepartamento
                        join m in movimentacoes.ToList()
                            on p.IdProduto equals m.IdMovimentacao
                        where d.IdDepartamento == idDepartamento && m.Tipo == "S"
                        select m.Quantidade;
            return (int) lista.ToList().Sum();
        }

    }
}
