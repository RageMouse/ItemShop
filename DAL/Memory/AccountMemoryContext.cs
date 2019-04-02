using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.DTOs;
using DAL.Interface.Interfaces;

namespace DAL.Memory
{
    public class AccountMemoryContext : IAccountContext
    {
        public void CreateAccount(AccountDTO account)
        {
            throw new NotImplementedException();
        }

        public void RemoveAccount(AccountDTO account)
        {
            throw new NotImplementedException();
        }

        public List<AccountDTO> GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public AccountDTO GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
