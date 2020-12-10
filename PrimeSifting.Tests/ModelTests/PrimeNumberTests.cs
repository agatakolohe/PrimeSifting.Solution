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
            List<int> newList = new List<int> { };

            List<int> result = PrimeNumber.GetNumbers(4, newList);

            CollectionAssert.AreEqual(newList, result);
        }
        [TestMethod]
        public void GetNumbers_ReturnsListOfNumbersFromTwoToNumber_PrimeNumberList()
        {
            int number = 10;
            PrimeNumber newPrimeNumber = new PrimeNumber(number);
            List<int> newList = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> testList = new List<int> { };
            // Console.WriteLine(newPrimeNumber.Number);
            // for (int i = 2; i <= newPrimeNumber.Number; i++)
            // {
            //     newList.Add(i);
            // }
            Console.WriteLine("NUMLIST LENGTH: {0}", newList.Count);

            List<int> result = PrimeNumber.GetNumbers(number, testList);

            // foreach (int thisNumber in newList)
            // {
            //     Console.WriteLine(thisNumber);
            // }
            foreach (int thisNumber in result)
            {
                Console.WriteLine(thisNumber);
            }

            CollectionAssert.AreEqual(newList, result);
        }
    }
}
