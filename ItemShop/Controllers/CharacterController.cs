using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Factory;
using ItemShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ItemShop.Controllers
{
    public class CharacterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public CharacterController(IConfiguration configuration)
        {
            //_characterFactory = new CharacterFactory(configuration);
        }
    }
}