using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace TextStudio
{
    class SpellChecker
    {
        public List<string> words = new List<string>();

        public SpellChecker()
        {
            
        }

        public void Load()
        {
            words = File.ReadAllLines(Environment.CurrentDirectory + "\\english.dic").ToList();
        }

        public bool CheckWord(string word)
        {
            word = word.Replace(" ", "");
            word = word.Replace(".", "");
            word = word.Replace(",", "");
            word = word.Replace("!", "");
            word = word.Replace("?", "");
            word = word.ToLower();
            return words.Contains(word);
        }

        public void PerformSpellcheck(RichTextBox Editor)
        {
            string[] allwords = Editor.Text.Split(' ');
            int index = 0;

            foreach (string word in allwords)
            {
                if(!CheckWord(word))
                {
                    Editor.Select(index, word.Length);
                    Editor.SelectionBackColor = Color.Red;
                }
                index = index + word.Length + 1;
            }
            if(MessageBox.Show("Spelling Check complete. Would you like to clear spelling highlighting?", "TextStudio Spell Checker",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Editor.SelectAll();
                Editor.SelectionBackColor = Color.White;
            }
        }
    }
}
