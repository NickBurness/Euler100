using Euler100Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler100.Tests
{
    [TestClass]
    public class MultiplesOf3And5Below1000
    {
        private readonly MultiplesOf3And5 _multiplesOf3And5;

        public MultiplesOf3And5Below1000()
        {
            _multiplesOf3And5 = new MultiplesOf3And5();
        }

        [TestMethod]
        public void Challenge1_Returns233168()
        {
            var result = _multiplesOf3And5.Challenge1();

            Assert.AreEqual(233168, result);
        }
    }
}
