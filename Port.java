import java.awt.Color;

import java.awt.Graphics;

import java.util.ArrayList;

public class Port {

	ArrayList<ClassArray<ITechno>> portStages;

	int countPlaces = 20;

	int placeWidth = 210;

	int placeHeight = 80;

	int currentLevel;

	public Port(int countStages)

	{

		portStages = new ArrayList<ClassArray<ITechno>>(countStages);

		for (int i = 0; i < countStages; i++)

		{

			portStages.add(new ClassArray<ITechno>(countPlaces, null));

		}

	}

	public int getCurrentLevel() {

		return currentLevel;

	}

	public void levelUp()

	{

		if (currentLevel + 1 < portStages.size())
			currentLevel++;

	}

	public void levelDown()

	{

		if (currentLevel > 0)
			currentLevel--;

	}

	public int putPlaneInPort(ITechno plane)

	{

		return portStages.get(currentLevel).plus(portStages.get(currentLevel),
				plane);

	}

	public ITechno getPlaneInPort(int index)

	{

		return portStages.get(currentLevel).minus(portStages.get(currentLevel),
				index);

	}

	public void draw(Graphics g, int width, int height)

	{

		drawMarking(g);

		for (int i = 0; i < countPlaces; i++)

		{

			ITechno plane = portStages.get(currentLevel).getPlane(i);

			if (plane != null)

			{

				plane.setPosition(5 + i / 5 * placeWidth + 45, i % 5
						* placeHeight + 65);

				plane.draw(g);

			}

		}

	}

	public void drawMarking(Graphics g)

	{

		g.setColor(Color.BLACK);

		g.drawRect(0, 0, (countPlaces / 5) * placeWidth, 450);

		for (int i = 0; i < countPlaces / 5; i++)

		{

			for (int j = 0; j < 6; j++)

			{

				g.drawLine(i * placeWidth, j * placeHeight, i * placeWidth
						+ 110, j * placeHeight);

			}

			g.drawLine(i * placeWidth, 0, i * placeWidth, 400);

		}

	}

}