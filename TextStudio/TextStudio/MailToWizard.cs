using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace TextStudio
{
    public partial class MailToWizard : Form
    {
        RichTextBox editor;
        string filepath;
        public MailToWizard(string filepath,RichTextBox editor)
        {
            InitializeComponent();
            this.filepath = filepath;
            this.editor = editor;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage(EmailInput.Text, ToInput.Text);
                SmtpClient client = new SmtpClient();
                client.Port = int.Parse(PortInput.Text);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = UseSSLSecurityCheckBox.Checked;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(EmailInput.Text, PasswordInput.Text);
                client.Host = HostInput.Text;
                client.Timeout = 10000;
                mail.Subject = SubjectInput.Text;
                if(SendTextInBody.Checked)
                {
                    mail.Body = editor.Text;
                }
                else
                {
                    mail.Body = "This document has been shared to you.";
                }
                mail.Attachments.Add(new Attachment(filepath));
                client.Send(mail);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Message: "+ex.Message,"TextStudio MailToWizard",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
