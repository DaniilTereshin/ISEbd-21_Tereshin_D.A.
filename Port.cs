﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Port
    {
        ClassArray<Techno> port;
        int countPlaces = 20;
        int placeSizeWidth = 350;
        int placeSizeHeight = 80;
        public Port()
        {
            port = new ClassArray<Techno>(countPlaces, null);
        }
        public int PutShipInPort(Techno ship)
        {
            return port + ship;
        }
        public Techno GetShipInPort(int ticket)
        {
            return port - ticket;
        }
        public void Draw(Graphics g, int width, int height)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var ship = port.getObject(i);
                if (ship != null)
                {
                    ship.setPosition(5 + i / 5 * placeSizeWidth + 45, i % 5 * placeSizeHeight + 65);
                    ship.draw(g);
                }
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);
            for (int i = 0; i < countPlaces / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight,
                        i * placeSizeWidth + 110, j * placeSizeHeight);
                }
                g.DrawLine(pen, i * placeSizeWidth, 0,
                        i * placeSizeWidth, 400);
            }
        }
    }
}
