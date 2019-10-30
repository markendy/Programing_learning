using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static float diametr = 180;
        static float centerX = 0;
        static float centerY = 0;
        static float radius = diametr / 2;

        static float x = 0;
        static float y = 0;

        static int time = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            Graphics g = pictureBox1.CreateGraphics();
            Pen P1 = new Pen(Color.Red, 2);
            g.DrawEllipse(new Pen(Color.Purple, 2), centerX, centerY, diametr, diametr);
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
