using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.Interfaces;
using DAL.Memory;
using DAL.MSSQL;
using Logic.Collections;
using Logic.Interfaces;
using Logic.Models;
using Microsoft.Extensions.Configuration;

namespace DAL.Factory
{
    public class AccountFactory
    {
        private readonly string _context;

        public AccountFactory(IConfiguration configuration)
        {
            _context = configuration.GetSection("Database").GetSection("Type").Value;
            configuration.GetConnectionString(_context);
        }

        private IAccountContext GeAccountContext()
        {
            switch (_context)
            {
                case "MSSQL":
                    return new AccountMSSQLContext();
                case "MEMORY":
                    return new AccountMemoryContext();
                default:
                    throw new NotImplementedException();
            }
        }

        public IAccount Account() => new Account();
        public IAccountCollection AccountCollection() => new AccountCollection(GeAccountContext());
    }
}
