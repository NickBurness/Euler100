using System;
using System.Collections.Generic;
using System.Text;
using Euler100Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler100.Tests
{
    [TestClass]
    public class SumSquareDifferenceOfFirstOneHundredNaturalNumbers
    {

        private readonly SumSquareDifference _sumSquareDifference;

        public SumSquareDifferenceOfFirstOneHundredNaturalNumbers()
        {
            _sumSquareDifference = new SumSquareDifference();
        }

        [TestMethod]
        public void SumSquareDifferenceOfFirstOneHundredNaturalNumbers_Returns25164150()
        {
            var result = _sumSquareDifference.Challenge6();

            Assert.AreEqual(25164150, result);
        }
    }
}
