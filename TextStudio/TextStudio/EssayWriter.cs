using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace TextStudio
{
    public partial class EssayWriter : Form
    {
        public string rtf;

        public EssayWriter()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DownloadDocumentButton_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            try
            {
                rtf = client.DownloadString("https://raw.githubusercontent.com/TheRealMichaelWang/TextStudio/files/Essays/"+Input.Text.ToLower()+".rtf");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Sorry, we can't find that essay.","Essay Writer",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
