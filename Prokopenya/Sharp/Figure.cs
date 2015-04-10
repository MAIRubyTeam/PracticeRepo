using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    abstract class Figure
    {
        private Point coordinate;
        public Point Coordinate { get; set; }

        public Figure()
        {
        }

        abstract public void Draw();
    }
}
