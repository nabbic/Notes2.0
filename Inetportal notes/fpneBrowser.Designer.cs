namespace NotesApp
{
    partial class fpneBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fpneBrowser));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressBar = new System.Windows.Forms.ToolStripTextBox();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fpneTabControl = new System.Windows.Forms.TabControl();
            this.fpneAdminTab = new System.Windows.Forms.TabPage();
            this.fpneAdminBrowser = new System.Windows.Forms.WebBrowser();
            this.fpneTrackerTab = new System.Windows.Forms.TabPage();
            this.fpneTrackerBrowser = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.trackerSearchText = new wmgCMS.WaterMarkTextBox();
            this.trackerSearchButton = new System.Windows.Forms.Button();
            this.fpneWikiTab = new System.Windows.Forms.TabPage();
            this.fpneWikiBrowser = new System.Windows.Forms.WebBrowser();
            this.hiddenJwalkBrowser = new System.Windows.Forms.WebBrowser();
            this.dataviewTab = new System.Windows.Forms.TabPage();
            this.dataviewBrowser = new System.Windows.Forms.WebBrowser();
            this.hostopiaTab = new System.Windows.Forms.TabPage();
            this.hostopiaBrowser = new System.Windows.Forms.WebBrowser();
            this.securityAdminTab = new System.Windows.Forms.TabPage();
            this.securityAdminBrowser = new System.Windows.Forms.WebBrowser();
            this.securityPortalTab = new System.Windows.Forms.TabPage();
            this.securityPortalBrowser = new System.Windows.Forms.WebBrowser();
            this.securityLookupTab = new System.Windows.Forms.TabPage();
            this.securityLookupBrowser = new System.Windows.Forms.WebBrowser();
            this.UserDefined1 = new System.Windows.Forms.TabPage();
            this.userBrowser1 = new System.Windows.Forms.WebBrowser();
            this.userDefined2 = new System.Windows.Forms.TabPage();
            this.userBrowser2 = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.fpneTabControl.SuspendLayout();
            this.fpneAdminTab.SuspendLayout();
            this.fpneTrackerTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.fpneWikiTab.SuspendLayout();
            this.dataviewTab.SuspendLayout();
            this.hostopiaTab.SuspendLayout();
            this.securityAdminTab.SuspendLayout();
            this.securityPortalTab.SuspendLayout();
            this.securityLookupTab.SuspendLayout();
            this.UserDefined1.SuspendLayout();
            this.userDefined2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.goToolStripMenuItem,
            this.addressBar,
            this.loadToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.Name = "goToolStripMenuItem";
            this.goToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.goToolStripMenuItem.Text = "Go";
            this.goToolStripMenuItem.Click += new System.EventHandler(this.goToolStripMenuItem_Click);
            // 
            // addressBar
            // 
            this.addressBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(300, 20);
            this.addressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBar_KeyDown);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Settings";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // fpneTabControl
            // 
            this.fpneTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.fpneTabControl.Controls.Add(this.fpneAdminTab);
            this.fpneTabControl.Controls.Add(this.fpneTrackerTab);
            this.fpneTabControl.Controls.Add(this.fpneWikiTab);
            this.fpneTabControl.Controls.Add(this.dataviewTab);
            this.fpneTabControl.Controls.Add(this.hostopiaTab);
            this.fpneTabControl.Controls.Add(this.securityAdminTab);
            this.fpneTabControl.Controls.Add(this.securityPortalTab);
            this.fpneTabControl.Controls.Add(this.securityLookupTab);
            this.fpneTabControl.Controls.Add(this.UserDefined1);
            this.fpneTabControl.Controls.Add(this.userDefined2);
            this.fpneTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpneTabControl.HotTrack = true;
            this.fpneTabControl.Location = new System.Drawing.Point(0, 24);
            this.fpneTabControl.Multiline = true;
            this.fpneTabControl.Name = "fpneTabControl";
            this.fpneTabControl.Padding = new System.Drawing.Point(3, 3);
            this.fpneTabControl.SelectedIndex = 0;
            this.fpneTabControl.Size = new System.Drawing.Size(746, 363);
            this.fpneTabControl.TabIndex = 8;
            this.fpneTabControl.SelectedIndexChanged += new System.EventHandler(this.fpneTabControl_SelectedIndexChanged);
            // 
            // fpneAdminTab
            // 
            this.fpneAdminTab.Controls.Add(this.fpneAdminBrowser);
            this.fpneAdminTab.Location = new System.Drawing.Point(4, 25);
            this.fpneAdminTab.Name = "fpneAdminTab";
            this.fpneAdminTab.Padding = new System.Windows.Forms.Padding(3);
            this.fpneAdminTab.Size = new System.Drawing.Size(738, 334);
            this.fpneAdminTab.TabIndex = 0;
            this.fpneAdminTab.Text = "Admin";
            this.fpneAdminTab.UseVisualStyleBackColor = true;
            // 
            // fpneAdminBrowser
            // 
            this.fpneAdminBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpneAdminBrowser.Location = new System.Drawing.Point(3, 3);
            this.fpneAdminBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.fpneAdminBrowser.Name = "fpneAdminBrowser";
            this.fpneAdminBrowser.Size = new System.Drawing.Size(732, 328);
            this.fpneAdminBrowser.TabIndex = 2;
            this.fpneAdminBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // fpneTrackerTab
            // 
            this.fpneTrackerTab.Controls.Add(this.fpneTrackerBrowser);
            this.fpneTrackerTab.Controls.Add(this.tableLayoutPanel1);
            this.fpneTrackerTab.Location = new System.Drawing.Point(4, 25);
            this.fpneTrackerTab.Name = "fpneTrackerTab";
            this.fpneTrackerTab.Padding = new System.Windows.Forms.Padding(3);
            this.fpneTrackerTab.Size = new System.Drawing.Size(738, 334);
            this.fpneTrackerTab.TabIndex = 9;
            this.fpneTrackerTab.Text = "Tracker";
            this.fpneTrackerTab.UseVisualStyleBackColor = true;
            // 
            // fpneTrackerBrowser
            // 
            this.fpneTrackerBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpneTrackerBrowser.Location = new System.Drawing.Point(3, 23);
            this.fpneTrackerBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.fpneTrackerBrowser.Name = "fpneTrackerBrowser";
            this.fpneTrackerBrowser.Size = new System.Drawing.Size(732, 308);
            this.fpneTrackerBrowser.TabIndex = 6;
            this.fpneTrackerBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.trackerSearchText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackerSearchButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 20);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // trackerSearchText
            // 
            this.trackerSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.trackerSearchText.Location = new System.Drawing.Point(0, 0);
            this.trackerSearchText.Margin = new System.Windows.Forms.Padding(0);
            this.trackerSearchText.Name = "trackerSearchText";
            this.trackerSearchText.Size = new System.Drawing.Size(156, 20);
            this.trackerSearchText.TabIndex = 0;
            this.trackerSearchText.WaterMarkColor = System.Drawing.Color.Gray;
            this.trackerSearchText.WaterMarkText = "Search for BTN or Username";
            // 
            // trackerSearchButton
            // 
            this.trackerSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trackerSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackerSearchButton.Location = new System.Drawing.Point(156, 0);
            this.trackerSearchButton.Margin = new System.Windows.Forms.Padding(0);
            this.trackerSearchButton.Name = "trackerSearchButton";
            this.trackerSearchButton.Size = new System.Drawing.Size(77, 20);
            this.trackerSearchButton.TabIndex = 1;
            this.trackerSearchButton.Text = "Search";
            this.trackerSearchButton.UseVisualStyleBackColor = true;
            // 
            // fpneWikiTab
            // 
            this.fpneWikiTab.Controls.Add(this.fpneWikiBrowser);
            this.fpneWikiTab.Controls.Add(this.hiddenJwalkBrowser);
            this.fpneWikiTab.Location = new System.Drawing.Point(4, 25);
            this.fpneWikiTab.Name = "fpneWikiTab";
            this.fpneWikiTab.Padding = new System.Windows.Forms.Padding(3);
            this.fpneWikiTab.Size = new System.Drawing.Size(738, 334);
            this.fpneWikiTab.TabIndex = 5;
            this.fpneWikiTab.Text = "WIKI";
            this.fpneWikiTab.UseVisualStyleBackColor = true;
            // 
            // fpneWikiBrowser
            // 
            this.fpneWikiBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpneWikiBrowser.Location = new System.Drawing.Point(3, 3);
            this.fpneWikiBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.fpneWikiBrowser.Name = "fpneWikiBrowser";
            this.fpneWikiBrowser.Size = new System.Drawing.Size(732, 328);
            this.fpneWikiBrowser.TabIndex = 0;
            this.fpneWikiBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // hiddenJwalkBrowser
            // 
            this.hiddenJwalkBrowser.Location = new System.Drawing.Point(692, 334);
            this.hiddenJwalkBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.hiddenJwalkBrowser.Name = "hiddenJwalkBrowser";
            this.hiddenJwalkBrowser.Size = new System.Drawing.Size(73, 28);
            this.hiddenJwalkBrowser.TabIndex = 1;
            this.hiddenJwalkBrowser.Visible = false;
            this.hiddenJwalkBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // dataviewTab
            // 
            this.dataviewTab.Controls.Add(this.dataviewBrowser);
            this.dataviewTab.Location = new System.Drawing.Point(4, 25);
            this.dataviewTab.Name = "dataviewTab";
            this.dataviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.dataviewTab.Size = new System.Drawing.Size(738, 334);
            this.dataviewTab.TabIndex = 1;
            this.dataviewTab.Text = "Dataview";
            this.dataviewTab.UseVisualStyleBackColor = true;
            // 
            // dataviewBrowser
            // 
            this.dataviewBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataviewBrowser.Location = new System.Drawing.Point(3, 3);
            this.dataviewBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.dataviewBrowser.Name = "dataviewBrowser";
            this.dataviewBrowser.Size = new System.Drawing.Size(732, 328);
            this.dataviewBrowser.TabIndex = 1;
            this.dataviewBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // hostopiaTab
            // 
            this.hostopiaTab.Controls.Add(this.hostopiaBrowser);
            this.hostopiaTab.Location = new System.Drawing.Point(4, 25);
            this.hostopiaTab.Name = "hostopiaTab";
            this.hostopiaTab.Padding = new System.Windows.Forms.Padding(3);
            this.hostopiaTab.Size = new System.Drawing.Size(738, 334);
            this.hostopiaTab.TabIndex = 2;
            this.hostopiaTab.Text = "Hostopia";
            this.hostopiaTab.UseVisualStyleBackColor = true;
            // 
            // hostopiaBrowser
            // 
            this.hostopiaBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostopiaBrowser.Location = new System.Drawing.Point(3, 3);
            this.hostopiaBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.hostopiaBrowser.Name = "hostopiaBrowser";
            this.hostopiaBrowser.Size = new System.Drawing.Size(732, 328);
            this.hostopiaBrowser.TabIndex = 0;
            this.hostopiaBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // securityAdminTab
            // 
            this.securityAdminTab.Controls.Add(this.securityAdminBrowser);
            this.securityAdminTab.Location = new System.Drawing.Point(4, 25);
            this.securityAdminTab.Name = "securityAdminTab";
            this.securityAdminTab.Padding = new System.Windows.Forms.Padding(3);
            this.securityAdminTab.Size = new System.Drawing.Size(738, 334);
            this.securityAdminTab.TabIndex = 3;
            this.securityAdminTab.Text = "Security Admin";
            this.securityAdminTab.UseVisualStyleBackColor = true;
            // 
            // securityAdminBrowser
            // 
            this.securityAdminBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.securityAdminBrowser.Location = new System.Drawing.Point(3, 3);
            this.securityAdminBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.securityAdminBrowser.Name = "securityAdminBrowser";
            this.securityAdminBrowser.Size = new System.Drawing.Size(732, 328);
            this.securityAdminBrowser.TabIndex = 0;
            this.securityAdminBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // securityPortalTab
            // 
            this.securityPortalTab.Controls.Add(this.securityPortalBrowser);
            this.securityPortalTab.Location = new System.Drawing.Point(4, 25);
            this.securityPortalTab.Name = "securityPortalTab";
            this.securityPortalTab.Padding = new System.Windows.Forms.Padding(3);
            this.securityPortalTab.Size = new System.Drawing.Size(738, 334);
            this.securityPortalTab.TabIndex = 4;
            this.securityPortalTab.Text = "Security Portal";
            this.securityPortalTab.UseVisualStyleBackColor = true;
            // 
            // securityPortalBrowser
            // 
            this.securityPortalBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.securityPortalBrowser.Location = new System.Drawing.Point(3, 3);
            this.securityPortalBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.securityPortalBrowser.Name = "securityPortalBrowser";
            this.securityPortalBrowser.Size = new System.Drawing.Size(732, 328);
            this.securityPortalBrowser.TabIndex = 0;
            this.securityPortalBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // securityLookupTab
            // 
            this.securityLookupTab.Controls.Add(this.securityLookupBrowser);
            this.securityLookupTab.Location = new System.Drawing.Point(4, 25);
            this.securityLookupTab.Name = "securityLookupTab";
            this.securityLookupTab.Padding = new System.Windows.Forms.Padding(3);
            this.securityLookupTab.Size = new System.Drawing.Size(738, 334);
            this.securityLookupTab.TabIndex = 6;
            this.securityLookupTab.Text = "Security Lookup";
            this.securityLookupTab.UseVisualStyleBackColor = true;
            // 
            // securityLookupBrowser
            // 
            this.securityLookupBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.securityLookupBrowser.Location = new System.Drawing.Point(3, 3);
            this.securityLookupBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.securityLookupBrowser.Name = "securityLookupBrowser";
            this.securityLookupBrowser.Size = new System.Drawing.Size(732, 328);
            this.securityLookupBrowser.TabIndex = 0;
            this.securityLookupBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // UserDefined1
            // 
            this.UserDefined1.Controls.Add(this.userBrowser1);
            this.UserDefined1.Location = new System.Drawing.Point(4, 25);
            this.UserDefined1.Name = "UserDefined1";
            this.UserDefined1.Padding = new System.Windows.Forms.Padding(3);
            this.UserDefined1.Size = new System.Drawing.Size(738, 334);
            this.UserDefined1.TabIndex = 7;
            this.UserDefined1.Text = "Custom Tab 1";
            this.UserDefined1.UseVisualStyleBackColor = true;
            // 
            // userBrowser1
            // 
            this.userBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBrowser1.Location = new System.Drawing.Point(3, 3);
            this.userBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.userBrowser1.Name = "userBrowser1";
            this.userBrowser1.Size = new System.Drawing.Size(732, 328);
            this.userBrowser1.TabIndex = 0;
            this.userBrowser1.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // userDefined2
            // 
            this.userDefined2.Controls.Add(this.userBrowser2);
            this.userDefined2.Location = new System.Drawing.Point(4, 25);
            this.userDefined2.Name = "userDefined2";
            this.userDefined2.Padding = new System.Windows.Forms.Padding(3);
            this.userDefined2.Size = new System.Drawing.Size(738, 334);
            this.userDefined2.TabIndex = 8;
            this.userDefined2.Text = "Custom Tab 2";
            this.userDefined2.UseVisualStyleBackColor = true;
            // 
            // userBrowser2
            // 
            this.userBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBrowser2.Location = new System.Drawing.Point(3, 3);
            this.userBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.userBrowser2.Name = "userBrowser2";
            this.userBrowser2.Size = new System.Drawing.Size(732, 328);
            this.userBrowser2.TabIndex = 1;
            this.userBrowser2.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 26);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // fpneBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 387);
            this.Controls.Add(this.fpneTabControl);
            this.Controls.Add(this.menuStrip1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fpneBrowser";
            this.ShowIcon = false;
            this.TabPageContextMenuStrip = this.contextMenuStrip1;
            this.Text = "Fpne Browser";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.fpneTabControl.ResumeLayout(false);
            this.fpneAdminTab.ResumeLayout(false);
            this.fpneTrackerTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.fpneWikiTab.ResumeLayout(false);
            this.dataviewTab.ResumeLayout(false);
            this.hostopiaTab.ResumeLayout(false);
            this.securityAdminTab.ResumeLayout(false);
            this.securityPortalTab.ResumeLayout(false);
            this.securityLookupTab.ResumeLayout(false);
            this.UserDefined1.ResumeLayout(false);
            this.userDefined2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        public System.Windows.Forms.ToolStripTextBox addressBar;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        public System.Windows.Forms.TabControl fpneTabControl;
        public System.Windows.Forms.TabPage fpneAdminTab;
        public System.Windows.Forms.WebBrowser fpneAdminBrowser;
        public System.Windows.Forms.TabPage fpneWikiTab;
        public System.Windows.Forms.WebBrowser fpneWikiBrowser;
        private System.Windows.Forms.WebBrowser hiddenJwalkBrowser;
        public System.Windows.Forms.TabPage dataviewTab;
        public System.Windows.Forms.WebBrowser dataviewBrowser;
        public System.Windows.Forms.TabPage hostopiaTab;
        public System.Windows.Forms.WebBrowser hostopiaBrowser;
        public System.Windows.Forms.TabPage securityAdminTab;
        public System.Windows.Forms.WebBrowser securityAdminBrowser;
        public System.Windows.Forms.TabPage securityPortalTab;
        public System.Windows.Forms.WebBrowser securityPortalBrowser;
        public System.Windows.Forms.TabPage securityLookupTab;
        public System.Windows.Forms.WebBrowser securityLookupBrowser;
        public System.Windows.Forms.TabPage UserDefined1;
        public System.Windows.Forms.WebBrowser userBrowser1;
        public System.Windows.Forms.TabPage userDefined2;
        public System.Windows.Forms.WebBrowser userBrowser2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private wmgCMS.WaterMarkTextBox trackerSearchText;
        private System.Windows.Forms.Button trackerSearchButton;
        public System.Windows.Forms.TabPage fpneTrackerTab;
        private System.Windows.Forms.WebBrowser fpneTrackerBrowser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}