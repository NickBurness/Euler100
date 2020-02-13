using System;
using System.Collections.Generic;
using System.Text;
using Euler100Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler100.Tests
{
    [TestClass]
    public class TotalOfEvenFibonacciNumbersBelow4Million
    {
        private readonly EvenFibonacciNumbers _evenFibonacciNumbers;

        public TotalOfEvenFibonacciNumbersBelow4Million()
        {
            _evenFibonacciNumbers = new EvenFibonacciNumbers();
        }

        [TestMethod]
        public void Challenge2_TotalOfEvenFibonacciNumbersEquals4613732()
        {
            var result = _evenFibonacciNumbers.Challenge2();

            Assert.AreEqual(4613732, result);
        }
    }
}
