import java.awt.Color;

import java.awt.Graphics;
public abstract class SwimmingTechnique implements ITechno
{


	protected int startX;

	protected int startY;

	public int maxSpeed;

	public int goruchee;

	public double tonnazh;

	public Color color;



	protected abstract void setmaxSpeed(int s);



	public abstract int getmaxSpeed();



	protected abstract void setGoruchee(int w);



	public abstract int getGoruchee();



	protected abstract void setTonnazh(double h);

	public abstract int getTonnazh();

	public abstract void move(Graphics g);

	public abstract void draw(Graphics g);

	public void setPosition(int x, int y) {

		startX = x;

		startY = y;


}
}
