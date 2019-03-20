using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Models
{
    public class Item
    {
        public string Name { get; private set; }
        public int Bonus { get; private set; }
        public string Description { get; private set; }
        public bool Type { get; private set; }

        public Item()
        {

        }

        public Item(string name, int bonus, string description, bool type)
        {
            Name = name;
            Bonus = bonus;
            Description = description;
            Type = type;
        }
    }
}
