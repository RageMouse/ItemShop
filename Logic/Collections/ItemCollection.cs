using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.DTOs;
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
            int maxLength = 25;
            if (string.IsNullOrEmpty(item.Name))
            {
                throw new ArgumentOutOfRangeException();
            }

            _itemContext.CreateItem(new ItemDTO(item.Name, item.Bonus, item.Description, item.Type));
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
