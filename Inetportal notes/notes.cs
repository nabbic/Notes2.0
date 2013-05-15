using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;
using System.Web;
using System.Xaml;
using System.Xml;
using WeifenLuo.WinFormsUI.Docking;
using notesApp;
using System.Diagnostics;

namespace NotesApp
{

    public partial class notesForm : DockContent
    {
        public string checkBoxes;
        private string _custName;
        private string _custBtn;
        private string _custCbr;
        private string _tshootText;
        private string _otherNotes;
        private string _modemText;

        public notesForm()
        {
            InitializeComponent();
            
    
        }

        public string CustName
        {
            get
            {
                return custNameText.Text;
            }
            set
            {
                _custName = value;
                custNameText.Text = _custName;
            }

        }
        public string CustBtn
        {
            get
            {
                return custBtnText.Text;
            }
            set
            {
                _custBtn = value;
                custBtnText.Text = _custBtn;
            }

        }
        public string CustCbr
        {
            get
            {
                return custCbrText.Text;
            }
            set
            {
                _custCbr = value;
                custCbrText.Text = _custCbr;
            }

        }
        public string tshootText
        {
            get
            {
                return tShootText.Text;
            }
            set
            {
                _tshootText = value;
                tShootText.Text  = _tshootText;
            }

        }
        public string otherNotes
        {
            get
            {
                return otherNotesText.Text;
            }
            set
            {
                _otherNotes = value;
                otherNotesText.Text = _otherNotes;
            }

        }
        public string modemText
        {
            get
            {
                return custModemText.Text;
            }
            set
            {
                _modemText = value;
                custModemText.Text = _modemText;
            }
        }

        bool outage = true;
        string checkBoxesLine;
        //Generate to output and textfile
        private void save_button_Click(object sender, EventArgs e)
        {
            //Starts process to process the lights checkboxes
             checkBoxesLine = "\u2022 LIGHTS: ";
            foreach (Control control in pnlCheckBoxes.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;

                    if (checkBox.Checked && checkBox.Tag is string)
                    {
                        string checkBoxId = (string)checkBox.Tag;
                        checkBoxesLine += string.Format("{0}, ", checkBoxId);
                        checkBoxes = checkBoxesLine;}}}
            //Starts the Stringbuilder
            System.Text.StringBuilder strBuilder = new System.Text.StringBuilder();
            {
                string cbrSame = custBtnText.Text;
                if (cbrSameCbx.Checked)
                {
                    custCbrText.Text = cbrSame;
                }
                //Writes textboxes to the stringbuilder
                strBuilder.AppendLine("\u2022 CX NAME: " + custNameText.Text);
                strBuilder.AppendLine("\u2022 BTN: " + custBtnText.Text);
                strBuilder.AppendLine("\u2022 CBR: " + custCbrText.Text);

                if (noModemChkbox.Checked)
                {
                }
                else
                {
                    strBuilder.AppendLine("\u2022 MODEM: " + custModemText.Text);
                    //Statements to write checkboxes to stringbuilder

                    //Newline for checkboxes
                    strBuilder.AppendLine(checkBoxesLine);
                    strBuilder.AppendLine();
                }
                //Continues textboxes to stringbuilder
                strBuilder.AppendLine("\u2022 TROUBLESHOOTING: " + tShootText.Text);
                strBuilder.AppendLine();
                if (outage == true)
                {
                strBuilder.AppendLine("\u2022 SERVICES OFFERED: " + svcsOfferedText.Text);
                strBuilder.AppendLine();
                strBuilder.AppendLine("\u2022 OTHER NOTES: " + otherNotesText.Text);
                }
                notesViewText.Text = strBuilder.ToString();
                //Copy output to clipboard
                System.Windows.Forms.Clipboard.SetText(notesViewText.Text);
                // create a writer and open the file
                //TextWriter tw = new StreamWriter("noteslog.txt");
                // write a line of text to the file
                using (TextWriter tr = new StreamWriter(new FileStream(AppDomain.CurrentDomain.BaseDirectory + "noteslog.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite)))
                {
                    {
                        tr.WriteLine("\u2022 CX NAME: " + custNameText.Text);
                        tr.WriteLine("\u2022 BTN: " + custBtnText.Text);
                        tr.WriteLine("\u2022 CBR: " + custCbrText.Text);
                        tr.WriteLine("\u2022 MODEM: " + custModemText.Text);
                        tr.WriteLine(checkBoxesLine);
                        tr.WriteLine("\u2022 TROUBLESHOOTING: " + tShootText.Text);
                        tr.WriteLine("\u2022 SERVICES OFFERED: " + svcsOfferedText.Text);
                        tr.WriteLine("\u2022 OTHER NOTES: " + otherNotesText.Text);
                        tr.WriteLine("*******************************");
                        // close the stream
                        tr.Close();}}}}
        //Button to reset entire form
        private void reset_form_button_Click(object sender, EventArgs e)
        {
            //Reset checkboxes panel
            try
            {
                foreach (Control ctrl in pnlCheckBoxes.Controls)
                {
                    if (ctrl.GetType() == typeof(CheckBox))
                        ((CheckBox)ctrl).Checked = false;

                }
                //resets textboxes
                noModemChkbox.Checked = false;
                custNameText.Clear();
                custBtnText.Clear();
                custCbrText.Clear();
                custModemText.Clear();
                tShootText.ResetText();
                svcsOfferedText.Clear();
                otherNotesText.Clear();
                notesViewText.Clear();
                cbrSameCbx.Checked = false;
                this.outage = true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
        //Context menu on rich text that copies
        private void copy_context_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(notesViewText.Text);
        }
        //Button to copy BTN to Clipboard and remove the "-" from the number
        private void copyBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(!String.IsNullOrEmpty(custBtnText.Text))
            {
            System.Windows.Forms.Clipboard.SetText(custBtnText.Text.Replace("-", ""));
            
            }
            else
                System.Windows.Forms.MessageBox.Show("Please insert the customer's billing number!", "Information Required");
        }
        // Open Fairpoint form
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //To process checkboxes if generate is not pushed on main form.
            string checkBoxesLine = "Lights: ";
            foreach (Control control in pnlCheckBoxes.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;

                    if (checkBox.Checked && checkBox.Tag is string)
                    {
                        string checkBoxId = (string)checkBox.Tag;
                        checkBoxesLine += string.Format("{0}, ", checkBoxId);
                        checkBoxes = checkBoxesLine;
                    }
                }
            }

            //__________________________________________________________________//

            //To work out CBR same if generate is not pushed on main form.


            //__________________________________________________________________//

            fairpoint fpneForm = new fairpoint(this);
            fpneForm.Show();
        }
        //Checkbox to check if CBR and BTN are the same
        private void cbrSameCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (cbrSameCbx.Checked == true)
            {
                custCbrText.BackColor = System.Drawing.Color.LightGray;
                custCbrText.Enabled = false;
            }
            else
            {
                custCbrText.Enabled = true;
                custCbrText.BackColor = System.Drawing.Color.White;
            }
            }
        //Check box to disable modem options and corresponding formatting
        private void noModemChkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (noModemChkbox.Checked == true)
            {
                custModemText.BackColor = System.Drawing.Color.LightGray;
                custModemText.Enabled = false;
                custModemText.WaterMarkText = "";
                pwrCbx.Enabled = false;
                e1Cbx.Enabled = false;
                e2Cbx.Enabled = false;
                e3Cbx.Enabled = false;
                e4Cbx.Enabled = false;
                dslblinkCbx.Enabled = false;
                enetCbx.Enabled = false;
                dslCbx.Enabled = false;
                inetCbx.Enabled = false;
                inetredCbx.Enabled = false;
                wlanCbx.Enabled = false;
                activityChkbox.Enabled = false;
            }
            else
            {
                custModemText.BackColor = System.Drawing.Color.White;
                custModemText.WaterMarkText = "Customer's Modem";
                custModemText.Enabled = true;
                pwrCbx.Enabled = true;
                e1Cbx.Enabled = true;
                e2Cbx.Enabled = true;
                e3Cbx.Enabled = true;
                e4Cbx.Enabled = true;
                dslblinkCbx.Enabled = true;
                enetCbx.Enabled = true;
                dslCbx.Enabled = true;
                inetCbx.Enabled = true;
                inetredCbx.Enabled = true;
                wlanCbx.Enabled = true;
                activityChkbox.Enabled = true;
            }
        }
        //Menu button to sue for outages
        private void outageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tShootText.Text += "\r" + "Cx currently in an outage area. Advised cx of the outage and any information we have currently regarding it.";
             this.outage = true;
             noModemChkbox.Checked = true;

        }
    }
}






















