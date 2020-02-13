using System;
using System.Collections.Generic;
using System.Text;
using Euler100Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler100.Tests
{
    [TestClass]
    public class SmallestWholeNumberThatCanBeDividedByInts1to20
    {
        private readonly SmallestMultiple _smallestMultiple;
        
        public SmallestWholeNumberThatCanBeDividedByInts1to20()
        {
            _smallestMultiple = new SmallestMultiple();
        }

        [TestMethod]
        public void SmallestMultipleOfInts1To20_Returns232792560()
        {
            var result = _smallestMultiple.Challenge5();

            Assert.AreEqual(232792560, result);
        }
    }
}
