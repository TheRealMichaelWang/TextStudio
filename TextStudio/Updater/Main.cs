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
using System.Threading;
using System.Windows.Forms;

namespace Updater
{
    public partial class Main : Form
    {
        WebClient webClient;
        UpdateInfo updateInfo;
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
            string info = "The download has failed.";
            try
            {
                byte[] appdata = webClient.DownloadData("https://raw.githubusercontent.com/TheRealMichaelWang/TextStudio/files/TextStudio.exe");
                byte[] dicdata = webClient.DownloadData("https://raw.githubusercontent.com/TheRealMichaelWang/TextStudio/files/english.dic");
                byte[] syndata = webClient.DownloadData("https://raw.githubusercontent.com/TheRealMichaelWang/TextStudio/files/synonyms.dic");
                info = webClient.DownloadString("https://raw.githubusercontent.com/TheRealMichaelWang/TextStudio/master/notes.txt");
                File.WriteAllBytes(Environment.CurrentDirectory + "\\TextStudio.exe",appdata);
                File.WriteAllBytes(Environment.CurrentDirectory + "\\english.dic", dicdata);
                File.WriteAllBytes(Environment.CurrentDirectory + "\\synonyms.dic", syndata);
                MessageBox.Show("Update Fnished", "TextStudio Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(Environment.CurrentDirectory + "\\TextStudio.exe");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"TextStudio Updater",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Thread.Sleep(1000);
            updateInfo = new UpdateInfo(info);
            this.Close();
        }
    }
}
