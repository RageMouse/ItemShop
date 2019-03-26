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
    public class AccountController : Controller
    {
        private readonly AccountFactory _accountFactory;

        public AccountController(IConfiguration configuration)
        {
            _accountFactory = new AccountFactory(configuration);
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateNewAccount()
        {
            return View();
        }

        public IActionResult CreateNewAccount(CreateAccounViewModel model)
        {
            IAccountCollection accountCollection = _accountFactory.AccountCollection();
            accountCollection.CreateAccount(new Account(model.Name, model.Password, model.IsGamemaster, model.IsActive));
            return RedirectToAction("Index", "Account");
        }
    }
}