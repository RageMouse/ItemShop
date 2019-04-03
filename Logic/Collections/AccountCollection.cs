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

            _accountContext.CreateAccount(new AccountDTO(account.Name, account.Password, account.Gamemaster,
                account.Active));
        }

        public void DeleteAccount(AccountDTO account)
        {
            _accountContext.RemoveAccount(account);
        }

        internal Account ConvertAccount(AccountDTO account)
        {
            int maxLength = 20;
            if (maxLength < account.Name.Length || string.IsNullOrEmpty(account.Name))
            {
                throw new ArgumentOutOfRangeException();
            }

            return new Account(account.AccountId, account.Name, account.Password, account.Gamemaster, account.Active);
        }

        public List<Account> GetAllAccounts()
        {
            List<Account> accounts = new List<Account>();

            foreach (AccountDTO accountDto in _accountContext.GetAllAccounts())
            {
                Account account = ConvertAccount(accountDto);
                accounts.Add(account);
            }

            return accounts;
        }

        public Account GetById(int id)
        {
            AccountDTO accountDto = _accountContext.GetById(id);

            return new Account(accountDto.AccountId, accountDto.Name, accountDto.Gamemaster, accountDto.Active);
        }

        public void Update(Account account)
        {
            _accountContext.Update(new AccountDTO(account.AccountId, account.Name, account.Password, account.Gamemaster, account.Active));
        }
    }
}