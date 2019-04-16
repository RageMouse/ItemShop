using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.DTOs;

namespace DAL.Interface.Interfaces
{
    public interface IItemContext
    {
        void CreateItem(ItemDTO item);
        List<ItemDTO> GetAllItems();
        ItemDTO GetByName(string name);
        void Update(ItemDTO item);
    }
}
