using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{    
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points1 = { new Point(5, 0), new Point(4, 0), new Point(3, 3), new Point(1, 1), new Point(-1, -2) };
            Figure shapes = new Figure(points1);
            shapes.Draw();
            Polygon poly1 = new Polygon(points1);
            poly1.Draw();
            Triangle trg1 = new Triangle(new Point(1,3),new Point(3,2),new Point(3,6));
            trg1.Draw();
            Rectangle rec1 = new Rectangle(new Point(2,1), new Point(1,2),new Point(2,1), new Point(1,2));
            rec1.Draw();
            Parallelogram par1 = new Parallelogram(new Point(2, 1), new Point(1, 2), new Point(2, 1), new Point(1, 2));
            par1.Draw();
            Square sqr = new Square(points1);
            sqr.Draw();
            Rhombus rhb = new Rhombus(new Point(2, 1), new Point(1, 2), new Point(2, 1), new Point(1, 2));
            rhb.Draw();
            Oval ov = new Oval(new Point(3,1));
            ov.Draw();
            Circle crc = new Circle(new Point(2,2),3 );
            crc.Draw();
            DistanceCalculator dc = new DistanceCalculator(new Point(1,1),new Point(2,2));
            Console.WriteLine(dc.getDistance());
            Console.ReadKey(true);
        }
    }
}
