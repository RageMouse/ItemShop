using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Factory;
using ItemShop.Models;
using Logic.Interfaces;
using Logic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ItemShop.Controllers
{
    public class CharacterController : Controller
    {
        private readonly CharacterFactory _characterFactory;
        public IActionResult Index()
        {
            return View();
        }

        public CharacterController(IConfiguration configuration)
        {
            _characterFactory = new CharacterFactory(configuration);
        }

        [HttpGet]
        public IActionResult CreateNewCharacter()
        {
            return View();
        }

        public IActionResult CreateNewCharacter(CreateCharacterViewModel model)
        {
            ICharacterCollection characterCollection = _characterFactory.CharacterCollection();
            characterCollection.CreateCharacter(new Character(model.Name, model.RoleId));
            return RedirectToAction("Index", "Character");
        }
    }
}