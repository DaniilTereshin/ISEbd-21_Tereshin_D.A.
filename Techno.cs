﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
   public interface Techno
    {
        void move(Graphics g);
        void draw(Graphics g);
        void setPosition(int x, int y);


    }
}
