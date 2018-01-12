using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Kreiser : Ship
    {
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

    }
}
