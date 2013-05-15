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

        }
        //Method to show startup forms
        public void showStartForms()
        {
            aboutForm about = new aboutForm();
            about.Show(dockPanel1, DockState.Document);
            notesForm = new notesForm();
            notesForm.Show(dockPanel1, DockState.DockLeft);
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
            frontierBrowser.Show(dockPanel1, DockState.Document);
            frontierBrowser.Hide();
            fpneBrowser fpneBrowser = new fpneBrowser();
            fpneBrowser.Show(dockPanel1, DockState.Document);
            fpneBrowser.Hide();
        }
        //Load new front browser
        private void frontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frontierBrowser.IsHidden)
            {
                frontierBrowser.Show(dockPanel1, DockState.Document);
            }

        }
        //Load new fpne browser
        private void fpneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fpneBrowser.IsHidden)
            {
                fpneBrowser.Show(dockPanel1, DockState.Document);
            }
        }
        //Open and send data to code blue form from notes form
        private void codeBlueButton_Click(object sender, EventArgs e)
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
            codeBlueForm.Show();

        }
       
    }
}