// вариант 4

using System;
using System.Collections;
using System.Collections.Generic;

namespace task1
{
    public class Airport
    {
        private static Airport instance;
        private Airport()
        { }
        public static Airport GetInstance()
        {
            if (instance == null)
            {
                instance = new Airport();
            }
            return instance;
        }

        private string name;
        private Ticket ticket = new Ticket();
        private int places;
        private int sold;
        public static List<Ticket> tickets = new List<Ticket>();
        public static List<Tariff> tariffs = new List<Tariff>();
        public static List<Person> passengers = new List<Person>();
        public int Cash()
        {
            int cash = 0;
            for (int i = 0; i < tickets.Count; i++)
            {
                cash += tickets[i].GetTariff().GetCost();
            }
            return cash;
        }

        public void AddTicket()
        {
            Ticket tmp = new Ticket();
            if (tariffs.Count == 0)
            {
                Console.WriteLine("Сначала добавьте хотя бы один тариф!");
                Tariff.AddTariff();
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Введите номер тарифа");
                    int t = Convert.ToInt32(Console.ReadLine());
                    bool isExist = false;
                    for (int i = 0; i < tariffs.Count; i++)
                    {
                        if (tariffs[i].GetNumber() == t)
                        {
                            t = i;
                            isExist = true;
                            break;
                        }
                    }
                    if (isExist)
                    {
                        tmp.SetTariff(tariffs[t]);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Такого тарифа нет, давай по новой Миш");
                    }
                }
            }
            

            tmp.SetPerson(Person.AddPerson());
            sold++;
            tickets.Add(tmp);
        }

        public void AddTicket(int t, string name, string passport, string s)
        {
            Ticket tmp = new Ticket();
            tmp.SetTariff(tariffs[t - 1]);
            
            tmp.SetPerson(Person.AddPerson(name, passport, s));
            sold++;
            tickets.Add(tmp);
        }

        public int CostPerson()
        {
            int costPerson = 0;

            Console.WriteLine("Введите имя пассажира");
            string s = Convert.ToString(Console.ReadLine());
            bool isExist = false;
                
            for (int i = 0; i < tickets.Count; i++)
            {
                if (tickets[i].GetPerson().GetName() == s)
                {
                    costPerson += tickets[i].GetTariff().GetCost();
                    isExist = true;
                    break;
                }
            }
            if (isExist)
            {
            }
            else
            {
                Console.WriteLine("Такого пассажира нет, давай по новой Миш");
            }

            return costPerson;
        }

        public int CostPerson(string s)
        {
            int costPerson = 0;

            bool isExist = false;

            for (int i = 0; i < tickets.Count; i++)
            {
                if (tickets[i].GetPerson().GetName() == s)
                {
                    costPerson += tickets[i].GetTariff().GetCost();
                    isExist = true;
                    //break;
                }
            }
            if (isExist)
            {
            }
            else
            {
                Console.WriteLine("Такого пассажира нет, давай по новой Миш");
            }

            return costPerson;
        }

        public string GetName()
        {
            return name;
        }
        public int GetPlaces()
        {
            return places;
        }
        public int GetSold()
        {
            return sold;
        }

        public void SetName(string n)
        {
            name = n;
        }
        public void SetPlaces(int n)
        {
            places = n;
        }
        public void SetSold(int n)
        {
            sold = n;
        }

    }

    public enum PersonSex
    {
        MALE = 1,
        FEMALE = 2
    }
    public class Person 
    {
        private string name;
        private string passport;
        private PersonSex sex;

        public static Person AddPerson()
        {
            Person tmp = new Person();
            Console.WriteLine("Введите имя");
            tmp.SetName(Convert.ToString(Console.ReadLine()));
            Console.WriteLine("Введите паспортные данные");
            tmp.SetPassport(Convert.ToString(Console.ReadLine()));
            Console.WriteLine("Введите пол (MALE или FEMALE)");
            tmp.SetSex(Convert.ToString(Console.ReadLine()));
            Airport.passengers.Add(tmp);
            return tmp;
        }

        public static Person AddPerson(string name, string passport, string s)
        {
            Person tmp = new Person();
            tmp.SetName(name);
            tmp.SetPassport(passport);
            tmp.SetSex(s);
            Airport.passengers.Add(tmp);
            return tmp;
        }

        public void SetName(string n)
        {
            name = n;
        }
        public void SetPassport(string n)
        {
            passport = n;
        }
        public void SetSex(string n)
        {
            if (n == "MALE")
            {
                sex = PersonSex.MALE;
            }
            else if (n == "FEMALE")
            {
                sex = PersonSex.FEMALE;
            }
        }
        public string GetName()
        {
            return name;
        }
        public string GetPassport()
        {
            return passport;
        }
        public PersonSex GetSex()
        {
            return sex;
        }
    }

    public class Tariff
    {
        private int number;
        private string from;
        private string to;
        private int cost;

        public static void AddTariff()
        {
            Tariff tmp = new Tariff();
            Console.WriteLine("Введите номер тарифа");
            tmp.SetNumber(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите пункт отправления");
            tmp.SetFrom(Convert.ToString(Console.ReadLine()));
            Console.WriteLine("Введите пункт прибытия");
            tmp.SetTo(Convert.ToString(Console.ReadLine()));
            Console.WriteLine("Введите стоимость билета на маршрут");
            tmp.SetCost(Convert.ToInt32(Console.ReadLine()));
            Airport.tariffs.Add(tmp);
        }

        public static void AddTariff(int n, string from, string to, int cost)
        {
            Tariff tmp = new Tariff();
            tmp.SetNumber(n);
            tmp.SetFrom(from);
            tmp.SetTo(to);
            tmp.SetCost(cost);
            Airport.tariffs.Add(tmp);
        }
        public void SetNumber(int n)
        {
            number = n;
        }
        public void SetFrom(string n)
        {
            from = n;
        }
        public void SetTo(string n)
        {
            to = n;
        }
        public void SetCost(int n)
        {
            cost = n;
        }
        public int GetNumber()
        {
            return number;
        }
        public string GetFrom()
        {
            return from;
        }
        public string GetTo()
        {
            return to;
        }
        public int GetCost()
        {
            return cost;
        }
    }
    public class Ticket
    {

        private Tariff tariff;
        private Person person;

        public void SetTariff(Tariff n)
        {
            tariff = n;
        }
        public void SetPerson(Person n)
        {
            person = n;
        }

        public Tariff GetTariff()
        {
            return tariff;
        }
        public Person GetPerson()
        {
            return person;
        }
    }

    class Task1
    {
        static void Main(string[] args)
        {
            Airport airport = Airport.GetInstance();
            
            
            while (true)
            {
                
                short choice;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("1. Добавить тариф" + "\n" + "2. Добавить билет и пассажира"
                            + "\n" + "3. Рассчитать стоимость билетов для пассажира"
                            + "\n" + "4. Рассчитать стоимость всех билетов" + "\n" + "5. Выйти");
                        choice = Convert.ToInt16(Console.ReadLine());

                        if (choice != 1 && choice != 2 && choice != 3 && choice != 4 && choice != 5)
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
                        Tariff.AddTariff();
                        break;

                    case 2:
                        airport.AddTicket();
                        break;

                    case 3:
                        Console.WriteLine(airport.CostPerson());
                        break;

                    case 4:
                        Console.WriteLine(airport.Cash());
                        break;

                    case 5:
                        break;

                }
                if (choice == 5)
                {
                    break;
                }
            }
            
        }
    }
}
