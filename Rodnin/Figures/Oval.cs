using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Oval:Figure
    {
        public Oval(Point center)
            : base(center)
        {

        }
        public void Draw()
        {
            Console.Write(ToString() + " have coordinates:({0},{1})", Coordinate.X, Coordinate.Y);
            Console.WriteLine();
        }
    }
}
