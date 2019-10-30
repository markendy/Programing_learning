using System;
using System.IO;
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
        public string FilePath = "";
        public int answ = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "9 8 5 3")
            {
                textBox1.Text = "2 6 0 9 2 0 1 9";
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog1.FileName;
                string[] contant = File.ReadAllText(FilePath).Split('\r', '\n', ' ');
                foreach (string s in contant)
                {
                    if (s != "")
                    {
                        answ += Convert.ToInt32(s);
                    }
                }
                textBox1.Text = answ.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "9 8 5 3")
            {
                textBox1.Text = "2 6 0 9 2 0 1 9";
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath = saveFileDialog1.FileName;
                File.WriteAllText(FilePath, textBox1.Text);
            }
        }
    }
}