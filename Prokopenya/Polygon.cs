using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    class Polygon:Figure
    {
        private Point[] verteces;
        public Point[] Verteces { get; set; }

        public Polygon(Point[] verteces):base(new Point(0,0))
        {
            Verteces = verteces;
        }

        public void Draw()
        {
            Console.WriteLine(ToString());
            if (Verteces.Length != 3)
                Console.WriteLine("Многоугольник с координатами: ");
            else
                Console.WriteLine("Треугольние с координатами: ");
            foreach (Point point in Verteces)
            {
                Console.WriteLine("({0}; {1})", point.X, point.Y);
            }
            Console.WriteLine();
        }
    }
}
