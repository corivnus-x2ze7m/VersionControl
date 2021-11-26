﻿using NUnit.Framework;
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
            TestCase("abcd2134", false),
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
    }
}
