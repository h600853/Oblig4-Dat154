namespace Maintance_App
{
    partial class HovedVindu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            addOrDeleteButton = new Button();
            editStatusButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 0;
            label1.Text = "Add or Delete";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 25);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 1;
            label2.Text = "Change Status";
            // 
            // addOrDeleteButton
            // 
            addOrDeleteButton.Location = new Point(24, 77);
            addOrDeleteButton.Name = "addOrDeleteButton";
            addOrDeleteButton.Size = new Size(142, 34);
            addOrDeleteButton.TabIndex = 2;
            addOrDeleteButton.Text = "Add or delete";
            addOrDeleteButton.UseVisualStyleBackColor = true;
            addOrDeleteButton.Click += addOrDelete_Click;
            // 
            // editStatusButton
            // 
            editStatusButton.Location = new Point(178, 77);
            editStatusButton.Name = "editStatusButton";
            editStatusButton.Size = new Size(112, 34);
            editStatusButton.TabIndex = 3;
            editStatusButton.Text = "Edit Status";
            editStatusButton.UseVisualStyleBackColor = true;
            editStatusButton.Click += editStatusButton_Click;
            // 
            // HovedVindu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editStatusButton);
            Controls.Add(addOrDeleteButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HovedVindu";
            Text = "Form1";
            Load += HovedVindu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button addOrDeleteButton;
        private Button editStatusButton;
    }
}