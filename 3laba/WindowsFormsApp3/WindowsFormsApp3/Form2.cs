﻿using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form

    {
        Port port;

        public Form2()
        {
            InitializeComponent();
            port = new Port();
            Draw();
        }
        /// <summary>
        /// Метод для отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            port.Draw(gr, pictureBoxParking.Width, pictureBoxParking.Height);
            pictureBoxParking.Image = bmp;
        }



        private void buttonSetCar_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var ship = new Ship(100, 4, 1000, 500, dialog.Color);
                int place = port.PutShipInPort(ship);
                Draw();
                MessageBox.Show("Ваше место: " + place);
            }

        }

        private void buttonSetGru_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var ship = new Kreiser(200, 4, 2, 2, dialog.Color, true, true,  dialogDop.Color);
                    int place = port.PutShipInPort(ship);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
            }
        }

        private void buttonTakeCar_Click_1(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var ship = port.GetShipInPort(Convert.ToInt32(maskedTextBox1.Text));

                Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.setPosition(5, 5);
                ship.draw(gr);
                pictureBoxTakeCar.Image = bmp;
                Draw();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}