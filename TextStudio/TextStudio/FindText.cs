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
    public partial class FindText : Form
    {
        public RichTextBox editor;
        public int index = 0;

        public FindText(ref RichTextBox Editor)
        {
            InitializeComponent();
            this.editor = Editor;
        }

        private void FindAll_Click(object sender, EventArgs e)
        {
            editor.SelectionBackColor = Color.White;

            try
            {
                index = editor.Find(ToFindInput.Text, index, RichTextBoxFinds.MatchCase);
            }
            catch
            {
                MessageBox.Show("Text not found or end of text was reached. Press ResetRind to reset.", "TextStudio Finder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (index == -1)
            {
                MessageBox.Show("Text not found or end of text was reached. Press ResetRind to reset.","TextStudio Finder",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                editor.Select(index, ToFindInput.Text.Length);
                editor.SelectionBackColor = Color.Yellow;
                editor.ScrollToCaret();
                index = index + ToFindInput.Text.Length;
            }
        }

        private void ResetFind_Click(object sender, EventArgs e)
        {
            index = 0;
            editor.SelectAll();
            editor.SelectionBackColor = Color.White;
        }
    }
}
