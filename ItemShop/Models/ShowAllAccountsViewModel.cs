using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic.Models;

namespace ItemShop.Models
{
    public class ShowAllAccountsViewModel
    {
        public int AccountId { get; internal set; }
        public string Name { get; internal set; }
        public string Password { get; internal set; }
        public bool Gamemaster { get; internal set; }
        public bool Active { get; internal set; }

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