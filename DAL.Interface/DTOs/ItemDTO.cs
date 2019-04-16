using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface.DTOs
{
    public struct ItemDTO
    {
        public readonly int ItemId;
        public readonly string Name;
        public readonly int Bonus;
        public readonly string Description;
        public readonly string Type;

        public ItemDTO(int itemId, string name, int bonus, string description, string type)
        {
            ItemId = itemId;
            Name = name;
            Bonus = bonus;
            Description = description;
            Type = type;
        }

        public ItemDTO(string name, int bonus, string description, string type)
        {
            ItemId = 0;
            Name = name;
            Bonus = bonus;
            Description = description;
            Type = type;
        }
    }
}
