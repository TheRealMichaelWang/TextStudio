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
    public partial class MergeLinePrompt : Form
    {
        public string returnvalue = "";

        public MergeLinePrompt(string original, string tomerge)
        {
            InitializeComponent();
            OriginalValueOutput.Text = original;
            ToMergeOutut.Text = tomerge;
            this.ShowDialog();
        }

        private void MergeLinePrompt_Load(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            returnvalue = NewValueInput.Text;
            this.Close();
        }

        private void ToMergeOutut_TextChanged(object sender, EventArgs e)
        {
            NewValueInput.Text = ToMergeOutut.Text;
        }

        private void OriginalValueOutput_TextChanged(object sender, EventArgs e)
        {
            NewValueInput.Text = OriginalValueOutput.Text;
        }
    }
}
