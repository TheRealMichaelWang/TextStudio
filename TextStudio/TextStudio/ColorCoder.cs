using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextStudio
{
    enum ColorCodedEssayPart
    {
        Thesis,
        TopicSentence,
        SupportingEvidence,
        Commentary,
        ThesisRestatement,
        ClosingSentence,
        Clincher
    }
    class ColorCoder
    {
        public ColorCoder()
        {

        }

        public void ColorCode(RichTextBox Editor, ColorCodedEssayPart part)
        {
            if(!string.IsNullOrEmpty(Editor.SelectedText))
            {
                if(part == ColorCodedEssayPart.Thesis)
                {
                    Editor.SelectionColor = Color.Black;
                    Editor.SelectionFont = new Font(Editor.SelectionFont.FontFamily, Editor.SelectionFont.Size, FontStyle.Underline);
                }
                if(part == ColorCodedEssayPart.TopicSentence)
                {
                    Editor.SelectionColor = Color.Black;
                }
                if(part == ColorCodedEssayPart.SupportingEvidence)
                {
                    Editor.SelectionColor = Color.DarkRed;
                }
                if(part == ColorCodedEssayPart.Commentary)
                {
                    Editor.SelectionColor = Color.DarkGreen;
                }
                if(part == ColorCodedEssayPart.ClosingSentence)
                {
                    Editor.SelectionColor = Color.Black;
                }
                if(part == ColorCodedEssayPart.ThesisRestatement)
                {
                    Editor.SelectionColor = Color.Black;
                    Editor.SelectionFont = new Font(Editor.SelectionFont.FontFamily, Editor.SelectionFont.Size, FontStyle.Underline);
                }
                if(part == ColorCodedEssayPart.Clincher)
                {
                    Editor.SelectionColor = Color.DarkGreen;
                }
            }
        }
    }
}
