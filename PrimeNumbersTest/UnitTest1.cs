using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumbersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(PrimeNumbers.PrimeNumbers.PrimeTest(4));
        }
    }
}
