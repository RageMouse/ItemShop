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

        public ItemFactory(IConfiguration configuration)
        {
            _context = configuration.GetSection("Database").GetSection("Type").Value;
            configuration.GetConnectionString(_context);
        }

        private IItemContext GetItemContext()
        {
            switch (_context)
            {
                case "MSSQL":
                    return new ItemMSSQLContext();
                case "MEMORY":
                    return new ItemMemoryContext();
                default:
                    throw new NotImplementedException();
            }
        }

        public IItemCollection ItemCollection() => new ItemCollection(GetItemContext());
    }
}
