using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting.Models;
using System;
using System.Collections.Generic;

namespace PrimeSifting.Tests
{
    [TestClass]
    public class PrimeNumberTests : IDisposable
    {
        public void Dispose()
        {
            PrimeNumber.ClearAll();
        }
        [TestMethod]
        public void PrimeNumberConstructor_CreatesInstanceOfPrimeNumber_PrimeNumber()
        {
            PrimeNumber newPrimeNumber = new PrimeNumber(3);
            Assert.AreEqual(typeof(PrimeNumber), newPrimeNumber.GetType());
        }
        [TestMethod]
        public void GetNumber_ReturnsNumber_Int()
        {
            int number = 3;
            PrimeNumber newPrimeNumber = new PrimeNumber(number);

            int result = newPrimeNumber.Number;

            Assert.AreEqual(number, result);
        }
        [TestMethod]
        public void SetNumber_SetNumber_Int()
        {
            int number = 3;
            PrimeNumber newPrimeNumber = new PrimeNumber(number);

            int updatedNumber = 4;
            newPrimeNumber.Number = updatedNumber;
            int result = newPrimeNumber.Number;

            Assert.AreEqual(updatedNumber, result);
        }
        [TestMethod]
        public void GetNumbers_ReturnsEmptyList_PrimeNumberList()
        {
            List<PrimeNumber> newList = new List<PrimeNumber> { };

            List<PrimeNumber> result = PrimeNumber.GetNumbers();

            CollectionAssert.AreEqual(newList, result);
        }
    }
}
