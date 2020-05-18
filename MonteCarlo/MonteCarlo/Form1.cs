using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarlo
{
    public partial class Form1 : Form
    {
        Random rn;
        Graphics graphic;
        double insideCircleCnt;
        double totalPointAmount;
        bool flag;
        public Form1()
        {
            InitializeComponent();
            graphic = panel1.CreateGraphics();
        }

        private void bthStart_Click(object sender, EventArgs e)
        {
            flag = true;
            insideCircleCnt = 0;
            totalPointAmount = 0;
            graphic.Clear(Color.Gray);
            Pen pen = new Pen(Color.Green);
            graphic.DrawEllipse(pen, 100, 65, (float)Convert.ToDouble(this.textBoxRad.Text), (float)Convert.ToDouble(this.textBoxRad.Text));
            graphic.DrawRectangle(pen, 100, 65, (float)Convert.ToDouble(this.textBoxRad.Text), (float)Convert.ToDouble(this.textBoxRad.Text));
            Random r = new Random();
            rn = new Random();
            for (int i = 0; i < Convert.ToDouble(this.textBoxCntThr.Text); i++)
            {
                Thread thread = new Thread(ThreadedDraw);
                thread.Start(unchecked((int)r.Next(unchecked((int)2863311530), unchecked((int)3500570100))));
                
            }
        }

        void DrawPoint(object i, Graphics k)
        {
            k = panel1.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(unchecked((int)i)), 2);
            int x = rn.Next(100, 100 + Convert.ToInt32(this.textBoxRad.Text));
            int y = rn.Next(65, 65 + Convert.ToInt32(this.textBoxRad.Text));
            k.DrawEllipse(pen, x, y, 1, 1);
            if (InCircle(Convert.ToInt32(this.textBoxRad.Text), x, y)) insideCircleCnt++;
            totalPointAmount++;
            Thread.Sleep(Convert.ToInt32(this.textBoxSpeed.Text));
        }
        void ThreadedDraw(object i)
        {
            while (flag)
            {
                DrawPoint(i, graphic);
            }

        }
        bool InCircle(double radius, double x, double y)
        {
            double xcentr = radius / 2 + 100;
            double ycentr = radius / 2 + 65;
            return (((x- xcentr) * (x- xcentr) + (y- ycentr) * (y- ycentr)) <= (radius/2) * (radius/2));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            flag = false;
            this.textBoxSqr.Text = ((2 * Convert.ToInt32(textBoxRad.Text)) * (2 * Convert.ToInt32(textBoxRad.Text))).ToString();
            this.textBoxSqr2.Text = ((2 * Convert.ToInt32(textBoxRad.Text)) * (2 * Convert.ToInt32(textBoxRad.Text)) * insideCircleCnt / totalPointAmount).ToString();
            this.textBox1.Text = (4*insideCircleCnt / totalPointAmount).ToString();
        }
    }
     
}
