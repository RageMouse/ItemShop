using System;
using System.Collections.Generic;
using System.Text;
using Logic.Models;

namespace Logic.Interfaces
{
    public interface ICharacterCollection
    {
        void CreateCharacter(Account account);
        List<Character> GetAllCharacters();
        Character GetById(int id);
        void Update(Character character);
    }
}
