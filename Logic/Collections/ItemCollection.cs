using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.Interfaces;
using Logic.Interfaces;
using Logic.Models;

namespace Logic.Collections
{
    public class ItemCollection : IItemCollection
    {
        private readonly IItemContext _itemContext;

        public ItemCollection(IItemContext context)
        {
            _itemContext = context;
        }

        public void CreateItem(Item item)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Item GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
