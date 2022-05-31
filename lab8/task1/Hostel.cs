using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    interface IRate
    {
        int rate();
        void showRate();
    }

    public class Rate : IRate
    {
        private int cost;

        public Rate(int cost)
        {
            this.cost = cost;
        }

        public int rate()
        {
            return this.cost;
        }

        public void showRate()
        {
            Console.WriteLine($"cost - {cost}");
        }
    }

    public class DiscountRate : IRate
    {
        private int cost;
        private int discount;

        public DiscountRate()
        {

        }

        public DiscountRate(int cost, int discount)
        {
            this.cost = cost;
            this.discount = discount;
        }

        public int rate()
        {
            return cost * discount / 100;
        }

        public void showRate()
        {
            Console.WriteLine($"cost - {cost} discount - {discount} cost with discount - {cost * discount / 100}");
        }
    }

    public class Number
    {
        private Rate rate;
        private DiscountRate discRate;
        private int number;

        public Number(Rate rate, DiscountRate discRate, int number)
        {
            this.rate = rate;
            this.discRate = discRate;
            this.number = number;
        }

        public static int getDiscountedPrice(int price, int percent)
        {
            return price * percent / 100;
        }

        public Rate getRate()
        {
            return rate;
        }

        public DiscountRate GetDiscountRate()
        {
            return discRate;
        }

        public int getNumber()
        {
            return number;
        }
    }

    public class Hostel
    {
        private static Hostel hostel = null;
        private string HostelName;

        private List<Number> list = new List<Number>();

        protected Hostel(string name)
        {
            this.HostelName = name;
        }

        public static Hostel Initialize(string name)
        {
            if (hostel == null)
                hostel = new Hostel(name);

            return hostel;
        }

        public void Add()
        {
            Console.WriteLine("Input number of number");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) ||
                n > int.MaxValue || n < 0) Console.WriteLine("Input correct value of cost");

            foreach (var c in list)
            {
                if (c.getNumber() == n)
                {
                    Console.WriteLine("You already have room with such number, do it agin");
                    return;
                }
            }

            Console.WriteLine("Input cost of living in number for 24 hours");
            int tmp;
            while (!int.TryParse(Console.ReadLine(), out tmp) ||
                tmp > int.MaxValue || tmp < 0) Console.WriteLine("Input correct value of cost");

            Rate item = new Rate(tmp);
            Number it = new Number(item, null, n);
            list.Add(it);
        }

        public void AddWithDiscount()
        {
            Console.WriteLine("Input number of number");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) ||
                n > int.MaxValue || n < 0) Console.WriteLine("Input correct value of cost");

            foreach (var c in list)
            {
                if (c.getNumber() == n)
                {
                    Console.WriteLine("You already have room with such number, do it agin");
                    return;
                }
            }

            Console.WriteLine("Input cost of living in number for 24 hours");
            int tmp;
            while (!int.TryParse(Console.ReadLine(), out tmp) ||
                tmp > int.MaxValue || tmp < 0) Console.WriteLine("Input correct value of cost");

            int disc;
            Console.WriteLine("Input discount in %");
            while (!int.TryParse(Console.ReadLine(), out disc) ||
                disc > 99 || disc < 1) Console.WriteLine("Input correct value of discount");

            DiscountRate discRate = new DiscountRate(tmp, disc);
            Number it = new Number(null, discRate, n);
            list.Add(it);
        }

        public static int getAverangeCost(params int[] a)
        {
            int sum = 0;
            foreach (var item in a)
            {
                sum += item;
            }
            return sum / a.Length;
        }

        public int AverangeCost()
        {
            int averange = 0;
            int k = 0;
            foreach (var item in list)
            {
                if (item.GetDiscountRate() != null)
                {
                    averange += item.GetDiscountRate().rate();
                }
                else
                {
                    averange += item.getRate().rate();
                }
                k++;
            }

            return averange / k;
        }

        public void print()
        {
            Console.Clear();
            int i = 1;
            foreach (var item in list)
            {
                if (item.GetDiscountRate() != null)
                {
                    Console.WriteLine($"\nRoom #{i}");
                    Console.WriteLine(
                   $"room number - {item.getNumber()} "
                   );
                    item.GetDiscountRate().showRate();
                }
                else
                {
                    Console.WriteLine($"\nRoom #{i}");
                    Console.WriteLine(
                   $"room number - {item.getNumber()} "
                   );
                    item.getRate().showRate();
                }
                i++;
            }
        }
    }

}
