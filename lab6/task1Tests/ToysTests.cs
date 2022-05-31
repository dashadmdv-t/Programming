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

            Shark akula = new Shark(300);

            int expected = 500000;
            int actual = akula.cost;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {

            Ball myach = new Ball(1990, "Football World Cup 1996");

            string expected = "Black-White";
            string actual = myach.color;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Robot robo = new Robot(100);

            string expected = "Delivery Robot";
            string actual = robo.name;

            Assert.AreEqual(expected, actual);
        }
    }
}
