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
using WeifenLuo.WinFormsUI.Docking;

namespace NotesApp
{
    public partial class fairpointTr : DockContent
    {
        private string _custName;
        private string _custBtn;
        private string _custCbr;
        private string _tshootText;
        private string _otherNotes;
        private string _modemCheckbox;
        private string _modemText;

        public fairpointTr()
        {
            InitializeComponent();
        }
        public string CustName
        {
            get
            {
                return _custName;
            }
            set
            {
                _custName = value;
                fpneCxName.Text = _custName;
            }

        }
        public string CustBtn
        {
            get
            {
                return _custBtn;
            }
            set
            {
                _custBtn = value;
                fpneDslNumber.Text = _custBtn;
            }

        }
        public string CustCbr
        {
            get
            {
                return _custCbr;
            }
            set
            {
                _custCbr = value;
                fpneCbrNumber.Text = _custCbr;
            }

        }
        public string tshootText
        {
            get
            {
                return _tshootText;
            }
            set
            {
                _tshootText = value;
                tshootString = _tshootText;
            }

        }
        public string otherNotes
        {
            get
            {
                return _otherNotes;
            }
            set
            {
                _otherNotes = value;
                otherNotesString = _otherNotes;
            }

        }
        public string modemCheckBox
        {
            get
            {
                return _modemCheckbox;
            }
            set
            {
                _modemCheckbox = value;
                modemChkboxString = _modemCheckbox;
            }
        }
        public string modemText
        {
            get
            {
                return _modemText;
            }
            set
            {
                _modemText = value;
                fpneModem.Text = _modemText;
            }
        }
        string tshootString;
        string modemChkboxString;
        string otherNotesString;
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
            //Copy info to output with formatting
            System.Text.StringBuilder fpneTrProccess = new System.Text.StringBuilder();
            {
                fpneTrProccess.AppendLine(fpneActive);
                fpneTrProccess.AppendLine();
                fpneTrProccess.AppendLine(fpneCxName.Text);
                fpneTrProccess.AppendLine("DSL Number: " + fpneDslNumber.Text);
                fpneTrProccess.AppendLine("CBR Number: " + fpneCbrNumber.Text);
                fpneTrProccess.AppendLine("Service Type: " + reasonCombo.Text);
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
                Clipboard.SetText(fpneOutput.Text);}}
        private void fairpointTr_Load(object sender, EventArgs e)
        {
            fpneTshooting.Text = modemChkboxString + Environment.NewLine + "TroubleShooting: " + tshootString + Environment.NewLine + "OtherNotes: " + otherNotesString;
        }
    }
}
