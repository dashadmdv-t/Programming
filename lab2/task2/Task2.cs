// вариант 35 % 18 = 17

using System;

namespace task2
{
    public class Task2
    {

        public int IsInside(double x, double y)
        {
            if(x > -23 && x < 0 && y > -x && y < 23)
            {
                return 1;
            }
            else if ((x >= -23 && x <= 0 && (y == 23 || y == -x)) || (x == 0 && y >= 0 && y <= 23))
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Введите координаты точки x, y");
                double x, y;
                try
                {
                    x = Convert.ToDouble(Console.ReadLine());
                    y = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Неверное значение! Попробуйте снова!");
                    continue;
                }
                Task2 t = new Task2();
                if (t.IsInside(x, y) == 1)
                {
                    Console.WriteLine("Да");
                }
                else if (t.IsInside(x, y) == 2)
                {
                    Console.WriteLine("На границе");
                }
                else
                {
                    Console.WriteLine("Нет");
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
