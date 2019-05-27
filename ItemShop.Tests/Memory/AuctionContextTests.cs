using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using DAL.Memory;
using Logic.Collections;
using Logic.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ItemShop.Test.Memory
{
    [TestClass]
    public class AuctionContextTests
    {
        [TestMethod]
        public void CreateAuction()
        {
            var memcontext = new AuctionMemoryContext();
            //Arrange
            AuctionCollection auctionCollection = new AuctionCollection(memcontext);
            Auction auction = new Auction(11, DateTime.Now, false, DateTime.MaxValue, 30, 50, 1);
            //Act
            auctionCollection.CreateAuction(auction);
            var auctionResult = memcontext._auctions.Find(a => a.ItemId == auction.ItemId);
            //Assert, ItemId is unique enough to have just 1 assert.
            Assert.AreEqual(auctionResult.ItemId, auction.ItemId);
        }
    }
}