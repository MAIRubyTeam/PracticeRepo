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
            : base(center)
        {
            SmallDim = smallDim;
            BigDim = bigDim;
        }
        public void Draw()
        {
            Console.Write(ToString() + " have coordinates: ");
            Console.WriteLine("({0}; {1}) and small diameter = {2}, big diameter = {3}", Coordinate.X, Coordinate.Y, SmallDim, BigDim);
        }
    }
}
