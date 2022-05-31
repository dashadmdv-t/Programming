using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Number.getDiscountedPrice(40, 50));
            Console.WriteLine("Input name of hostel");
            Hostel hostel = Hostel.Initialize(Console.ReadLine());

            int n = 6;
            bool status = true;

            while (status)
            {
                switch (n)
                {
                    case 1:
                        hostel.Add();
                        n = 6;
                        break;
                    case 2:
                        hostel.AddWithDiscount();
                        n = 6;
                        break;
                    case 3:
                        Console.Clear();
                        hostel.print();
                        n = 6;
                        break;
                    case 4:
                        Console.WriteLine($"Averange profit from your hostel - {hostel.AverangeCost()}");
                        n = 6;
                        break;
                    case 5:
                        return;
                    case 6:
                        Console.WriteLine(
                            "\nChoose what you want to do\n" +
                            "1 - add number\n" +
                            "2 - add discount\n" +
                            "3 - print list of numbers\n" +
                            "4 - calc averange cost\n" +
                            "5 - exit\n"
                            );

                        while (!int.TryParse(Console.ReadLine(), out n) ||
                            n > 5 || n < 1) Console.WriteLine("Input correct value in range[1,5]");
                        break;

                }
            }
        }
    }
}
