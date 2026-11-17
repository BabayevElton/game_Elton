
using System;
using System.Drawing;
using System.Windows.Forms;

namespace game_Elton
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();

            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // Panel (Raket)
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(517, 476);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 40);
            panel1.TabIndex = 0;

            // Timer
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;

            // Ball
            pictureBox1.Location = new Point(547, 236);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;

            // Left Button
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(154, 632);
            button1.Name = "button1";
            button1.Size = new Size(198, 51);
            button1.TabIndex = 2;
            button1.Text = "<-- LEFT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

            // Right Button
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(415, 632);
            button2.Name = "button2";
            button2.Size = new Size(198, 51);
            button2.TabIndex = 3;
            button2.Text = "RIGHT -->";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;

            // Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1296, 764);

            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);

            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";

            Load += Form1_Load;
            KeyDown += Form1_KeyDown;

            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}
