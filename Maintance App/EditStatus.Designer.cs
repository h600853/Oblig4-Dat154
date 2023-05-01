namespace Maintance_App
{
    partial class EditStatus
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
            comboBox1 = new ComboBox();
            SelectStatusLabel = new Label();
            Submit = new Button();
            IDLabel = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(774, 134);
            comboBox1.Margin = new Padding(5, 6, 5, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 40);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // SelectStatusLabel
            // 
            SelectStatusLabel.AutoSize = true;
            SelectStatusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SelectStatusLabel.Location = new Point(774, 60);
            SelectStatusLabel.Margin = new Padding(5, 0, 5, 0);
            SelectStatusLabel.Name = "SelectStatusLabel";
            SelectStatusLabel.Size = new Size(149, 32);
            SelectStatusLabel.TabIndex = 1;
            SelectStatusLabel.Text = "Select Status";
            // 
            // Submit
            // 
            Submit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Submit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Submit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Submit.Location = new Point(876, 193);
            Submit.Margin = new Padding(5, 6, 5, 6);
            Submit.Name = "Submit";
            Submit.Size = new Size(177, 92);
            Submit.TabIndex = 2;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(86, 60);
            IDLabel.Margin = new Padding(5, 0, 5, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(37, 32);
            IDLabel.TabIndex = 4;
            IDLabel.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(86, 135);
            textBox1.Margin = new Padding(5, 6, 5, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 39);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(414, 134);
            comboBox2.Margin = new Padding(5, 6, 5, 6);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(221, 40);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 7;
            label1.Text = "Select Task";
            label1.Click += label1_Click;
            // 
            // EditStatus
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 311);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(IDLabel);
            Controls.Add(Submit);
            Controls.Add(SelectStatusLabel);
            Controls.Add(comboBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "EditStatus";
            Text = "EditStatus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label SelectStatusLabel;
        private Button Submit;
        private Label IDLabel;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label1;
    }
}