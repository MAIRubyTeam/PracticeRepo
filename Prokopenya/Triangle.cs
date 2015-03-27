
namespace AbstractFigure
{
    class Triangle:Polygon
    {
        public Triangle(Point[] verteces)
            : base(new Point[] { verteces[0], verteces[1], verteces[2] })
        {
        }
    }
}
