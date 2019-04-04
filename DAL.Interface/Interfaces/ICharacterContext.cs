using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.DTOs;

namespace DAL.Interface.Interfaces
{
    public interface ICharacterContext
    {
        void CreateAccount(CharacterDTO account);
        void RemoveAccount(CharacterDTO account);
        List<CharacterDTO> GetAllAccounts();
        CharacterDTO GetById(int id);
        void Update(CharacterDTO account);
    }
}