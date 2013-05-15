﻿using System;
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
    public partial class codeBlueform : Form
    {
        private string _custName;
        private string _custBtn;
        private string _custCbr;
        private string _otherNotes;

        public codeBlueform()
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
                cbNameText.Text = _custName;
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
                cbWtnText.Text = _custBtn;
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
                cbCbrText.Text = _custCbr;
            }

        }
        public string OtherNotes
        {
            get
            {
                return _otherNotes;
            }
            set
            {
                _otherNotes = value;
                cbNotesText.Text = _otherNotes;
            }

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder strBuilder = new System.Text.StringBuilder();
            {
                strBuilder.AppendLine("Hello, L2 CODE BLUE");
                strBuilder.AppendLine();
                strBuilder.AppendLine("Tech Name: " + cbTechText.Text);
                strBuilder.AppendLine("Reason: " + reasonCombo.SelectedItem);
                strBuilder.AppendLine("Cx Name: " + cbNameText.Text);
                strBuilder.AppendLine("Cx WTN: " + cbWtnText.Text.Replace("-", ""));
                strBuilder.AppendLine("Cx CBR: " + cbCbrText.Text.Replace("-", ""));
                strBuilder.AppendLine("Cx Email: " + cbEmailText.Text);
                strBuilder.AppendLine("Cx Street: " + cbStreetText.Text + " ");
                strBuilder.AppendLine(cbCityText.Text + ", ");
                strBuilder.AppendLine(cbStateText.Text + " ");
                strBuilder.AppendLine(cbZipText.Text);
                strBuilder.AppendLine("DPI Ticket# " + cbDpiText.Text);
                strBuilder.AppendLine();
                strBuilder.AppendLine("Inet Notes: " + "\r" + cbNotesText.Text);

                cbViewText.Text = strBuilder.ToString();

                Clipboard.SetText(cbViewText.Text);
            }
        }



    }
}
