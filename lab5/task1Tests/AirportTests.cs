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
        public void CashTest_1()
        {
            Airport airport = Airport.GetInstance();
            Tariff.AddTariff(1, "Minsk", "Moscow", 1);
            airport.AddTicket(1, "Pasha", "HB658283", "MALE");
            int expected = 1;
            int actual = airport.Cash();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void CashTest_3()
        {
            Airport airport = Airport.GetInstance();
            Tariff.AddTariff(1, "Minsk", "Moscow", 1);
            Tariff.AddTariff(2, "Minsk", "London", 2);
            airport.AddTicket(1, "Pasha", "HB658283", "MALE");
            airport.AddTicket(2, "Pasha", "HB658283", "MALE");
            int expected = 3;
            int actual = airport.Cash();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void CostPersonTest_1()
        {
            Airport airport = Airport.GetInstance();
            Tariff.AddTariff(1, "Minsk", "Moscow", 1);
            airport.AddTicket(1, "Pasha", "HB658283", "MALE");
            int expected = 1;
            int actual = airport.CostPerson("Pasha");
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void CostPersonTest_3()
        {
            Airport airport = Airport.GetInstance();
            Tariff.AddTariff(1, "Minsk", "Moscow", 1);
            Tariff.AddTariff(2, "Minsk", "London", 2);
            airport.AddTicket(1, "Pasha", "HB658283", "MALE");
            airport.AddTicket(2, "Pasha", "HB658283", "MALE");
            int expected = 3;
            int actual = airport.CostPerson("Pasha");
            Assert.AreEqual(expected, actual);
        }
    }
}