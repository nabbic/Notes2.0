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

            }
        }

        private void openTextFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveFile.ShowDialog();
            opentext.FileName = saveFile.FileName;
            File.WriteAllText(saveFile.FileName, richTextBox1.Text);

        }
    
    }
}
