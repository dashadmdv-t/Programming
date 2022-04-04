using Microsoft.VisualStudio.TestTools.UnitTesting;
using task2.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace task2.Services.Tests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void CountYTest_0_1()
        {
            double z = 0, b = 1;
            double actual = Calc.CountY(z, b);
            double expected = -2.141592653589793;
            Assert.AreEqual(expected, actual, "Test for 0, 1 has failed!");
        }


        [TestMethod]
        public void CountYTest_1_0()
        {
            double z = 1, b = 0;
            double actual = Calc.CountY(z, b);
            double expected = -2.141592653589793;
            Assert.AreEqual(expected, actual, "Test for 1, 0 has failed!");
        }


        [TestMethod]
        public void CountYTest_branch_1()
        {
            double z = 0, b = 1;
            Calc.CountY(z, b);
            int actual = Calc.branch;
            int expected = 1;
            Assert.AreEqual(expected, actual, "Test for 0, 1 branch has failed!");
        }


        [TestMethod]
        public void CountYTest_branch_2()
        {
            double z = 1, b = 0;
            Calc.CountY(z, b);
            int actual = Calc.branch;
            int expected = 2;
            Assert.AreEqual(expected, actual, "Test for 1, 0 branch has failed!");
        }
    }
}