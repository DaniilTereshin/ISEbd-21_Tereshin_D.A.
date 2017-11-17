import java.awt.BorderLayout;

import java.awt.Color;

import java.awt.EventQueue;

import java.awt.Frame;

import java.awt.Graphics;



import javax.swing.JFrame;

import javax.swing.JPanel;

import javax.swing.JTextField;

import javax.swing.JButton;

import javax.swing.JColorChooser;

import javax.swing.JLabel;

import java.awt.event.ActionListener;

import java.awt.image.BufferedImage;

import java.awt.event.ActionEvent;

import javax.swing.JCheckBox;



public class main {



	private JFrame frame;

	private JTextField textMaxSpeed;

	private JTextField textmaxCountEkipazh;

	private JTextField texttonnazh;

	private JTextField textgoruchee;
	



	Color color;

	Color colorKreiser;

	int maxSpeed;

	int tonnazh;

	int maxCountEkipazh;

	int goruchee;

	boolean zenit;

	boolean brony;

	



	private ITechno interTran;

	private Frame btnColor;

	private Frame btnSelectFigtherColor;



	/**

	 * Launch the application.

	 */

	public static void main(String[] args) {

		EventQueue.invokeLater(new Runnable() {

			public void run() {

				try {

					main window = new main();

					window.frame.setVisible(true);

				} catch (Exception e) {

					e.printStackTrace();

				}

			}

		});

	}



	/**

	 * Create the application.

	 */

	public main() {

		color = Color.GRAY;

		colorKreiser = Color.BLUE;

		maxSpeed = 2000;

		maxCountEkipazh = 2;

		goruchee = 30;

		tonnazh = 5;



		initialize();



	}



	/**

	 * Initialize the contents of the frame.

	 */

	private void initialize() {

		frame = new JFrame();

		frame.setBounds(100, 100, 682, 434);

		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		frame.getContentPane().setLayout(null);



		textMaxSpeed = new JTextField();

		textMaxSpeed.setBounds(176, 227, 86, 20);

		frame.getContentPane().add(textMaxSpeed);

		textMaxSpeed.setColumns(10);



		textmaxCountEkipazh = new JTextField();

		textmaxCountEkipazh.setBounds(81, 261, 86, 20);

		frame.getContentPane().add(textmaxCountEkipazh);

		textmaxCountEkipazh.setColumns(10);



		textgoruchee = new JTextField();

		textgoruchee.setBounds(353, 227, 86, 20);

		frame.getContentPane().add(textgoruchee);

		textgoruchee.setColumns(10);



		texttonnazh = new JTextField();

		texttonnazh.setBounds(368, 261, 86, 20);

		frame.getContentPane().add(texttonnazh);

		texttonnazh.setColumns(10);



		JPanel panel = new JPanel();

		panel.setBounds(10, 11, 547, 195);

		frame.getContentPane().add(panel);



		JCheckBox checkzenit = new JCheckBox("Zenit" + "");

		checkzenit.setBounds(548, 226, 97, 23);

		frame.getContentPane().add(checkzenit);



		JCheckBox checkbrony = new JCheckBox("brony");

		checkbrony.setBounds(548, 260, 97, 23);

		frame.getContentPane().add(checkbrony);



		


		JButton btnDrawPlane = new JButton("Zadat Korabl");

		btnDrawPlane.addActionListener(new ActionListener() {

			public void actionPerformed(ActionEvent e) {



				if (checkFields()) {

					interTran =  new Ship( maxSpeed, maxCountEkipazh, tonnazh, color);



					Graphics g = panel.getGraphics();

					g.clearRect(0, 0, panel.getWidth(), panel.getHeight());

					interTran.draw(g);



				}



			}

		});

		btnDrawPlane.setBounds(148, 319, 138, 37);

		frame.getContentPane().add(btnDrawPlane);



		JButton btnDrawKreiser = new JButton("Zadat Kreiser");

		btnDrawKreiser.addActionListener(new ActionListener() {

			public void actionPerformed(ActionEvent e) {

				if (checkFields()) {

					zenit = checkzenit.isSelected();

					brony = checkbrony.isSelected();

					

					interTran =  new Kreiser( maxSpeed,  maxCountEkipazh,  tonnazh,  goruchee,  color,
				             zenit, brony,  colorKreiser);



					Graphics g = panel.getGraphics();

					g.clearRect(0, 0, panel.getWidth(), panel.getHeight());

					interTran.draw(g);

				}



			}

		});

		btnDrawKreiser.setBounds(494, 322, 162, 37);

		frame.getContentPane().add(btnDrawKreiser);



		JButton btnColor = new JButton("Цвет");

		btnColor.setForeground(color);

		btnColor.addActionListener(new ActionListener() {

			public void actionPerformed(ActionEvent arg0) {



				Color initialBackground = btnColor.getForeground();

				Color foreground = JColorChooser.showDialog(null, "JColorChooser Sample", initialBackground);

				if (foreground != null) {

					btnColor.setForeground(foreground);

				}

				color = foreground;

			}

		});

		btnColor.setBounds(10, 292, 115, 23);

		frame.getContentPane().add(btnColor);

		

		



		JButton btnSelectFigtherColor = new JButton("DopColor");

		btnSelectFigtherColor.setForeground(colorKreiser);

		btnSelectFigtherColor.addActionListener(new ActionListener() {

			public void actionPerformed(ActionEvent e) {



				Color initialBackground = btnSelectFigtherColor.getForeground();

				Color foreground = JColorChooser.showDialog(null, "JColorChooser Sample", initialBackground);

				if (foreground != null) {

					btnSelectFigtherColor.setForeground(foreground);

				}

				colorKreiser = foreground;

			}

		});

		btnSelectFigtherColor.setBounds(318, 326, 166, 23);

		frame.getContentPane().add(btnSelectFigtherColor);



		JLabel lblNewLabel = new JLabel("Speed");

		lblNewLabel.setBounds(6, 230, 181, 17);

		frame.getContentPane().add(lblNewLabel);



		JLabel lblNewLabel_1 = new JLabel("Ekipazh");

		lblNewLabel_1.setBounds(29, 264, 46, 14);

		frame.getContentPane().add(lblNewLabel_1);



		JLabel texteight = new JLabel("tonnazh");

		texteight.setBounds(290, 230, 46, 14);

		frame.getContentPane().add(texteight);



		JLabel lblNewLabel_3 = new JLabel("goruchee");

		lblNewLabel_3.setBounds(290, 264, 111, 14);

		frame.getContentPane().add(lblNewLabel_3);



	}



	private boolean checkParse(String str) {

		try {

			Integer.parseInt(str);

		} catch (NumberFormatException e) {

			return false;

		}



		return true;

	}



	private boolean checkFields() {

		if (checkParse(textMaxSpeed.getText()))

			maxSpeed = Integer.parseInt(textMaxSpeed.getText());

		if (checkParse(texttonnazh.getText()))

			tonnazh = Integer.parseInt(texttonnazh.getText());

		if (checkParse(textgoruchee.getText()))

			goruchee = Integer.parseInt(textgoruchee.getText());

		if (checkParse(textmaxCountEkipazh.getText()))

			maxCountEkipazh = Integer.parseInt(textmaxCountEkipazh.getText());



		System.out.println(maxSpeed + " " + goruchee + " " + tonnazh + " " + maxCountEkipazh);



		return true;

	}

}