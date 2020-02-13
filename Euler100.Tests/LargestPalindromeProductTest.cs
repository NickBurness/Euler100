using System;
using System.Collections.Generic;
using System.Text;
using Euler100Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler100.Tests
{
    [TestClass]
    public class LargestPalindromeProductOfTwo3DigitNumbers
    {
        private readonly LargestPalindromeProduct _largestPalindromeProduct;

        public LargestPalindromeProductOfTwo3DigitNumbers()
        {
            _largestPalindromeProduct = new LargestPalindromeProduct();
        }

        [TestMethod]
        public void Challenge4_LargestPalindromeOfTwo3DigitNumbers_Equals906609()
        {
            var result = _largestPalindromeProduct.Challenge4();

            Assert.AreEqual(906609, result);
        }
    }
}

