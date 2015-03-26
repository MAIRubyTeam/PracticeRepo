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
            Point p1 = new Point(3.1, 2.7);
            Point p2 = new Point(1.1, 4.8);
            Point[] vertPoints = { new Point(5, 0), new Point(4, 0), new Point(3, 3), new Point(1, 1), new Point(-1, -2) };
            Point[] vertRect = {new Point(2, 2), new Point(5, 0)};
            Point[] vertSquare = {new Point(-1, 1),new Point(1, -1) };
            p1.Draw();
            Figure figure1 = new Figure(p1);
            figure1.Draw();
            Oval oval1 = new Oval(p2,3.7,6.2);
            oval1.Draw();
            Circle circle1 = new Circle(p1, 9.2);
            circle1.Draw();
            Polygon polygon1 = new Polygon(vertPoints);
            polygon1.Draw();
            Rectangle rectangle1 = new Rectangle(vertRect);
            rectangle1.Draw();
            Square square1 = new Square(vertSquare);
            square1.Draw();
            Triangle triangle1 = new Triangle(new Point(-1, 1), new Point(1, -1), new Point(1,1));
            triangle1.Draw();
            Console.ReadKey(true);
        }
    }
}
