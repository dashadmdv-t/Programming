// вариант 35 % 19 = 16

using System;

namespace task1
{
    public class Task1
    {
        public bool IsTriangle(double a, double b, double c)
        {
            if (a + b > c && b + c > a && a + c > b)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void Main()
        {

	Console.WriteLine("HELLO WORLD!!!");
		
            while (true)
            {
                Console.WriteLine("Введите длины сторон a, b, c");
                double a, b, c;
                try
                {
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    c = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неверное значение! Попробуйте снова!");
                    continue;
                }
                Task1 t = new Task1();
                if (t.IsTriangle(a, b, c))
                {
                    Console.WriteLine("Существует");
                }
                else
                {
                    Console.WriteLine("Не существует");
                }

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