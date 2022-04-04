using Microsoft.VisualStudio.TestTools.UnitTesting;
using func;
using System;
using System.Collections.Generic;
using System.Text;

namespace func.Tests
{

    [TestClass]
    public class FuncTests
    {
        [TestMethod]
        public void F_nTest10()
        {
            //int n = 0;
            int actual = Func.F_n(10);
            int expected = 100;
            Assert.AreEqual(expected, actual, "Test for 0 has failed!\n");
        }


        [TestMethod]
        public void F_nTest4()
        {
            //int n = 4;
            int actual = Func.F_n(4);
            int expected = 16;
            Assert.AreEqual(expected, actual, "Test for 4 has failed!\n");
        }


        [TestMethod]
        public void F_nTest9()
        {
            //int n = 9;
            int actual = Func.F_n(9);
            int expected = 81;
            Assert.AreEqual(expected, actual, "Test for 9 has failed!\n");
        }

        [TestMethod]
        public void F_nTest14()
        {
            //int n = 14;
            int actual = Func.F_n(14);
            int expected = 196;
            Assert.AreEqual(expected, actual, "Test for 14 has failed!\n");
        }


        [TestMethod]
        public void F_nTest5()
        {
            //int n = 5;
            int actual = Func.F_n(5);
            int expected = 25;
            Assert.AreEqual(expected, actual, "Test for 5 has failed!\n");
        }
    }
}