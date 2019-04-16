using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Models
{
    public class Item
    {
        public int ItemId { get; private set; }
        public string Name { get; set; }
        public int Bonus { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public Item()
        {

        }

        public Item(int id ,string name, int bonus, string description, string type)
        {
            ItemId = id;
            Name = name;
            Bonus = bonus;
            Description = description;
            Type = type;
        }

        public Item(string name, int bonus, string description, string type)
        {
            ItemId = 0;
            Name = name;
            Bonus = bonus;
            Description = description;
            Type = type;
        }
    }
}
