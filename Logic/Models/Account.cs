using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Models
{
    public class Account
    {
        private string Name { get; set; }
        private bool Type { get; set; }
        private string Password { get; set; }

        public Account()
        {

        }

        public Account(string name, bool type, string password)
        {
            Name = name;
            Type = type;
            Password = password;
        }
    }
}
