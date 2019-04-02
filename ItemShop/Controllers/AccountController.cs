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
            ShowAllAccountsViewModel model = new ShowAllAccountsViewModel();
            model.Accounts = _accountFactory.AccountCollection().GetAllAccounts();
            return View(model);
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

        public IActionResult Edit(int id)
        {
            Account account = _accountFactory.AccountCollection().GetById(id);

            ShowAllAccountsViewModel model = new ShowAllAccountsViewModel()
            {
                AccountId = id,
                Name = account.Name,
                Password = account.Password,
                Active = account.Active,
                Gamemaster = account.Gamemaster
            };

            return View(model);
        }
    }
}