package Shapashap;

public class BadPointsException extends Exception
{
	private Point[] verteces;
	private String name;
	
	public BadPointsException(Point[] verteces, String name)
	{
		this.verteces = verteces;
		this.name = name;
	}
	
	public String toString()
	{
		String message = "Error while creating " + name + "!\n";
		
		if(verteces == null)
		{
			return message + "There are no points for shape!";
		}
		
		for(Point p: verteces)
		{
			message += p.toString() + " ";
		}
		
		message += " are bad points for shape.";
		
		return message;
	}
}
