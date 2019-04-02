using System;
using System.Collections.Generic;
using System.Text;
using Logic.Interfaces;

namespace Logic.Models
{
    public class Account : IAccount
    {
        public  int AccountId { get; private set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Gamemaster { get; set; }
        public bool Active { get; set; }

        public Account()
        {
        }

        public Account(string name, string password, bool gamemaster, bool active)
        {
            Name = name;
            Password = password;
            Gamemaster = gamemaster;
            Active = active;
        }

        public Account(int accountId ,string name, string password, bool gamemaster, bool active)
        {
            AccountId = accountId;
            Name = name;
            Password = password;
            Gamemaster = gamemaster;
            Active = active;
        }

        public Account(int accountId, string name, bool gamemaster, bool active)
        {
            AccountId = accountId;
            Name = name;
            Gamemaster = gamemaster;
            Active = active;
        }
    }
}