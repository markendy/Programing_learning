using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(new Pen(Color.Red), 0, 0, 300, 170);
            MessageBox.Show("Test 1", "Test 2", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);           
        }
    }
}
