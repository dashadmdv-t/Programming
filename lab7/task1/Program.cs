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
            Circle circle = new Circle(2, 4, 4.5);
            Console.WriteLine("Start arguments : 2(x), 4(y), 4.5(r) of circle");
            int n = 10;

            while (true)
            {
                switch (n)
                {
                    case 1:
                        circle++;
                        n = 10;
                        break;
                    case 2:
                        circle--;
                        n = 10;
                        break;
                    case 3:
                        int tmp;
                        Console.WriteLine("Input n\n");
                        while (!int.TryParse(Console.ReadLine(), out tmp) ||
                           tmp > int.MaxValue || tmp < 1) Console.WriteLine("Input correct value");
                        circle += tmp;
                        n = 10;
                        break;
                    case 4:
                        int buf;
                        Console.WriteLine("Input n\n");
                        while (!int.TryParse(Console.ReadLine(), out buf) ||
                           buf > circle.getR() || buf < 1) Console.WriteLine("Input correct value");
                        circle += buf;
                        n = 10;
                        break;
                    case 5:
                        int buf2;
                        Console.WriteLine("Input n\n");
                        while (!int.TryParse(Console.ReadLine(), out buf2) ||
                           buf2 > int.MaxValue || buf2 < 1) Console.WriteLine("Input correct value");
                        circle *= buf2;
                        n = 10;
                        break;
                    case 6:
                        int buf3;
                        Console.WriteLine("Input n\n");
                        while (!int.TryParse(Console.ReadLine(), out buf3) ||
                           buf3 > circle.getR() || buf3 < 1) Console.WriteLine("Input correct value");
                        circle /= buf3;
                        n = 10;
                        break;
                    case 7:
                        double type1 = (double)circle;
                        n = 10;
                        break;
                    case 8:
                        Circle type2 = (Circle)circle.getR();
                        n = 10;
                        break;
                    case 9:
                        return;
                        break;
                    case 10:
                        Console.Clear();

                        Console.WriteLine(
                            $"circle - {circle.ToString()}\n"
                            );

                        Console.WriteLine(
                            "Choose operator\n" +
                            "1. ++\n" +
                            "2. --\n" +
                            "3. + \n" +
                            "4. - \n" +
                            "5. * \n" +
                            "6. / \n" +
                            "7. double()\n" +
                            "8. Circle()\n" +
                            "9. exit "
                            );

                        while (!int.TryParse(Console.ReadLine(), out n) ||
                           n > 9 || n < 1) Console.WriteLine("Input correct value in range[1,8]");

                        break;

                }
            }


            double y = (double)circle;
            Console.WriteLine($"{y}");
            Circle newCircle = (Circle)y;
            Console.WriteLine($"{newCircle}");
            Console.ReadKey();
        }
    }
}
