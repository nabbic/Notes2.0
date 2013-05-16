namespace NotesApp
{
    partial class frontierBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frontierBrowser));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressBar = new System.Windows.Forms.ToolStripTextBox();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jWALKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.frontierTabInner = new System.Windows.Forms.TabControl();
            this.inetTab = new System.Windows.Forms.TabPage();
            this.inetTabBrowser = new System.Windows.Forms.WebBrowser();
            this.frontierWikiTab = new System.Windows.Forms.TabPage();
            this.frontierWikiBrowser = new System.Windows.Forms.WebBrowser();
            this.hiddenJwalkBrowser = new System.Windows.Forms.WebBrowser();
            this.loopcareTab = new System.Windows.Forms.TabPage();
            this.loopcareBrowser = new System.Windows.Forms.WebBrowser();
            this.vnetTab = new System.Windows.Forms.TabPage();
            this.vnetBrowser = new System.Windows.Forms.WebBrowser();
            this.cdpiTab = new System.Windows.Forms.TabPage();
            this.cdpiBrowser = new System.Windows.Forms.WebBrowser();
            this.lolaTab = new System.Windows.Forms.TabPage();
            this.lolaBrowser = new System.Windows.Forms.WebBrowser();
            this.billingLookupTab = new System.Windows.Forms.TabPage();
            this.billingLookupBrowser = new System.Windows.Forms.WebBrowser();
            this.UserDefinedTab = new System.Windows.Forms.TabPage();
            this.userBrowser1 = new System.Windows.Forms.WebBrowser();
            this.userDefined = new System.Windows.Forms.TabPage();
            this.userBrowser2 = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.frontierTabInner.SuspendLayout();
            this.inetTab.SuspendLayout();
            this.frontierWikiTab.SuspendLayout();
            this.loopcareTab.SuspendLayout();
            this.vnetTab.SuspendLayout();
            this.cdpiTab.SuspendLayout();
            this.lolaTab.SuspendLayout();
            this.billingLookupTab.SuspendLayout();
            this.UserDefinedTab.SuspendLayout();
            this.userDefined.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.jWALKToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 6;
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
            this.addressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
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
            // jWALKToolStripMenuItem
            // 
            this.jWALKToolStripMenuItem.Name = "jWALKToolStripMenuItem";
            this.jWALKToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.jWALKToolStripMenuItem.Text = "JWALK";
            this.jWALKToolStripMenuItem.Click += new System.EventHandler(this.jWALKToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Settings";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.toolStripMenuItem1.Text = "Test";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // frontierTabInner
            // 
            this.frontierTabInner.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.frontierTabInner.Controls.Add(this.inetTab);
            this.frontierTabInner.Controls.Add(this.frontierWikiTab);
            this.frontierTabInner.Controls.Add(this.loopcareTab);
            this.frontierTabInner.Controls.Add(this.vnetTab);
            this.frontierTabInner.Controls.Add(this.cdpiTab);
            this.frontierTabInner.Controls.Add(this.lolaTab);
            this.frontierTabInner.Controls.Add(this.billingLookupTab);
            this.frontierTabInner.Controls.Add(this.UserDefinedTab);
            this.frontierTabInner.Controls.Add(this.userDefined);
            this.frontierTabInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frontierTabInner.HotTrack = true;
            this.frontierTabInner.Location = new System.Drawing.Point(3, 3);
            this.frontierTabInner.Name = "frontierTabInner";
            this.frontierTabInner.Padding = new System.Drawing.Point(3, 3);
            this.frontierTabInner.SelectedIndex = 0;
            this.frontierTabInner.Size = new System.Drawing.Size(740, 357);
            this.frontierTabInner.TabIndex = 9;
            // 
            // inetTab
            // 
            this.inetTab.Controls.Add(this.inetTabBrowser);
            this.inetTab.Location = new System.Drawing.Point(4, 25);
            this.inetTab.Name = "inetTab";
            this.inetTab.Padding = new System.Windows.Forms.Padding(3);
            this.inetTab.Size = new System.Drawing.Size(732, 328);
            this.inetTab.TabIndex = 0;
            this.inetTab.Text = "Inet Portal";
            this.inetTab.UseVisualStyleBackColor = true;
            // 
            // inetTabBrowser
            // 
            this.inetTabBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inetTabBrowser.Location = new System.Drawing.Point(3, 3);
            this.inetTabBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.inetTabBrowser.Name = "inetTabBrowser";
            this.inetTabBrowser.Size = new System.Drawing.Size(726, 322);
            this.inetTabBrowser.TabIndex = 2;
            this.inetTabBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // frontierWikiTab
            // 
            this.frontierWikiTab.Controls.Add(this.frontierWikiBrowser);
            this.frontierWikiTab.Controls.Add(this.hiddenJwalkBrowser);
            this.frontierWikiTab.Location = new System.Drawing.Point(4, 25);
            this.frontierWikiTab.Name = "frontierWikiTab";
            this.frontierWikiTab.Padding = new System.Windows.Forms.Padding(3);
            this.frontierWikiTab.Size = new System.Drawing.Size(732, 328);
            this.frontierWikiTab.TabIndex = 5;
            this.frontierWikiTab.Text = "WIKI";
            this.frontierWikiTab.UseVisualStyleBackColor = true;
            // 
            // frontierWikiBrowser
            // 
            this.frontierWikiBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frontierWikiBrowser.Location = new System.Drawing.Point(3, 3);
            this.frontierWikiBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.frontierWikiBrowser.Name = "frontierWikiBrowser";
            this.frontierWikiBrowser.Size = new System.Drawing.Size(726, 322);
            this.frontierWikiBrowser.TabIndex = 0;
            this.frontierWikiBrowser.Url = new System.Uri("", System.UriKind.Relative);
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
            // loopcareTab
            // 
            this.loopcareTab.Controls.Add(this.loopcareBrowser);
            this.loopcareTab.Location = new System.Drawing.Point(4, 25);
            this.loopcareTab.Name = "loopcareTab";
            this.loopcareTab.Padding = new System.Windows.Forms.Padding(3);
            this.loopcareTab.Size = new System.Drawing.Size(732, 328);
            this.loopcareTab.TabIndex = 1;
            this.loopcareTab.Text = "Loopcare";
            this.loopcareTab.UseVisualStyleBackColor = true;
            // 
            // loopcareBrowser
            // 
            this.loopcareBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loopcareBrowser.Location = new System.Drawing.Point(3, 3);
            this.loopcareBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.loopcareBrowser.Name = "loopcareBrowser";
            this.loopcareBrowser.Size = new System.Drawing.Size(726, 322);
            this.loopcareBrowser.TabIndex = 1;
            this.loopcareBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // vnetTab
            // 
            this.vnetTab.Controls.Add(this.vnetBrowser);
            this.vnetTab.Location = new System.Drawing.Point(4, 25);
            this.vnetTab.Name = "vnetTab";
            this.vnetTab.Padding = new System.Windows.Forms.Padding(3);
            this.vnetTab.Size = new System.Drawing.Size(732, 328);
            this.vnetTab.TabIndex = 2;
            this.vnetTab.Text = "Viryanet";
            this.vnetTab.UseVisualStyleBackColor = true;
            // 
            // vnetBrowser
            // 
            this.vnetBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vnetBrowser.Location = new System.Drawing.Point(3, 3);
            this.vnetBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.vnetBrowser.Name = "vnetBrowser";
            this.vnetBrowser.Size = new System.Drawing.Size(726, 322);
            this.vnetBrowser.TabIndex = 0;
            this.vnetBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // cdpiTab
            // 
            this.cdpiTab.Controls.Add(this.cdpiBrowser);
            this.cdpiTab.Location = new System.Drawing.Point(4, 25);
            this.cdpiTab.Name = "cdpiTab";
            this.cdpiTab.Padding = new System.Windows.Forms.Padding(3);
            this.cdpiTab.Size = new System.Drawing.Size(732, 328);
            this.cdpiTab.TabIndex = 3;
            this.cdpiTab.Text = "CDPI Ticket";
            this.cdpiTab.UseVisualStyleBackColor = true;
            // 
            // cdpiBrowser
            // 
            this.cdpiBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cdpiBrowser.Location = new System.Drawing.Point(3, 3);
            this.cdpiBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.cdpiBrowser.Name = "cdpiBrowser";
            this.cdpiBrowser.Size = new System.Drawing.Size(726, 322);
            this.cdpiBrowser.TabIndex = 0;
            this.cdpiBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // lolaTab
            // 
            this.lolaTab.Controls.Add(this.lolaBrowser);
            this.lolaTab.Location = new System.Drawing.Point(4, 25);
            this.lolaTab.Name = "lolaTab";
            this.lolaTab.Padding = new System.Windows.Forms.Padding(3);
            this.lolaTab.Size = new System.Drawing.Size(732, 328);
            this.lolaTab.TabIndex = 4;
            this.lolaTab.Text = "LOLA";
            this.lolaTab.UseVisualStyleBackColor = true;
            // 
            // lolaBrowser
            // 
            this.lolaBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lolaBrowser.Location = new System.Drawing.Point(3, 3);
            this.lolaBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.lolaBrowser.Name = "lolaBrowser";
            this.lolaBrowser.Size = new System.Drawing.Size(726, 322);
            this.lolaBrowser.TabIndex = 0;
            this.lolaBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // billingLookupTab
            // 
            this.billingLookupTab.Controls.Add(this.billingLookupBrowser);
            this.billingLookupTab.Location = new System.Drawing.Point(4, 25);
            this.billingLookupTab.Name = "billingLookupTab";
            this.billingLookupTab.Padding = new System.Windows.Forms.Padding(3);
            this.billingLookupTab.Size = new System.Drawing.Size(732, 328);
            this.billingLookupTab.TabIndex = 6;
            this.billingLookupTab.Text = "Billing Lookup";
            this.billingLookupTab.UseVisualStyleBackColor = true;
            // 
            // billingLookupBrowser
            // 
            this.billingLookupBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billingLookupBrowser.Location = new System.Drawing.Point(3, 3);
            this.billingLookupBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.billingLookupBrowser.Name = "billingLookupBrowser";
            this.billingLookupBrowser.Size = new System.Drawing.Size(726, 322);
            this.billingLookupBrowser.TabIndex = 0;
            this.billingLookupBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // UserDefinedTab
            // 
            this.UserDefinedTab.Controls.Add(this.userBrowser1);
            this.UserDefinedTab.Location = new System.Drawing.Point(4, 25);
            this.UserDefinedTab.Name = "UserDefinedTab";
            this.UserDefinedTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserDefinedTab.Size = new System.Drawing.Size(732, 328);
            this.UserDefinedTab.TabIndex = 7;
            this.UserDefinedTab.Text = "Custom Tab 1";
            this.UserDefinedTab.UseVisualStyleBackColor = true;
            // 
            // userBrowser1
            // 
            this.userBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBrowser1.Location = new System.Drawing.Point(3, 3);
            this.userBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.userBrowser1.Name = "userBrowser1";
            this.userBrowser1.Size = new System.Drawing.Size(726, 322);
            this.userBrowser1.TabIndex = 0;
            this.userBrowser1.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // userDefined
            // 
            this.userDefined.Controls.Add(this.userBrowser2);
            this.userDefined.Location = new System.Drawing.Point(4, 25);
            this.userDefined.Name = "userDefined";
            this.userDefined.Padding = new System.Windows.Forms.Padding(3);
            this.userDefined.Size = new System.Drawing.Size(732, 328);
            this.userDefined.TabIndex = 8;
            this.userDefined.Text = "Custom Tab 2";
            this.userDefined.UseVisualStyleBackColor = true;
            // 
            // userBrowser2
            // 
            this.userBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBrowser2.Location = new System.Drawing.Point(3, 3);
            this.userBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.userBrowser2.Name = "userBrowser2";
            this.userBrowser2.Size = new System.Drawing.Size(726, 322);
            this.userBrowser2.TabIndex = 1;
            this.userBrowser2.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.frontierTabInner, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(746, 363);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // frontierBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 387);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight) 
            | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frontierBrowser";
            this.ShowIcon = false;
            this.TabText = "Frontier Broswer";
            this.Text = "Browser";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.frontierTabInner.ResumeLayout(false);
            this.inetTab.ResumeLayout(false);
            this.frontierWikiTab.ResumeLayout(false);
            this.loopcareTab.ResumeLayout(false);
            this.vnetTab.ResumeLayout(false);
            this.cdpiTab.ResumeLayout(false);
            this.lolaTab.ResumeLayout(false);
            this.billingLookupTab.ResumeLayout(false);
            this.UserDefinedTab.ResumeLayout(false);
            this.userDefined.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        public System.Windows.Forms.ToolStripTextBox addressBar;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        public System.Windows.Forms.TabControl frontierTabInner;
        public System.Windows.Forms.TabPage inetTab;
        public System.Windows.Forms.WebBrowser inetTabBrowser;
        public System.Windows.Forms.TabPage frontierWikiTab;
        public System.Windows.Forms.WebBrowser frontierWikiBrowser;
        private System.Windows.Forms.WebBrowser hiddenJwalkBrowser;
        public System.Windows.Forms.TabPage loopcareTab;
        public System.Windows.Forms.WebBrowser loopcareBrowser;
        public System.Windows.Forms.TabPage vnetTab;
        public System.Windows.Forms.WebBrowser vnetBrowser;
        public System.Windows.Forms.TabPage cdpiTab;
        public System.Windows.Forms.WebBrowser cdpiBrowser;
        public System.Windows.Forms.TabPage lolaTab;
        public System.Windows.Forms.WebBrowser lolaBrowser;
        public System.Windows.Forms.TabPage billingLookupTab;
        public System.Windows.Forms.WebBrowser billingLookupBrowser;
        public System.Windows.Forms.TabPage UserDefinedTab;
        public System.Windows.Forms.WebBrowser userBrowser1;
        public System.Windows.Forms.TabPage userDefined;
        public System.Windows.Forms.WebBrowser userBrowser2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem jWALKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;


    }
}