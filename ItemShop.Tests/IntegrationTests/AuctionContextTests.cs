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
        public readonly string connString2 = "Server=mssql.fhict.local;Database=dbi387022;User Id=dbi387022;Password=yoloswag1337";




        [TestMethod]
        public void CreateAuction()
        {
            //Arrange
            var testContext = new AuctionMSSQLContext(connString);
            AuctionCollection auctionCollection = new AuctionCollection(testContext);
            Auction auction = new Auction(0, DateTime.Now, false, DateTime.MaxValue, 30, 50, 1);
            //Act
            auctionCollection.CreateAuction(auction);
            //Assert, todo need to change it so it checks if a row exists.
            Assert.AreEqual(auction, auctionCollection.GetById(2));
        }

        [TestMethod]
        public void TestAlgoritm()
        {
            //Arrange
            var testContext = new AuctionMSSQLContext(connString2);
            AuctionCollection auctionCollection = new AuctionCollection(testContext);
            Auction auction = new Auction(0, DateTime.Now, false, DateTime.MaxValue, 30, 50, 1);
            //Act
            auctionCollection.SuggestPrice(auction);
            //Assert, todo need to change it so it checks if a row exists.
            Assert.AreEqual(auction, auctionCollection.GetById(2));
        }
    }
}