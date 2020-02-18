using System;
using System.Collections.Generic;
using System.Text;
using Euler100Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler100.Tests
{
    [TestClass]
    public class PrimeNumberTenThousandAndOneIsCorrect
    {
        private readonly Prime10001 _prime10001;

        public PrimeNumberTenThousandAndOneIsCorrect()
        {
            _prime10001 = new Prime10001();
        }

        [TestMethod]
        public void PrimeNumberTenThousandAndOneIs_104759()
        {
            var result = _prime10001.Challenge7();

            Assert.AreEqual(104759, result);
        }
    }
}
