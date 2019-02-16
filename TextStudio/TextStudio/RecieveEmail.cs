using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using OpenPop;
using OpenPop.Pop3;

namespace TextStudio
{
    public partial class RecieveEmail : Form
    {
        RichTextBox editor = null;
        string[] content = null;

        public RecieveEmail(ref RichTextBox editor)
        {
            InitializeComponent();
            this.editor = editor;
            this.ShowDialog();
        }

        public RecieveEmail(ref string[] content)
        {
            InitializeComponent();
            this.content = content;
            this.InsertWithFormatingButton.Hide();
            this.InsertTextButton.Text = "OK";
            this.ShowDialog();
        }

        public MailMessage GetMessage()
        {
            try
            {
                var client = new Pop3Client();
                client.Connect(HostInput.Text, int.Parse(PortInput.Text), UseSSLSecurityCheckBox.Checked);
                client.Authenticate(EmailInput.Text, PasswordInput.Text);
                var count = client.GetMessageCount();
                for(int i = count; i > 0; i++)
                {
                    OpenPop.Mime.Message message = client.GetMessage(i+1);
                    MailMessage toproc = message.ToMailMessage();
                    if(toproc.Subject == SubjectInput.Text)
                    {
                        return toproc;
                    }
                }
                return null;
            }
            catch(Exception e)
            {
                MessageBox.Show("An error occured. Err Msg: " + e.Message, "TextStudio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void InsertTextButton_Click(object sender, EventArgs e)
        {
            MailMessage msg = GetMessage();
            if (msg == null)
            {
                MessageBox.Show("We couldn't find that message", "TextStudio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                editor.Text = msg.Body;
                this.Close();
            }
        }

        private void InsertWithFormatingButton_Click(object sender, EventArgs e)
        {
            MailMessage msg = GetMessage();
            if (msg == null)
            {
                MessageBox.Show("We couldn't find that message", "TextStudio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                editor.LoadFile(msg.Attachments[0].ContentStream, RichTextBoxStreamType.RichText);
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
