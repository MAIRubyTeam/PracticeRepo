package Shapashap;

class Oval extends RoundShapes
{

	private int r1, r2;
	
	
	public Oval(Point point, int r1, int r2) {
		super(point);
		this.setR1(r1);
		this.setR2(r2);
	}


	public int getR1() {
		return r1;
	}


	public void setR1(int r1) {
		this.r1 = r1;
	}


	public int getR2() {
		return r2;
	}


	public void setR2(int r2) {
		this.r2 = r2;
	}
}