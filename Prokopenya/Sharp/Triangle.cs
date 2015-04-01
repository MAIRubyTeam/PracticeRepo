
using System;
namespace AbstractFigure
{
    class Triangle:Polygon
    {
        public Triangle(Point[] verteces)
            : base(verteces)
        {
          //  if (verteces.Length != 3)
           // {
          //      throw new Exception("@@");
          //  }

            if ((Verteces[2].X == Verteces[0].X) || (Verteces[2].Y == Verteces[0].Y)) //х2-х1=х3-х1, у2-у1=у3-у1, z2-z1=z3-z1. ноль
            {
                throw new Exception("Точки совпадают");
            }
            else if ((Verteces[1].X - Verteces[0].X == Verteces[2].X - Verteces[0].X) && (Verteces[1].Y - Verteces[0].Y == Verteces[2].Y - Verteces[0].Y))
            {
                throw new Exception("Точки совпадают");
            }
            if ((Verteces[1].X - Verteces[0].X) / (Verteces[2].X - Verteces[0].X) ==
                (Verteces[1].Y - Verteces[0].Y) / (Verteces[2].Y - Verteces[0].Y))
                throw new Exception("Точки лежат на одной прямой");
        }

        public Triangle(Point a, Point b, Point c) : this(new Point[] { a, b, c }) { }
    }
}
