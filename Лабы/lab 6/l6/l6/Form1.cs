using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l6
{
    public partial class Form1 : Form
    {
        static float centerX = 0.0f;
        static float centerY = 0.0f;
        static float diametr = 180.0f;
        static float radius = diametr / 2;

        bool dir = true;

        static int time = 0;

        Pen Str = new Pen(Color.Red, 2);
        Pen Round = new Pen(Color.Purple, 2);

        static float x = radius - diametr / 30;//def
        static float xd = x;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void DrawUp(float x, int pen)
        {
            float m_x = x - radius;
            Graphics g = pictureBox1.CreateGraphics();
            float m_y = radius - (float)(Math.Sqrt((Math.Pow(radius, 2) - Math.Pow(m_x, 2))));
            if (pen == 1)
            {
                Str.Color = Color.Red;
                g.DrawLine(Str, radius, radius, x, m_y);
                g.DrawEllipse(Round, centerX, centerY, diametr, diametr);
            }
            else if (pen == 3)
            {
                Str.Color = Color.White;
                g.DrawLine(Str, radius, radius, x, m_y);
                g.DrawEllipse(Round, centerX, centerY, diametr, diametr);
            }
            else
            {
                Str.Color = Color.Blue;
                g.DrawLine(Str, radius, radius, x, m_y);
                g.DrawEllipse(Round, centerX, centerY, diametr, diametr);
            }
        }

        public void DrawUnd(float x, int pen)
        {
            float m_x = x - radius;
            Graphics g = pictureBox1.CreateGraphics();
            float m_y = radius + (float)(Math.Sqrt((Math.Pow(radius, 2) - Math.Pow(m_x, 2))));
            if (pen == 1)
            {
                Str.Color = Color.Red;
                g.DrawLine(Str, radius, radius, x, m_y);
                g.DrawEllipse(Round, centerX, centerY, diametr, diametr);
            }
            else if (pen == 3)
            {
                Str.Color = Color.White;
                g.DrawLine(Str, radius, radius, x, m_y);
                g.DrawEllipse(Round, centerX, centerY, diametr, diametr);
            }
            else
            {
                Str.Color = Color.Blue;
                g.DrawLine(Str, radius, radius, x, m_y);
                g.DrawEllipse(Round, centerX, centerY, diametr, diametr);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawEllipse(Round, centerX, centerY, diametr, diametr);
            timer1.Enabled = true;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 1;
            if (x < diametr && dir == true)
            {
                if (time % 2 == 0)
                {
                    DrawUp(x, 3);
                    x += (float)diametr / 30f;
                    DrawUp(x, 1);
                }
                else
                {
                    DrawUp(x, 3);
                    x += (float)diametr / 30f;
                    DrawUp(x, 2);
                }
            }
            else
            {
                dir = false;
                if (time % 2 == 0)
                {
                    DrawUnd(x, 3);
                    x -= (float)diametr / 30f;
                    DrawUnd(x, 1);
                }
                else
                {
                    DrawUnd(x, 3);
                    x -= (float)diametr / 30f;
                    DrawUnd(x, 2);
                }
                if (x <= 0)
                {
                    x = 0;
                    dir = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
