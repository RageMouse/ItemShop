using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Models
{
    public class Item
    {
        public int ItemId { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool Unique { get; set; }

        public Item()
        {
        }

        public Item(int id, string name, string description, string type, bool unique)
        {
            ItemId = id;
            Name = name;
            Description = description;
            Type = type;
            Unique = unique;
        }

        public Item(string name, string description, string type, bool unique)
        {
            ItemId = 0;
            Name = name;
            Description = description;
            Type = type;
            Unique = unique;
        }
    }
}