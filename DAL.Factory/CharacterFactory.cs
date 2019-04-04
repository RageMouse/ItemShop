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
    public class CharacterFactory
    {
        private readonly string _context;

        public CharacterFactory(IConfiguration configuration)
        {
            _context = configuration.GetSection("Database").GetSection("Type").Value;
            configuration.GetConnectionString(_context);
        }

        private ICharacterContext GetCharacterContext()
        {
            switch (_context)
            {
                case "MSSQL":
                    return new CharacterMSSQLContext();
                case "MEMORY":
                    return new CharacterMemoryContext();
                default:
                    throw new NotImplementedException();
            }
        }

        public ICharacterCollection CharacterCollection() => new CharacterCollection(GetCharacterContext());
    }
}
