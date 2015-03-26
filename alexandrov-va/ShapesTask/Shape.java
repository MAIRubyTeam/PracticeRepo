package Shapashap;

class Shape
{
	private Point coord;
	private Point[] verteces;
	
	public Shape(Point point)
	{
		this.setCoord(point);
	}
	
	public Shape(Point[] verteces)
	{
		this.setVerteces(verteces);
	}

	public Point getCoord() {
		return coord;
	}

	public void setCoord(Point coord) {
		this.coord = coord;
	}
	
	public void draw()
	{
		System.out.println(this.getClass().getSimpleName() + " have coords: "  + coord.toString());
	}

	public Point[] getVerteces() 
	{
		return verteces;
	}

	public void setVerteces(Point[] verteces) 
	{
		if(verteces == null || verteces.length < 3)
		{
			verteces = new Point[]{new Point(0, 0), new Point(1, 0), new Point(0, 1)};
			this.verteces = verteces;
			return;
		}
		this.verteces = verteces;
	}
}