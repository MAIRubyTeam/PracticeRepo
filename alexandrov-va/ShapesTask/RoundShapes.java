package Shapashap;

class RoundShapes extends Shape
{

	public RoundShapes(Point point) 
	{
		super(point);
	}
	
	public void draw()
	{
		System.out.println(this.getClass().getSimpleName() + " have coords: " + this.getCoord().toString());
	}
}