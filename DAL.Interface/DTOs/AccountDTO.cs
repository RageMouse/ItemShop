using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface.DTOs
{
    public struct AccountDTO
    {
        public readonly int AccountId;
        public readonly string Name;
        public bool Gamemaster;
        public readonly string Password;
        public readonly bool Active;

        public AccountDTO(int accountId, string name, bool gamemaster, string password, bool active)
        {
            AccountId = accountId;
            Name = name;
            Gamemaster = gamemaster;
            Password = password;
            Active = active;
        }
    }
}
