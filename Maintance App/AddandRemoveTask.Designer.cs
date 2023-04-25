namespace Maintance_App
{
    partial class AddandRemoveTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 93);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(69, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 93);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 2;
            label2.Text = "Enter Task";
            label2.Click += label2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(246, 121);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(210, 133);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(509, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(542, 93);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 6;
            label3.Text = "Select Type";
            // 
            // button1
            // 
            button1.Location = new Point(404, 323);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(542, 323);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 93);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 9;
            label4.Text = "Roomnumber";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(86, 31);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 5);
            label5.Name = "label5";
            label5.Size = new Size(416, 25);
            label5.TabIndex = 11;
            label5.Text = "Fill roomnumber, enter task and select type to add.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 40);
            label6.Name = "label6";
            label6.Size = new Size(128, 25);
            label6.TabIndex = 12;
            label6.Text = "Fill id to delete";
            // 
            // AddandRemoveTask
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AddandRemoveTask";
            Text = "AddandRemoveTask";
            Load += AddandRemoveTask_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
    }
}