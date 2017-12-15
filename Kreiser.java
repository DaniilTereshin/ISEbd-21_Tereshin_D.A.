import java.awt.Color;
import java.awt.Graphics;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;

public class Kreiser extends Ship implements Serializable {

	private boolean zenit;

	private boolean brony;

	transient private Color colorKreiser;

	public Kreiser(int maxSpeed, int maxCountEkipazh, double tonnazh,
			int goruchee, Color color, boolean zenit, boolean brony,
			Color colorKreiser) {

		super(maxSpeed, tonnazh, maxCountEkipazh, color);

		// TODO Auto-generated constructor stub

		this.zenit = zenit;

		this.brony = brony;

		this.colorKreiser = colorKreiser;

	}

	protected void drawShipPlane(Graphics g) {

		super.drawShipPlane(g);

		g.setColor(colorKreiser);

		if (zenit) {

			g.setColor(colorBody);

			g.setColor(colorKreiser);
			g.fillOval(startX + 35, startY - 34, 18, 15);
			g.fillOval(startX + 33, startY - 23, 18, 8);
			g.fillOval(startX + 58, startY - 26, 15, 8);
			g.fillOval(startX + 51, startY - 30, 30, 2);
			g.fillOval(startX + 71, startY - 24, 30, 2);

		}

		if (brony) {

			g.fillRect(startX, startY - 8, 63, 10);

		}

	}

	public void setColorFight(Color f) {

		colorKreiser = f;

	}

	private void writeObject(ObjectOutputStream s) throws IOException {

		s.defaultWriteObject();

		s.writeInt(colorBody.getRed());

		s.writeInt(colorBody.getGreen());

		s.writeInt(colorBody.getBlue());

		s.writeInt(colorKreiser.getRed());

		s.writeInt(colorKreiser.getGreen());

		s.writeInt(colorKreiser.getBlue());

	}

	private void readObject(ObjectInputStream s) throws IOException,
			ClassNotFoundException {

		s.defaultReadObject();

		int red = s.readInt();

		int green = s.readInt();

		int blue = s.readInt();

		colorBody = new Color(red, green, blue);

		int red1 = s.readInt();

		int green1 = s.readInt();

		int blue1 = s.readInt();

		colorKreiser = new Color(red1, green1, blue1);

	}

	@Override
	public String getInfo() {

		// TODO Auto-generated method stub

		return maxSpeed + ";" + maxCountEkipazh + ";" + tonnazh + ";"
				+ goruchee + ";" + colorBody + ";" + zenit + ";" + brony + ";"

				+ colorKreiser;

	}

}
