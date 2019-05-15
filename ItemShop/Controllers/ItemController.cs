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
            itemCollection.CreateItem(new Item(model.Name, model.Description, model.Type, model.IsUnique));
            return RedirectToAction("Index", "Item");
        }

        public IActionResult Details(string name)
        {
            Item item = _itemFactory.ItemCollection().GetByName(name);

            ShowAllItemsViewModel model = new ShowAllItemsViewModel()
            {
                Name = item.Name,
                Description = item.Description,
                Type = item.Type,
                Unique = item.Unique
            };

            return View(model);
        }

        public IActionResult Edit(string name)
        {
            Item item = _itemFactory.ItemCollection().GetByName(name);

            ShowAllItemsViewModel model = new ShowAllItemsViewModel()
            {
                Name = item.Name,
                Description = item.Description,
                Type = item.Type,
                Unique = item.Unique
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult SaveEdit(ShowAllItemsViewModel model)
        {
            IItemCollection accountCollection = _itemFactory.ItemCollection();
            accountCollection.Update(new Item(model.Name, model.Description, model.Type, model.Unique));

            return RedirectToAction("Index", "Item");
        }
    }
}