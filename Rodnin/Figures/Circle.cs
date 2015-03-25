using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle:Oval
    {
        public Circle(Point center, int radius)
            : base(center)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public void Draw()
        {
            Console.Write(ToString() + " have coordinates:({0},{1}) and radius {2}", Coordinate.X, Coordinate.Y, Radius);
            Console.WriteLine();
        }
    }
}
