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
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(277, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // SelectStatusLabel
            // 
            SelectStatusLabel.AutoSize = true;
            SelectStatusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SelectStatusLabel.Location = new Point(277, 25);
            SelectStatusLabel.Name = "SelectStatusLabel";
            SelectStatusLabel.Size = new Size(97, 21);
            SelectStatusLabel.TabIndex = 1;
            SelectStatusLabel.Text = "Select Status";
            // 
            // Submit
            // 
            Submit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Submit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Submit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Submit.Location = new Point(693, 395);
            Submit.Name = "Submit";
            Submit.Size = new Size(95, 43);
            Submit.TabIndex = 2;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(84, 24);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(25, 21);
            IDLabel.TabIndex = 4;
            IDLabel.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(84, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(107, 29);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // EditStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(IDLabel);
            Controls.Add(Submit);
            Controls.Add(SelectStatusLabel);
            Controls.Add(comboBox1);
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
    }
}