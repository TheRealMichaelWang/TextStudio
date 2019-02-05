using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace TextStudio
{
    class SpeechWizard
    {
        SpeechSynthesizer SpeechSynthesizer;
        SpeechRecognitionEngine SpeechRecognizer;
        Grammar dictationgrammar;

        public SpeechWizard()
        {
            SpeechSynthesizer = new SpeechSynthesizer();
            SpeechRecognizer = new SpeechRecognitionEngine();
            dictationgrammar = new DictationGrammar();
            SpeechSynthesizer.Volume = 100;
            SpeechRecognizer.LoadGrammar(dictationgrammar);
            SpeechRecognizer.SetInputToDefaultAudioDevice();
        }
        public void ReadOutLoud(RichTextBox Editor)
        {
            string toread = Editor.SelectedText;
            if(string.IsNullOrEmpty(toread))
            {
                toread = Editor.Text;
            }
            try
            {
                SpeechSynthesizer.Speak(toread);
                MessageBox.Show("Done", "TextStudio Reader", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Please plug in an audio device or speaker","TextStudio Reader",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void GetTextFromSpeech(RichTextBox Editor)
        {
            try
            {
                RecognitionResult result = SpeechRecognizer.Recognize();
                Editor.AppendText(result.Text);
            }
            catch
            {
                MessageBox.Show("Couldn't recognize audio input.", "TextStudio Reader", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
