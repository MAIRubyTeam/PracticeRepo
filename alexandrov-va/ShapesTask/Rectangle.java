package Shapashap;

class Rectangle extends Polygon
{

	public Rectangle(Point p1, Point p2) 
	{
		super(new Point[]{p1, new Point(p2.getX(), p1.getY()), p2, new Point(p1.getX(), p2.getY())});
		// TODO Auto-generated constructor stub
	}

	/*public void draw()
	{
		System.out.println(this.toString() + " have coords: " + this.getCoord().getX() + " " + this.getCoord().getY());
	}*/
}