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
using NLog;

namespace WindowsFormsApplication3
{
    public partial class FormSelectShip : Form
    {


        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>
        ITechno ship = null;
        /// <summary>
        /// Получить машину
        /// </summary>
        public ITechno getShip { get { return ship; } }
        private Logger Log;
        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawShip()
        {
            if (ship != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.setPosition(45, 80);
                ship.draw(gr);
                pictureBoxShip.Image = bmp;
            }
        }
        /// <summary>
        /// Событие
        /// </summary>
        private event myDel eventAddShip;
        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(myDel ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new myDel(ev);
            }
            else
            {
                eventAddShip += ev;
            }
        }

        public FormSelectShip()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Готовимся к перетаскиванию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelShip.DoDragDrop(labelShip.Text,
            DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Готовимся к перетаскиванию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelKreiser_MouseDown(object sender, MouseEventArgs e)
        {
            labelKreiser.DoDragDrop(labelKreiser.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверяем, что мы принимаем (мы не всеядные)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelShip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        /// <summary>
        /// Принимаем то, что перетаскивали
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelShip_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {//случаным образом выбриаем какая машина встанет
                case "Ship":
                    ship = new Ship(100, 4, 3, 500, Color.Black);
                    break;
                case "Kreiser":
                    ship = new Kreiser(1000, 4, 3, 50, Color.Black, true, true, Color.Black);
                    break;
            }
            DrawShip();
        }
        /// <summary>
        /// Перетаскиваем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
            DragDropEffects.Move | DragDropEffects.Copy);

        }
        /// <summary>
        /// Готовимся к приему
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        /// <summary>
        /// Принимаем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                ship.setMainColor((Color)e.Data.GetData(typeof(Color)));
               
                DrawShip();
            }
        }
        /// <summary>
        /// Принимаем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                if (ship is Kreiser)
                {
                    (ship as Kreiser).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    Log.Info("Выбрали дополнительный цвет");
                    DrawShip();
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (eventAddShip != null)
            {
                eventAddShip(ship);
            }
            Close();
        }

        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {

        }


        private void FormSelectCar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxShip_Click(object sender, EventArgs e)
        {

        }

        private void labelShip_Click(object sender, EventArgs e)
        {
            
        }

        private void labelKreiser_Click(object sender, EventArgs e)
        {
            
        }

        private void labelBaseColor_Click(object sender, EventArgs e)
        {
            
        }

        private void labelDopColor_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
