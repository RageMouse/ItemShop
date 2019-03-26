using System;
using System.Collections.Generic;
using System.Text;
using Logic.Interfaces;

namespace Logic.Models
{
    public class Account : IAccount
    {
        private string Name { get; set; }
        private bool Gamemaster { get; set; }
        private string Password { get; set; }
        private bool Active { get; set; }

        public Account()
        {
        }

        public Account(string name, bool gamemaster, string password, bool active)
        {
            Name = name;
            Gamemaster = gamemaster;
            Password = password;
            Active = active;
        }
    }
}