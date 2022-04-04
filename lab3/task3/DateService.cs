using System;
using System.Collections.Generic;
using System.Text;

namespace dateservice
{
    public class DateService
    {

        public static string GetDay(string date)
        {
            DateTime d = Convert.ToDateTime(date);
            Console.WriteLine("This is " + d.DayOfWeek);
            return "This is " + d.DayOfWeek;
        }


        public static string GetDaysSpan(int day, int month, int year)
        {
            DateTime d = new DateTime(year, month, day);
            DateTime today = DateTime.Today;
            Console.WriteLine(d.Subtract(today).Days + " days in between");
            return d.Subtract(today).Days + " days in between";
        }
    }
}
