using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Models
{
    public class Item
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Bonus { get; private set; }
        public string Description { get; private set; }
        public string Type { get; private set; }

        public Item()
        {

        }

        public Item(int id ,string name, int bonus, string description, string type)
        {
            Id = id;
            Name = name;
            Bonus = bonus;
            Description = description;
            Type = type;
        }
    }
}
