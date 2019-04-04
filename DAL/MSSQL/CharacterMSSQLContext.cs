using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.DTOs;
using DAL.Interface.Interfaces;

namespace DAL.MSSQL
{
    public class CharacterMSSQLContext : ICharacterContext
    {
        public void CreateAccount(CharacterDTO account)
        {
            throw new NotImplementedException();
        }

        public void RemoveAccount(CharacterDTO account)
        {
            throw new NotImplementedException();
        }

        public List<CharacterDTO> GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public CharacterDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CharacterDTO account)
        {
            throw new NotImplementedException();
        }
    }
}
