using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    class Oval : Figure
    {
        public double SmallDim { get; set; }
        public double BigDim { get; set; }
        public Oval(Point center, double smallDim, double bigDim)
        {
            Coordinate = center;
            SmallDim = smallDim;
            BigDim = bigDim;
        }
        override public void Draw()
        {
            Console.WriteLine(ToString());
            Console.WriteLine("Овал с центром в точке ({0}; {1})\nмаленький диаметр = {2}\nбольшой диаметр = {3}\n", Coordinate.X, Coordinate.Y, SmallDim, BigDim);
        }
    }
}
