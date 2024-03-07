namespace employment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("показать");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Актуальные вакансии", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("показать ");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Оставленные заявления", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("показать");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("О нас", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vacancies = new System.Windows.Forms.TreeView();
            this.entity = new System.Windows.Forms.TreeView();
            this.county = new System.Windows.Forms.TreeView();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(220, 528);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // vacancies
            // 
            this.vacancies.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.vacancies.Location = new System.Drawing.Point(12, 103);
            this.vacancies.Name = "vacancies";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "показать";
            treeNode2.Name = "vacancies";
            treeNode2.Tag = "";
            treeNode2.Text = "Актуальные вакансии";
            this.vacancies.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.vacancies.Size = new System.Drawing.Size(198, 41);
            this.vacancies.TabIndex = 4;
            this.vacancies.Visible = false;
            this.vacancies.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.vacancies_text);
            // 
            // entity
            // 
            this.entity.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.entity.Location = new System.Drawing.Point(12, 150);
            this.entity.Name = "entity";
            treeNode3.Name = "Узел0";
            treeNode3.Text = "показать ";
            treeNode4.Name = "entity";
            treeNode4.Text = "Оставленные заявления";
            this.entity.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.entity.Size = new System.Drawing.Size(198, 38);
            this.entity.TabIndex = 5;
            this.entity.Visible = false;
            this.entity.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.entity_text);
            // 
            // county
            // 
            this.county.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.county.Location = new System.Drawing.Point(12, 394);
            this.county.Name = "county";
            treeNode5.Name = "Узел0";
            treeNode5.Text = "показать";
            treeNode6.Name = "Country";
            treeNode6.Text = "О нас";
            this.county.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.county.Size = new System.Drawing.Size(198, 37);
            this.county.TabIndex = 6;
            this.county.Visible = false;
            this.county.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.about_text);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(257, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 86);
            this.button3.TabIndex = 9;
            this.button3.Text = "показать боковой интерфейс";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 126);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(497, 158);
            this.textBox1.TabIndex = 10;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(12, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "скрыть боковой интерфейс\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(803, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 131);
            this.button2.TabIndex = 12;
            this.button2.Text = "сохранить и отправить";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(440, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 86);
            this.button4.TabIndex = 13;
            this.button4.Text = "оставить заявку на работу";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(257, 167);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(511, 349);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(257, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(977, 528);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.county);
            this.Controls.Add(this.entity);
            this.Controls.Add(this.vacancies);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Employment";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView vacancies;
        private System.Windows.Forms.TreeView entity;
        private System.Windows.Forms.TreeView county;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

