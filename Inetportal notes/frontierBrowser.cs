using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WatiN;
using WatiN.Core;
using System.Web;
using System.Threading;
using WeifenLuo.WinFormsUI.Docking;

namespace NotesApp
{
    public partial class frontierBrowser : DockContent
    {
        public frontierBrowser()
        {
            InitializeComponent();
        }
        //Load
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inetTabBrowser.Navigate("http://www.czncorp.com/inetportal/showform.action?moduleName=search");
            frontierWikiBrowser.Navigate("http://wiki.telenetwork.com/index.php/Frontier");
            loopcareBrowser.Navigate("http://lpcare.czncorp.com/loopcare/Login.jsp");
            vnetBrowser.Navigate("http://wolfgang.czncorp.com/sh/servlet/PortalLogin");
            cdpiBrowser.Navigate("http://tools.telenetwork.com/cdpiportal/cdpitt/");
            lolaBrowser.Navigate("http://techhelp.northcentralnetworks.com/vsc/index.asp?");
            billingLookupBrowser.Navigate("http://tools.telenetwork.com/Frontier%20Secure/Blookup/");
        }
        //Login button
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frontierWikiBrowser.Navigate("http://wiki.telenetwork.com/index.php/Frontier");
 //INET____________________________________________________________________________________________
            var inetBrowserThread = new Thread(() =>
            {
               Settings.AutoStartDialogWatcher = false;
                var inetThread = new IE(inetTabBrowser.ActiveXInstance);

                inetThread.GoTo("http://www.czncorp.com/inetportal/showform.action?moduleName=search");
                inetThread.TextField(Find.ByName("j_username")).TypeText(Settings1.Default.inetUsername);
                inetThread.TextField(Find.ByName("j_password")).TypeText(Settings1.Default.inetPassword);
                inetThread.Button(Find.ByName("submit")).Click();
                Application.Run();
            });
            inetBrowserThread.SetApartmentState(ApartmentState.STA);
            inetBrowserThread.Start();

//LOOPCARE______________________________________________________________________________________
            var loopBrowserThread = new Thread(() =>
            {
                Settings.AutoStartDialogWatcher = false;
                var loopThread = new IE(loopcareBrowser.ActiveXInstance);

                loopThread.GoTo("http://lpcare.czncorp.com/loopcare/Login.jsp");
                loopThread.TextField(Find.ByName("UserId")).TypeText(Settings1.Default.loopUsername);
                loopThread.TextField(Find.ByName("Password")).TypeText(Settings1.Default.loopPassword);
                loopThread.ElementWithTag("a", Find.By("accessKey", "S")).Click();
                Application.Run();
            });
            loopBrowserThread.SetApartmentState(ApartmentState.STA);
            loopBrowserThread.Start();
//CDPI___________________________________________________________________________________________
            var cdpiBrowserThread = new Thread(() =>
            {
                Settings.AutoStartDialogWatcher = false;
                var cdpiThread = new IE(cdpiBrowser.ActiveXInstance);

                cdpiThread.GoTo("http://tools.telenetwork.com/cdpiportal/cdpitt/");
                cdpiThread.TextField(Find.ById("lanid")).TypeText(Settings1.Default.cdpiUsername);
                cdpiThread.TextField(Find.ById("lanpwd")).TypeText(Settings1.Default.cdpiPassword);
                Application.Run();
            });
            cdpiBrowserThread.SetApartmentState(ApartmentState.STA);
            cdpiBrowserThread.Start();
//LOLA___________________________________________________________________________________________
            var lolaThread = new Thread(() =>
            {
                Settings.AutoStartDialogWatcher = false;
                var lolaBrowserThread = new IE(lolaBrowser.ActiveXInstance);

                lolaBrowserThread.GoTo("http://techhelp.northcentralnetworks.com/vsc/index.asp?");
                lolaBrowserThread.TextField(Find.ById("Username")).TypeText("telenet");
                lolaBrowserThread.TextField(Find.ById("Password")).TypeText("austin");
                lolaBrowserThread.Button(Find.ByValue("Submit")).Click();
                Application.Run();
            });
            lolaThread.SetApartmentState(ApartmentState.STA);
            lolaThread.Start();
//BILLING________________________________________________________________________________________
            var billingThread = new Thread(() =>
            {
                Settings.AutoStartDialogWatcher = false;
                var billingLookupThread = new IE(billingLookupBrowser.ActiveXInstance);

                billingLookupThread.GoTo("http://tools.telenetwork.com/Frontier%20Secure/Blookup/");
                billingLookupThread.TextField(Find.ByName("UN")).TypeText(Settings1.Default.cdpiUsername);
                billingLookupThread.TextField(Find.ByName("PW")).TypeText(Settings1.Default.cdpiPassword);
                billingLookupThread.Button(Find.ByValue("Submit")).Click();
                Application.Run();
            });
            billingThread.SetApartmentState(ApartmentState.STA);
            billingThread.Start();
//END LOGIN
        }

        //Load JWALK
        private void jWALKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hiddenJwalkBrowser.Navigate("http://endeavor.czncorp.com/JWALK42/CITIZENSDPItele.HTML");
        }
        //Go button 
        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser goControl = frontierTabInner.SelectedTab.Controls.OfType<WebBrowser>().FirstOrDefault();
            goControl.Navigate(addressBar.Text);
            if (goControl.ReadyState.ToString() == "Complete")
            {
                addressBar.Text = goControl.Url.ToString();
            }
        }
        //Back button
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser backControl =
               frontierTabInner.SelectedTab.Controls.OfType<WebBrowser>().FirstOrDefault();

            if (backControl.CanGoBack)
            {
                backControl.GoBack();
                addressBar.Text = backControl.Url.ToString();
            }


        }
        //Refresh Button
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowser refreshControl =
   frontierTabInner.SelectedTab.Controls.OfType<WebBrowser>().FirstOrDefault();
            refreshControl.Refresh();
            if (refreshControl.ReadyState.ToString() == "Complete")
            {
                addressBar.Text = refreshControl.Url.ToString();
            }
        }
        //Load Settings menu
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browserSettings settings = new browserSettings();
            settings.Show();
        }
        //Update Address Bar
        private void frontierTabInner_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebBrowser goControl = frontierTabInner.SelectedTab.Controls.OfType<WebBrowser>().FirstOrDefault();
            addressBar.Text = goControl.Url.ToString();
        }
        //Press enter to go
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                goToolStripMenuItem_Click((object)sender, (EventArgs)e);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var vnetBrowserThread = new Thread(() =>
            {
                
                Settings.AutoStartDialogWatcher = false;
                var vnetThread = new IE(vnetBrowser.ActiveXInstance);
                
                vnetThread.GoTo("http://wolfgang.czncorp.com/sh/servlet/PortalLogin");
                int test = vnetThread.Frames.Count;
                MessageBox.Show(test.ToString());
                Application.Run();
            });
            vnetBrowserThread.SetApartmentState(ApartmentState.STA);
            vnetBrowserThread.Start();
        }
    }
}



    
