using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextStudio
{
    public partial class RunProgram : Form
    {
        string filename;
        Process current;
        PerformanceCounter PerformanceCounter;

        public RunProgram(string filename)
        {
            InitializeComponent();
            this.filename = filename;
        }

        private void RunAsBatchFile_Click(object sender, EventArgs e)
        {
            current = Process.Start("cmd.exe", filename);
            ProcessInfo.Text += "Process Booted to Command Prompt\r\n\r\nProc Name: "+current.ProcessName+"\r\nId: "+current.Id+"\r\nSession Id: "+current.SessionId;
        }

        private void DeployHtmlToChrome_Click(object sender, EventArgs e)
        {
            current = Process.Start("chrome.exe", filename);
            ProcessInfo.Text += "Process Booted to Command Prompt\r\n\r\nProc Name: " + current.ProcessName + "\r\nId: " + current.Id + "\r\nSession Id: " + current.SessionId;
        }

        private void RunAsPythonProgram_Click(object sender, EventArgs e)
        {
            current = Process.Start("python.exe", filename);
            ProcessInfo.Text += "Process Booted to Command Prompt\r\n\r\nProc Name: " + current.ProcessName + "\r\nId: " + current.Id + "\r\nSession Id: " + current.SessionId;
        }
    }
}
