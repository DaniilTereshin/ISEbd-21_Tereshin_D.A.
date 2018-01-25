namespace WindowsFormsApplication3
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
            this.pictureBoxPort = new System.Windows.Forms.PictureBox();
            this.buttonSetShip = new System.Windows.Forms.Button();
            this.buttonSetGru = new System.Windows.Forms.Button();
            this.buttonTakeShip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxTakeShip = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonDown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPort
            // 
            this.pictureBoxPort.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPort.Name = "pictureBoxPort";
            this.pictureBoxPort.Size = new System.Drawing.Size(659, 404);
            this.pictureBoxPort.TabIndex = 0;
            this.pictureBoxPort.TabStop = false;
            this.pictureBoxPort.Click += new System.EventHandler(this.pictureBoxPort_Click);
            // 
            // buttonSetShip
            // 
            this.buttonSetShip.Location = new System.Drawing.Point(760, 186);
            this.buttonSetShip.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetShip.Name = "buttonSetShip";
            this.buttonSetShip.Size = new System.Drawing.Size(138, 41);
            this.buttonSetShip.TabIndex = 1;
            this.buttonSetShip.Text = "Пришвартовать корабль";
            this.buttonSetShip.UseVisualStyleBackColor = true;
            this.buttonSetShip.Click += new System.EventHandler(this.buttonSetShip_Click);
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
            this.buttonSetGru.Click += new System.EventHandler(this.buttonSetKreiser_Click);
            // 
            // buttonTakeShip
            // 
            this.buttonTakeShip.Location = new System.Drawing.Point(829, 285);
            this.buttonTakeShip.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTakeShip.Name = "buttonTakeShip";
            this.buttonTakeShip.Size = new System.Drawing.Size(94, 31);
            this.buttonTakeShip.TabIndex = 3;
            this.buttonTakeShip.Text = "Забрать";
            this.buttonTakeShip.UseVisualStyleBackColor = true;
            this.buttonTakeShip.Click += new System.EventHandler(this.buttonTakeShip_Click);
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
            // pictureBoxTakeShip
            // 
            this.pictureBoxTakeShip.Location = new System.Drawing.Point(759, 398);
            this.pictureBoxTakeShip.Name = "pictureBoxTakeShip";
            this.pictureBoxTakeShip.Size = new System.Drawing.Size(246, 126);
            this.pictureBoxTakeShip.TabIndex = 7;
            this.pictureBoxTakeShip.TabStop = false;
            this.pictureBoxTakeShip.Click += new System.EventHandler(this.pictureBoxTakeShip_Click);
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(668, 2);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(178, 134);
            this.listBoxLevels.TabIndex = 8;
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
            this.ClientSize = new System.Drawing.Size(1050, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.pictureBoxPort);
            this.Controls.Add(this.pictureBoxTakeShip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTakeShip);
            this.Controls.Add(this.buttonSetGru);
            this.Controls.Add(this.buttonSetShip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeShip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPort;
        private System.Windows.Forms.Button buttonSetShip;
        private System.Windows.Forms.Button buttonSetGru;
        private System.Windows.Forms.Button buttonTakeShip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxTakeShip;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button button1;
    }
}