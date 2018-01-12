using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Kreiser : Ship , IComparable<Kreiser>, IEquatable<Kreiser>
    {

        public int CompareTo(Kreiser other)
        {

            var res = (this is Ship).CompareTo(other is Ship);
            if ( res !=0)
            {
                return res;
            }
            if (zenit != other.zenit)
            {
                return zenit.CompareTo(other.zenit);
            }
            if (brony != other.brony)
            {
                return brony.CompareTo(other.brony);
            }
            
            if (dopColor != other.dopColor)
            {
                dopColor.Name.CompareTo(other.dopColor.Name);
            }
            return 0;
        }

        public bool Equals(Kreiser other)
        {

            var res = (this is Ship).Equals(other is Ship);
            if (!res)
            {
                return res;
            }

            if (zenit != other.zenit)
            {
                return false;
            }


            if (brony != other.brony)
            {
                return false;
            }

            if (dopColor != other.dopColor)
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


            Kreiser shipObj = obj as Kreiser;
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



















        private bool zenit;
        private bool brony;
        private Color dopColor;

        public void Ekipazh(int count)
        {
            if (countEkipazh + count < MaxCountEkipazh)
            {
                countEkipazh += count;
            }
        }

        public int getEkipazh()
        {
            int count = countEkipazh;
            countEkipazh = 0;
            return count;
        }
        public override int MaxCountEkipazh
        {
            get
            {
                return base.MaxCountEkipazh;
            }
            protected set
            {
                if (value > 1500 && value < 2800)
                {
                    base.MaxCountEkipazh = value;
                }
                else
                {
                    base.MaxCountEkipazh = 1500;
                }
            }
        }

        public Kreiser(int maxSpeed, int maxCountEkipazh, int tonnazh, int goruchee, Color color,
            bool zenit, bool brony, Color dopColor) :
            base(maxSpeed, maxCountEkipazh, tonnazh, goruchee, color)
        {
            this.zenit = zenit;
            this.brony = brony;
            this.dopColor = dopColor;

        }


        public Kreiser(string info) : base (info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 8) //если че цифра
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountEkipazh = Convert.ToInt32(strs[1]);
                goruchee = Convert.ToInt32(strs[2]);
                Tonnazh = Convert.ToInt32(strs[3]);
                ColorBody = Color.FromName(strs[4]);
                zenit = Convert.ToBoolean(strs[5]);
                brony = Convert.ToBoolean(strs[6]);
                dopColor = Color.FromName(strs[7]);

            }

        }






        protected override void drawKorablSwim(Graphics g)
        {
            base.drawKorablSwim(g);

            if (zenit)
            {
                Brush b = new SolidBrush(dopColor);
                g.FillEllipse(b, startPosX + 35, startPosY - 34, 18, 15);
                g.FillEllipse(b, startPosX + 33, startPosY - 23, 18, 8);
                g.FillEllipse(b, startPosX + 58, startPosY - 26, 15, 8);
                g.FillRectangle(b, startPosX + 51, startPosY - 30, 30, 2);
                g.FillRectangle(b, startPosX + 71, startPosY - 24, 30, 2);
            }
            if (brony)
            {
                Brush b = new SolidBrush(dopColor);
                g.FillRectangle(b, startPosX, startPosY - 8, 63, 10);

            }

            
        }

        public void setDopColor(Color color)
        {
            dopColor = color;
        }

        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountEkipazh + ";" + goruchee + ";" + Tonnazh + ";" + ColorBody.Name 
                + ";" + zenit + ";" + brony + ";" + dopColor.Name;
        }

    }
}
