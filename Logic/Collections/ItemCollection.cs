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

        internal Item ConvertItem(ItemDTO item)
        {
            if (string.IsNullOrEmpty(item.Name))
            {
                throw new ArgumentOutOfRangeException();
            }

            return new Item(item.ItemId, item.Name, item.Description, item.Type, item.Unique);
        }

        public void CreateItem(Item item)
        {
            if (string.IsNullOrEmpty(item.Name))
            {
                throw new ArgumentOutOfRangeException();
            }

            _itemContext.CreateItem(new ItemDTO(item.Name, item.Description, item.Type, item.Unique));
        }

        public List<Item> GetAllItems()
        {
            List<Item> items = new List<Item>();

            foreach (ItemDTO itemDto in _itemContext.GetAllItems())
            {
                Item item = ConvertItem(itemDto);
                items.Add(item);
            }

            return items;
        }

        public Item GetByName(string name)
        {
            ItemDTO itemDto = _itemContext.GetByName(name);

            return new Item(itemDto.Name, itemDto.Description, itemDto.Type, itemDto.Unique);
        }

        public void Update(Item item)
        {
            _itemContext.Update(new ItemDTO(item.Name, item.Description, item.Type, item.Unique));
        }
    }
}
