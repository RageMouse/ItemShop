using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.DTOs;
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
            int maxLength = 25;
            if (maxLength < account.Name.Length || string.IsNullOrEmpty(account.Name))
            {
                throw new ArgumentOutOfRangeException();
            }

            _accountContext.CreateAccount(new AccountDTO(account.Name, account.Password, account.Gamemaster, account.Active));
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