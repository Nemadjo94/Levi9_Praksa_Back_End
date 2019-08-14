using E_Commerce.Domain.Exceptions;
using E_Commerce.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace E_Commerce.Domain.Tests.ValueObjects
{
   [TestClass]
   public  class AddAccountTests
   {
        [TestMethod]
        public void ShouldHaveCorrectDomainAndName()
        {
            var account = AddAccount.For("SSW\\Nemanja");

            Assert.AreEqual("SSW", account.Domain);
            Assert.AreEqual("Nemanja", account.Name);
        }

        [TestMethod]
        public void ToStringReturnsCorrectFormat()
        {
            const string value = "SSW\\Nemanja";
            var account = AddAccount.For(value);

            Assert.AreEqual(value, account.ToString());
        }

        [TestMethod]
        public void ImplicitConversionToStringResultsInCorrectString()
        {
            const string value = "SSW\\Nemanja";
            var account = AddAccount.For(value);
            string result = account;

            Assert.AreEqual(value, result);
        }

        [TestMethod]
        public void ShouldThrowAddAccountInvalidExceptionForInvalidAccount()
        {
            Assert.ThrowsException<AddAccountInvalidException>(() =>
                (AddAccount)"SSWNemanja");
        }

   }
}
