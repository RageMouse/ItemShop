﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Factory;
using ItemShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ItemShop.Controllers
{
    public class ShopController : Controller
    {
        private readonly ItemFactory _itemFactory;

        public ShopController(IConfiguration configuration)
        {
            _itemFactory = new ItemFactory(configuration);
        }
        public IActionResult Index()
        {
            ShowAllItemsViewModel model = new ShowAllItemsViewModel();
            model.Items = _itemFactory.ItemCollection().GetAllItems();
            return View(model);
        }
    }
}