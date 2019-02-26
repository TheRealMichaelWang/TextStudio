using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextStudio
{
    class Merger
    {
        public Merger()
        {

        }

        public void MergeText(ref RichTextBox richTextBox,string[] tomerge)
        {
            if(MessageBox.Show("Are you sure you wan't to continue merging these 2 files?","TextStudio Text Merger",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            string[] lines = richTextBox.Lines;
            List<string> toret = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == tomerge[i])
                {
                    toret.Add(lines[i]);
                }
                else
                {
                    MergeLinePrompt mergeLinePrompt = new MergeLinePrompt(lines[i], tomerge[i]);
                    toret.Add(mergeLinePrompt.returnvalue);
                }
            }
            richTextBox.Lines = toret.ToArray();
        }
    }
}
