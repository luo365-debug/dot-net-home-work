using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        string color;

        void drawLine(double x0, double y0,double x1, double y1)//画线
        {
            switch (color)
            {
                case "Blue":
                    graphics.DrawLine(Pens.Blue,
                        new Point((int)x0, (int)y0),
                        new Point((int)x1, (int)y1)
                        );break;
                case "Black":
                    graphics.DrawLine(Pens.Black,
                        new Point((int)x0, (int)y0),
                        new Point((int)x1, (int)y1)
                        );break;
                case "Red":
                    graphics.DrawLine(Pens.Red,
                        new Point((int)x0, (int)y0),
                        new Point((int)x1, (int)y1)
                        ); break;
                case "Yellow":
                    graphics.DrawLine(Pens.Yellow,
                        new Point((int)x0, (int)y0),
                        new Point((int)x1, (int)y1)
                        );break;
                default:
                    graphics.DrawLine(Pens.Green,
                        new Point((int)x0, (int)y0),
                        new Point((int)x1, (int)y1)
                        ); break;
            }

        }
        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        private void button_Start_Click(object sender, EventArgs e)//开始做图
        {
            if (graphics == null) 
                graphics = this.CreateGraphics();
            th1 = textBoxth1.Text == "" ? 30 * Math.PI / 180 : double.Parse(textBoxth1.Text);
            th2 = textBoxth2.Text == "" ? 20 * Math.PI / 180 : double.Parse(textBoxth2.Text);
            per1 = textBoxper1.Text == "" || Math.Abs(double.Parse(textBoxper1.Text)) > 1 ? 0.6 : double.Parse(textBoxper1.Text);
            per2 = textBoxper2.Text == "" || Math.Abs(double.Parse(textBoxper2.Text)) > 1 ? 0.7 : double.Parse(textBoxper2.Text);
            int n = textBoxn.Text == "" ? 10 : int.Parse(textBoxn.Text);
            int length = textBoxlen.Text == "" ? 100 : int.Parse(textBoxlen.Text);


            drawCayleyTree(n, 200, 310, length, -Math.PI / 2);
        }

        private void Blue_CheckedChanged_1(object sender, EventArgs e)
        {
            color = "Blue";
        }

        private void Red_CheckedChanged_1(object sender, EventArgs e)
        {
            color = "Red";
        }

        private void Black_CheckedChanged_1(object sender, EventArgs e)
        {
            color = "Black";
        }

        private void Yellow_CheckedChanged_1(object sender, EventArgs e)
        {
            color = "Yellow";
        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }
    }
}
