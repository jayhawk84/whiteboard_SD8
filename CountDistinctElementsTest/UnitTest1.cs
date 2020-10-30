using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountDistinctElements;

namespace CountDistinctElementsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCountDistinct_Jenny()
        {
            int[] myTestNumbers = { 8, 6, 7, 5, 3, 0, 9 };
            Assert.AreEqual(7, DistinctElements.CountDistinct(myTestNumbers));                      
        }

        public void TestCountDistinct_ZIP()
        {
            int[] myTestNumbers = { 9, 2, 1, 0, 1 };
            Assert.AreEqual(4, DistinctElements.CountDistinct(myTestNumbers));
        }
    }
}
