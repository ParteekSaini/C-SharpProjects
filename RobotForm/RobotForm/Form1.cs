using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotForm
{
    public partial class Form1 : Form
    {
        Robot robot = new Robot();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, QueryAccessibilityHelpEventArgs e)
        {
            label1.Text = robot.ToString();
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            robot.location = label1.Location;
            panel1.Controls.Add(label1);
            label2.Text = robot.GetFormattedLocation();
        }

        private void nButton_Click(object sender, EventArgs e)
        {
            robot.direction = Direction.North;
            label1.Text = robot.ToString();
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            robot.direction = Direction.East;
            label1.Text = robot.ToString();
        }

        private void wButton_Click(object sender, EventArgs e)
        {
            robot.direction = Direction.West;
            label1.Text = robot.ToString();
        }

        private void sButton_Click(object sender, EventArgs e)
        {
            robot.direction = Direction.South;
            label1.Text = robot.ToString();
        }

        private void go10Button_Click(object sender, EventArgs e)
        {
            robot.move(10);
            label1.Location = robot.location;
            label2.Text = robot.GetFormattedLocation();
            if (robot.location.X <= 210 && robot.location.X >= 0 && robot.location.Y >=0 && robot.location.Y <=130)
            {
                panel1.Focus();
            }
            else
            {
                MessageBox.Show("You have reached maximum steps in direction " + robot.direction);
                
            }
        }

        private void go1Button_Click(object sender, EventArgs e)
        {
            robot.move(1);
            label1.Location = robot.location;
            label2.Text = robot.GetFormattedLocation();
            if (robot.location.X <= 210 && robot.location.X >= 0 && robot.location.Y >= 0 && robot.location.Y <= 130)
            {
                panel1.Focus();
            }
            else
            {
                MessageBox.Show("You have reached maximum steps in direction " + robot.direction);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
