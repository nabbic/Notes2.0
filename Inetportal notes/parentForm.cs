using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using notesApp;
using WeifenLuo.WinFormsUI.Docking;
namespace NotesApp
{
    public partial class parentForm : Form
    {

        public parentForm()
        {
            InitializeComponent();
            aboutForm about = new aboutForm();
            about.Show(dockPanel1, DockState.Document);
        }

        
        private frontierBrowser frontierBrowser = new frontierBrowser();
        private fpneBrowser fpneBrowser = new fpneBrowser();
        public static notesForm notes = new notesForm();
        public void showNotesForm()
        {
            notes = new notesForm();
            notes.Show(dockPanel1, DockState.DockLeft);
        }
        private void TestForm_Load(object sender, EventArgs e)
        {
            showNotesForm();
        }

        private void loadBrowsers()
        {
            frontierBrowser frontierBrowser = new frontierBrowser();
            frontierBrowser.Show(dockPanel1, DockState.Document);
            frontierBrowser.Hide();
            fpneBrowser fpneBrowser = new fpneBrowser();
            fpneBrowser.Show(dockPanel1, DockState.Document);
            fpneBrowser.Hide();
        }

        private void frontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frontierBrowser.IsHidden)
            {
                frontierBrowser.Show(dockPanel1, DockState.Document);
            }

        }

        private void fpneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fpneBrowser.IsHidden)
            {
                fpneBrowser.Show(dockPanel1, DockState.Document);
            }
        }

        private void codeBlueButton_Click(object sender, EventArgs e)
        {
            codeBlueform form2 = new codeBlueform();
            form2.CustName = notes.CustName;
            form2.CustBtn = notes.CustBtn;
            form2.CustCbr = notes.CustCbr;
            form2.OtherNotes = notes.OtherNotes;
            form2.Show();
        }

    }
}