using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using ProjetoVendas.Model;

namespace ProjetoVendas.Data
{
    class ClienteData
    {

        private VendasEntities db;
        private ObjectSet<Cliente> clientes;

        public ClienteData(VendasEntities db)
        {
            this.db = db;
            this.clientes = db.CreateObjectSet<Cliente>();
        }

        public List<Cliente> todosClientes()
        {
            return clientes.ToList();
        }

        public string salvarCliente(Cliente cliente)
        {
            string erro = null;
            try
            {
                if (cliente.IdCliente == 0)
                {
                    clientes.AddObject(cliente);
                }
                else
                {
                    if (cliente.EntityState == System.Data.EntityState.Detached)
                    {
                        clientes.Attach(cliente);
                    }
                    db.ObjectStateManager.ChangeObjectState(cliente, System.Data.EntityState.Modified);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirCliente(Cliente cliente)
        {
            string erro = null;
            try
            {
                clientes.DeleteObject(cliente);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public List<Cliente> pesquisarClientePorNome(string nome)
        {
            var lista = from c in todosClientes()
                        where c.Nome.ToLower().Contains(nome.ToLower())
                        select c;
            return lista.ToList();
        }

        public int calcularIdade(DateTime dataNascimento)
        {
            DateTime agora = DateTime.Now;
            if (dataNascimento.Month < agora.Month || (dataNascimento.Month == agora.Month && dataNascimento.Day <= agora.Day)) 
            {
                return agora.Year - dataNascimento.Year;
            } 
            else 
            {
                return (agora.Year - dataNascimento.Year) - 1;
            }
        }

    }
}
