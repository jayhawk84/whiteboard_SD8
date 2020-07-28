using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5.0, Geometry.Triangle.AreaOfTriangle(5.0, 2.0));
            Assert.AreEqual(5.0, Geometry.Triangle.AreaOfTriangle(2.0, 5.0));
        }
    }
}
