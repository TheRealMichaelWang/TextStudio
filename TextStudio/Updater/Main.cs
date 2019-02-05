using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Updater
{
    public partial class Main : Form
    {
        WebClient webClient;
        public Main()
        {
            InitializeComponent();
            this.Load += Main_Shown;
            webClient = new WebClient();
        }
        private void Main_Shown(object sender, EventArgs e)
        {
            foreach(Process proc in Process.GetProcessesByName("TextStudio"))
            {
                proc.Kill();
            }
            try
            {
                byte[] appdata = webClient.DownloadData("https://raw.githubusercontent.com/TheRealMichaelWang/TextStudio/files/TextStudio.exe");
                byte[] dicdata = webClient.DownloadData("https://raw.githubusercontent.com/TheRealMichaelWang/TextStudio/files/english.dic");
                File.WriteAllBytes(Environment.CurrentDirectory + "\\TextStudio.exe",appdata);
                File.WriteAllBytes(Environment.CurrentDirectory + "\\english.dic", dicdata);
                MessageBox.Show("Update Fnished", "TextStudio Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(Environment.CurrentDirectory + "\\TextStudio.exe");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"TextStudio Updater",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
