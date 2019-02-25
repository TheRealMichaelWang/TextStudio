using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Authentication;
using System.Text;
using System.Windows.Forms;

namespace TextStudio
{
    class Rephraser
    {
        public List<string> words;

        public Rephraser()
        {
            words = File.ReadAllLines(Environment.CurrentDirectory + "\\english.dic").ToList();
        }

        public static string GetSynonyms(string word)
        {
            foreach(string line in File.ReadLines(Environment.CurrentDirectory+"\\synonyms.dic"))
            {
                string[] datargs = line.Split(',');
                if(datargs[0] == word)
                {
                    return datargs[1];
                }
            }
            return word;
        }

        public void Rephrase(ref RichTextBox editor)
        {
            List<string> wordsintext = new List<string>();
            string temp = "";
            for (int i = 0; i < editor.Text.Length; i++)
            {
                if (editor.Text[i] == ' ' || editor.Text[i] == '.' || editor.Text[i] == ',' || editor.Text[i] == '?'||editor.Text[i]=='!')
                {
                    wordsintext.Add(temp);
                    wordsintext.Add(editor.Text[i].ToString());
                    temp = "";
                }
                else
                {
                    temp += editor.Text[i];
                }
            }
            for (int i = 0; i < wordsintext.Count; i++)
            {
                try
                {
                    if (wordsintext[i] == " " || wordsintext[i] == "." || wordsintext[i] == "," || wordsintext[i] == "?" || wordsintext[i] == "!")
                    {

                    }
                    else
                    {
                        wordsintext[i] = GetSynonyms(wordsintext[i]);
                    }
                }
                catch(IndexOutOfRangeException)
                {

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Err Msg: " + ex.Message,"TextStudio Rephraser",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            temp = "";
            for (int i = 0; i < wordsintext.Count; i++)
            {
                temp = temp + wordsintext[i];
            }
            editor.Text = temp;
        }
    }
}
