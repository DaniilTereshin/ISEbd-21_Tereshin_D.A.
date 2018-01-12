using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public class Ship : SwimmingTechnique, IComparable<Ship>, IEquatable<Ship>
    {
        public int CompareTo(Ship other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (MaxCountEkipazh != other.MaxCountEkipazh)
            {
                return MaxCountEkipazh.CompareTo(other.MaxCountEkipazh);
            }
            if (osnastka != other.osnastka)
            {
                return osnastka.CompareTo(other.osnastka);

            }
            if (ColorBody != other.ColorBody)
            {
                ColorBody.Name.CompareTo(other.ColorBody.Name);
            }
            return 0;
        }

        public bool Equals (Ship other)
        {
            if (other == null)
            {
                return false;
            }

            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }


            if (MaxCountEkipazh != other.MaxCountEkipazh)
            {
                return false;
            }
            if (osnastka != other.osnastka)
            {
                return false;
            }

            if (ColorBody != other.ColorBody)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }


            Ship shipObj = obj as Ship;
            if (shipObj == null)
            {
                return false;
            }
            else
            {
                return Equals(shipObj);
            }
        }






        public override int GetHashCode()
        {
            return MaxSpeed.GetHashCode();
        }


        protected int countEkipazh;
        public virtual int MaxCountEkipazh { protected set; get; }
        public virtual int osnastka { protected set; get; }
        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }
            protected set
            {
                if (value > 0 && value < 1000000)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 150;
                }
            }
        }


        public override double Tonnazh
        {
            get
            {
                return base.Tonnazh;
            }
            protected set
            {
                if (value > 20000 && value < 70000)
                {
                    base.Tonnazh = value;
                }
                else
                {
                    base.Tonnazh = 40000;
                }
            }
        }
        public Ship(int maxSpeed, int maxCountEkipazh, int goruchee, double tonnazh, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountEkipazh = maxCountEkipazh;
            this.ColorBody = color;
            this.goruchee = goruchee;
            this.Tonnazh = tonnazh;
            this.countEkipazh = 0;
            startPosX = 40;
            startPosY = 100;
        }

        public Ship(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 5) //если че цифра
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountEkipazh = Convert.ToInt32(strs[1]);
                goruchee = Convert.ToInt32(strs[2]);
                Tonnazh = Convert.ToInt32(strs[3]);
                ColorBody = Color.FromName(strs[4]);

            }
            this.countEkipazh = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);



        }
        public override void move(Graphics g)
        {

            if (this.goruchee > 0)
            {
                startPosX +=
               (MaxSpeed * 50 / (float)Tonnazh) / (countEkipazh == 0 ? 1 : countEkipazh);

            }
            else
            {
                MessageBox.Show("Горючее не залито!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            draw(g);

        }
        public override void draw(Graphics g)
        {
            drawKorablSwim(g);
        }

        protected virtual void drawKorablSwim(Graphics g)
        {
            Pen pen = new Pen(ColorBody);
            g.DrawLine(pen, startPosX, startPosY, startPosX + 60, startPosY);

            g.DrawLine(pen, startPosX, startPosY, startPosX - 10, startPosY - 20);
            g.DrawLine(pen, startPosX + 60, startPosY, startPosX + 85, startPosY - 20);
            g.DrawLine(pen, startPosX - 10, startPosY - 20, startPosX + 85, startPosY - 20);

            Brush br = new SolidBrush(ColorBody);
            g.FillRectangle(br, startPosX, startPosY - 35, 5, 16);
            g.FillRectangle(br, startPosX + 8, startPosY - 40, 5, 20);
            g.FillRectangle(br, startPosX + 16, startPosY - 45, 5, 26);
        }

        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountEkipazh + ";" + goruchee + ";" + Tonnazh + ";" + ColorBody.Name;
        }


    }
}