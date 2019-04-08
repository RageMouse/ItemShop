using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface.DTOs
{
    public struct CharacterDTO
    {
        public readonly int CharacterId;
        public readonly string Name;
        public readonly string Role;
        public readonly int RoleId;

        public CharacterDTO(int characterId, string name, string role, int roleId)
        {
            CharacterId = characterId;
            Name = name;
            Role = role;
            RoleId = roleId;
        }

        public CharacterDTO(string name, int roleId)
        {
            CharacterId = 0;
            Name = name;
            Role = "";
            RoleId = roleId;
        }
    }
}
