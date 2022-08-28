// вариант 3

using System;
using task2.Services;

namespace task2
{
    class Task2
    {
        static void Main(string[] args)
        {
		Console.WriteLine("i definitely need help :cccc");

		Console.WriteLine("i don't understand git");

            while (true)
            {
                Console.WriteLine("Введите z, b");
                double z, b;
                try
                {
                    z = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неверное значение! Попробуйте снова!");
                    continue;
                }


                Console.WriteLine("y = " + Calc.CountY(z, b));
                Console.WriteLine("Вычисления производились по " + Calc.branch + " ветке");

                short choice;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("1. Продолжить" + "\n" + "2. Закончить");
                        choice = Convert.ToInt16(Console.ReadLine());

                        if (choice != 1 && choice != 2)
                        {
                            Console.WriteLine("Такого пункта в меню нет! Попробуйте еще раз!");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Такого пункта в меню нет! Попробуйте еще раз!");
                        continue;
                    }
                }

                switch (choice)
                {
                    case 1:
                        continue;

                    case 2:
                        break;

                }
                break;
            }
        }
    }
}
