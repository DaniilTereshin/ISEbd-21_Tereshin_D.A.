﻿namespace WindowsFormsApplication3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSetCar = new System.Windows.Forms.Button();
            this.buttonSetGru = new System.Windows.Forms.Button();
            this.buttonTakeCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxTakeCar = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonDown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxParking.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(659, 404);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            this.pictureBoxParking.Click += new System.EventHandler(this.pictureBoxParking_Click);
            // 
            // buttonSetCar
            // 
            this.buttonSetCar.Location = new System.Drawing.Point(760, 186);
            this.buttonSetCar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetCar.Name = "buttonSetCar";
            this.buttonSetCar.Size = new System.Drawing.Size(138, 41);
            this.buttonSetCar.TabIndex = 1;
            this.buttonSetCar.Text = "Пришвартовать корабль";
            this.buttonSetCar.UseVisualStyleBackColor = true;
            this.buttonSetCar.Click += new System.EventHandler(this.buttonSetCar_Click_1);
            // 
            // buttonSetGru
            // 
            this.buttonSetGru.Location = new System.Drawing.Point(760, 231);
            this.buttonSetGru.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetGru.Name = "buttonSetGru";
            this.buttonSetGru.Size = new System.Drawing.Size(138, 40);
            this.buttonSetGru.TabIndex = 2;
            this.buttonSetGru.Text = "Пришвартовать крейсер";
            this.buttonSetGru.UseVisualStyleBackColor = true;
            this.buttonSetGru.Click += new System.EventHandler(this.buttonSetGru_Click);
            // 
            // buttonTakeCar
            // 
            this.buttonTakeCar.Location = new System.Drawing.Point(668, 326);
            this.buttonTakeCar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTakeCar.Name = "buttonTakeCar";
            this.buttonTakeCar.Size = new System.Drawing.Size(94, 31);
            this.buttonTakeCar.TabIndex = 3;
            this.buttonTakeCar.Text = "Забрать";
            this.buttonTakeCar.UseVisualStyleBackColor = true;
            this.buttonTakeCar.Click += new System.EventHandler(this.buttonTakeCar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Забрать корабль";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(718, 285);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 285);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Место";
            // 
            // pictureBoxTakeCar
            // 
            this.pictureBoxTakeCar.Location = new System.Drawing.Point(668, 362);
            this.pictureBoxTakeCar.Name = "pictureBoxTakeCar";
            this.pictureBoxTakeCar.Size = new System.Drawing.Size(145, 34);
            this.pictureBoxTakeCar.TabIndex = 7;
            this.pictureBoxTakeCar.TabStop = false;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(668, 2);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(178, 134);
            this.listBoxLevels.TabIndex = 8;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(668, 151);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(75, 23);
            this.buttonDown.TabIndex = 9;
            this.buttonDown.Text = "buttonDown";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(771, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "buttonUp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.pictureBoxTakeCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTakeCar);
            this.Controls.Add(this.buttonSetGru);
            this.Controls.Add(this.buttonSetCar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetCar;
        private System.Windows.Forms.Button buttonSetGru;
        private System.Windows.Forms.Button buttonTakeCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxTakeCar;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button button1;
    }
}