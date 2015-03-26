using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    class Circle : Oval
    {
        public double Radius { get; set; }
        public Circle(Point center, double radius):base(center, 0, 0)
        {
            Radius = radius;
        }        

        public void Draw()
        {
            Console.Write(ToString() + " have coordinates: ");
            Console.WriteLine("({0}; {1}) and radius {2}", Coordinate.X, Coordinate.Y, Radius);
        }
    }
}
