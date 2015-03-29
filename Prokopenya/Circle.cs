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

        override public void Draw()
        {
            Console.WriteLine(ToString());
            Console.WriteLine("Круг с центром в точке ({0}; {1})\nрадиус {2}", Coordinate.X, Coordinate.Y, Radius);
        }
    }
}
