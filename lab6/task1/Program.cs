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
            Player player = new Player();

            Toys[] list = { new Robot(100), new Barbie(77), new Shark(300), new Ball(1990, "Football World Cup 1996") };

            foreach (var item in list)
            {
                player.Play(item);
            }

            Console.ReadKey();
        }
    }
}
