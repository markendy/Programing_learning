namespace BinaryTree
{
    partial class mainform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NameTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Logs = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.задачаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вГлубинуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вШиринуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отображениеУровняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестовыеЗначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отрисовкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отрисоватьДеревоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьЦветОтрисовкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Clear Tree"});
            this.checkedListBox1.Location = new System.Drawing.Point(5, 288);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(122, 19);
            this.checkedListBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(6, 311);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "All clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.Logs);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 338);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Структура";
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSize = true;
            this.NameTextBox.Location = new System.Drawing.Point(6, 85);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(56, 13);
            this.NameTextBox.TabIndex = 10;
            this.NameTextBox.Text = "Opecation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Logs:";
            // 
            // Logs
            // 
            this.Logs.Location = new System.Drawing.Point(6, 62);
            this.Logs.Name = "Logs";
            this.Logs.ReadOnly = true;
            this.Logs.Size = new System.Drawing.Size(121, 20);
            this.Logs.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 22);
            this.button3.TabIndex = 6;
            this.button3.Text = "Del";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 18);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 22);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 31);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задачаToolStripMenuItem,
            this.задачиToolStripMenuItem,
            this.отрисовкаToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(37, 28);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // задачаToolStripMenuItem
            // 
            this.задачаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вГлубинуToolStripMenuItem,
            this.вШиринуToolStripMenuItem});
            this.задачаToolStripMenuItem.Name = "задачаToolStripMenuItem";
            this.задачаToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.задачаToolStripMenuItem.Text = "Обход";
            // 
            // вГлубинуToolStripMenuItem
            // 
            this.вГлубинуToolStripMenuItem.Name = "вГлубинуToolStripMenuItem";
            this.вГлубинуToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.вГлубинуToolStripMenuItem.Text = "В глубину";
            this.вГлубинуToolStripMenuItem.Click += new System.EventHandler(this.вГлубинуToolStripMenuItem_Click);
            // 
            // вШиринуToolStripMenuItem
            // 
            this.вШиринуToolStripMenuItem.Name = "вШиринуToolStripMenuItem";
            this.вШиринуToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.вШиринуToolStripMenuItem.Text = "В ширину";
            this.вШиринуToolStripMenuItem.Click += new System.EventHandler(this.вШиринуToolStripMenuItem_Click_1);
            // 
            // задачиToolStripMenuItem
            // 
            this.задачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отображениеУровняToolStripMenuItem,
            this.тестовыеЗначенияToolStripMenuItem});
            this.задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            this.задачиToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.задачиToolStripMenuItem.Text = "Задачи";
            // 
            // отображениеУровняToolStripMenuItem
            // 
            this.отображениеУровняToolStripMenuItem.Name = "отображениеУровняToolStripMenuItem";
            this.отображениеУровняToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.отображениеУровняToolStripMenuItem.Text = "Отображение уровня";
            this.отображениеУровняToolStripMenuItem.Click += new System.EventHandler(this.отображениеУровняToolStripMenuItem_Click);
            // 
            // тестовыеЗначенияToolStripMenuItem
            // 
            this.тестовыеЗначенияToolStripMenuItem.Name = "тестовыеЗначенияToolStripMenuItem";
            this.тестовыеЗначенияToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.тестовыеЗначенияToolStripMenuItem.Text = "Тестовые значения";
            this.тестовыеЗначенияToolStripMenuItem.Click += new System.EventHandler(this.тестовыеЗначенияToolStripMenuItem_Click);
            // 
            // отрисовкаToolStripMenuItem
            // 
            this.отрисовкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отрисоватьДеревоToolStripMenuItem,
            this.выбратьЦветОтрисовкиToolStripMenuItem});
            this.отрисовкаToolStripMenuItem.Name = "отрисовкаToolStripMenuItem";
            this.отрисовкаToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.отрисовкаToolStripMenuItem.Text = "Отрисовка";
            // 
            // отрисоватьДеревоToolStripMenuItem
            // 
            this.отрисоватьДеревоToolStripMenuItem.Name = "отрисоватьДеревоToolStripMenuItem";
            this.отрисоватьДеревоToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.отрисоватьДеревоToolStripMenuItem.Text = "Отрисовать дерево";
            this.отрисоватьДеревоToolStripMenuItem.Click += new System.EventHandler(this.отрисоватьДеревоToolStripMenuItem_Click_1);
            // 
            // выбратьЦветОтрисовкиToolStripMenuItem
            // 
            this.выбратьЦветОтрисовкиToolStripMenuItem.Name = "выбратьЦветОтрисовкиToolStripMenuItem";
            this.выбратьЦветОтрисовкиToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.выбратьЦветОтрисовкиToolStripMenuItem.Text = "Выбрать цвет отрисовки";
            this.выбратьЦветОтрисовкиToolStripMenuItem.Click += new System.EventHandler(this.выбратьЦветОтрисовкиToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(147, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 332);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // mainform
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 391);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "mainform";
            this.Text = "TreeProg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem задачаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вГлубинуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вШиринуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отображениеУровняToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Logs;
        private System.Windows.Forms.ToolStripMenuItem отрисовкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отрисоватьДеревоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьЦветОтрисовкиToolStripMenuItem;
        private System.Windows.Forms.Label NameTextBox;
        private System.Windows.Forms.ToolStripMenuItem тестовыеЗначенияToolStripMenuItem;
    }
}

