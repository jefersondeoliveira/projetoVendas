using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using ProjetoVendas.Model;

namespace ProjetoVendas.Data
{
    class VendedorData
    {

        private VendasEntities db;
        private ObjectSet<Vendedor> vendedors;

        public VendedorData(VendasEntities db)
        {
            this.db = db;
            this.vendedors = db.CreateObjectSet<Vendedor>();
        }

        public List<Vendedor> todosVendedors()
        {
            return vendedors.ToList();
        }

        public string salvarVendedor(Vendedor vendedor)
        {
            string erro = null;
            try
            {
                if (vendedor.IdVendedor == 0)
                {
                    vendedors.AddObject(vendedor);
                }
                else
                {
                    if (vendedor.EntityState == System.Data.EntityState.Detached)
                    {
                        vendedors.Attach(vendedor);
                    }
                    db.ObjectStateManager.ChangeObjectState(vendedor, System.Data.EntityState.Modified);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirVendedor(Vendedor vendedor)
        {
            string erro = null;
            try
            {
                vendedors.DeleteObject(vendedor);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public List<Vendedor> pesquisarVendedorPorNome(string nome)
        {
            var lista = from v in todosVendedors()
                        where v.NomeVendedor.ToLower().Contains(nome.ToLower())
                        select v;
            return lista.ToList();
        }

    }
}
