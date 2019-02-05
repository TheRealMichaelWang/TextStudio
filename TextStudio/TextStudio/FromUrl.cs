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
    public partial class FromUrl : Form
    {
        public byte[] Return = null;
        WebClient client;
        public FromUrl()
        {
            InitializeComponent();
            client = new WebClient();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Download_Click(object sender, EventArgs e)
        {
            try
            {
                Return = client.DownloadData(URLInput.Text);
                MessageBox.Show("Download Complete", "TextStudio Object Handeler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Enter in a valid uri or check your connection. Err Msg: "+ex.Message, "TextStudio Object Handeler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
