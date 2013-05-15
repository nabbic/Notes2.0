namespace NotesApp
{
    partial class browserSettings
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
            this.inetGrpBox = new System.Windows.Forms.GroupBox();
            this.saveSettings = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loopcareGrpBox = new System.Windows.Forms.GroupBox();
            this.vnetGrpBox = new System.Windows.Forms.GroupBox();
            this.cdpiTicketGrpBox = new System.Windows.Forms.GroupBox();
            this.cdpiTicketPassword = new wmgCMS.WaterMarkTextBox();
            this.cdpiTicketUsername = new wmgCMS.WaterMarkTextBox();
            this.vnetPassword = new wmgCMS.WaterMarkTextBox();
            this.vnetUsername = new wmgCMS.WaterMarkTextBox();
            this.loopcarePassword = new wmgCMS.WaterMarkTextBox();
            this.loopcareUsername = new wmgCMS.WaterMarkTextBox();
            this.InetPassword = new wmgCMS.WaterMarkTextBox();
            this.inetUsername = new wmgCMS.WaterMarkTextBox();
            this.inetGrpBox.SuspendLayout();
            this.loopcareGrpBox.SuspendLayout();
            this.vnetGrpBox.SuspendLayout();
            this.cdpiTicketGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inetGrpBox
            // 
            this.inetGrpBox.Controls.Add(this.InetPassword);
            this.inetGrpBox.Controls.Add(this.inetUsername);
            this.inetGrpBox.Location = new System.Drawing.Point(0, 2);
            this.inetGrpBox.Name = "inetGrpBox";
            this.inetGrpBox.Size = new System.Drawing.Size(119, 77);
            this.inetGrpBox.TabIndex = 0;
            this.inetGrpBox.TabStop = false;
            this.inetGrpBox.Text = "INET Portal Login";
            // 
            // saveSettings
            // 
            this.saveSettings.Location = new System.Drawing.Point(7, 85);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(75, 23);
            this.saveSettings.TabIndex = 1;
            this.saveSettings.Text = "Save";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(7, 114);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loopcareGrpBox
            // 
            this.loopcareGrpBox.Controls.Add(this.loopcarePassword);
            this.loopcareGrpBox.Controls.Add(this.loopcareUsername);
            this.loopcareGrpBox.Location = new System.Drawing.Point(125, 2);
            this.loopcareGrpBox.Name = "loopcareGrpBox";
            this.loopcareGrpBox.Size = new System.Drawing.Size(119, 77);
            this.loopcareGrpBox.TabIndex = 3;
            this.loopcareGrpBox.TabStop = false;
            this.loopcareGrpBox.Text = "Lopcare";
            // 
            // vnetGrpBox
            // 
            this.vnetGrpBox.Controls.Add(this.vnetPassword);
            this.vnetGrpBox.Controls.Add(this.vnetUsername);
            this.vnetGrpBox.Location = new System.Drawing.Point(250, 2);
            this.vnetGrpBox.Name = "vnetGrpBox";
            this.vnetGrpBox.Size = new System.Drawing.Size(119, 77);
            this.vnetGrpBox.TabIndex = 4;
            this.vnetGrpBox.TabStop = false;
            this.vnetGrpBox.Text = "Viryanet";
            // 
            // cdpiTicketGrpBox
            // 
            this.cdpiTicketGrpBox.Controls.Add(this.cdpiTicketPassword);
            this.cdpiTicketGrpBox.Controls.Add(this.cdpiTicketUsername);
            this.cdpiTicketGrpBox.Location = new System.Drawing.Point(375, 2);
            this.cdpiTicketGrpBox.Name = "cdpiTicketGrpBox";
            this.cdpiTicketGrpBox.Size = new System.Drawing.Size(119, 77);
            this.cdpiTicketGrpBox.TabIndex = 5;
            this.cdpiTicketGrpBox.TabStop = false;
            this.cdpiTicketGrpBox.Text = "CDPI/Billing Lookup";
            // 
            // cdpiTicketPassword
            // 
            this.cdpiTicketPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cdpiTicketPassword.Location = new System.Drawing.Point(7, 46);
            this.cdpiTicketPassword.Name = "cdpiTicketPassword";
            this.cdpiTicketPassword.Size = new System.Drawing.Size(100, 20);
            this.cdpiTicketPassword.TabIndex = 1;
            this.cdpiTicketPassword.WaterMarkColor = System.Drawing.Color.Gray;
            this.cdpiTicketPassword.WaterMarkText = "Password";
            // 
            // cdpiTicketUsername
            // 
            this.cdpiTicketUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cdpiTicketUsername.Location = new System.Drawing.Point(7, 20);
            this.cdpiTicketUsername.Name = "cdpiTicketUsername";
            this.cdpiTicketUsername.Size = new System.Drawing.Size(100, 20);
            this.cdpiTicketUsername.TabIndex = 0;
            this.cdpiTicketUsername.WaterMarkColor = System.Drawing.Color.Gray;
            this.cdpiTicketUsername.WaterMarkText = "Username";
            // 
            // vnetPassword
            // 
            this.vnetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.vnetPassword.Location = new System.Drawing.Point(7, 46);
            this.vnetPassword.Name = "vnetPassword";
            this.vnetPassword.Size = new System.Drawing.Size(100, 20);
            this.vnetPassword.TabIndex = 1;
            this.vnetPassword.WaterMarkColor = System.Drawing.Color.Gray;
            this.vnetPassword.WaterMarkText = "Password";
            // 
            // vnetUsername
            // 
            this.vnetUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.vnetUsername.Location = new System.Drawing.Point(7, 20);
            this.vnetUsername.Name = "vnetUsername";
            this.vnetUsername.Size = new System.Drawing.Size(100, 20);
            this.vnetUsername.TabIndex = 0;
            this.vnetUsername.WaterMarkColor = System.Drawing.Color.Gray;
            this.vnetUsername.WaterMarkText = "Username";
            // 
            // loopcarePassword
            // 
            this.loopcarePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.loopcarePassword.Location = new System.Drawing.Point(7, 46);
            this.loopcarePassword.Name = "loopcarePassword";
            this.loopcarePassword.Size = new System.Drawing.Size(100, 20);
            this.loopcarePassword.TabIndex = 1;
            this.loopcarePassword.WaterMarkColor = System.Drawing.Color.Gray;
            this.loopcarePassword.WaterMarkText = "Password";
            // 
            // loopcareUsername
            // 
            this.loopcareUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.loopcareUsername.Location = new System.Drawing.Point(7, 20);
            this.loopcareUsername.Name = "loopcareUsername";
            this.loopcareUsername.Size = new System.Drawing.Size(100, 20);
            this.loopcareUsername.TabIndex = 0;
            this.loopcareUsername.WaterMarkColor = System.Drawing.Color.Gray;
            this.loopcareUsername.WaterMarkText = "Username";
            // 
            // InetPassword
            // 
            this.InetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.InetPassword.Location = new System.Drawing.Point(7, 47);
            this.InetPassword.Name = "InetPassword";
            this.InetPassword.Size = new System.Drawing.Size(100, 20);
            this.InetPassword.TabIndex = 1;
            this.InetPassword.WaterMarkColor = System.Drawing.Color.Gray;
            this.InetPassword.WaterMarkText = "Password";
            // 
            // inetUsername
            // 
            this.inetUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.inetUsername.Location = new System.Drawing.Point(7, 20);
            this.inetUsername.Name = "inetUsername";
            this.inetUsername.Size = new System.Drawing.Size(100, 20);
            this.inetUsername.TabIndex = 0;
            this.inetUsername.WaterMarkColor = System.Drawing.Color.Gray;
            this.inetUsername.WaterMarkText = "Username";
            // 
            // browserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(520, 146);
            this.Controls.Add(this.cdpiTicketGrpBox);
            this.Controls.Add(this.vnetGrpBox);
            this.Controls.Add(this.loopcareGrpBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.inetGrpBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "browserSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.browserSettings_Load);
            this.inetGrpBox.ResumeLayout(false);
            this.inetGrpBox.PerformLayout();
            this.loopcareGrpBox.ResumeLayout(false);
            this.loopcareGrpBox.PerformLayout();
            this.vnetGrpBox.ResumeLayout(false);
            this.vnetGrpBox.PerformLayout();
            this.cdpiTicketGrpBox.ResumeLayout(false);
            this.cdpiTicketGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inetGrpBox;
        private wmgCMS.WaterMarkTextBox inetUsername;
        private wmgCMS.WaterMarkTextBox InetPassword;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox loopcareGrpBox;
        private wmgCMS.WaterMarkTextBox loopcarePassword;
        private wmgCMS.WaterMarkTextBox loopcareUsername;
        private System.Windows.Forms.GroupBox vnetGrpBox;
        private wmgCMS.WaterMarkTextBox vnetPassword;
        private wmgCMS.WaterMarkTextBox vnetUsername;
        private System.Windows.Forms.GroupBox cdpiTicketGrpBox;
        private wmgCMS.WaterMarkTextBox cdpiTicketPassword;
        private wmgCMS.WaterMarkTextBox cdpiTicketUsername;
    }
}