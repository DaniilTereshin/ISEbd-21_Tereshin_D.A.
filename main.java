import java.awt.BorderLayout;

import java.awt.Color;

import java.awt.Component;

import java.awt.EventQueue;

import java.awt.Frame;

import java.awt.Graphics;

import javax.swing.JFrame;

import javax.swing.JPanel;

import javax.swing.JTextField;

import javax.swing.JButton;

import javax.swing.JColorChooser;

import javax.swing.JLabel;

import javax.swing.JOptionPane;

import java.awt.event.ActionListener;

import java.awt.image.BufferedImage;

import java.awt.event.ActionEvent;

import javax.swing.JCheckBox;

public class main {

	private JFrame frame;

	Port port;

	private Frame btnColor;

	private Frame btnSelectKreiserColor;

	private JTextField numPlace;

	/**
	 * 
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
	 * 
	 * Create the application.
	 */

	public main() {

		port = new Port();

		initialize();

	}

	/**
	 * 
	 * Initialize the contents of the frame.
	 */

	private void initialize() {

		frame = new JFrame();

		frame.setBounds(100, 100, 1080, 559);

		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		frame.getContentPane().setLayout(null);

		JPanel panel = new Panel(port);

		panel.setBounds(10, 11, 854, 499);

		frame.getContentPane().add(panel);

		JButton btnSetPlane = new JButton("Пришвартовать корабль");
		btnSetPlane.setBackground(Color.PINK);

		btnSetPlane.addActionListener(new ActionListener() {

			public void actionPerformed(ActionEvent e) {

				Color colorDialog = JColorChooser.showDialog(null,
						"JColorChooser Sample", null);

				if (colorDialog != null) {

					ITechno plane = new Ship(1000, 100, 30, colorDialog);

					int place = port.putPlaneInPort(plane);

					panel.repaint();

					JOptionPane.showMessageDialog(null, "Ваше место " + place);

				}

			}

		});

		btnSetPlane.setBounds(874, 293, 180, 23);

		frame.getContentPane().add(btnSetPlane);

		JButton btnSetFigther = new JButton("Пришвартовать Крейсер");
		btnSetFigther.setBackground(Color.PINK);

		btnSetFigther.addActionListener(new ActionListener() {

			public void actionPerformed(ActionEvent e) {

				Color colorDialog1 = JColorChooser.showDialog(null,
						"JColorChooser Sample", null);

				if (colorDialog1 != null) {

					Color colorDialog = JColorChooser.showDialog(null,
							"JColorChooser Sample", null);

					if (colorDialog != null) {

						ITechno plane = new Kreiser(1000, 100, 30, 30,
								colorDialog1, true, true, colorDialog);

						int place = port.putPlaneInPort(plane);

						panel.repaint();

						JOptionPane.showMessageDialog(null, "Ваше место "
								+ place);

					}

				}

			}

		});

		btnSetFigther.setBounds(874, 330, 180, 23);

		frame.getContentPane().add(btnSetFigther);

		JPanel panelTake = new JPanel();

		panelTake.setBounds(901, 11, 153, 170);

		frame.getContentPane().add(panelTake);

		JButton btnTake = new JButton("Забрать");
		btnTake.setBackground(Color.PINK);

		btnTake.addActionListener(new ActionListener() {

			public void actionPerformed(ActionEvent arg0) {

				if (checkPlace(numPlace.getText())) {

					ITechno plane = port.getPlaneInPort(Integer
							.parseInt(numPlace.getText()));

					Graphics gr = panelTake.getGraphics();

					gr.clearRect(0, 0, panelTake.getWidth(),
							panelTake.getHeight());

					plane.setPosition(10, 45);

					plane.draw(gr);

					panel.repaint();

				}

			}

		});

		btnTake.setBounds(901, 242, 117, 23);

		frame.getContentPane().add(btnTake);

		JLabel lblNewLabel = new JLabel("Место");

		lblNewLabel.setBounds(912, 205, 46, 14);

		frame.getContentPane().add(lblNewLabel);

		numPlace = new JTextField();

		numPlace.setBounds(968, 202, 86, 20);

		frame.getContentPane().add(numPlace);

		numPlace.setColumns(10);

	}

	private boolean checkPlace(String str) {

		try {

			Integer.parseInt(str);

		} catch (NumberFormatException e) {

			return false;

		}

		if (Integer.parseInt(str) > 20)
			return false;

		return true;

	}

}