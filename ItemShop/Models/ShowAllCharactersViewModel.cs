using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic.Models;

namespace ItemShop.Models
{
    public class ShowAllCharactersViewModel
    {
        public int CharacterId { get; private set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int RoleId { get; set; }

        public List<Character> Characters { get; set; }

        public ShowAllCharactersViewModel()
        {

        }

        public ShowAllCharactersViewModel(List<Character> characters)
        {
            Characters = characters;
        }
    }
}
