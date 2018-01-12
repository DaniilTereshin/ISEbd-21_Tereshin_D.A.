using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
   public class Port
    {
        //список уровней парковки
        List<ClassArray<ITechno>> portStages;
        int countPlaces = 10;
        int placeSizeWidth = 350;
        int placeSizeHeight = 80;
        int currentLevel;
        private ClassArray<ITechno>  port;

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
            int i = 0;
                foreach (var ship in portStages[currentLevel])
                {
                    ship.setPosition(5 + i / 5 * placeSizeWidth + 45, i % 5 * placeSizeHeight + 65);
                    ship.draw(g);
                    i++;
                }
            
        }

        public void Sort()
        {
            portStages.Sort();
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

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            using (FileStream fs = new FileStream(filename , FileMode.Create))
                {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("CountLevels:" + portStages.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach ( var level in portStages)
                    {
                        info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            var ship = level[i];
                            if (ship != null)
                            {
                                if ( ship.GetType().Name == "Ship")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Ship:");
                                    fs.Write(info, 0, info.Length);
                                }

                                if (ship.GetType().Name == "Kreiser")
                                {
                                    info = new UTF8Encoding(true).GetBytes("kreiser:");
                                    fs.Write(info, 0, info.Length);
                                }

                                info = new UTF8Encoding(true).GetBytes(ship.getInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);
                            } 
                        }
                    }
                }
            }


            return true;



        }


        public bool LoadData (string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }

            using(FileStream fs = new FileStream(filename, FileMode.Open))
            {
                string s = "";
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b,0,b.Length) > 0)
                    {
                        s += temp.GetString(b);
                    }
                }

                s = s.Replace("\r", "");
                var strs = s.Split('\n');
                if (strs[0].Contains("CountLevels"))
                {
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if (portStages != null)
                    {
                        portStages.Clear();
                    }
                    portStages = new List<ClassArray<ITechno>>(count);
                }
                else
                {
                    return false;
                }
                int counter = -1;
                for (int i = 1; i < strs.Length; ++i)
                {
                    if(strs[i] == "Level")
                    {
                        counter++;
                        portStages.Add(new ClassArray<ITechno>(countPlaces, null));
                    }
                    else if (strs[i].Split(':')[0] == "Ship")
                    {
                        ITechno ship = new Ship(strs[i].Split(':')[1]);
                        int number = portStages[counter] + ship;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                    else if (strs[i].Split(':')[0] == "Kreiser")
                    {
                        ITechno ship = new Kreiser(strs[i].Split(':')[1]);
                        int number = portStages[counter] + ship;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }






    }
}
