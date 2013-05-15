using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        }
        //Method to show startup forms
        public void showStartForms()
        {
            aboutForm about = new aboutForm();
            about.Show(mainDock, DockState.Document);
            notesForm = new notesForm();
            notesForm.Show(mainDock, DockState.DockLeft);
        }
        //Set Instance of front browser
        private frontierBrowser frontierBrowser = new frontierBrowser();
        //set instance of fpne browser
        private fpneBrowser fpneBrowser = new fpneBrowser();
        //set instance of notes browser
        public static notesForm notesForm = new notesForm();
        //Load forms
        private void TestForm_Load(object sender, EventArgs e)
        {
            showStartForms();
        }
        //Load the browsers
        private void loadBrowsers()
        {
            frontierBrowser frontierBrowser = new frontierBrowser();
            frontierBrowser.Show(mainDock, DockState.Document);
            frontierBrowser.Hide();
            fpneBrowser fpneBrowser = new fpneBrowser();
            fpneBrowser.Show(mainDock, DockState.Document);
            fpneBrowser.Hide();
        }
        //Load new front browser
        private void frontierBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frontierBrowser.IsHidden)
            {
                frontierBrowser.Show(mainDock, DockState.Document);
            }

        }
        //Load new fpne browser
        private void fPNEBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fpneBrowser.IsHidden)
            {
                fpneBrowser.Show(mainDock, DockState.Document);
            }
        }
        //Open and send data to code blue form from notes form
        private void codeBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeBlueform codeBlueForm = new codeBlueform();
            string checkBoxesLine = "Lights: ";
            foreach (Control control in notesForm.pnlCheckBoxes.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;

                    if (checkBox.Checked && checkBox.Tag is string)
                    {
                        string checkBoxId = (string)checkBox.Tag;
                        checkBoxesLine += string.Format("{0}, ", checkBoxId);

                    }
                }
            }
            string cbrSame = notesForm.CustBtn;
            if (notesForm.cbrSameCbx.Checked)
            {
                codeBlueForm.CustCbr = cbrSame;
            }
            else
            {
                codeBlueForm.CustCbr = notesForm.CustCbr;
            }
            codeBlueForm.CustName = notesForm.CustName;
            codeBlueForm.CustBtn = notesForm.CustBtn;
            codeBlueForm.modemCheckBox = checkBoxesLine;
            codeBlueForm.tshootText = notesForm.tshootText;
            codeBlueForm.otherNotes = notesForm.otherNotes;
            codeBlueForm.modemTextString = notesForm.modemText;
            codeBlueForm.Show(mainDock, DockState.DockRight);

        }
        //Open Fpne TR Form
        private void fPNETRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fairpointTr fairpointTrForm = new fairpointTr();
            string checkBoxesLine = "Lights: ";
            foreach (Control control in notesForm.pnlCheckBoxes.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;

                    if (checkBox.Checked && checkBox.Tag is string)
                    {
                        string checkBoxId = (string)checkBox.Tag;
                        checkBoxesLine += string.Format("{0}, ", checkBoxId);

                    }
                }
            }
            string cbrSame = notesForm.CustBtn;
            if (notesForm.cbrSameCbx.Checked)
            {
                fairpointTrForm.CustCbr = cbrSame;
            }
            else
            {
                fairpointTrForm.CustCbr = notesForm.CustCbr;
            }
            fairpointTrForm.CustName = notesForm.CustName;
            fairpointTrForm.CustBtn = notesForm.CustBtn;
            fairpointTrForm.modemCheckBox = checkBoxesLine;
            fairpointTrForm.tshootText = notesForm.tshootText;
            fairpointTrForm.otherNotes = notesForm.otherNotes;
            fairpointTrForm.modemText = notesForm.modemText;
            fairpointTrForm.Show(mainDock, DockState.DockRight);
        }   
        //Create new empty text window
        private void emptyTextWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textWindow textWindow = new textWindow();
            textWindow.Show(mainDock, DockState.DockRight);
        }
        //Open Log form
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logForm logForm = new logForm();
            logForm.Show(mainDock, DockState.DockRight);
        }
        //Clear Log
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("noteslog.txt");
            TextWriter tw = new StreamWriter(fi.Open(FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite));
        }
    }
}