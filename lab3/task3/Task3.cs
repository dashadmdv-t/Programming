using System;
using dateservice;

namespace task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            while (true)
            {
                short choice_f;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Выберите функцию:");
                        Console.WriteLine("1. Определить день недели" + "\n" + 
                            "2. Определить количество дней между введенной датой и сегодняшним днем");
                        choice_f = Convert.ToInt16(Console.ReadLine());

                        if (choice_f != 1 && choice_f != 2)
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

                

                switch (choice_f)
                {
                    case 1:
                        Console.WriteLine("Введите дату");
                        string date;
                        date = Convert.ToString(Console.ReadLine());
                        DateService.GetDay(date);
                        break;

                    case 2:
                        Console.WriteLine("Введите день, месяц и год");
                        int day, month, year;
                        while (true)
                        {
                            try
                            {
                                day = Convert.ToInt32(Console.ReadLine());
                                month = Convert.ToInt32(Console.ReadLine());
                                year = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Неверное значение! Попробуйте снова!");
                                continue;
                            }

                            DateService.GetDaysSpan(day, month, year);
                            break;
                        }
                        break;

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
