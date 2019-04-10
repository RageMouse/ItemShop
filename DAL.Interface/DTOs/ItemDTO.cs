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
        public readonly bool Type;

        public ItemDTO(string name, int bonus, string description, bool type)
        {
            Name = name;
            Bonus = bonus;
            Description = description;
            Type = type;
        }
    }
}
