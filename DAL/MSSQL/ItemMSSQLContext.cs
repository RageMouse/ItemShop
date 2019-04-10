using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.DTOs;
using DAL.Interface.Interfaces;

namespace DAL.MSSQL
{
    public class ItemMSSQLContext : IItemContext
    {
        public void CreateItem(ItemDTO item)
        {
            throw new NotImplementedException();
        }

        public List<ItemDTO> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public ItemDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ItemDTO item)
        {
            throw new NotImplementedException();
        }
    }
}
