﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication3
{
    public abstract class SwimmingTechnique : Techno
    {
        protected float startPosX;
        protected float startPosY;
        public virtual int goruchee { protected set; get; }
        public virtual int MaxSpeed { protected set; get; }
        public Color ColorBody { protected set; get; }
        public virtual double Tonnazh { protected set; get; }
        public abstract void move(Graphics g);
        public abstract void draw(Graphics g);

        public void setPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }


    }
}