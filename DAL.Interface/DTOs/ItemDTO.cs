using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface.DTOs
{
    public struct ItemDTO
    {
        public readonly string Name;
        public readonly int Bonus;
        public readonly string Description;
        public readonly string Type;

        public ItemDTO(string name, int bonus, string description, string type)
        {
            Name = name;
            Bonus = bonus;
            Description = description;
            Type = type;
        }
    }
}
