using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTree
{
    public partial class Autorisation : Form
    {
        public Autorisation()
        {
            InitializeComponent();
            logpas = new Dictionary<string, string>();
            logpas.Add("admin", "admin");
        }

        public Dictionary<string, string> logpas;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginCheck())
            {
                mainform f = new mainform();
                f.Show();
                this.Hide();
            }
            else
            {
                label3.Text = "Error";
                label3.Visible = true;
            }
        }

        private bool LoginCheck()
        {
            foreach (var t in logpas)
            {
                if (t.Value == textBox2.Text && t.Key == textBox1.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//добавить файл с лп
            try
            {
                logpas.Add(textBox1.Text, textBox2.Text);
                label3.Visible = false;
            }
            catch { label3.Text = "Again?"; }
        }
    }
}
