using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using ProjetoVendas.Model;

namespace ProjetoVendas.Data
{
    class ItemVendaData
    {

        private VendasEntities db;
        private ObjectSet<ItemVenda> itemVendas;

        public ItemVendaData(VendasEntities db)
        {
            this.db = db;
            this.itemVendas = db.CreateObjectSet<ItemVenda>();
        }

        public List<ItemVenda> todosItemVenda()
        {
            return itemVendas.ToList();
        }

        public string salvarItemVenda(ItemVenda itemVenda)
        {
            string erro = null;
            try
            {
                itemVendas.AddObject(itemVenda);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirItemVenda(ItemVenda itemVenda)
        {
            string erro = null;
            try
            {
                itemVendas.DeleteObject(itemVenda);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }


    }
}
