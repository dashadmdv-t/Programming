using Microsoft.VisualStudio.TestTools.UnitTesting;
using task2;

namespace task2.Tests
{
    [TestClass]
    public class Task2Tests
    {
        [TestMethod]
        public void IsInside1()
        {
            double x = - 10, y = 15;

            Task2 t = new Task2();
            int actual = t.IsInside(x, y);
            int expected = 1;
            Assert.AreEqual(expected, actual, "Test (-10, 15) has failed!\n");
        }

        [TestMethod]
        public void IsInside2()
        {
            double x = -4, y = 10;

            Task2 t = new Task2();
            int actual = t.IsInside(x, y);
            int expected = 1;
            Assert.AreEqual(expected, actual, "Test (-4, 10) has failed!\n");
        }

        [TestMethod]
        public void IsOutside1()
        {
            double x = 12, y = 10;

            Task2 t = new Task2();
            int actual = t.IsInside(x, y);
            int expected = 3;
            Assert.AreEqual(expected, actual, "Test (12, 10) has failed!\n");
        }

        [TestMethod]
        public void IsOutside2()
        {
            double x = -23, y = 25;

            Task2 t = new Task2();
            int actual = t.IsInside(x, y);
            int expected = 3;
            Assert.AreEqual(expected, actual, "Test (-23, 25) has failed!\n");
        }

        [TestMethod]
        public void IsOnBoundary1()
        {
            double x = -10, y = 23;

            Task2 t = new Task2();
            int actual = t.IsInside(x, y);
            int expected = 2;
            Assert.AreEqual(expected, actual, "Test (-10, 23) has failed!\n");
        }

        [TestMethod]
        public void IsOnBoundary2()
        {
            double x = -4, y = 4;

            Task2 t = new Task2();
            int actual = t.IsInside(x, y);
            int expected = 2;
            Assert.AreEqual(expected, actual, "Test (-4, 4) has failed!\n");
        }

        [TestMethod]
        public void IsOnBoundary3()
        {
            double x = 0, y = 15;

            Task2 t = new Task2();
            int actual = t.IsInside(x, y);
            int expected = 2;
            Assert.AreEqual(expected, actual, "Test (0, 15) has failed!\n");
        }
    }
}
