using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
        class Figure
        {
            private Point coordinate;

            public Point Coordinate
            {
                get { return coordinate; }
                set { coordinate = value; }
            }
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

            public Figure(Point point)
            {
                Coordinate = point;
            }

            public Figure(Point[] verteces)
            {
                Verteces = verteces;
            }
            public void Draw()
	        {
		        Console.Write(ToString() + " have coordinates: ");
                foreach (Point Coordinate in verteces)
                {
                    Console.Write("({0}, {1})", Coordinate.X, Coordinate.Y);
                }
                Console.WriteLine();
	        }
        }
    }

