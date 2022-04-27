// вариант 4

using System;

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

        public int Cash()
        {
            return sold * ticket.GetCost();
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

        public void SetCost(int n)
        {
            ticket.SetCost(n);
        }
    }

    public class Ticket
    {
        public Ticket()
        {

        }
        public Ticket(int n)
        {
            SetCost(n);
            FirstCost = n;
        }

        private static int cost;
        private static int FirstCost = 0;

        public void SetCost(int n)
        {
            cost = n;
            if (FirstCost == 0)
            {
                FirstCost = n;
            }
        }

        public void SetCost()
        {
            cost = FirstCost;
        }

        public int GetCost()
        {
            return cost;
        }
    }

    class Task1
    {
        static void Main(string[] args)
        {
            
        }
    }
}
