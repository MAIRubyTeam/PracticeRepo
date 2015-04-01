using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    class Point
    {

        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public void Draw()
        {
            Console.Write(ToString() + " have coordinates: ");
            Console.Write("({0}; {1})", X, Y);
            Console.WriteLine();
        }

        public double GetDistanceBetweenPoints(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        public double GetDistanceToPoint(Point p)
        {
            return GetDistanceBetweenPoints(this, p);
        }

        public double XShift(double x)
        {
           return X += x;
        }

        public double YShift(double y)
        {
            return Y += y;
        }        
    }
}       

