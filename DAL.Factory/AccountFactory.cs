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
        private readonly string _connString;

        public AccountFactory(IConfiguration configuration)
        {
            _context = configuration.GetSection("Database").GetSection("Type").Value;
            _connString = configuration.GetSection("ConnectionStrings").GetSection("ConnectionString").Value;
        }

        private IAccountContext GeAccountContext()
        {
            switch (_context)
            {
                case "MSSQL":
                    return new AccountMSSQLContext("Server=mssql.fhict.local;Database=dbi387022;User Id=dbi387022;Password=yoloswag1337");
                case "MEMORY":
                    return new AccountMemoryContext();
                default:
                    throw new NotImplementedException();
            }
        }

        public IAccountCollection AccountCollection() => new AccountCollection(GeAccountContext());
    }
}