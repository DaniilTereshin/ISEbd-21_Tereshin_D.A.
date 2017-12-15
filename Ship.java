import java.awt.Color;

import java.awt.Graphics;

public class Ship extends SwimmingTechnique {
	public int maxCountEkipazh;

	public static double osnastka;

	public Ship(int maxSpeed, double MaxCountEkipazh, int osnastka,
			Color colorShip) {

		this.maxSpeed = maxSpeed;

		this.goruchee = goruchee;

		this.color = colorShip;

		this.tonnazh = tonnazh;

		startX = 60;

		startY = 100;

	}

	@Override
	protected void setmaxSpeed(int s) {

		// TODO Auto-generated method stub

		if (s > 0 && s < 1000000)

			super.maxSpeed = s;

		else

			super.maxSpeed = 200;

	}

	@Override
	public int getmaxSpeed() {

		// TODO Auto-generated method stub

		return super.maxSpeed;

	}

	@Override
	protected void setGoruchee(int w) {

		// TODO Auto-generated method stub

		if (w > 16000 && w < 35000)

			super.goruchee = w;

		else

			super.goruchee = 30000;

	}

	@Override
	public int getGoruchee() {

		// TODO Auto-generated method stub

		return super.goruchee;

	}

	@Override
	protected void setTonnazh(double h) {

		// TODO Auto-generated method stub

		if (h > 0 && h < 8)

			super.tonnazh = h;

		else

			super.tonnazh = 5;

	}

	@Override
	public int getTonnazh() {

		return (int) super.tonnazh;

	}

	@Override
	public void move(Graphics g) {

		if (this.goruchee > 0) {

			if (startY > maxSpeed)

				startY -= 3;

			startX += 10;

			this.goruchee -= 10;

		} else {

			System.out.println("Íåòó òîïëèâà");

		}

		draw(g);

	}

	@Override
	public void draw(Graphics g) {

		drawShipPlane(g);

	}

	protected void drawShipPlane(Graphics g) {

		g.setColor(color);

		g.drawLine(startX, startY, startX + 60, startY);

		g.drawLine(startX, startY, startX - 10, startY - 20);
		g.drawLine(startX + 60, startY, startX + 85, startY - 20);
		g.drawLine(startX - 10, startY - 20, startX + 85, startY - 20);
		g.fillRect(startX, startY - 35, 5, 16);
		g.fillRect(startX + 8, startY - 40, 5, 20);
		g.fillRect(startX + 16, startY - 45, 5, 26);
	}

}