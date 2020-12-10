using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
    public class PrimeNumber
    {
        public int Number {get; set;}
        private static List<PrimeNumber> _numbers = new List<PrimeNumber> {};
        public PrimeNumber(int number)
        {
            Number = number;
            _numbers.Add(this);
        }
        public static List<PrimeNumber> GetNumbers()
        {
            return _numbers;
        }
        public static void ClearAll()
        {
            _numbers.Clear();
        }
    }
}