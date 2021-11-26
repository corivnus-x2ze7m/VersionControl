using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        
        [Test, 
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu",false),
            TestCase("irf@uni-corvinus.hu", true)]
        public void TestValidate(string email, bool expectedResult)
        {
            //Arrange
            var accountController = new AccountController();

            //Act
            var actualResult = accountController.ValidateEmail(email);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test,
            TestCase("abCD", false),
            TestCase("ABCD1234", false),
            TestCase("abcd1234", false),
            TestCase("ab1234", false),
            TestCase("ABcd1234", true)]
        public void PwValidate(string password, bool expectedResult)
        {
            var accountController = new AccountController();

            var actualResult = accountController.ValidatePassword(password);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestRegisterHappyPath(string email, string password)
        {
            AccountController t = new AccountController();

            var actualResult = t.Register(email, password);

            Assert.AreEqual(email, actualResult.Email);
            Assert.Equals(password, actualResult.Password);
            Assert.AreNotEqual(Guid.Empty, actualResult.ID);
        }
    }
}
