using DAL.Memory;
using Logic.Collections;
using Logic.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ItemShop.Test.Memory
{
    [TestClass]
    public class AccountCollectionTest
    {
        [TestMethod]
        public void AddAccount()
        {
            //Arrange
            var memcontext = new AccountMemoryContext();
            AccountCollection accountCollection = new AccountCollection(memcontext);
            Account account = new Account(2, "John", "Password", true);
            //Act
            accountCollection.CreateAccount(account);
            var auctionResult = memcontext._accounts.Find(a => a.Name == account.Name);
            //Assert, Name together with Password is unique enough for this test.
            Assert.AreEqual(auctionResult.Name, account.Name);
            Assert.AreEqual(auctionResult.Password, account.Password);
        }
    }
}
