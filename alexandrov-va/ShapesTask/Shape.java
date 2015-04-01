package Shapashap;

abstract class Shape implements Drawable
{
	private Point coord;
	private Point[] verteces;
	
	public Shape(Point point)
	{
		this.setCoord(point);
	}
	
	public Shape(Point[] verteces)
	{
		try 
		{
			this.setVerteces(verteces);
		} 
		catch (BadPointsException e) 
		{
			System.out.println(e);
			System.out.println("Generating single square points for this shape...\n");
			this.verteces = (new Point[]{new Point(0, 0), new Point(1, 0), new Point(1, 1), new Point(0, 1)});
		}
	}

	public Point getCoord() {
		return coord;
	}

	public void setCoord(Point coord) {
		this.coord = coord;
	}

	public Point[] getVerteces() 
	{
		return verteces;
	}

	public void setVerteces(Point[] verteces) throws BadPointsException
	{
		if(verteces == null || verteces.length < 3)
		{
			throw new BadPointsException(verteces, this.getClass().getSimpleName());
		}
		for(int i = 0; i < verteces.length - 2; i++)
		{
			if(Math.atan2(verteces[i + 1].getY() - verteces[i].getY(), verteces[i + 1].getX() - verteces[i].getX()) == 
					Math.atan2(verteces[i + 2].getY() - verteces[i + 1].getY(), verteces[i + 2].getX() - verteces[i + 1].getX()))
			{
				throw new BadPointsException(verteces, this.getClass().getSimpleName());
			}
		}
		this.verteces = verteces;
	}
}