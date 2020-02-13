using System;
using System.Collections.Generic;
using System.Text;
using Euler100Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler100.Tests
{
        [TestClass]
        public class LargestPrimeFactorOfLongNumber
        {
            private readonly LargestPrimeFactor _largestPrimeFactor;

            public LargestPrimeFactorOfLongNumber()
            {
                _largestPrimeFactor = new LargestPrimeFactor();
            }

            [TestMethod]
            public void Challenge3_LargestPrimeFactor_Equals6857()
            {
                var result = _largestPrimeFactor.Challenge3(600851475143);

                Assert.AreEqual(6857, result);
            }
        }
}
