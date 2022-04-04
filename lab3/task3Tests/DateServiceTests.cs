using Microsoft.VisualStudio.TestTools.UnitTesting;
using dateservice;
using System;
using System.Collections.Generic;
using System.Text;

namespace dateservice.Tests
{
    [TestClass]
    public class DateServiceTests
    {
        [TestMethod]
        public void GetDayTest_1()
        {
            string d = "04.04.2022";
            string actual = DateService.GetDay(d);
            string expected = "This is Monday";
            Assert.AreEqual(expected, actual, "Test for 04.04.2022 has failed!");
        }


        [TestMethod]
        public void GetDayTest_2()
        {
            string d = "29.07.2004";
            string actual = DateService.GetDay(d);
            string expected = "This is Thursday";
            Assert.AreEqual(expected, actual, "Test for 29.07.2004 has failed!");
        }


        [TestMethod]
        public void GetDayTest_3()
        {
            string d = "15.04.2022";
            string actual = DateService.GetDay(d);
            string expected = "This is Friday";
            Assert.AreEqual(expected, actual, "Test for 15.04.2022 has failed!");
        }


        [TestMethod]
        public void GetDaysSpanTest_1()
        {
            int day = 5, month = 4, year = 2022;
            string actual = DateService.GetDaysSpan(day, month, year);
            string expected = "1 days in between";
            Assert.AreEqual(expected, actual, "Test for 05.04.2022 has failed!");
        }


        [TestMethod]
        public void GetDaysSpanTest_2()
        {
            int day = 15, month = 4, year = 2022;
            string actual = DateService.GetDaysSpan(day, month, year);
            string expected = "11 days in between";
            Assert.AreEqual(expected, actual, "Test for 15.04.2022 has failed!");
        }


        [TestMethod]
        public void GetDaysSpanTest_3()
        {
            int day = 4, month = 4, year = 2022;
            string actual = DateService.GetDaysSpan(day, month, year);
            string expected = "0 days in between";
            Assert.AreEqual(expected, actual, "Test for 04.04.2022 has failed!");
        }
    }
}