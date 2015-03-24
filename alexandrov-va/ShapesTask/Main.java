package Shapashap;

public class Main 
{

	public static void main(String[] args) 
	{
		Point[] points1 = {new Point(5, 0), new Point(4, 0), new Point(3, 3), new Point(1, 1), new Point(-1, -2)};
		Shape[] shapes = new Shape[8];
		shapes[0] = new Shape(new Point(5, 0));
		shapes[1] = new Polygon(points1);
		shapes[2] = new RoundShapes(new Point(1, 0));
		shapes[3] = new Triangle(new Point(5, 0), new Point(4, 0), new Point(3, 3));
		shapes[4] = new Rectangle(new Point(5, 0), new Point(4, 0), new Point(3, 3), new Point(1, 1));
		shapes[5] = new Oval(new Point(35, 30));
		shapes[6] = new Circle(new Point(52, 0));
		shapes[7] = new Polygon(null);
		
		for(int i = 0; i < 8; i++)
			shapes[i].draw();
	}

}
