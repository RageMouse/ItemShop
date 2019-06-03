using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DAL.Memory;
using DAL.MSSQL;
using Logic.Collections;
using Logic.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ItemShop.Test.IntegrationTests
{
    [TestClass]
    public class AuctionContextTests
    {
        public readonly string connString = "Server=localhost;Database=AuctionHouseDB;Integrated Security=SSPI;";

        [TestMethod]
        public void CreateAuction()
        {
            //Arrange
            var testContext = new AuctionMSSQLContext(connString);
            AuctionCollection auctionCollection = new AuctionCollection(testContext);
            Auction auction = new Auction(0, DateTime.Now, false, DateTime.MaxValue, 30, 50, 1);
            //Act
            auctionCollection.CreateAuction(auction);
            //Assert, ItemId is unique enough to have just 1 assert.
            Assert.AreEqual(auction, auctionCollection.GetById(2));
        }
    }
}
