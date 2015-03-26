using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AbstractFigure
{
    class Rectangle:Polygon
    {
        public Point LeftTop { get; set; }
        public Point RightBottom { get; set; }
        public double Height { get; set; }

        public Rectangle(Point[] verteces):base(verteces)
        {
            LeftTop = verteces[0];
            RightBottom = verteces[1];
            Height = verteces[0].GetDistanceToPoint(new Point(LeftTop.X, RightBottom.Y));
        }

        public void Draw()
        {
            Console.Write(ToString() + " have coordinates: ");
            Console.WriteLine(" LeftTop ({0}; {1}), RightBottom ({2}; {3}) LeftBottom ({0};{4}), RightTop ({2}; {5}) ",
                LeftTop.X, LeftTop.Y, RightBottom.X, RightBottom.Y, (LeftTop.Y - Height), (RightBottom.Y+Height) );
        }
    }
}
