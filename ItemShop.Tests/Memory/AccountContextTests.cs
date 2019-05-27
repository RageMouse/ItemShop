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

        [TestMethod]
        public void EditCharacter()
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
