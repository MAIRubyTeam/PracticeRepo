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
            Console.Write(ToString() + " have coordinates: ");
            Console.Write("({0}; {1})", Coordinate.X, Coordinate.Y);
            Console.WriteLine();
        }
    }
}
