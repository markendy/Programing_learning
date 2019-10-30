using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dan9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] str_main = richTextBox1.Text.ToCharArray();
            for(int i = 0; i < str_main.Length; i++)
            {
                if(Chek(i, str_main)>0 && str_main[i]!='*')
                {
                    str_main[Chek(i, str_main)] = '*';
                    str_main[i] = '*';
                }
            }
            for(int i = 0; i < str_main.Length; i++)
            {
                if (str_main[i] != '*')
                {
                   richTextBox1.Select(i,1);
                   richTextBox1.SelectionColor=Color.Red;
                }
            }
        }

        public int Chek(int nomer, char[] str)
        {
            switch (str[nomer])
            {
                case '(':
                    if (CaseIt(nomer,')', str)>0)
                    {
                        return CaseIt(nomer,')',str);
                    }
                    break;
                case '[':
                    if (CaseIt(nomer,']', str) > 0)
                    {
                        return CaseIt(nomer,']', str);
                    }
                    break;
            }
            return -1;
        }
         
        public int CaseIt(int n, char sk, char[] str)
        {
            for(int i = n; i< str.Length; i++)
            {
                if (str[i]=='*')
                {
                    return -1;
                }
                if (str[i] == sk)
                {
                    return i;
                }
            }
            return -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
