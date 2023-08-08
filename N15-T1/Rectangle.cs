using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N15_T1
{
    public class Rectangle
    {
        public Rectangle(Point a, Point b, Point c, Point d)
        {
            A = a; B = b;
            C = c; D = d;
        }

        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Point D { get; set; }


        public double AB { get => Get }





        private double GEtLength(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow((a.Y - b.Y), 2));
        }
    }
}
