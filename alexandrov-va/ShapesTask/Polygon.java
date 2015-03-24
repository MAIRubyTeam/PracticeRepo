package Shapashap;

class Polygon extends Shape
{
	

	public Polygon(Point[] verteces) 
	{
		super(verteces);
	}

	public void draw()
	{
		System.out.print(this.toString() + " have coords: ");
		for(Point p: getVerteces())
		{
			System.out.print(p.toString() + " ");
		}
		System.out.println("");
	}
}