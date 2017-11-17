import java.awt.Color;

import java.awt.Graphics;



public class Kreiser extends Ship {



	private boolean zenit;

	private boolean brony;

    private Color colorKreiser;



	public Kreiser(int maxSpeed, int maxCountEkipazh, double tonnazh, int goruchee, Color color,
            boolean zenit, boolean brony, Color colorKreiser) {

		super( maxSpeed,tonnazh, maxCountEkipazh,  color);

		// TODO Auto-generated constructor stub

		this.zenit = zenit;

		this.brony = brony;

		this.colorKreiser = colorKreiser;



	}



	//public Kreiser(int maxSpeed, int maxCountEkipazh, int tonnazh,
			//int goruchee, Color color, boolean zenit2, boolean brony2,
			//Color colorKreiser2) {
		// TODO Auto-generated constructor stub
	//}



	protected void drawShipPlane(Graphics g) {

		super.drawShipPlane(g);

		g.setColor(colorKreiser);



		if (zenit) {



			g.setColor(Color.BLACK);





			g.setColor(colorKreiser);
			 g.fillOval( startX + 35, startY - 34, 18, 15);
             g.fillOval( startX + 33, startY - 23, 18, 8);
             g.fillOval(startX + 58, startY - 26, 15, 8);
             g.fillOval( startX + 51, startY - 30, 30, 2);
             g.fillOval( startX + 71, startY - 24, 30, 2);
			

			



		}

		if (brony) {

			g.fillRect( startX, startY - 8, 63, 10);


		}

	


	}

}