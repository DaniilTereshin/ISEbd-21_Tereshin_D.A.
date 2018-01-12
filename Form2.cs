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
    public partial class Form2 : Form
    {
        /// <summary>
        /// Парковка
        /// </summary>
        Port port;
        /// <summary>
        /// Форма для добавления
        /// </summary>
        FormSelectShip form;
        private Logger Log;

        public Form2()
        {
            InitializeComponent();
            Log = LogManager.GetCurrentClassLogger();
            port = new Port(5);
            //заполнение listBox
            for (int i = 1; i < 6; i++)
            {
                listBoxLevels.Items.Add("Уровень " + i);
            }
            listBoxLevels.SelectedIndex = port.getCurrentLevel;
            Draw();
        }
        /// <summary>
        /// Метод для отрисовки уровня парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxPort.Width, pictureBoxPort.Height);
                Graphics gr = Graphics.FromImage(bmp);
                port.Draw(gr, 0, 0);
                pictureBoxPort.Image = bmp;
            }
        }
        /// <summary>
        /// Перемещаемся на следующий уровень парковки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDown_Click(object sender, EventArgs e)
        {
            port.LevelDown();
            listBoxLevels.SelectedIndex = port.getCurrentLevel;
            Log.Info("Переход на уровень ниже Текущий уровень: " + port.getCurrentLevel );
            Draw();
        }
        /// <summary>
        /// Перемещаемся на нижний уровень парковки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUp_Click(object sender, EventArgs e)
        {
            port.LevelUp();
            listBoxLevels.SelectedIndex = port.getCurrentLevel;
            Log.Info("Переход на уровень выше Текущий уровень: " + port.getCurrentLevel);
            Draw();
        }
        /// <summary>
        /// Вызываем форму добавления машины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            form = new FormSelectShip();
            form.AddEvent(AddShip);
            Log.Info("Добавили корабль уровень парковки: " + port.getCurrentLevel);
            form.Show();
        }
        /// <summary>
        /// Метод добавления машины
        /// </summary>
        /// <param name="car"></param>
        private void AddShip(ITechno ship)
        {
            if (ship != null)
            {
                try
                {
                    int place = port.PutShipInPort(ship);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка переполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Общая ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Ставим гоночную машину
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetKreiser_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var ship = new Kreiser(100, 4, 100, 10, dialog.Color, true, true, dialogDop.Color);
                    int place = port.PutShipInPort(ship);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                    Log.Info("Добавили крейсер уровень парковки: " + port.getCurrentLevel);
                }
            }
        }
        /// <summary>
        /// Забираем машину
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {//Прежде чем забрать машину, надо выбрать с какого уровня будем забирать
                string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    try { 
                    ITechno ship = port.GetShipInPort(Convert.ToInt32(maskedTextBox1.Text));
                   
                    //если удалось забрать, то отрисовываем
                        Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width, pictureBoxTakeShip.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        ship.setPosition(20, 80);
                        ship.draw(gr);
                        pictureBoxTakeShip.Image = bmp;
                        Log.Info("Забрали корабль") ;
                        Draw();
                    }
                    catch (ParkingIndexOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch ( Exception ex)
                    {//иначе сообщаем об этом
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxTakeShip_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (port.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("не сохранилось", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (port.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("не загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }






        }

        private void pictureBoxPort_Click(object sender, EventArgs e)
        {

        }

        private void Sort_Click(object sender, EventArgs e)
        {
            port.Sort();
            Draw();
        }
    }
}
