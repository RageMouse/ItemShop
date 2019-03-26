using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.Interfaces;
using Logic.Interfaces;
using Logic.Models;

namespace Logic.Collections
{
    public class AccountCollection : IAccountCollection
    {
        public List<Account> Accounts { get; set; }
        private readonly IAccountContext _accountContext;

        public AccountCollection(IAccountContext context)
        {
            _accountContext = context;
        }

        public void CreateAccount(Account account)
        {
        }

        public void DeleteAccout(Account account)
        {
        }

        internal Account ConvertAccount(Account account)
        {
            return account;
        }

        public List<Account> GetAllAccounts()
        {
            List<Account> accounts = new List<Account>();

            return accounts;
        }

        public Account GetById(int id)
        {
            return new Account();
        }
    }
}