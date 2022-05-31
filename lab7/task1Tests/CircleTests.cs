using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;
using System;
using System.Collections.Generic;
using System.Text;

namespace task1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Circle.Perimetr(4), 25.12);
        }


        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Circle.Square(4), 50.24);
        }


        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(Circle.Square(5), 78.50);
        }
    }
}