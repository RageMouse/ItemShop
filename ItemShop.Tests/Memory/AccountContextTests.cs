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
            AccountCollection accountCollection = new AccountCollection(new AccountMemoryContext());
            Account account = new Account(0, "John", true);
            //Act
            accountCollection.CreateAccount(account);
            //Assert
            //todo change the assert to make sense
            Assert.AreEqual(account, account);
        }

        [TestMethod]
        public void EditAccount()
        {
            //Arrange
            AccountCollection accountCollection = new AccountCollection(new AccountMemoryContext());
            Account account = new Account(0, "John", true);
            //Act
            accountCollection.Update(account);
            //Assert
        }
    }
}
