using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Point center = new Point(3.1, 2.7);

            Point[] coordinates = { new Point(0, 1), new Point(1, 1), new Point(1, 0), new Point(0, 0), new Point(-1, -2) };

            Figure figure = new Figure(center);
            figure.Draw();        

            Polygon polygon = new Polygon(coordinates);
            polygon.Draw();

            Rectangle rectangle = new Rectangle(coordinates);
            rectangle.Draw();

            Square square = new Square(coordinates);
            square.Draw();
            
            Triangle triangle = new Triangle(coordinates);
            triangle.Draw();

            Oval oval = new Oval(center, 6.2, 9.4);
            oval.Draw();

            Circle circle = new Circle(center, 10.0);
            circle.Draw();

            Console.ReadKey();
        }
    }
}
