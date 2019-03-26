using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.DTOs;

namespace DAL.Interface.Interfaces
{
    public interface IAccountContext
    {
        void CreateAccount(AccountDTO account);
        List<AccountDTO> GetAllAccounts();
        AccountDTO GetById(int id);
    }
}
