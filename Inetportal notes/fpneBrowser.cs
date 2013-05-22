using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WatiN.Core;
using System.Threading;
using WatiN.Core.DialogHandlers;
using WatiN.Core.UtilityClasses;
using System.Diagnostics;
using System.Windows.Automation;
using WatiN.Core.Native.Windows;

namespace NotesApp
{
    public partial class fpneBrowser : DockContent
    {
        public fpneBrowser()
        {
            InitializeComponent();
        }
        //Load
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fpneAdminBrowser.Navigate("http://fairpoint.telenetwork.com/prod/om/subinfo/");
            fpneWikiBrowser.Navigate("http://wiki.telenetwork.com/index.php/FairPoint_NE");
            dataviewBrowser.Navigate("http://wiki.telenetwork.com/index.php/FairPoint_Dataview");
            hostopiaBrowser.Navigate("https://w3control.carrierzone.com/WHOS/");
            securityAdminBrowser.Navigate("https://fairpoint-portal.radialpoint.net/ProvisioningPortal/");
            securityPortalBrowser.Navigate("http://support.radialpoint.com/");
            securityLookupBrowser.Navigate("http://csis.freedom.net/");
        }
        //Search Tracker
        private void trackerSearchButton_Click(object sender, EventArgs e)
        {
            string searchKey = trackerSearchText.Text;
            fpneTrackerBrowser.Navigate("http://tracker.telenetwork.com/tracker/gobetween.plx?searchby=uname&submit=Search&looky=" + searchKey);
            
        }
        //Login
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fpneWikiBrowser.Navigate("http://wiki.telenetwork.com/index.php/FairPoint_NE");
//ADMIN_________________________________________________________________________________
            var adminBrowserThread = new Thread(() =>
            {
                Settings.AutoStartDialogWatcher = false;
                var adminThread = new IE(fpneAdminBrowser.ActiveXInstance);
                adminThread.GoTo("http://fairpoint.telenetwork.com/prod/om/subinfo/");
                Application.Run();
            });
            adminBrowserThread.SetApartmentState(ApartmentState.STA);
            adminBrowserThread.Start();
//DATAVIEW_______________________________________________________________________________
            var dataViewBrowserThread = new Thread(() =>
            {
                Settings.AutoStartDialogWatcher = false;
                var dataViewThread = new IE(dataviewBrowser.ActiveXInstance);
                dataViewThread.GoTo("http://dataview.fairpoint.com/AWS/AWSCredSearch.aspx");
                Application.Run();
            });
            dataViewBrowserThread.SetApartmentState(ApartmentState.STA);
            dataViewBrowserThread.Start();
//HOSTOPIA________________________________________________________________________________
            var hostopiaBrowserThread = new Thread(() =>
            {
                Settings.AutoStartDialogWatcher = false;
                var hostopiaThread = new IE(hostopiaBrowser.ActiveXInstance);

                hostopiaThread.GoTo("https://w3control.carrierzone.com/WHOS/");
                hostopiaThread.TextField(Find.ByName("Email")).TypeText("tele.network@myfairpoint.net");
                hostopiaThread.TextField(Find.ByName("Password")).TypeText("pw4@t3ln");
                hostopiaThread.Button(Find.ByName("btnLogin")).Click();
                Application.Run();
            });
            hostopiaBrowserThread.SetApartmentState(ApartmentState.STA);
            hostopiaBrowserThread.Start();
//SEC ADMIN________________________________________________________________________________
            var secAdminBrowserThread = new Thread(() =>
            {
                Settings.AutoStartDialogWatcher = false;
                var secAdminThread = new IE(securityAdminBrowser.ActiveXInstance);

                secAdminThread.GoTo("https://fairpoint-portal.radialpoint.net/ProvisioningPortal/");
                secAdminThread.TextField(Find.ByName("name")).TypeText("tni1");
                secAdminThread.TextField(Find.ByName("password")).TypeText("Cowboy00");
                secAdminThread.Button(Find.ByName("submit")).Click();
                Application.Run();
            });
            secAdminBrowserThread.SetApartmentState(ApartmentState.STA);
            secAdminBrowserThread.Start();
//SEC PORTAL___________________________________________________________________________________
            var secPortalBrowserThread = new Thread(() =>
            {
                Settings.AutoStartDialogWatcher = false;
                var secPortalThread = new IE(securityPortalBrowser.ActiveXInstance);

                secPortalThread.GoTo("http://support.radialpoint.com/");
                secPortalThread.TextField(Find.ByName("username")).TypeText("fairpointt1");
                secPortalThread.TextField(Find.ByName("password")).TypeText("fairpointt1");
                secPortalThread.Button(Find.ByName("login")).Click();
                Application.Run();
            });
            secPortalBrowserThread.SetApartmentState(ApartmentState.STA);
            secPortalBrowserThread.Start();
//SEC LOOKUP_____________________________________________________________________________________
            var secLookupBrowserThread = new Thread(() =>
            {
                Settings.AutoStartDialogWatcher = false;
                var secLookupThread = new IE(securityLookupBrowser.ActiveXInstance);

                secLookupThread.GoTo("http://csis.freedom.net/");
                secLookupThread.TextField(Find.ByName("auth")).TypeText("fairpoint");
                secLookupThread.TextField(Find.ByName("pass")).TypeText("fair22point ");
                secLookupThread.Button(Find.ByName("op")).Click();
                Application.Run();
            });
            secLookupBrowserThread.SetApartmentState(ApartmentState.STA);
            secLookupBrowserThread.Start();
        }
        //Load Settings
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browserSettings settings = new browserSettings();
            settings.Show();
        }
        //Back Button
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser goControl = fpneTabControl.SelectedTab.Controls.OfType<WebBrowser>().FirstOrDefault();
            goControl.Navigate(addressBar.Text);
            if (goControl.ReadyState.ToString() == "Complete")
            {
                addressBar.Text = goControl.Url.ToString();
            }
        }
        //Refresh Button
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser refreshControl =
            fpneTabControl.SelectedTab.Controls.OfType<WebBrowser>().FirstOrDefault();
            refreshControl.Refresh();
            if (refreshControl.ReadyState.ToString() == "Complete")
            {
                addressBar.Text = refreshControl.Url.ToString();
            }
        }
        //Go button
        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser goControl = fpneTabControl.SelectedTab.Controls.OfType<WebBrowser>().FirstOrDefault();
            goControl.Navigate(addressBar.Text);
            addressBar.Text = goControl.Url.ToString();
            userBrowser1.DocumentTitleChanged += userBrowser1_DocumentTitleChanged;
            userBrowser2.DocumentTitleChanged += userBrowser2_DocumentTitleChanged;
        }

        void userBrowser2_DocumentTitleChanged(object sender, EventArgs e)
        {
            userDefined2.Text = userBrowser2.DocumentTitle;

        }

        void userBrowser1_DocumentTitleChanged(object sender, EventArgs e)
        {
            UserDefined1.Text = userBrowser1.DocumentTitle;
        }
        
        //Update address bar
        private void fpneTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebBrowser addressControl = fpneTabControl.SelectedTab.Controls.OfType<WebBrowser>().FirstOrDefault();
            addressBar.Text = addressControl.Url.ToString();
        }
        //Enter to go
        private void addressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                goToolStripMenuItem_Click((object)sender, (EventArgs)e);
            }
        }



        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
