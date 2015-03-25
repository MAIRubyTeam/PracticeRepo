using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Square:Rectangle
    {
        public Square(Point p1, Point p2, Point p3, Point p4)
            : base(new Point[] { p1, p2, p3, p4 })
        {

        }

        public Square(Point[] verteces)
            : base(verteces)
        {
            Verteces = verteces;            
        }
    }
}
