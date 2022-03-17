using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;

namespace task1Tests
{
    [TestClass]
    public class Task1Tests
    {
        [TestMethod]
        public void TriangleExists1()
        {
            double a = 3, b = 4, c = 5;

            Task1 t = new Task1();
            bool actual = t.IsTriangle(a, b, c);
            bool expected = true;
            Assert.AreEqual(expected, actual, "Test (3, 4, 5) has failed!\n");
        }

        [TestMethod]
        public void TriangleExists2()
        {
            double a = 10, b = 10, c = 10;

            Task1 t = new Task1();
            bool actual = t.IsTriangle(a, b, c);
            bool expected = true;
            Assert.AreEqual(expected, actual, "Test (10, 10, 10) has failed!\n");
        }

        [TestMethod]
        public void TriangleExists3()
        {
            double a = 3.5, b = 5, c = 2.5;

            Task1 t = new Task1();
            bool actual = t.IsTriangle(a, b, c);
            bool expected = true;
            Assert.AreEqual(expected, actual, "Test (3.5, 5, 2.5) has failed!\n");
        }

        [TestMethod]
        public void TriangleDoesntExist1()
        {
            double a = 5, b = 7, c = 12;

            Task1 t = new Task1();
            bool actual = t.IsTriangle(a, b, c);
            bool expected = false;
            Assert.AreEqual(expected, actual, "Test (5, 7, 12) has failed!\n");
        }

        [TestMethod]
        public void TriangleDoesntExist2()
        {
            double a = 1.75, b = 0.5, c = 2.25;

            Task1 t = new Task1();
            bool actual = t.IsTriangle(a, b, c);
            bool expected = false;
            Assert.AreEqual(expected, actual, "Test (1.75, 0.5, 2.25) has failed!\n");
        }

        [TestMethod]
        public void TriangleDoesntExist3()
        {
            double a = 7 / 3, b = 29 / 3, c = 4;

            Task1 t = new Task1();
            bool actual = t.IsTriangle(a, b, c);
            bool expected = false;
            Assert.AreEqual(expected, actual, "Test (7/3, 29/3, 4) has failed!\n");
        }
    }
}