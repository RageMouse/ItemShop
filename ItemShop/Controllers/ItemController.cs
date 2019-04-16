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
    public class ItemController : Controller
    {
        private readonly ItemFactory _itemFactory;

        public ItemController(IConfiguration configuration)
        {
            _itemFactory = new ItemFactory(configuration);
        }
        public IActionResult Index()
        {
            ShowAllItemsViewModel model = new ShowAllItemsViewModel();
            model.Items = _itemFactory.ItemCollection().GetAllItems();
            return View(model);
        }

        [HttpGet]
        public IActionResult CreateNewItem()
        {
            return View();
        }

        public IActionResult CreateNewItem(CreateItemViewModel model)
        {
            IItemCollection itemCollection = _itemFactory.ItemCollection();
            itemCollection.CreateItem(new Item(model.Name, model.Bonus, model.Description, model.Type));
            return RedirectToAction("Index", "Item");
        }
    }
}