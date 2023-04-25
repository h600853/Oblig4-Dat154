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
            rolleVinduPanel = new Panel();
            rolleVinduPanel.SuspendLayout();
            SuspendLayout();
            // 
            // selectRoleLabel
            // 
            selectRoleLabel.AutoSize = true;
            selectRoleLabel.Location = new Point(318, 97);
            selectRoleLabel.Name = "selectRoleLabel";
            selectRoleLabel.Size = new Size(134, 25);
            selectRoleLabel.TabIndex = 0;
            selectRoleLabel.Text = "Select your role";
            // 
            // cleaningButton
            // 
            cleaningButton.Location = new Point(167, 203);
            cleaningButton.Name = "cleaningButton";
            cleaningButton.Size = new Size(132, 45);
            cleaningButton.TabIndex = 1;
            cleaningButton.Text = "Cleaning";
            cleaningButton.UseVisualStyleBackColor = true;
            cleaningButton.Click += cleaningButton_Click;
            // 
            // ServiceButton
            // 
            ServiceButton.Location = new Point(318, 203);
            ServiceButton.Name = "ServiceButton";
            ServiceButton.Size = new Size(144, 45);
            ServiceButton.TabIndex = 2;
            ServiceButton.Text = "Service";
            ServiceButton.UseVisualStyleBackColor = true;
            ServiceButton.Click += ServiceButton_Click;
            // 
            // maintanceButton
            // 
            maintanceButton.Location = new Point(481, 203);
            maintanceButton.Name = "maintanceButton";
            maintanceButton.Size = new Size(136, 45);
            maintanceButton.TabIndex = 3;
            maintanceButton.Text = "Maintance";
            maintanceButton.UseVisualStyleBackColor = true;
            maintanceButton.Click += maintanceButton_Click;
            // 
            // rolleVinduPanel
            // 
            rolleVinduPanel.Controls.Add(maintanceButton);
            rolleVinduPanel.Controls.Add(selectRoleLabel);
            rolleVinduPanel.Controls.Add(cleaningButton);
            rolleVinduPanel.Controls.Add(ServiceButton);
            rolleVinduPanel.Location = new Point(-5, -2);
            rolleVinduPanel.Name = "rolleVinduPanel";
            rolleVinduPanel.Size = new Size(807, 452);
            rolleVinduPanel.TabIndex = 4;
            // 
            // RolleVindu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rolleVinduPanel);
            Name = "RolleVindu";
            Text = "RolleVindu";
            Load += RolleVindu_Load;
            SizeChanged += RolleVindu_SizeChanged;
            rolleVinduPanel.ResumeLayout(false);
            rolleVinduPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label selectRoleLabel;
        private Button cleaningButton;
        private Button ServiceButton;
        private Button maintanceButton;
        private Panel rolleVinduPanel;
    }
}