using Logic.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL.Memory;
using Logic.Models;

namespace ItemShop.Test
{
    [TestClass]
    public class AccountCollectionTest
    {
        [TestMethod]
        public void AddCharacter()
        {
            //Arrange
            AccountCollection accountCollection = new AccountCollection(new AccountMemoryContext());
            Account account = new Account(0, "John", true);
            //Act
            accountCollection.CreateAccount(account);
            //Assert
            Assert.AreEqual(account, account);
        }
    }
}
