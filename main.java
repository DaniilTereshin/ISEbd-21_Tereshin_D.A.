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

import java.util.Vector;

import java.awt.event.ActionEvent;

import javax.swing.JCheckBox;

import javax.swing.JList;

public class main {

	private JFrame frame;

	Port port;

	private Frame btnColor;

	private Frame btnSelectFigtherColor;

	private JTextField numPlace;

	JPanel panel;

	private String[] elements = new String[6];

	JList listLevels;

	SelectPlane select;

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

		port = new Port(5);

		initialize();

		for (int i = 0; i < 5; i++) {

			elements[i] = "Уровень " + (i + 1);

		}

		listLevels.setSelectedIndex(port.getCurrentLevel());

	}

	/**
	 * 
	 * Initialize the contents of the frame.
	 */

	public void getPlane() {

		select = new SelectPlane(frame);

		if (select.res()) {

			ITechno plane = select.getPlane();

			int place = port.putPlaneInPort(plane);

			panel.repaint();

			System.out.println("Ваше место: " + place);

		}

	}

	private void initialize() {

		frame = new JFrame();

		frame.setBounds(100, 100, 1080, 559);

		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		frame.getContentPane().setLayout(null);

		panel = new Panel(port);

		panel.setBounds(10, 11, 854, 499);

		frame.getContentPane().add(panel);

		JPanel panelTake = new JPanel();

		panelTake.setBounds(901, 11, 153, 170);

		frame.getContentPane().add(panelTake);

		JButton btnTake = new JButton("Забрать корабль");

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

		btnTake.setBounds(901, 233, 153, 23);

		frame.getContentPane().add(btnTake);

		JLabel lblNewLabel = new JLabel("Место");

		lblNewLabel.setBounds(912, 205, 46, 14);

		frame.getContentPane().add(lblNewLabel);

		numPlace = new JTextField();

		numPlace.setBounds(968, 202, 86, 20);

		frame.getContentPane().add(numPlace);

		numPlace.setColumns(10);

		listLevels = new JList(elements);

		listLevels.setBounds(891, 373, 153, 111);

		frame.getContentPane().add(listLevels);

		JButton btnLevelDown = new JButton("<<");

		btnLevelDown.addActionListener(new ActionListener() {

			public void actionPerformed(ActionEvent arg0) {

				port.levelDown();

				listLevels.setSelectedIndex(port.getCurrentLevel());

				panel.repaint();

			}

		});

		btnLevelDown.setBounds(869, 495, 89, 23);

		frame.getContentPane().add(btnLevelDown);

		JButton btnLevelUp = new JButton(">>");

		btnLevelUp.addActionListener(new ActionListener() {

			public void actionPerformed(ActionEvent e) {

				port.levelUp();

				listLevels.setSelectedIndex(port.getCurrentLevel());

				panel.repaint();

			}

		});

		btnLevelUp.setBounds(973, 495, 89, 23);

		frame.getContentPane().add(btnLevelUp);

		JButton btnGetPlane = new JButton("Добавить Корабль");

		btnGetPlane.addActionListener(new ActionListener() {

			@SuppressWarnings("deprecation")
			public void actionPerformed(ActionEvent e) {

				getPlane();

			}

		});

		btnGetPlane.setBounds(901, 300, 153, 23);

		frame.getContentPane().add(btnGetPlane);

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