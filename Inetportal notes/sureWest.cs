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
using VncSharp;


namespace NotesApp
{
    public partial class sureWest : DockContent
    {
        public sureWest()
        {
            InitializeComponent();
        }
        private TabPage[] customTab = new TabPage[100];
        private WebBrowser[] webBrowserCustom = new WebBrowser[100];
        int i = 0;
        //Back Button
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser goControl = swTabControl.SelectedTab.Controls.OfType<WebBrowser>().FirstOrDefault();
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
swTabControl.SelectedTab.Controls.OfType<WebBrowser>().FirstOrDefault();
            refreshControl.Refresh();
            if (refreshControl.ReadyState.ToString() == "Complete")
            {
                addressBar.Text = refreshControl.Url.ToString();
            }
        }
        //Go Button
        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser goControl = swTabControl.SelectedTab.Controls.OfType<WebBrowser>().FirstOrDefault();
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
        //Update Address Bar
        private void fpneTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebBrowser addressControl = swTabControl.SelectedTab.Controls.OfType<WebBrowser>().FirstOrDefault();
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
        //Load Browsers
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            swWikiBrowser.Navigate("http://wiki.telenetwork.com/index.php/SureWest");
            swToolsBrowser.Navigate("http://cm-prov-nova.corp.surewest.com/");
            swQuickTicketBrowser.Navigate("http://caro815niisp01.corp.surewest.com/troubleticketquickadd/Default.aspx");
            swEmailAdmin.Navigate("http://email-prov.corp.surewest.com/");
        }
        //Search Tracker
        private void trackerSearchButton_Click(object sender, EventArgs e)
        {
            string searchKey = trackerSearchText.Text;
            swTrackerBrowser.Navigate("http://tracker.telenetwork.com/tracker/gobetween.plx?searchby=uname&submit=Search&looky=" + searchKey);
        }
        //Load settings
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browserSettings settings = new browserSettings();
            settings.Show();
        }
        private void FlipMenuOptions()
        {
            connectStormMenu.Enabled = !stormWatchControl.IsConnected;
            disconnectStormMEnu.Enabled = stormWatchControl.IsConnected;
            loginStormMenu.Enabled = stormWatchControl.IsConnected;
        }
        private void loginToolStripStormWatch_Click(object sender, EventArgs e)
        {
            if (stormWatchControl.IsConnected)
            {
                stormWatchControl.SendSpecialKeys(SpecialKeys.s, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.t, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.o, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.r, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.m, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.w, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.a, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.t, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.c, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.h, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.Enter, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.v, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.H, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.s, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.four, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.E, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.v, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.e, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.r, true);
                stormWatchControl.SendSpecialKeys(SpecialKeys.Enter, true);
            }
            else
            {MessageBox.Show("Please wait till it finishes loading.","Please wait");}
        }

        private void connectToolStrip_Click(object sender, EventArgs e)
        {
            disconnectStormMEnu.Enabled = true;
            string host = "64.126.0.244";
            if (host != null)
            {
                try
                {
                    stormWatchControl.Connect(host);
                }
                catch (VncProtocolException vex)
                {
                    MessageBox.Show(this,
            string.Format("Unable to connect to StormWatch. Ensure you are on the correct VPN Server", vex.Message),
            string.Format("Unable to Connect to StormWatch", host),
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this,
        string.Format("Unable to connect to StormWatch.  Error was: {0}", ex.Message),
        string.Format("Unable to Connect to {0}", host),
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation);
                }
            }

        }   
        private void sureWest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (stormWatchControl.IsConnected)
                stormWatchControl.Disconnect();
            base.OnClosing(e);
        }
        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stormWatchControl.Disconnect();
        }

        private void stormWatchControl_ConnectComplete(object sender, ConnectEventArgs e)
        {
            FlipMenuOptions();
        }

        private void stormWatchControl_ConnectionLost(object sender, EventArgs e)
        {
            MessageBox.Show(this,
                "StormWatch has been disconnected. If this was not intentional try reconnecting.",
                "Connection Lost",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            FlipMenuOptions();
        }

        private void addTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customTab[i] = new TabPage();
            customTab[i].Text = "New Tab";
            webBrowserCustom[i] = new WebBrowser();
            webBrowserCustom[i].Dock = DockStyle.Fill;
            webBrowserCustom[i].Navigate("about:blank");
            
            customTab[i].Controls.Add(webBrowserCustom[i]);
            customTab[i].Name = "customTab" + i.ToString();
            swTabControl.TabPages.Add(customTab[i]);
            i++;
        }
        private void novaConnect_Click(object sender, EventArgs e)
        {
        
            try
            {
                //rdp.Server = "FFWIN2008R2DC.fflab123.net";
                //rdp.Domain = "fflab123";
                //rdp.UserName = "administrator";
                
                //rdp.OnConnected += rdp_OnConnected;
                ////rdp.RemoteProgram.RemoteProgramMode = true;
                ////rdp.RemoteProgram2.RemoteApplicationName = "Calculator";
                ////rdp.RemoteProgram2.RemoteApplicationProgram = @"C:\Windows\system32\calc.exe";
                
                //rdp.Connect();   
  
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error Connecting", "Error connecting to remote desktop " + " Error:  " + Ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

        void rdp_OnConnected(object sender, EventArgs e)
        {
            //rdp.SecuredSettings.StartProgram = @"C:\Windows\System32\calc.exe";
            

        }

        private void novaDisconnect_Click(object sender, EventArgs e)
        {

            
            }
        }

    }

