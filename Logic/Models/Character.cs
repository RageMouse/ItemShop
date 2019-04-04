using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Models
{
    public class Character
    {
        public int CharacterId { get; private set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int RoleId { get; set; }

        public Character()
        {

        }

        public Character(int characterId, string name, string role, int roleId)
        {
            CharacterId = characterId;
            Name = name;
            Role = role;
            RoleId = roleId;
        }
    }
}
