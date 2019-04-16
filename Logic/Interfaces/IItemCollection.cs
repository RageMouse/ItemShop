using System;
using System.Collections.Generic;
using System.Text;
using Logic.Models;

namespace Logic.Interfaces
{
    public interface IItemCollection
    {
        void CreateItem(Item item);
        List<Item> GetAllItems();
        Item GetByName(string name);
        void Update(Item item);
    }
}
