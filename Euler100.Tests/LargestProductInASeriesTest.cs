using System;
using System.Collections.Generic;
using System.Text;
using Euler100Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler100.Tests
{
    [TestClass]
    public class LargestProductFor13AdjacentNumbersTest
    {
        private readonly LargestProductInASeries _largestProductInASeries;

        public LargestProductFor13AdjacentNumbersTest()
        {
            _largestProductInASeries = new LargestProductInASeries();
        }

        [TestMethod]
        public void Challenge8_Largest13AdjactNumbers()
        {
            long result = _largestProductInASeries.Challenge8();

            Assert.AreEqual(23514624000, result);
        }
    }
}
