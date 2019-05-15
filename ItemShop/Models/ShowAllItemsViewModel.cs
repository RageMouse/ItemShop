using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic.Models;

namespace ItemShop.Models
{
    public class ShowAllItemsViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool Unique { get; set; }

        public List<Item> Items { get; set; }

        public ShowAllItemsViewModel()
        {

        }

        public ShowAllItemsViewModel(List<Item> items)
        {
            Items = items;
        }
    }
}
