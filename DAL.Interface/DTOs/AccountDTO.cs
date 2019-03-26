using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface.DTOs
{
    public struct AccountDTO
    {
        public readonly int AccountId;
        public readonly string Name;
        public readonly string Password;
        public bool Gamemaster;
        public bool Active;

        public AccountDTO(int accountId, string name, string password, bool gamemaster, bool active)
        {
            AccountId = accountId;
            Name = name;
            Password = password;
            Gamemaster = gamemaster;
            Active = active;
        }

        public AccountDTO(string name,  string password, bool gamemaster, bool active)
        {
            AccountId = 0;
            Name = name;
            Password = password;
            Gamemaster = gamemaster;
            Active = true;
        }
    }
}