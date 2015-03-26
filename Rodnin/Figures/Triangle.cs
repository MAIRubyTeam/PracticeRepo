using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    class Triangle:Polygon
    {
        public Triangle(Point p1, Point p2, Point p3)
            : base(new Point[] { p1, p2, p3 })
        {

        }
    }
}
