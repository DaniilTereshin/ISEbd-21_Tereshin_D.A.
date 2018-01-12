using System;
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

namespace WindowsFormsApp2
{ 
    public partial class Form1 : Form
{
        Color color;
        Color dopColor;
        int maxSpeed;
        int maxCountEkipazh;
        int Tonnazh;
        int goruchee;
        private Techno inter;
        public Form1()
        {
            InitializeComponent();
            color = Color.Red;
            dopColor = Color.Blue;
            maxSpeed = 10000000;
            maxCountEkipazh = 2800;
            Tonnazh = 70000;
            goruchee = 0;
            buttonSelectColor.BackColor = color;
            buttonSelectDopColor.BackColor = dopColor;

        }

    

    private void buttonSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                buttonSelectColor.BackColor = color;
            }
        }

        private void buttonSelectDopColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopColor = cd.Color;
                buttonSelectDopColor.BackColor = dopColor;
            }
        }
        private void textBoxMaxSpeed_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMaxCountEkipazh_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {

        }
        private bool checkFields()
        {
            if (!int.TryParse(textBox1.Text, out maxSpeed))
            {
                return false;
            }
            if (!int.TryParse(textBox2.Text, out maxCountEkipazh))
            {
                return false;
            }
            if (!int.TryParse(textBox3.Text, out Tonnazh))
            {
                return false;
            }
            if (!int.TryParse(textBox4.Text, out goruchee))
            {
                return false;
            }
            return true;
        }

        private void buttonSetKorabl_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Ship(maxSpeed, maxCountEkipazh, Tonnazh, goruchee, color);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.draw(gr);
                pictureBox1.Image = bmp;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetLinkor_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Kreiser(maxSpeed, maxCountEkipazh, goruchee, Tonnazh, color, checkBoxBrony.Checked, checkBoxZenit.Checked, dopColor);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.draw(gr);
                pictureBox1.Image = bmp;
            }

        }

        private void checkBoxBrony_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxZenit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.move(gr);
                pictureBox1.Image = bmp;
            }
        }
    }
}
