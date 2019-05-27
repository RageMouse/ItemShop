using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.Interfaces;
using DAL.Memory;
using DAL.MSSQL;
using Logic.Collections;
using Logic.Interfaces;
using Microsoft.Extensions.Configuration;

namespace DAL.Factory
{
    public class AuctionFactory
    {
        private readonly string _context;

        public AuctionFactory(IConfiguration configuration)
        {
            _context = configuration.GetSection("Database").GetSection("Type").Value;
            configuration.GetConnectionString(_context);
        }

        private IAuctionContext GetAuctionContext()
        {
            switch (_context)
            {
                case "MSSQL":
                    return new AuctionMSSQLContext();
                case "MEMORY":
                    return new AuctionMemoryContext();
                default:
                    throw new NotImplementedException();
            }
        }

        public IAuctionCollection AuctionCollection() => new AuctionCollection(GetAuctionContext());
    }
}
