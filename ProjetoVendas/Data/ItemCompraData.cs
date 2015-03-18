using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using ProjetoVendas.Model;

namespace ProjetoVendas.Data
{
    class ItemCompraData
    {

        private VendasEntities db;
        private ObjectSet<ItemCompra> itemCompras;

        public ItemCompraData(VendasEntities db)
        {
            this.db = db;
            this.itemCompras = db.CreateObjectSet<ItemCompra>();
        }

        public List<ItemCompra> todosItemCompra()
        {
            return itemCompras.ToList();
        }

        public string salvarItemCompra(ItemCompra itemCompra)
        {
            string erro = null;
            try
            {
                itemCompras.AddObject(itemCompra);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string excluirItemCompra(ItemCompra itemCompra)
        {
            string erro = null;
            try
            {
                itemCompras.DeleteObject(itemCompra);
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
