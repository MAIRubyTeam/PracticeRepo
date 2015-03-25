using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class DistanceCalculator
    {
        private int x1, x2, y1, y2;
        public DistanceCalculator(Point p1, Point p2)
        {
            x1 = p1.X;
            x2 = p2.X;
            y1 = p1.Y;
            y2 = p2.Y;
        }

        public string getDistance()
        {
            return String.Format("Расстояние между точками ({0},{1}) и ({2},{3}) равно {4}", x1,y1,x2,y2,Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
        }
    }
}
