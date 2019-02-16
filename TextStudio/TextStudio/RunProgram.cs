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
        RichTextBox editor;

        public RunProgram(RichTextBox editor)
        {
            InitializeComponent();
            this.editor = editor;
        }

        private void Run_Click(object sender, EventArgs e)
        {

        }
    }
}
