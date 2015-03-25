using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Polygon:Figure
    {
        public Polygon(Point[] verteces):base(verteces)
        {
            Verteces = verteces;
        }

        public void Draw()
        {
            Console.Write(ToString() + " have coordinates: ");
            foreach (Point point in Verteces)
            {
                Console.Write("({0}, {1})", point.X, point.Y);
            }
            Console.WriteLine();
        }
    }
}
