using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace NotesApp
{
    public partial class fairpoint : Form
    {

        private notesForm parent;

        public fairpoint(notesForm parent)
        {

            InitializeComponent();
            this.parent = parent;
            fpneCxName.Text = parent.custNameText.Text;
            fpneDslNumber.Text = parent.custBtnText.Text;
            fpneCbrNumber.Text = parent.custCbrText.Text;
            fpneModem.Text = parent.custModemText.Text;
            fpneTshooting.Text = parent.checkBoxes + Environment.NewLine + "Troubleshooting: " + parent.tShootText.Text + Environment.NewLine + "Other Notes: " + parent.otherNotesText.Text;

        }



        private void fpneCopyButton_Click(object sender, EventArgs e)
            //Message box to ensure cx is Active.
        {
            string fpneActive = "CUSTOMER NOT ACTIVE";
            if (MessageBox.Show("Is the Customer Active in Dataview?", "Check if customer is active!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                fpneActive = "ACTIVE";

            }
            else
                MessageBox.Show("Refer to Customer Service if customer is not active!", "Warning", MessageBoxButtons.OK);

           


           //Put TAG info from radio buttons to output
            string radioButtonLine = "Service Type: ";
            foreach (Control control in pnlRadioButtons.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;

                    if (radioButton.Checked && radioButton.Tag is string)
                    {
                        string radioButtonId = (string)radioButton.Tag;
                        radioButtonLine += string.Format(radioButtonId);
                        radioButtonId = radioButtonLine;
                    }
                }

            }
           
            //Copy info to output with formatting
            System.Text.StringBuilder fpneTrProccess = new System.Text.StringBuilder();
            {
                fpneTrProccess.AppendLine(fpneActive);
                fpneTrProccess.AppendLine();
                fpneTrProccess.AppendLine(fpneCxName.Text);
                fpneTrProccess.AppendLine("DSL Number: " + fpneDslNumber.Text);
                fpneTrProccess.AppendLine("CBR Number: " + fpneCbrNumber.Text);
                fpneTrProccess.AppendLine(radioButtonLine);
                fpneTrProccess.AppendLine("Modem: " + fpneModem.Text);
                fpneTrProccess.AppendLine("PPP UN: " + fpnePppName.Text);
                fpneTrProccess.AppendLine("PPP PW: " + fpnePppPassword.Text);
                fpneTrProccess.AppendLine("Serving Wire: " + fpneServingWire.Text);
                fpneTrProccess.AppendLine("Address: " + fpneStreet.Text);
                fpneTrProccess.AppendLine("City: " + fpneCity.Text);
                fpneTrProccess.AppendLine("State: " + fpneState.Text);
                fpneTrProccess.AppendLine("Zip: " + fpneZipCode.Text);
                fpneTrProccess.AppendLine();
                fpneTrProccess.AppendLine(fpneTshooting.Text);
                fpneTrProccess.AppendLine();
                fpneTrProccess.AppendLine("Approved by: " + fpneApproval.Text);
                fpneOutput.Text = fpneTrProccess.ToString();

                if (fpneActive == "CUSTOMER NOT ACTIVE")
                {
                    fpneOutput.Text = "CUSTOMER NOT ACTIVE";
                }

                //Copy output to clipboard
                Clipboard.SetText(fpneOutput.Text);





        }
}
    }
}
