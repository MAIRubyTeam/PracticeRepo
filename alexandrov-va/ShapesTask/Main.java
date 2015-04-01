package Shapashap;

public class Main 
{

	public static void main(String[] args) 
	{
		final int count = 10;
		
		Point[] points1 = {new Point(5, 0), new Point(4, 0), new Point(3, 3), new Point(1, 1), new Point(-1, -2)};
		Point[] badPoints = {new Point(-1, 1), new Point(0, 0), new Point(1, -1)};
		Shape[] shapes = new Shape[count];
		Textbox[] textBoxes = new Textbox[2];
		
		shapes[0] = new Polygon(points1);
		shapes[1] = new Polygon(badPoints);
		shapes[2] = new RoundShapes(new Point(1, 0));
		shapes[3] = new Triangle(new Point(5, 0), new Point(4, 0), new Point(3, 3));
		shapes[4] = new Rectangle(new Point(2, 4), new Point(4, 1));
		shapes[5] = new Oval(new Point(35, 30), 4, 5);
		shapes[6] = new Circle(new Point(52, 0), 10);
		shapes[7] = new Polygon(null);
		shapes[8] = new Square(new Point (2, 2), 5);
		shapes[9] = new Rectangle(new Point(2, 2), new Point(3, 2));
		
		textBoxes[0] = new Textbox(new Point(2, 5), "Hi there");
		textBoxes[1] = new Textbox(null, "Null point");
		
		for(int i = 0; i < count; i++)
		{
			System.out.print("#" + i + ":\t");
			shapes[i].draw();
		}
		
		for(int i = 0; i < 2; i++)
			textBoxes[i].draw();
	}

}
