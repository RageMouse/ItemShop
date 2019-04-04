using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface.Interfaces;
using Logic.Interfaces;
using Logic.Models;

namespace Logic.Collections
{
    public class CharacterCollection : ICharacterCollection
    {
        private readonly ICharacterContext _characterContext;

        public CharacterCollection(ICharacterContext context)
        {
            _characterContext = context;
        }

        public void CreateCharacter(Account account)
        {
            throw new NotImplementedException();
        }

        public List<Character> GetAllCharacters()
        {
            throw new NotImplementedException();
        }

        public Character GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Character character)
        {
            throw new NotImplementedException();
        }
    }
}