using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WeifenLuo.WinFormsUI.Docking;
namespace NotesApp
{
    public partial class openTextFile : DockContent
    {
        public openTextFile()
        {
            InitializeComponent();
        }

        private void openTextFile_Load(object sender, EventArgs e)
        {

            if (opentext.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(opentext.FileName);
                this.Text = opentext.SafeFileName.ToString();
            }
        }

        private void openTextFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Save file before closing?", "Save File?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                saveFileDialog1.ShowDialog();
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
    }
}
