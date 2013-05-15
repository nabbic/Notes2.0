using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;
using System.Threading;
namespace NotesApp
{
    public partial class logForm : DockContent
    {
        private string logString;
        public logForm()
        {
            InitializeComponent();
        }
        private void logForm_Load(object sender, EventArgs e)
        {
            var watch = new FileSystemWatcher();
            watch.Path = AppDomain.CurrentDomain.BaseDirectory;
            watch.Filter = "noteslog.txt";
            watch.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite; //more options
            watch.Changed += new FileSystemEventHandler(OnChanged);
            watch.EnableRaisingEvents = true;
        }
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            if (e.FullPath == AppDomain.CurrentDomain.BaseDirectory + "noteslog.txt")
            {
                {
                    if (logText.InvokeRequired)
                    {
                        logText.Invoke((MethodInvoker)delegate { OnChanged(source, e); });
                    }
                    else
                    {
                        TextReader reader = new StreamReader(new FileStream(AppDomain.CurrentDomain.BaseDirectory + "noteslog.txt", FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)) ;
                        {
                            
                           logText.Text = reader.ReadToEnd();
                            reader.Close();
                        }
                    }
                }

            }
        }
    }
}


