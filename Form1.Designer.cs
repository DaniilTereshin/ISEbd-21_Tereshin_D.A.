namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxBrony = new System.Windows.Forms.CheckBox();
            this.checkBoxZenit = new System.Windows.Forms.CheckBox();
            this.buttonSelectColor = new System.Windows.Forms.Button();
            this.buttonSelectDopColor = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonMove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 202);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBoxMaxSpeed_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 353);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBoxMaxCountEkipazh_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(259, 269);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(37, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBoxWeight_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Задать корабль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSetKorabl_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 22);
            this.button2.TabIndex = 5;
            this.button2.Text = "Задать крейсер";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonSetLinkor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Грузоподъемность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Экипаж";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Максимальная скорость";
            // 
            // checkBoxBrony
            // 
            this.checkBoxBrony.AutoSize = true;
            this.checkBoxBrony.Location = new System.Drawing.Point(352, 286);
            this.checkBoxBrony.Name = "checkBoxBrony";
            this.checkBoxBrony.Size = new System.Drawing.Size(65, 17);
            this.checkBoxBrony.TabIndex = 10;
            this.checkBoxBrony.Text = "Оружие";
            this.checkBoxBrony.UseVisualStyleBackColor = true;
            this.checkBoxBrony.CheckedChanged += new System.EventHandler(this.checkBoxBrony_CheckedChanged);
            // 
            // checkBoxZenit
            // 
            this.checkBoxZenit.AutoSize = true;
            this.checkBoxZenit.Location = new System.Drawing.Point(355, 313);
            this.checkBoxZenit.Name = "checkBoxZenit";
            this.checkBoxZenit.Size = new System.Drawing.Size(57, 17);
            this.checkBoxZenit.TabIndex = 11;
            this.checkBoxZenit.Text = "Броня";
            this.checkBoxZenit.UseVisualStyleBackColor = true;
            this.checkBoxZenit.CheckedChanged += new System.EventHandler(this.checkBoxZenit_CheckedChanged);
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.Location = new System.Drawing.Point(167, 350);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectColor.TabIndex = 12;
            this.buttonSelectColor.Text = "Цвет";
            this.buttonSelectColor.UseVisualStyleBackColor = true;
            this.buttonSelectColor.Click += new System.EventHandler(this.buttonSelectColor_Click);
            // 
            // buttonSelectDopColor
            // 
            this.buttonSelectDopColor.Location = new System.Drawing.Point(421, 303);
            this.buttonSelectDopColor.Name = "buttonSelectDopColor";
            this.buttonSelectDopColor.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectDopColor.TabIndex = 13;
            this.buttonSelectDopColor.Text = "Цвет";
            this.buttonSelectDopColor.UseVisualStyleBackColor = true;
            this.buttonSelectDopColor.Click += new System.EventHandler(this.buttonSelectDopColor_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(76, 269);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(42, 20);
            this.textBox4.TabIndex = 14;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Топливо";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(420, 79);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 16;
            this.buttonMove.Text = "Плыть";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 385);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.buttonSelectDopColor);
            this.Controls.Add(this.buttonSelectColor);
            this.Controls.Add(this.checkBoxZenit);
            this.Controls.Add(this.checkBoxBrony);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxBrony;
        private System.Windows.Forms.CheckBox checkBoxZenit;
        private System.Windows.Forms.Button buttonSelectColor;
        private System.Windows.Forms.Button buttonSelectDopColor;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonMove;
    }
}

