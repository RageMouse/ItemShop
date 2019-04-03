using System;
using System.Collections.Generic;
using System.Text;
using Logic.Models;

namespace Logic.Interfaces
{
    public interface IAccountCollection
    {
        void CreateAccount(Account account);
        List<Account> GetAllAccounts();
        Account GetById(int id);
        void Update(Account account);
    }
}