package Shapashap;

public class Square extends Rectangle
{
	public Square (Point point, int length)
	{
		super(point, new Point(point.getX() + length, point.getY() + length));
	}
}
