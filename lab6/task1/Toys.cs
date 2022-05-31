using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public abstract class Toys
    {
        public abstract int cost { get; }
        public abstract string name { get; }
        public abstract string color { get; }

        public abstract void View();

        public void ShowInfo()
        {
            Console.WriteLine($"Type - {this.GetType()}");
        }

    }

    public class Robot : Toys
    {

        private int LevelOfSmart;

        public Robot(int smart)
        {
            this.LevelOfSmart = smart;
        }
        public override int cost { get { return 50; } }

        public override string name { get { return "Delivery Robot"; } }

        public override string color { get { return "Grey"; } }

        public override void View()
        {
            ShowInfo();
            Console.WriteLine(
                $"cost - {this.cost}\n" +
                $"name - {this.name}\n" +
                $"color - {this.color}\n" +
                $"smart level - {this.LevelOfSmart}\n"
                );
        }
    }

    public class Barbie : Toys
    {
        private int LevelOfBeauty;

        public Barbie(int beauty)
        {
            this.LevelOfBeauty = beauty;
        }
        public override int cost { get { return 25; } }

        public override string name { get { return "Barbie Girl"; } }

        public override string color { get { return "Pink"; } }

        public override void View()
        {
            ShowInfo();
            Console.WriteLine(
                $"cost - {this.cost}\n" +
                $"name - {this.name}\n" +
                $"color - {this.color}\n" +
                $"smart level - {this.LevelOfBeauty}\n"
                );
        }
    }

    public class Shark : Toys
    {
        private int Speed;

        public Shark(int speed)
        {
            this.Speed = speed;
        }
        public override int cost { get { return 500000; } }

        public override string name { get { return "Shark from IKEA"; } }

        public override string color { get { return "Blue"; } }

        public override void View()
        {
            ShowInfo();
            Console.WriteLine(
                $"cost - {this.cost}\n" +
                $"name - {this.name}\n" +
                $"color - {this.color}\n" +
                $"smart level - {this.Speed}\n"
                );
        }
    }

    public class Ball : Toys
    {

        private int YearOfCreating;
        private string History;

        public Ball(int year, string history)
        {
            this.YearOfCreating = year;
            this.History = history;
        }
        public override int cost { get { return 10; } }

        public override string name { get { return "Football ball"; } }

        public override string color { get { return "Black-White"; } }

        public override void View()
        {
            ShowInfo();
            Console.WriteLine(
                $"cost - {this.cost}\n" +
                $"name - {this.name}\n" +
                $"color - {this.color}\n" +
                $"year - {this.YearOfCreating}\n" +
                $"history - {this.History}\n"
                );
        }
    }

    class Player
    {
        public Player()
        {

        }

        public void Play(Toys toy)
        {
            toy.View();
        }
    }
}
