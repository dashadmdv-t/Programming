using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;
using System;
using System.Collections.Generic;
using System.Text;

namespace task1.Tests
{
    [TestClass()]
    public class AirportTests
    {
        [TestMethod()]
        public void CashTest_10_5()
        {
            Airport a = Airport.GetInstance();

            a.SetSold(10);
            a.SetCost(5);
            int actual = a.Cash();
            int expected = 50;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void CashTest_5_5()
        {
            Airport a = Airport.GetInstance();
            a.SetSold(5);
            a.SetCost(5);
            int actual = a.Cash();
            int expected = 25;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void CashTest_2_19()
        {
            Airport a = Airport.GetInstance();
            a.SetSold(2);
            a.SetCost(19);
            int actual = a.Cash();
            int expected = 38;
            Assert.AreEqual(expected, actual);
        }
    }
}