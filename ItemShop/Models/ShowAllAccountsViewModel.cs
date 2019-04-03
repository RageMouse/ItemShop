using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Logic.Models;

namespace ItemShop.Models
{
    public class ShowAllAccountsViewModel
    {
        public int AccountId { get; private set; }
        public string Name { get; private set; }
        public string Password { get;  set; }
        public bool Gamemaster { get;  set; }
        public bool Active { get;  set; }

        public List<Account> Accounts { get; set; }

        public ShowAllAccountsViewModel()
        {

        }

        public ShowAllAccountsViewModel(List<Account> accounts)
        {
            Accounts = accounts;
        }
    }
}