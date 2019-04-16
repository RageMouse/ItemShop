using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.DTOs;
using DAL.Interface.Interfaces;

namespace DAL.Memory
{
    public class ItemMemoryContext : IItemContext
    {
        public void CreateItem(ItemDTO item)
        {
            throw new NotImplementedException();
        }

        public List<ItemDTO> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public ItemDTO GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(ItemDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
