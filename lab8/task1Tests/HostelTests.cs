using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Number.getDiscountedPrice(230, 50), 115);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Hostel.getAverangeCost(100, 50, 40, 2000, 300, 100, 10, 50, 350, 500), 350);
        }
    }
}
