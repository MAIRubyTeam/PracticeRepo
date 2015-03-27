using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    class Figure
    {
        private Point coordinate;
        public Point Coordinate { get; set; }
        
        public Figure(Point point)
        {
            Coordinate = point;
        }

        public void Draw()
        {
            Console.WriteLine(ToString());
            Console.Write("Фигура в центре с точкой ");
            Console.Write("({0}; {1})\n", Coordinate.X, Coordinate.Y);
            Console.WriteLine();
        }
    }
}
