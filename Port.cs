using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
   public class Port
    {
        //список уровней парковки
        List<ClassArray<ITechno>> portStages;
        int countPlaces = 20;
        int placeSizeWidth = 350;
        int placeSizeHeight = 80;
        int currentLevel;
        private ClassArray<ITechno> port;

        public int getCurrentLevel { get { return currentLevel; } }


        
        public Port(int countStages)
        {
            portStages = new List<ClassArray<ITechno>>(countStages);
            for (int i = 0; i < countStages; i++)
            {
                portStages.Add(new ClassArray<ITechno>(countPlaces, null));
            }

            
        }
        public int PutShipInPort(ITechno ship)
        {
            return portStages[currentLevel] + ship;
        }
        public ITechno GetShipInPort(int ticket)
        {
            return portStages[currentLevel] - ticket;
        }
        public void Draw(Graphics g, int width, int height)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var ship = portStages[currentLevel][i];
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
            g.DrawString ("L" + (currentLevel+1), new Font("Arial",30), new SolidBrush(Color.Blue),
            (countPlaces/5)*placeSizeWidth - 70, 420);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 5) * placeSizeWidth, 480);
            for (int i = 0; i < countPlaces / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight,
                        i * placeSizeWidth + 110, j * placeSizeHeight);
                    if (j < 5)
                    {
                        g.DrawString((i * 5 + j + 1).ToString(), new Font("Arial", 30),
                            new SolidBrush(Color.Blue), i * placeSizeWidth + 30, j * placeSizeHeight + 20);
                    }
                }
                g.DrawLine(pen, i * placeSizeWidth, 0,
                        i * placeSizeWidth, 400);
            }
        }

        public void LevelUp()
        {
            if(currentLevel + 1 < portStages.Count)
            {
                currentLevel++;
            }
        }

        public void LevelDown()
        {
            if (currentLevel > 0)
            {
                currentLevel--;
            }
        }

    }
}
