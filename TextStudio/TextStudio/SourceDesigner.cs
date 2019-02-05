using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextStudio
{
    public partial class SourceDesigner : Form
    {
        public Source Result = null;
        public SourceDesigner()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Result = new Source(TitleInput.Text, AuthorInput.Text, UrlInput.Text, DatePublishedInput.Text, PublisherInput.Text);
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
