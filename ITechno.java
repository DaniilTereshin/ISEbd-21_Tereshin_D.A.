import java.awt.Color;
import java.awt.Graphics;

public interface ITechno {
	void move(Graphics g);

	void draw(Graphics g);

	void setPosition(int x, int y);

	void setMainColor(Color color);

	String getInfo();

}
