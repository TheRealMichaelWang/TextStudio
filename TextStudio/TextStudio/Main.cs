using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextStudio
{
    public partial class Main : Form
    {
        string filepath = "untitled document";
        bool fontready = false;
        FontStyle currentsyle;
        RichTextBoxPrintCtrl printCtrl;
        BibliographyWizard BibliographyWizard;
        HeaderWizard HeaderWizard;
        SpellChecker spellChecker;
        FindText finder;
        SpeechWizard speechWizard;

        public Main()
        {
            InitializeComponent();
            printCtrl = new RichTextBoxPrintCtrl();
            BibliographyWizard = new BibliographyWizard();
            HeaderWizard = new HeaderWizard();
            spellChecker = new SpellChecker();
            finder = new FindText(ref Editor);
            speechWizard = new SpeechWizard();
            this.WindowState = FormWindowState.Maximized;
            this.Text = "TextStudio -" + filepath;
            currentsyle = FontStyle.Regular;
            LoadFonts();
            LoadBibliographyOptions();
            LoadHeaderFormatOptions();
            spellChecker.Load();
        }

        public void LoadFonts()
        {
            FontFamilySelection.Items.Clear();
            FontSizeSelection.Items.Clear();
            foreach(FontFamily fontFamily in FontFamily.Families)
            {
                if (fontFamily.Name != "")
                {
                    FontFamilySelection.Items.Add(fontFamily.Name);
                }
            }
            for(int i = 0; i < 24; i++)
            {
                FontSizeSelection.Items.Add((float)(i+1));
            }
            for(int i = 26; i < 100; i = i + 2)
            {
                FontSizeSelection.Items.Add((float)(i));
            }
            FontFamilySelection.SelectedItem = "Times New Roman";
            FontSizeSelection.SelectedItem = (float)12;
            Editor.Font = new Font("Times New Roman", 12,currentsyle);
            fontready = true;
        }

        public void LoadBibliographyOptions()
        {
            BibliographyFormatSelector.Items.Clear();
            BibliographyFormatSelector.Items.Add("apa");
            BibliographyFormatSelector.Items.Add("mla");
            BibliographyFormatSelector.Items.Add("standard");
            BibliographyFormatSelector.SelectedItem = "apa";
        }

        public void LoadHeaderFormatOptions()
        {
            HeaderFormatInput.Items.Clear();
            HeaderFormatInput.Items.Add("standard");
            HeaderFormatInput.Items.Add("mla");
            HeaderFormatInput.SelectedItem = "standard";
            NameInput.Text = Environment.UserName;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            Editor.Width = this.Width-20;
            Editor.Height = this.Height - 120;
            AllTabs.Width = this.Width;
        }

        private void UpdateFont(object sender, EventArgs e)
        {
            if(!fontready)
            {
                return;
            }
            try
            {
                Editor.SelectionFont = new Font((string)FontFamilySelection.SelectedItem, (float)FontSizeSelection.SelectedItem, currentsyle);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Enter in a valid font","TextStudio Font Wizard",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BoldButton_Click(object sender, EventArgs e)
        {
            currentsyle = FontStyle.Bold;
            UpdateFont(null, null);
        }

        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            currentsyle = FontStyle.Underline;
            UpdateFont(null, null);
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            currentsyle = FontStyle.Italic;
            UpdateFont(null, null);
        }

        private void RegularButton_Click(object sender, EventArgs e)
        {
            currentsyle = FontStyle.Regular;
            UpdateFont(null, null);
        }

        private void Editor_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                fontready = false;
                FontFamilySelection.SelectedItem = Editor.SelectionFont.FontFamily.Name;
                FontSizeSelection.SelectedItem = Editor.SelectionFont.Size;
                fontready = true;
            }
            catch
            {

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(filepath == "untitled document")
            {
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = saveFileDialog.FileName;
                }
            }
            if (File.Exists(filepath))
            {
                Editor.SaveFile(filepath);
            }
            this.Text = "TextStudio -"+filepath;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Editor.LoadFile(filepath);
                    filepath = openFileDialog.FileName;
                }
                catch
                {
                    MessageBox.Show("Invalid Document Format. Must be of RICH TEXT FORMAT. The file may have been corrupted, or you selected a invalid file.", "Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Text = "TextStudio -" + filepath;
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if(printDialog.ShowDialog() == DialogResult.OK)
            {
                printCtrl.PrintDocument(printDialog.PrinterSettings, Editor,filepath);
            }
            this.Text = "TextStudio -" + filepath;
        }

        private void CiteAllButton_Click(object sender, EventArgs e)
        {
            Format format = Format.Apa;
            if((string)BibliographyFormatSelector.SelectedItem == "apa")
            {
                format = Format.Apa;
            }
            if((string)BibliographyFormatSelector.SelectedItem == "mla")
            {
                format = Format.Mla;
            }
            if((string)BibliographyFormatSelector.SelectedItem == "standard")
            {
                format = Format.Standard;
            }
            BibliographyWizard.Cite(Editor, format);
        }

        private void AddSourceButton_Click(object sender, EventArgs e)
        {
            SourceDesigner sourceDesigner = new SourceDesigner();
            sourceDesigner.ShowDialog();
            if(sourceDesigner.Result != null)
            {
                SourceViewer.Items.Add(sourceDesigner.Result.url);
                BibliographyWizard.sources.Add(sourceDesigner.Result);
            }
        }

        private void RemoveSourceButton_Click(object sender, EventArgs e)
        {
            try
            {
                SourceViewer.Items.RemoveAt(SourceViewer.SelectedIndex);
                BibliographyWizard.sources.RemoveAt(SourceViewer.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Invalid selection. Please sellect something", "TextStudio Bibliography Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CiteOneSoureButton_Click(object sender, EventArgs e)
        {
            try
            {
                Format format = Format.Apa;
                if ((string)BibliographyFormatSelector.SelectedItem == "apa")
                {
                    format = Format.Apa;
                }
                if ((string)BibliographyFormatSelector.SelectedItem == "mla")
                {
                    format = Format.Mla;
                }
                if ((string)BibliographyFormatSelector.SelectedItem == "standard")
                {
                    format = Format.Standard;
                }
                Source source = BibliographyWizard.sources[SourceViewer.SelectedIndex];
                Editor.AppendText(source.Cite(format));
            }
            catch
            {
                MessageBox.Show("Invalid selection. Please sellect something", "TextStudio Bibliography Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CenterButton_Click(object sender, EventArgs e)
        {
            Editor.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            Editor.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            Editor.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void InsertHeadingButton_Click(object sender, EventArgs e)
        {
            try
            {
                Format format = Format.Standard;
                if((string)HeaderFormatInput.SelectedItem == "mla")
                {
                    format = Format.Mla;
                }
                HeaderWizard.name = NameInput.Text;
                HeaderWizard.period = int.Parse(PeriodInput.Text);
                HeaderWizard.classname = ClassNameInput.Text;
                Editor.Text = HeaderWizard.MakeHeader(format) + "\r\n\r\n"+Editor.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter a number for your period", "TextStudio Header Wizard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertImageFromFileButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                    object temp = Clipboard.GetDataObject();
                    Clipboard.SetImage(bitmap);
                    Editor.Paste();
                    Clipboard.SetDataObject(temp);
                }
                catch
                {
                    MessageBox.Show("Choose a valid file", "TextStudio Image Insertter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InsertImageFromUri_Click(object sender, EventArgs e)
        {
            FromUrl fromUrl = new FromUrl();
            fromUrl.ShowDialog();
            if(fromUrl.Return != null)
            {
                try
                {
                    Bitmap bitmap;
                    using (var ms = new MemoryStream(fromUrl.Return))
                    {
                        bitmap = new Bitmap(ms);
                    }
                    object temp = Clipboard.GetDataObject();
                    Clipboard.SetImage(bitmap);
                    Editor.Paste();
                    Clipboard.SetDataObject(temp);
                }
                catch
                {
                    MessageBox.Show("Invalid format", "TextStudio Image Insertter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = Editor.SelectionColor;
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                Editor.SelectionColor = colorDialog.Color;
            }
        }

        private void FetchFromURIButton_Click(object sender, EventArgs e)
        {
            FromUrl fromUrl = new FromUrl();
            fromUrl.ShowDialog();
            if(fromUrl.Return != null)
            {
                string toappend = System.Text.Encoding.UTF8.GetString(fromUrl.Return);
                Editor.AppendText("\r\n" + toappend);
            }
        }

        private void SpellCheckButton_Click(object sender, EventArgs e)
        {
            spellChecker.PerformSpellcheck(Editor);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            finder = new FindText(ref Editor);
            finder.Show();
        }

        private void ZoomFactor_Scroll(object sender, EventArgs e)
        {
            Editor.ZoomFactor = ZoomFactor.Value;
        }

        private void ReadOutLoudButton_Click(object sender, EventArgs e)
        {
            speechWizard.ReadOutLoud(Editor);
        }

        private void InsertSpeechButton_Click(object sender, EventArgs e)
        {
            speechWizard.GetTextFromSpeech(Editor);
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control)
            {
                if(e.KeyCode == Keys.F)
                {
                    FindButton_Click(null, null);
                }
                if(e.KeyCode == Keys.S)
                {
                    SaveButton_Click(null, null);
                }
                if(e.KeyCode == Keys.O)
                {
                    OpenButton_Click(null, null);
                }
            }
            else if(e.Alt)
            {
                if(e.KeyCode == Keys.H)
                {
                    AllTabs.SelectedIndex = 0;
                }
                if(e.KeyCode == Keys.T)
                {
                    AllTabs.SelectedIndex = 1;
                }
            }
        }

        private void AddToDictionary_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Editor.SelectedText) && !Editor.Text.Contains(" "))
            {
                spellChecker.words.Add(Editor.SelectedText);
            }
            else
            {
                MessageBox.Show("Select a word. Words cannot include spaces.","TextEditor SpellChecker",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ToHTMLDocButton_Click(object sender, EventArgs e)
        {
            HTMLConverter converter = new HTMLConverter();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, converter.ToHtmlDocument(filepath,Editor));
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory + "\\Updater.exe");
        }
    }
}
