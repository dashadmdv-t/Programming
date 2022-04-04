using System;
using System.Collections.Generic;
using System.Text;

namespace task2.Services
{
    public class Calc
    {
        static public int branch;
        static public double CountY(double z, double b)
        {
            double x;
            if(z < 1)
            {
                x = z / b;
                branch = 1;
            }
            else
            {
                x = Math.Sqrt(Math.Pow(z * b, 3));
                branch = 2;
            }

            double y = -Math.PI + Math.Pow(Math.Cos(x * x * x), 2) + Math.Pow(Math.Sin(x * x), 2);

            return y;
        }
    }
}
