using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Circle
    {
        private int x;
        private int y;
        private double R;

        public Circle(int x, int y, double R)
        {
            this.x = x;
            this.y = y;
            this.R = R;
        }

        static public double Perimetr(double R)
        {
            return 2 * 3.14 * R;
        }

        static public double Square(double R)
        {
            return 3.14 * R * R;
        }

        public override string ToString()
        {
            return R.ToString();
        }

        public static Circle operator ++(Circle circle)
        {
            return new Circle(circle.x, circle.y, circle.R + 1);
        }

        public static Circle operator --(Circle circle)
        {
            if (circle.R - 1 > 0)
            {
                return new Circle(circle.x, circle.y, circle.R - 1);
            }
            return new Circle(circle.x, circle.y, 0);
        }

        public static Circle operator +(Circle circle, int d)
        {
            return new Circle(circle.x, circle.y, circle.R + d);
        }

        public static Circle operator -(Circle circle, int d)
        {
            return new Circle(circle.x, circle.y, circle.R - d);
        }

        public static Circle operator *(Circle circle, int d)
        {
            return new Circle(circle.x, circle.y, circle.R * d);
        }

        public static Circle operator /(Circle circle, int d)
        {
            return new Circle(circle.x, circle.y, circle.R / d);
        }

        public static bool operator !=(Circle c1, Circle c2)
        {
            return c1.R == c2.R;
        }

        public static bool operator ==(Circle c1, Circle c2)
        {
            return c1.R == c2.R;
        }
        public static explicit operator double(Circle circle)
        {
            return circle.R;
        }

        public static explicit operator Circle(double R)
        {
            return new Circle(0, 0, R);
        }

        public double getR()
        {
            return this.R;
        }
    }
}
