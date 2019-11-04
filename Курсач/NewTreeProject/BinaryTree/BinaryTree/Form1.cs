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
    public partial class Form1 : Form
    {
        public Pen MyPen = new Pen(Color.Black, 1);

        public Form1()
        {
            InitializeComponent();
            main_tree = new Tree(this);
        }

        Tree main_tree;

        public class Node
        {
            public Node Left = null;
            public Node Rigth = null;
            public int Value = 0;

            public int ID = 0;
            public int lvl = 0;
            public Node parent = null;

            public Node(int v, int l, int i)
            {
                Value = v;
                lvl = l;
                ID = i;
            }
        }
        public class Tree
        {
            public int Count = 0;
            public string OutS = "";
            private List<Node> OutL = new List<Node>();
            public Node root = null;
            Form1 f_m;
 
            public Tree() { }
            public Tree(Form1 fr)
            {
                f_m = fr;
            }
            //Draw: 
            public void DrawTree(ref List<int> xCount, int _lvl_, Node obj)
            {
                float w_r = 70;
                float h_r = 20;
                _lvl_++;
                int x = xCount[_lvl_ - 1] * 85 + _lvl_;
                int y = _lvl_ * 25;
                Graphics g = f_m.pictureBox1.CreateGraphics();

                if (obj == root)
                {
                    g.DrawRectangle(f_m.MyPen, x, y, 80, 20);
                    g.DrawString(obj.Value + " = " + "root", new Font("Courier New", 10), new SolidBrush(Color.Black), new Point(x + 2, y + 2));
                }
                else
                {
                    if (PerevParnt(obj) == 1)
                    {
                        g.DrawRectangle(new Pen(Color.Green), x, y, w_r, h_r);
                    }
                    else if (PerevParnt(obj) == 2)
                    {
                        g.DrawRectangle(new Pen(Color.Red), x, y, w_r, h_r);
                    }
                    g.DrawString(obj.Value + " < " + obj.parent.Value, new Font("Courier New", 10), new SolidBrush(f_m.MyPen.Color), new Point(x + 2, y + 2));
                }
                xCount[_lvl_ - 1]++;
            }
            //Для лени autoValue 
            public void AddDef()
            {
                Add(2);
                Add(1);
                Add(4);
                Add(3);
                Add(5);
            }
            //Обходы:
            public void GoToPick(Node obj, ref List<int> xI)
            {
                if (root == null)
                {
                    f_m.Logs.Text = "Tree null";
                }
                else
                {
                    DrawTree(ref xI, obj.lvl, obj);
                    if (obj.Left != null) GoToPick(obj.Left, ref xI);
                    if (obj.Rigth != null) GoToPick(obj.Rigth, ref xI);
                }
            }
            public void GoToDeep(Node obj)
            {
                if (root == null)
                {
                    f_m.Logs.Text = "Tree null";
                }
                else
                {
                    OutS += obj.Value + " ";
                    if (obj.Left != null) GoToDeep(obj.Left);
                    if (obj.Rigth != null) GoToDeep(obj.Rigth);
                }
            }
            public void GoToWeigth(Node root)
            {
                if (root == null)
                {
                    f_m.Logs.Text = "Tree null";
                }
                else
                {
                    Queue<Node> q = new Queue<Node>();
                    //Для начала поместим в очередь корень 
                    q.Enqueue(root);
                    while (q.Count != 0)
                    {
                        Node tmp = (Node)q.Dequeue();
                        OutS += (" " + tmp.Value);
                        //Если есть левый наследник, то помещаем его в очередь для дальнейшей обработки 
                        if (tmp.Left != null)
                        {
                            q.Enqueue(tmp.Left);
                        }
                        //Если есть правый наследник, то помещаем его в очередь для дальнейшей обработки 
                        if (tmp.Rigth != null)
                        {
                            q.Enqueue(tmp.Rigth);
                        }
                    }
                }
            }
            //Задачи: 
            //-->Поиск значения 
            public Node SearchValue(Node obj, int v)
            {
                Node b = new Node(v, obj.lvl, obj.ID);
                if (obj == null)
                    return null;
                if (obj.Value == v)
                    b = obj;
                else
                {
                    if (obj.Value > v)
                        b = SearchValue(obj.Left, v);
                    else
                        b = SearchValue(obj.Rigth, v);
                }
                return b;
            }
            //Работа со структурой: 
            public void Add(int v)
            {
                if (root == null)
                {
                    root = new Node(v, 0, 0);
                }
                else
                {
                    AddC(root, v);
                }
                Count++;
            }
            private void AddC(Node obj, int v)
            {
                if (obj.Value > v)
                {
                    if (obj.Left == null)
                    {
                        obj.Left = new Node(v, obj.lvl + 1, Count);
                        obj.Left.parent = obj;
                    }
                    else
                    {
                        AddC(obj.Left, v);
                    }
                }
                else
                {
                    if (obj.Rigth == null)
                    {
                        obj.Rigth = new Node(v, obj.lvl + 1, Count);
                        obj.Rigth.parent = obj;
                    }
                    else
                    {
                        AddC(obj.Rigth, v);
                    }
                }
            }
            public void Delete(int v)
            {
                if (root == null)
                {
                    OutS = "Root null";
                }
                else
                {
                    DelC(root, v);
                }
            }
            private void DelC(Node obj, int v)
            {
                if (obj.Value == v)
                {
                    if (AnalyticTypeForMinFindDel(obj) == 1)
                    {
                        obj.Value = FindMin(obj.Rigth);
                        DelC(obj.Rigth, FindMin(obj.Rigth));
                    }
                    else if (AnalyticTypeForMinFindDel(obj) == 2)
                    {
                        if (obj == root)
                        {
                            obj.Left.parent = null;
                            root = obj.Left;
                        }
                        else
                        {
                            obj.parent.Rigth = obj.Left;
                            obj.Left.parent = obj.parent;
                        }
                    }
                    else
                    {
                        if (obj == root)
                        {
                            root = null;
                        }
                        else if (PerevParnt(obj) == 1)
                        {
                            obj.parent.Rigth = null;
                            obj.parent = null;
                        }
                        else if (PerevParnt(obj) == 2)
                        {
                            obj.parent.Left = null;
                            obj.parent = null;
                        }
                    }
                }
                else if (obj.Value > v)
                {
                    if (obj.Left != null)
                        DelC(obj.Left, v);
                    else
                    {
                        OutS = "not found";
                    }
                }
                else if (obj.Value <= v)
                {
                    if (obj.Rigth != null)
                        DelC(obj.Rigth, v);
                    else
                    {
                        OutS = "not found";
                    }
                }
            }
            //Аналитические функции: 
            //-->Определение кем элемент является для родителя 
            private int PerevParnt(Node obj)
            {
                if (obj.parent.Left == obj)
                {
                    return 2;
                }
                else if (obj.parent.Rigth == obj)
                {
                    return 1;
                }
                return -1;
            }
            private int FindMin(Node obj)
            {
                int i = obj.Value;
                if (obj.Left != null)
                {
                    i = FindMin(obj.Left);
                }
                return i;
            }
            public void FindLvlDeep(Node obj, ref int max_lvl)
            {
                if (root == null)
                {
                    f_m.Logs.Text = "Tree null";
                }
                else
                {
                    if (max_lvl < obj.lvl)
                    {
                        max_lvl = obj.lvl;
                    }
                    if (obj.Left != null)
                    {
                        FindLvlDeep(obj.Left, ref max_lvl);
                    }
                    if (obj.Rigth != null)
                    {
                        FindLvlDeep(obj.Rigth, ref max_lvl);
                    }
                }
            }
            //-->Анализ типа случая(1 - есть правый, 2 - есть левый, нет правого, 3 - нет ни одного) 
            private int AnalyticTypeForMinFindDel(Node obj)
            {
                if (obj.Rigth != null)
                {
                    return 1;
                }
                else if (obj.Left == null)
                {
                    return 0;
                }
                return 2;
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == 0)
                while (main_tree.root != null)
                {
                    main_tree.Delete(main_tree.root.Value);
                }
            NameTextBox.Text = "Очистка";
            textBox1.Text = Logs.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                main_tree.Add((Convert.ToInt32(textBox1.Text)));
            }
            catch (FormatException)
            {
                Logs.Text = "String !digital";
            }
            finally
            {
                NameTextBox.Text = "Add element";
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                main_tree.Delete((Convert.ToInt32(textBox1.Text)));
            }
            catch (FormatException)
            {
                Logs.Text = "String !digital";
            }
            finally
            {
                NameTextBox.Text = "Del element";
                textBox1.Text = "";
            }
        }

        private void вГлубинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_tree.GoToDeep(main_tree.root);
            Logs.Text = main_tree.OutS;
            NameTextBox.Text = "Обход в глубину";
            main_tree.OutS = "";
        }

        /*private void поискЗначенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logs.Text = Convert.ToString(main_tree.SearchValue(main_tree.root, Convert.ToInt32(textBox1.Text)).ID);
            textBox1.Text = "";
        }*/

        private void отображениеУровняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Logs.Text = Convert.ToString(main_tree.SearchValue(main_tree.root, Convert.ToInt32(textBox1.Text)).lvl);
                textBox1.Text = "";
            }
            catch
            {
                NameTextBox.Text = "Отображение уровня";
                Logs.Text = "String !digital";
            }
        }

        private void вШиринуToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            main_tree.GoToWeigth(main_tree.root);
            Logs.Text = main_tree.OutS;
            NameTextBox.Text = "Обход в ширину";
            main_tree.OutS = "";
        }

        private void отрисоватьДеревоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*panel1.AutoScroll = true;//pictureBox1
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            */
            pictureBox1.Refresh();
            int max_lvl = 0;
            main_tree.FindLvlDeep(main_tree.root, ref max_lvl);
            List<int> weigthC = new List<int>();
            for (int i = 0; i <= max_lvl; i++)
            {
                weigthC.Add(0);
            }
            main_tree.GoToPick(main_tree.root, ref weigthC);
        }

        private void выбратьЦветОтрисовкиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                MyPen.Color = colorDialog1.Color;
            }
            NameTextBox.Text = "Выбор цвета отрисовки";
        }

        private void отрисоватьДеревоToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NameTextBox.Text = "Отрисовка дерева";
            pictureBox1.Refresh();
            int max_lvl = 0;
            main_tree.FindLvlDeep(main_tree.root, ref max_lvl);
            List<int> weigthC = new List<int>();
            for (int i = 0; i <= max_lvl; i++)
            {
                weigthC.Add(0);
            }
            main_tree.GoToPick(main_tree.root, ref weigthC);
        }

        private void тестовыеЗначенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_tree.AddDef();
            NameTextBox.Text = "Тестовые значения";
            main_tree.OutS = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm");
        }
    }
}