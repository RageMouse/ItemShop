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
    public class AuctionController : Controller
    {
        private readonly AuctionFactory _auctionFactory;

        public AuctionController(IConfiguration configuration)
        {
            _auctionFactory = new AuctionFactory(configuration);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateNewAuction()
        {
            return View();
        }

        public IActionResult CreateNewAccount(CreateAuctionViewModel model)
        {
            IAuctionCollection auctionCollection = _auctionFactory.AuctionCollection();
            //todo write this for creation of auctions
            //auctionCollection.AddAuction(new Auction(model.DateCreated, model.Sold, model.EndDateTime, model.MinPrice, model.BuyoutPrice, ));
            return RedirectToAction("Index", "Account");
        }
    }
}