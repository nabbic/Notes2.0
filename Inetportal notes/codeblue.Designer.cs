namespace NotesApp
{
    partial class codeBlueform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(codeBlueform));
            this.reasonCombo = new System.Windows.Forms.ComboBox();
            this.cust_wtn_label = new System.Windows.Forms.Label();
            this.cust_cbr_label = new System.Windows.Forms.Label();
            this.cbViewText = new System.Windows.Forms.RichTextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.cbToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbCbrText = new System.Windows.Forms.MaskedTextBox();
            this.cbWtnText = new System.Windows.Forms.MaskedTextBox();
            this.cbTechText = new wmgCMS.WaterMarkTextBox();
            this.cbNameText = new wmgCMS.WaterMarkTextBox();
            this.cbEmailText = new wmgCMS.WaterMarkTextBox();
            this.cbStreetText = new wmgCMS.WaterMarkTextBox();
            this.cbCityText = new wmgCMS.WaterMarkTextBox();
            this.cbStateText = new wmgCMS.WaterMarkTextBox();
            this.cbZipText = new wmgCMS.WaterMarkTextBox();
            this.cbDpiText = new wmgCMS.WaterMarkTextBox();
            this.cbNotesText = new wmgCMS.WaterMarkTextBox();
            this.SuspendLayout();
            // 
            // reasonCombo
            // 
            this.reasonCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reasonCombo.FormattingEnabled = true;
            this.reasonCombo.Items.AddRange(new object[] {
            "Surplus Of Users",
            "Missed commitment",
            "Repeat commitment",
            "Executive complaint"});
            this.reasonCombo.Location = new System.Drawing.Point(0, 35);
            this.reasonCombo.Name = "reasonCombo";
            this.reasonCombo.Size = new System.Drawing.Size(120, 21);
            this.reasonCombo.TabIndex = 4;
            this.reasonCombo.Text = "Reason";
            // 
            // cust_wtn_label
            // 
            this.cust_wtn_label.AutoSize = true;
            this.cust_wtn_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cust_wtn_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_wtn_label.Location = new System.Drawing.Point(0, 85);
            this.cust_wtn_label.Name = "cust_wtn_label";
            this.cust_wtn_label.Size = new System.Drawing.Size(69, 12);
            this.cust_wtn_label.TabIndex = 7;
            this.cust_wtn_label.Text = "Customer WTN";
            // 
            // cust_cbr_label
            // 
            this.cust_cbr_label.AutoSize = true;
            this.cust_cbr_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_cbr_label.Location = new System.Drawing.Point(0, 123);
            this.cust_cbr_label.Name = "cust_cbr_label";
            this.cust_cbr_label.Size = new System.Drawing.Size(68, 12);
            this.cust_cbr_label.TabIndex = 9;
            this.cust_cbr_label.Text = "Customer CBR";
            // 
            // cbViewText
            // 
            this.cbViewText.Location = new System.Drawing.Point(124, 12);
            this.cbViewText.Name = "cbViewText";
            this.cbViewText.Size = new System.Drawing.Size(188, 309);
            this.cbViewText.TabIndex = 23;
            this.cbViewText.Text = "";
            // 
            // copyButton
            // 
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyButton.Location = new System.Drawing.Point(111, 480);
            this.copyButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(95, 35);
            this.copyButton.TabIndex = 24;
            this.copyButton.Text = "Copy Info";
            this.cbToolTip.SetToolTip(this.copyButton, "Use this button to generate your CODE BLUE and save it to clipboard for pasting t" +
        "o chat.");
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // cbCbrText
            // 
            this.cbCbrText.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cbCbrText.Location = new System.Drawing.Point(0, 138);
            this.cbCbrText.Mask = "999-000-0000";
            this.cbCbrText.Name = "cbCbrText";
            this.cbCbrText.Size = new System.Drawing.Size(120, 20);
            this.cbCbrText.TabIndex = 29;
            // 
            // cbWtnText
            // 
            this.cbWtnText.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.cbWtnText.Location = new System.Drawing.Point(0, 100);
            this.cbWtnText.Mask = "999-000-0000";
            this.cbWtnText.Name = "cbWtnText";
            this.cbWtnText.Size = new System.Drawing.Size(120, 20);
            this.cbWtnText.TabIndex = 30;
            // 
            // cbTechText
            // 
            this.cbTechText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbTechText.Location = new System.Drawing.Point(0, 12);
            this.cbTechText.Name = "cbTechText";
            this.cbTechText.Size = new System.Drawing.Size(120, 20);
            this.cbTechText.TabIndex = 33;
            this.cbTechText.WaterMarkColor = System.Drawing.Color.Gray;
            this.cbTechText.WaterMarkText = "Tech Name";
            // 
            // cbNameText
            // 
            this.cbNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbNameText.Location = new System.Drawing.Point(0, 62);
            this.cbNameText.Name = "cbNameText";
            this.cbNameText.Size = new System.Drawing.Size(120, 20);
            this.cbNameText.TabIndex = 34;
            this.cbNameText.WaterMarkColor = System.Drawing.Color.Gray;
            this.cbNameText.WaterMarkText = "Customer\'s Full Name";
            // 
            // cbEmailText
            // 
            this.cbEmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbEmailText.Location = new System.Drawing.Point(0, 164);
            this.cbEmailText.Name = "cbEmailText";
            this.cbEmailText.Size = new System.Drawing.Size(120, 20);
            this.cbEmailText.TabIndex = 35;
            this.cbEmailText.WaterMarkColor = System.Drawing.Color.Gray;
            this.cbEmailText.WaterMarkText = "Customer\'s Email";
            // 
            // cbStreetText
            // 
            this.cbStreetText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbStreetText.Location = new System.Drawing.Point(0, 193);
            this.cbStreetText.Name = "cbStreetText";
            this.cbStreetText.Size = new System.Drawing.Size(120, 20);
            this.cbStreetText.TabIndex = 36;
            this.cbStreetText.WaterMarkColor = System.Drawing.Color.Gray;
            this.cbStreetText.WaterMarkText = "Street Address";
            // 
            // cbCityText
            // 
            this.cbCityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbCityText.Location = new System.Drawing.Point(4, 219);
            this.cbCityText.Name = "cbCityText";
            this.cbCityText.Size = new System.Drawing.Size(116, 20);
            this.cbCityText.TabIndex = 37;
            this.cbCityText.WaterMarkColor = System.Drawing.Color.Gray;
            this.cbCityText.WaterMarkText = "City";
            // 
            // cbStateText
            // 
            this.cbStateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbStateText.Location = new System.Drawing.Point(0, 245);
            this.cbStateText.Name = "cbStateText";
            this.cbStateText.Size = new System.Drawing.Size(120, 20);
            this.cbStateText.TabIndex = 38;
            this.cbStateText.WaterMarkColor = System.Drawing.Color.Gray;
            this.cbStateText.WaterMarkText = "State";
            // 
            // cbZipText
            // 
            this.cbZipText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbZipText.Location = new System.Drawing.Point(0, 271);
            this.cbZipText.Name = "cbZipText";
            this.cbZipText.Size = new System.Drawing.Size(120, 20);
            this.cbZipText.TabIndex = 39;
            this.cbZipText.WaterMarkColor = System.Drawing.Color.Gray;
            this.cbZipText.WaterMarkText = "Zipcode";
            // 
            // cbDpiText
            // 
            this.cbDpiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbDpiText.Location = new System.Drawing.Point(0, 297);
            this.cbDpiText.Name = "cbDpiText";
            this.cbDpiText.Size = new System.Drawing.Size(120, 20);
            this.cbDpiText.TabIndex = 40;
            this.cbDpiText.WaterMarkColor = System.Drawing.Color.Gray;
            this.cbDpiText.WaterMarkText = "Ticket Number";
            // 
            // cbNotesText
            // 
            this.cbNotesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbNotesText.Location = new System.Drawing.Point(0, 324);
            this.cbNotesText.Margin = new System.Windows.Forms.Padding(0);
            this.cbNotesText.Multiline = true;
            this.cbNotesText.Name = "cbNotesText";
            this.cbNotesText.Size = new System.Drawing.Size(307, 153);
            this.cbNotesText.TabIndex = 41;
            this.cbNotesText.WaterMarkColor = System.Drawing.Color.Gray;
            this.cbNotesText.WaterMarkText = "Full Notes";
            // 
            // codeBlueform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 516);
            this.Controls.Add(this.cbNotesText);
            this.Controls.Add(this.cbDpiText);
            this.Controls.Add(this.cbZipText);
            this.Controls.Add(this.cbStateText);
            this.Controls.Add(this.cbCityText);
            this.Controls.Add(this.cbStreetText);
            this.Controls.Add(this.cbEmailText);
            this.Controls.Add(this.cbNameText);
            this.Controls.Add(this.cbTechText);
            this.Controls.Add(this.cbWtnText);
            this.Controls.Add(this.cbCbrText);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.cbViewText);
            this.Controls.Add(this.cust_cbr_label);
            this.Controls.Add(this.cust_wtn_label);
            this.Controls.Add(this.reasonCombo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "codeBlueform";
            this.Text = "Frontier > Code Blue";
            this.Load += new System.EventHandler(this.codeBlueform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox reasonCombo;
        private System.Windows.Forms.Label cust_wtn_label;
        private System.Windows.Forms.Label cust_cbr_label;
        private System.Windows.Forms.RichTextBox cbViewText;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.ToolTip cbToolTip;
        private System.Windows.Forms.MaskedTextBox cbCbrText;
        private System.Windows.Forms.MaskedTextBox cbWtnText;
        private wmgCMS.WaterMarkTextBox cbTechText;
        private wmgCMS.WaterMarkTextBox cbNameText;
        private wmgCMS.WaterMarkTextBox cbEmailText;
        private wmgCMS.WaterMarkTextBox cbStreetText;
        private wmgCMS.WaterMarkTextBox cbCityText;
        private wmgCMS.WaterMarkTextBox cbStateText;
        private wmgCMS.WaterMarkTextBox cbZipText;
        private wmgCMS.WaterMarkTextBox cbDpiText;
        private wmgCMS.WaterMarkTextBox cbNotesText;
    }
}