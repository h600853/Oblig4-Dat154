namespace Maintance_App
{
    partial class RolleVindu
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
            selectRoleLabel = new Label();
            cleaningButton = new Button();
            ServiceButton = new Button();
            maintanceButton = new Button();
            SuspendLayout();
            // 
            // selectRoleLabel
            // 
            selectRoleLabel.AutoSize = true;
            selectRoleLabel.Location = new Point(300, 112);
            selectRoleLabel.Name = "selectRoleLabel";
            selectRoleLabel.Size = new Size(134, 25);
            selectRoleLabel.TabIndex = 0;
            selectRoleLabel.Text = "Select your role";
            // 
            // cleaningButton
            // 
            cleaningButton.Location = new Point(165, 215);
            cleaningButton.Name = "cleaningButton";
            cleaningButton.Size = new Size(112, 34);
            cleaningButton.TabIndex = 1;
            cleaningButton.Text = "Cleaning";
            cleaningButton.UseVisualStyleBackColor = true;
            cleaningButton.Click += cleaningButton_Click;
            // 
            // ServiceButton
            // 
            ServiceButton.Location = new Point(322, 215);
            ServiceButton.Name = "ServiceButton";
            ServiceButton.Size = new Size(112, 34);
            ServiceButton.TabIndex = 2;
            ServiceButton.Text = "Service";
            ServiceButton.UseVisualStyleBackColor = true;
            ServiceButton.Click += ServiceButton_Click;
            // 
            // maintanceButton
            // 
            maintanceButton.Location = new Point(476, 215);
            maintanceButton.Name = "maintanceButton";
            maintanceButton.Size = new Size(112, 34);
            maintanceButton.TabIndex = 3;
            maintanceButton.Text = "Maintance";
            maintanceButton.UseVisualStyleBackColor = true;
            maintanceButton.Click += maintanceButton_Click;
            // 
            // RolleVindu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maintanceButton);
            Controls.Add(ServiceButton);
            Controls.Add(cleaningButton);
            Controls.Add(selectRoleLabel);
            Name = "RolleVindu";
            Text = "RolleVindu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectRoleLabel;
        private Button cleaningButton;
        private Button ServiceButton;
        private Button maintanceButton;
    }
}