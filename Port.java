import java.awt.Color;

import java.awt.Graphics;

import java.io.BufferedInputStream;

import java.io.ByteArrayOutputStream;

import java.io.File;

import java.io.FileInputStream;

import java.io.FileNotFoundException;

import java.io.FileOutputStream;

import java.io.IOException;

import java.io.ObjectInputStream;

import java.io.ObjectOutputStream;

import java.io.Serializable;

import java.util.ArrayList;

import javax.print.DocFlavor.BYTE_ARRAY;

public class Port implements Serializable {

	ArrayList<ClassArray<ITechno>> aerodromeStages;

	int countPlaces = 20;

	int placeWidth = 210;

	int placeHeight = 80;

	int currentLevel;

	public Port(int countStages) {

		aerodromeStages = new ArrayList<ClassArray<ITechno>>(countStages);

		for (int i = 0; i < countStages; i++) {

			aerodromeStages.add(new ClassArray<ITechno>(countPlaces, null));

		}

	}

	public int getCurrentLevel() {

		return currentLevel;

	}

	public void levelUp() {

		if (currentLevel + 1 < aerodromeStages.size())

			currentLevel++;

	}

	public void levelDown() {

		if (currentLevel > 0)

			currentLevel--;

	}

	public int putPlaneInPort(ITechno plane) throws PortOverflowException {

		return aerodromeStages.get(currentLevel).plus(
				aerodromeStages.get(currentLevel), plane);

	}

	public ITechno getPlaneInPort(int index) throws PortIndexOutOfRangeException  {

		return aerodromeStages.get(currentLevel).minus(
				aerodromeStages.get(currentLevel), index);

	}

	public void draw(Graphics g, int width, int height) {

		drawMarking(g);

		for (int i = 0; i < countPlaces; i++) {

			ITechno plane = aerodromeStages.get(currentLevel).getPlane(i);

			if (plane != null) {

				plane.setPosition(5 + i / 5 * placeWidth + 45, i % 5
						* placeHeight + 65);

				plane.draw(g);

			}

		}

	}

	public void drawMarking(Graphics g) {

		g.setColor(Color.BLACK);

		g.drawRect(0, 0, (countPlaces / 5) * placeWidth, 450);

		for (int i = 0; i < countPlaces / 5; i++) {

			for (int j = 0; j < 6; j++) {

				g.drawLine(i * placeWidth, j * placeHeight, i * placeWidth
						+ 110, j * placeHeight);

			}

			g.drawLine(i * placeWidth, 0, i * placeWidth, 400);

		}

	}

	public boolean save(String fileName) throws IOException {

		FileOutputStream save = null;

		try {

			save = new FileOutputStream(fileName);

		} catch (FileNotFoundException e) {

			// TODO Auto-generated catch block

			e.printStackTrace();

		}

		ObjectOutputStream obSave = new ObjectOutputStream(save);

		

		obSave.writeObject(aerodromeStages);

		return true;

	}

	public boolean load(String filename) {

		try {

			ObjectInputStream obLoad = new ObjectInputStream(
					new BufferedInputStream(new FileInputStream(filename)));

			try {

				aerodromeStages = (ArrayList<ClassArray<ITechno>>) obLoad
						.readObject();

				

			} catch (ClassNotFoundException e) {

				// TODO Auto-generated catch block

				e.printStackTrace();

			}

		} catch (IOException e) {

			// TODO Auto-generated catch block

			e.printStackTrace();

		}

		return true;

	}

}