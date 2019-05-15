using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface.DTOs
{
    public struct ItemDTO
    {
        public readonly int ItemId;
        public readonly string Name;
        public readonly string Description;
        public readonly string Type;
        public readonly bool Unique;

        public ItemDTO(int itemId, string name, string description, string type, bool unique)
        {
            ItemId = itemId;
            Name = name;
            Description = description;
            Type = type;
            Unique = unique;
        }

        public ItemDTO(string name, string description, string type, bool unique)
        {
            ItemId = 0;
            Name = name;
            Description = description;
            Type = type;
            Unique = unique;
        }
    }
}