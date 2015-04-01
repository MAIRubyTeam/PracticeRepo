package Shapashap;

public class Textbox implements Drawable
{
	private Point coord;
	private String text;
	
	public Textbox(Point coord, String text)
	{
		setCoord(coord);
		setText(text);
	}
	
	public Point getCoord() 
	{
		return coord;
	}
	public void setCoord(Point coord) 
	{
		if(coord == null)
		{
			this.coord = new Point(0, 0);
			return;
		}
		this.coord = coord;
	}
	
	public String getText() 
	{
		return text;
	}
	public void setText(String text) 
	{
		this.text = text;
	}

	@Override
	public void draw() 
	{
		System.out.println(this.getClass().getSimpleName() + " got coord " + getCoord().toString() + " with text: " +
				getText());
	}
	
}
