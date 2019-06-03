using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.Interfaces;
using DAL.Memory;
using DAL.MSSQL;
using Logic.Collections;
using Logic.Interfaces;

namespace DAL.Factory
{
    public class ItemFactory
    {
        private readonly string _context;
        private readonly string _connString;

        public ItemFactory(IConfiguration configuration)
        {
            _context = configuration.GetSection("Database").GetSection("Type").Value;
            _connString = configuration.GetSection("ConnectionStrings").GetSection("ConnectionString").Value;
        }

        private IItemContext GetItemContext()
        {
            switch (_context)
            {
                case "MSSQL":
                    return new ItemMSSQLContext("Server=mssql.fhict.local;Database=dbi387022;User Id=dbi387022;Password=yoloswag1337");
                case "MEMORY":
                    return new ItemMemoryContext();
                default:
                    throw new NotImplementedException();
            }
        }

        public IItemCollection ItemCollection() => new ItemCollection(GetItemContext());
    }
}
