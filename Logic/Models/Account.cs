using System;
using System.Collections.Generic;
using System.Text;
using Logic.Interfaces;

namespace Logic.Models
{
    public class Account
    {
        public int AccountId { get; }
        public string Name { get; }
        public string Password { get; }
        public bool Active { get; }

        public Account()
        {
        }

        public Account(string name, string password, bool active)
        {
            Name = name;
            Password = password;
            Active = active;
        }

        public Account(int accountId, string name, string password, bool active)
        {
            AccountId = accountId;
            Name = name;
            Password = password;
            Active = active;
        }

        public Account(int accountId, string name, bool active)
        {
            AccountId = accountId;
            Name = name;
            Active = active;
        }
    }
}