using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NotesApp
{
    public partial class browserSettings : Form
    {

        public browserSettings()

        {
            InitializeComponent();
        }
        public string usernameInet;
        public string passwordInet;
        private void saveSettings_Click(object sender, EventArgs e)
        {
            Settings1.Default.inetUsername = (inetUsername.Text);
            Settings1.Default.inetPassword = (InetPassword.Text);
            Settings1.Default.vnetUsername = (vnetUsername.Text);
            Settings1.Default.vnetPassword = (vnetPassword.Text);
            Settings1.Default.loopUsername = (loopcareUsername.Text);
            Settings1.Default.loopPassword = (loopcarePassword.Text);
            Settings1.Default.cdpiUsername = (cdpiTicketUsername.Text);
            Settings1.Default.cdpiPassword = (cdpiTicketPassword.Text);
            Settings1.Default.Save();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browserSettings_Load(object sender, EventArgs e)
        {
            inetUsername.Text = Settings1.Default.inetUsername;
            InetPassword.Text = Settings1.Default.inetPassword;
            loopcareUsername.Text = Settings1.Default.loopUsername;
            loopcarePassword.Text = Settings1.Default.loopPassword;
            vnetUsername.Text = Settings1.Default.vnetUsername;
            vnetPassword.Text = Settings1.Default.vnetPassword;
            cdpiTicketUsername.Text = Settings1.Default.cdpiUsername;
            cdpiTicketPassword.Text = Settings1.Default.cdpiPassword;
        }
    }
}
