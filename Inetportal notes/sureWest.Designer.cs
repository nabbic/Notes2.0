namespace NotesApp
{
    partial class sureWest
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
            this.swTabControl = new System.Windows.Forms.TabControl();
            this.swTrackerTab = new System.Windows.Forms.TabPage();
            this.swTrackerBrowser = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.trackerSearchText = new wmgCMS.WaterMarkTextBox();
            this.trackerSearchButton = new System.Windows.Forms.Button();
            this.swWikiTab = new System.Windows.Forms.TabPage();
            this.swWikiBrowser = new System.Windows.Forms.WebBrowser();
            this.hiddenJwalkBrowser = new System.Windows.Forms.WebBrowser();
            this.ispTools = new System.Windows.Forms.TabPage();
            this.swToolsBrowser = new System.Windows.Forms.WebBrowser();
            this.quickTicket = new System.Windows.Forms.TabPage();
            this.swQuickTicketBrowser = new System.Windows.Forms.WebBrowser();
            this.swEmailAdminTab = new System.Windows.Forms.TabPage();
            this.swEmailAdmin = new System.Windows.Forms.WebBrowser();
            this.stormWatchTab = new System.Windows.Forms.TabPage();
            this.stormWatchControl = new VncSharp.RemoteDesktop();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.UserDefined1 = new System.Windows.Forms.TabPage();
            this.userBrowser1 = new System.Windows.Forms.WebBrowser();
            this.userDefined2 = new System.Windows.Forms.TabPage();
            this.userBrowser2 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressBar = new System.Windows.Forms.ToolStripTextBox();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sotrmWatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectStormMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectStormMEnu = new System.Windows.Forms.ToolStripMenuItem();
            this.loginStormMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.swTabControl.SuspendLayout();
            this.swTrackerTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.swWikiTab.SuspendLayout();
            this.ispTools.SuspendLayout();
            this.quickTicket.SuspendLayout();
            this.swEmailAdminTab.SuspendLayout();
            this.stormWatchTab.SuspendLayout();
            this.UserDefined1.SuspendLayout();
            this.userDefined2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // swTabControl
            // 
            this.swTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.swTabControl.Controls.Add(this.swTrackerTab);
            this.swTabControl.Controls.Add(this.swWikiTab);
            this.swTabControl.Controls.Add(this.ispTools);
            this.swTabControl.Controls.Add(this.quickTicket);
            this.swTabControl.Controls.Add(this.swEmailAdminTab);
            this.swTabControl.Controls.Add(this.stormWatchTab);
            this.swTabControl.Controls.Add(this.UserDefined1);
            this.swTabControl.Controls.Add(this.userDefined2);
            this.swTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swTabControl.HotTrack = true;
            this.swTabControl.Location = new System.Drawing.Point(0, 24);
            this.swTabControl.Multiline = true;
            this.swTabControl.Name = "swTabControl";
            this.swTabControl.Padding = new System.Drawing.Point(3, 3);
            this.swTabControl.SelectedIndex = 0;
            this.swTabControl.Size = new System.Drawing.Size(746, 363);
            this.swTabControl.TabIndex = 10;
            this.swTabControl.SelectedIndexChanged += new System.EventHandler(this.fpneTabControl_SelectedIndexChanged);
            // 
            // swTrackerTab
            // 
            this.swTrackerTab.Controls.Add(this.swTrackerBrowser);
            this.swTrackerTab.Controls.Add(this.tableLayoutPanel1);
            this.swTrackerTab.Location = new System.Drawing.Point(4, 25);
            this.swTrackerTab.Name = "swTrackerTab";
            this.swTrackerTab.Padding = new System.Windows.Forms.Padding(3);
            this.swTrackerTab.Size = new System.Drawing.Size(738, 334);
            this.swTrackerTab.TabIndex = 9;
            this.swTrackerTab.Text = "Tracker";
            this.swTrackerTab.UseVisualStyleBackColor = true;
            // 
            // swTrackerBrowser
            // 
            this.swTrackerBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swTrackerBrowser.Location = new System.Drawing.Point(3, 23);
            this.swTrackerBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.swTrackerBrowser.Name = "swTrackerBrowser";
            this.swTrackerBrowser.Size = new System.Drawing.Size(732, 308);
            this.swTrackerBrowser.TabIndex = 6;
            this.swTrackerBrowser.Url = new System.Uri("", System.UriKind.Relative);
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
            this.trackerSearchButton.Click += new System.EventHandler(this.trackerSearchButton_Click);
            // 
            // swWikiTab
            // 
            this.swWikiTab.Controls.Add(this.swWikiBrowser);
            this.swWikiTab.Controls.Add(this.hiddenJwalkBrowser);
            this.swWikiTab.Location = new System.Drawing.Point(4, 25);
            this.swWikiTab.Name = "swWikiTab";
            this.swWikiTab.Padding = new System.Windows.Forms.Padding(3);
            this.swWikiTab.Size = new System.Drawing.Size(738, 334);
            this.swWikiTab.TabIndex = 5;
            this.swWikiTab.Text = "WIKI";
            this.swWikiTab.UseVisualStyleBackColor = true;
            // 
            // swWikiBrowser
            // 
            this.swWikiBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swWikiBrowser.Location = new System.Drawing.Point(3, 3);
            this.swWikiBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.swWikiBrowser.Name = "swWikiBrowser";
            this.swWikiBrowser.Size = new System.Drawing.Size(732, 328);
            this.swWikiBrowser.TabIndex = 0;
            this.swWikiBrowser.Url = new System.Uri("", System.UriKind.Relative);
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
            // ispTools
            // 
            this.ispTools.Controls.Add(this.swToolsBrowser);
            this.ispTools.Location = new System.Drawing.Point(4, 25);
            this.ispTools.Name = "ispTools";
            this.ispTools.Padding = new System.Windows.Forms.Padding(3);
            this.ispTools.Size = new System.Drawing.Size(738, 334);
            this.ispTools.TabIndex = 1;
            this.ispTools.Text = "ISP Tools";
            this.ispTools.UseVisualStyleBackColor = true;
            // 
            // swToolsBrowser
            // 
            this.swToolsBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swToolsBrowser.Location = new System.Drawing.Point(3, 3);
            this.swToolsBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.swToolsBrowser.Name = "swToolsBrowser";
            this.swToolsBrowser.Size = new System.Drawing.Size(732, 328);
            this.swToolsBrowser.TabIndex = 1;
            this.swToolsBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // quickTicket
            // 
            this.quickTicket.Controls.Add(this.swQuickTicketBrowser);
            this.quickTicket.Location = new System.Drawing.Point(4, 25);
            this.quickTicket.Name = "quickTicket";
            this.quickTicket.Padding = new System.Windows.Forms.Padding(3);
            this.quickTicket.Size = new System.Drawing.Size(738, 334);
            this.quickTicket.TabIndex = 2;
            this.quickTicket.Text = "Quick Ticket";
            this.quickTicket.UseVisualStyleBackColor = true;
            // 
            // swQuickTicketBrowser
            // 
            this.swQuickTicketBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swQuickTicketBrowser.Location = new System.Drawing.Point(3, 3);
            this.swQuickTicketBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.swQuickTicketBrowser.Name = "swQuickTicketBrowser";
            this.swQuickTicketBrowser.Size = new System.Drawing.Size(732, 328);
            this.swQuickTicketBrowser.TabIndex = 0;
            this.swQuickTicketBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // swEmailAdminTab
            // 
            this.swEmailAdminTab.Controls.Add(this.swEmailAdmin);
            this.swEmailAdminTab.Location = new System.Drawing.Point(4, 25);
            this.swEmailAdminTab.Name = "swEmailAdminTab";
            this.swEmailAdminTab.Padding = new System.Windows.Forms.Padding(3);
            this.swEmailAdminTab.Size = new System.Drawing.Size(738, 334);
            this.swEmailAdminTab.TabIndex = 0;
            this.swEmailAdminTab.Text = "Email Admin";
            this.swEmailAdminTab.UseVisualStyleBackColor = true;
            // 
            // swEmailAdmin
            // 
            this.swEmailAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swEmailAdmin.Location = new System.Drawing.Point(3, 3);
            this.swEmailAdmin.MinimumSize = new System.Drawing.Size(20, 20);
            this.swEmailAdmin.Name = "swEmailAdmin";
            this.swEmailAdmin.Size = new System.Drawing.Size(732, 328);
            this.swEmailAdmin.TabIndex = 2;
            this.swEmailAdmin.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // stormWatchTab
            // 
            this.stormWatchTab.Controls.Add(this.stormWatchControl);
            this.stormWatchTab.Controls.Add(this.webBrowser1);
            this.stormWatchTab.Location = new System.Drawing.Point(4, 25);
            this.stormWatchTab.Name = "stormWatchTab";
            this.stormWatchTab.Size = new System.Drawing.Size(738, 334);
            this.stormWatchTab.TabIndex = 10;
            this.stormWatchTab.Text = "StormWatch";
            this.stormWatchTab.UseVisualStyleBackColor = true;
            // 
            // stormWatchControl
            // 
            this.stormWatchControl.AutoScroll = true;
            this.stormWatchControl.AutoScrollMinSize = new System.Drawing.Size(608, 427);
            this.stormWatchControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stormWatchControl.Location = new System.Drawing.Point(0, 0);
            this.stormWatchControl.Name = "stormWatchControl";
            this.stormWatchControl.Size = new System.Drawing.Size(738, 334);
            this.stormWatchControl.TabIndex = 2;
            this.stormWatchControl.ConnectComplete += new VncSharp.ConnectCompleteHandler(this.stormWatchControl_ConnectComplete);
            this.stormWatchControl.ConnectionLost += new System.EventHandler(this.stormWatchControl_ConnectionLost);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(40, 76);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 250);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            this.webBrowser1.Visible = false;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.goToolStripMenuItem,
            this.addressBar,
            this.loadToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.sotrmWatchToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 9;
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
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Settings";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // sotrmWatchToolStripMenuItem
            // 
            this.sotrmWatchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectStormMenu,
            this.disconnectStormMEnu,
            this.loginStormMenu});
            this.sotrmWatchToolStripMenuItem.Name = "sotrmWatchToolStripMenuItem";
            this.sotrmWatchToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.sotrmWatchToolStripMenuItem.Text = "StormWatch";
            // 
            // connectStormMenu
            // 
            this.connectStormMenu.Name = "connectStormMenu";
            this.connectStormMenu.Size = new System.Drawing.Size(152, 22);
            this.connectStormMenu.Text = "Connect";
            this.connectStormMenu.Click += new System.EventHandler(this.connectToolStrip_Click);
            // 
            // disconnectStormMEnu
            // 
            this.disconnectStormMEnu.Enabled = false;
            this.disconnectStormMEnu.Name = "disconnectStormMEnu";
            this.disconnectStormMEnu.Size = new System.Drawing.Size(152, 22);
            this.disconnectStormMEnu.Text = "Disconnect";
            this.disconnectStormMEnu.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // loginStormMenu
            // 
            this.loginStormMenu.Enabled = false;
            this.loginStormMenu.Name = "loginStormMenu";
            this.loginStormMenu.Size = new System.Drawing.Size(152, 22);
            this.loginStormMenu.Text = "Login";
            this.loginStormMenu.Click += new System.EventHandler(this.loginToolStripStormWatch_Click);
            // 
            // sureWest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 387);
            this.Controls.Add(this.swTabControl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Name = "sureWest";
            this.Text = "SureWest Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sureWest_FormClosing);
            this.swTabControl.ResumeLayout(false);
            this.swTrackerTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.swWikiTab.ResumeLayout(false);
            this.ispTools.ResumeLayout(false);
            this.quickTicket.ResumeLayout(false);
            this.swEmailAdminTab.ResumeLayout(false);
            this.stormWatchTab.ResumeLayout(false);
            this.UserDefined1.ResumeLayout(false);
            this.userDefined2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabControl swTabControl;
        public System.Windows.Forms.TabPage swEmailAdminTab;
        public System.Windows.Forms.WebBrowser swEmailAdmin;
        public System.Windows.Forms.TabPage swTrackerTab;
        private System.Windows.Forms.WebBrowser swTrackerBrowser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private wmgCMS.WaterMarkTextBox trackerSearchText;
        private System.Windows.Forms.Button trackerSearchButton;
        public System.Windows.Forms.TabPage swWikiTab;
        public System.Windows.Forms.WebBrowser swWikiBrowser;
        private System.Windows.Forms.WebBrowser hiddenJwalkBrowser;
        public System.Windows.Forms.TabPage ispTools;
        public System.Windows.Forms.WebBrowser swToolsBrowser;
        public System.Windows.Forms.TabPage quickTicket;
        public System.Windows.Forms.WebBrowser swQuickTicketBrowser;
        public System.Windows.Forms.TabPage UserDefined1;
        public System.Windows.Forms.WebBrowser userBrowser1;
        public System.Windows.Forms.TabPage userDefined2;
        public System.Windows.Forms.WebBrowser userBrowser2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        public System.Windows.Forms.ToolStripTextBox addressBar;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.TabPage stormWatchTab;
        private System.Windows.Forms.ToolStripMenuItem sotrmWatchToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem loginStormMenu;
        private System.Windows.Forms.ToolStripMenuItem connectStormMenu;
        private VncSharp.RemoteDesktop stormWatchControl;
        private System.Windows.Forms.ToolStripMenuItem disconnectStormMEnu;
    }
}