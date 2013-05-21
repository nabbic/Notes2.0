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

namespace NotesApp
{
    public partial class aboutForm : DockContent
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IE ie = new IE();
            ie.GoTo("http://notes.host-ed.me/contact.php");

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }




    }
}
