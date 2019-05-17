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
        private const int MaxLengthAccountName = 25;

        public AccountCollection(IAccountContext context)
        {
            _accountContext = context;
        }

        public void CreateAccount(Account account)
        {
            if (MaxLengthAccountName < account.Name.Length || string.IsNullOrEmpty(account.Name))
            {
                throw new ArgumentOutOfRangeException();
            }

            _accountContext.CreateAccount(new AccountDTO(account.Name, account.Password, account.Active));
        }

        public void DeleteAccount(AccountDTO account)
        {
            _accountContext.RemoveAccount(account);
        }

        internal Account ConvertAccount(AccountDTO account)
        {
            if (MaxLengthAccountName < account.Name.Length || string.IsNullOrEmpty(account.Name))
            {
                throw new ArgumentOutOfRangeException();
            }

            return new Account(account.AccountId, account.Name, account.Password, account.Active);
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

            return new Account(accountDto.AccountId, accountDto.Name, accountDto.Password, accountDto.Active);
        }

        public void Update(Account account)
        {
            _accountContext.Update(new AccountDTO(account.AccountId, account.Name, account.Password, account.Active));
        }
    }
}