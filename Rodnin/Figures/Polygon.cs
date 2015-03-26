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
        public Point[] Verteces
        {
            get { return verteces; }
            set
            {
                if (verteces == null || verteces.Length < 3)
                {
                    verteces = new Point[] { new Point(0, 0), new Point(1, 0), new Point(0, 1) };
                    verteces = value;
                    return;
                }
                verteces = value;
            }
        }
        public Polygon(Point[] verteces):base(new Point(0,0))
        {
            Verteces = verteces;
        }

        public void Draw()
        {
            Console.Write(ToString() + " have coordinates: ");
            foreach (Point point in Verteces)
            {
                Console.Write("({0}; {1})", point.X, point.Y);
            }
            Console.WriteLine();
        }
    }
}
