namespace TextStudio
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Editor = new System.Windows.Forms.RichTextBox();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.SpeechGroupBox = new System.Windows.Forms.GroupBox();
            this.InsertSpeechButton = new System.Windows.Forms.Button();
            this.ReadOutLoudButton = new System.Windows.Forms.Button();
            this.ZoomGroupBox = new System.Windows.Forms.GroupBox();
            this.ZoomFactor = new System.Windows.Forms.TrackBar();
            this.OtherToolsTab = new System.Windows.Forms.GroupBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.SpellCheckButton = new System.Windows.Forms.Button();
            this.ImageTab = new System.Windows.Forms.GroupBox();
            this.InsertImageFromUri = new System.Windows.Forms.Button();
            this.InsertImageFromFileButton = new System.Windows.Forms.Button();
            this.FileGroupBox = new System.Windows.Forms.GroupBox();
            this.FetchFromURIButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FontGroupBox = new System.Windows.Forms.GroupBox();
            this.ChangeColor = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.CenterButton = new System.Windows.Forms.Button();
            this.BoldButton = new System.Windows.Forms.Button();
            this.FontSizeSelection = new System.Windows.Forms.ComboBox();
            this.RegularButton = new System.Windows.Forms.Button();
            this.FontFamilySelection = new System.Windows.Forms.ComboBox();
            this.ItalicButton = new System.Windows.Forms.Button();
            this.UnderlineButton = new System.Windows.Forms.Button();
            this.AllTabs = new System.Windows.Forms.TabControl();
            this.TextProcessingTab = new System.Windows.Forms.TabPage();
            this.HeaderGroupBox = new System.Windows.Forms.GroupBox();
            this.HeaderFormatLabel = new System.Windows.Forms.Label();
            this.HeaderFormatInput = new System.Windows.Forms.ComboBox();
            this.PeriodLabel = new System.Windows.Forms.Label();
            this.ClassNameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ClassNameInput = new System.Windows.Forms.TextBox();
            this.PeriodInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.InsertHeadingButton = new System.Windows.Forms.Button();
            this.BibliographyGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CiteOneSoureButton = new System.Windows.Forms.Button();
            this.RemoveSourceButton = new System.Windows.Forms.Button();
            this.AddSourceButton = new System.Windows.Forms.Button();
            this.CiteAllButton = new System.Windows.Forms.Button();
            this.BibliographyFormatSelector = new System.Windows.Forms.ComboBox();
            this.SourceViewer = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.AddToDictionary = new System.Windows.Forms.Button();
            this.ToHTMLDocButton = new System.Windows.Forms.Button();
            this.HomeTab.SuspendLayout();
            this.SpeechGroupBox.SuspendLayout();
            this.ZoomGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomFactor)).BeginInit();
            this.OtherToolsTab.SuspendLayout();
            this.ImageTab.SuspendLayout();
            this.FileGroupBox.SuspendLayout();
            this.FontGroupBox.SuspendLayout();
            this.AllTabs.SuspendLayout();
            this.TextProcessingTab.SuspendLayout();
            this.HeaderGroupBox.SuspendLayout();
            this.BibliographyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Editor
            // 
            this.Editor.Location = new System.Drawing.Point(0, 120);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(1661, 614);
            this.Editor.TabIndex = 0;
            this.Editor.Text = "";
            this.Editor.SelectionChanged += new System.EventHandler(this.Editor_SelectionChanged);
            this.Editor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.SpeechGroupBox);
            this.HomeTab.Controls.Add(this.ZoomGroupBox);
            this.HomeTab.Controls.Add(this.OtherToolsTab);
            this.HomeTab.Controls.Add(this.ImageTab);
            this.HomeTab.Controls.Add(this.FileGroupBox);
            this.HomeTab.Controls.Add(this.FontGroupBox);
            this.HomeTab.Location = new System.Drawing.Point(4, 29);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(1653, 80);
            this.HomeTab.TabIndex = 1;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // SpeechGroupBox
            // 
            this.SpeechGroupBox.Controls.Add(this.InsertSpeechButton);
            this.SpeechGroupBox.Controls.Add(this.ReadOutLoudButton);
            this.SpeechGroupBox.Location = new System.Drawing.Point(1127, 3);
            this.SpeechGroupBox.Name = "SpeechGroupBox";
            this.SpeechGroupBox.Size = new System.Drawing.Size(168, 71);
            this.SpeechGroupBox.TabIndex = 11;
            this.SpeechGroupBox.TabStop = false;
            this.SpeechGroupBox.Text = "Speech";
            // 
            // InsertSpeechButton
            // 
            this.InsertSpeechButton.Location = new System.Drawing.Point(6, 42);
            this.InsertSpeechButton.Name = "InsertSpeechButton";
            this.InsertSpeechButton.Size = new System.Drawing.Size(156, 23);
            this.InsertSpeechButton.TabIndex = 1;
            this.InsertSpeechButton.Text = "InsertSpeech";
            this.InsertSpeechButton.UseVisualStyleBackColor = true;
            this.InsertSpeechButton.Click += new System.EventHandler(this.InsertSpeechButton_Click);
            // 
            // ReadOutLoudButton
            // 
            this.ReadOutLoudButton.Location = new System.Drawing.Point(6, 13);
            this.ReadOutLoudButton.Name = "ReadOutLoudButton";
            this.ReadOutLoudButton.Size = new System.Drawing.Size(156, 23);
            this.ReadOutLoudButton.TabIndex = 0;
            this.ReadOutLoudButton.Text = "ReadOutLoud";
            this.ReadOutLoudButton.UseVisualStyleBackColor = true;
            this.ReadOutLoudButton.Click += new System.EventHandler(this.ReadOutLoudButton_Click);
            // 
            // ZoomGroupBox
            // 
            this.ZoomGroupBox.Controls.Add(this.ZoomFactor);
            this.ZoomGroupBox.Location = new System.Drawing.Point(1442, 3);
            this.ZoomGroupBox.Name = "ZoomGroupBox";
            this.ZoomGroupBox.Size = new System.Drawing.Size(168, 71);
            this.ZoomGroupBox.TabIndex = 10;
            this.ZoomGroupBox.TabStop = false;
            this.ZoomGroupBox.Text = "Zoom";
            // 
            // ZoomFactor
            // 
            this.ZoomFactor.Location = new System.Drawing.Point(7, 19);
            this.ZoomFactor.Minimum = 1;
            this.ZoomFactor.Name = "ZoomFactor";
            this.ZoomFactor.Size = new System.Drawing.Size(155, 45);
            this.ZoomFactor.TabIndex = 0;
            this.ZoomFactor.Value = 1;
            this.ZoomFactor.Scroll += new System.EventHandler(this.ZoomFactor_Scroll);
            // 
            // OtherToolsTab
            // 
            this.OtherToolsTab.Controls.Add(this.AddToDictionary);
            this.OtherToolsTab.Controls.Add(this.FindButton);
            this.OtherToolsTab.Controls.Add(this.SpellCheckButton);
            this.OtherToolsTab.Location = new System.Drawing.Point(953, 3);
            this.OtherToolsTab.Name = "OtherToolsTab";
            this.OtherToolsTab.Size = new System.Drawing.Size(168, 71);
            this.OtherToolsTab.TabIndex = 9;
            this.OtherToolsTab.TabStop = false;
            this.OtherToolsTab.Text = "OtherTools";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(87, 13);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 1;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // SpellCheckButton
            // 
            this.SpellCheckButton.Location = new System.Drawing.Point(6, 13);
            this.SpellCheckButton.Name = "SpellCheckButton";
            this.SpellCheckButton.Size = new System.Drawing.Size(75, 23);
            this.SpellCheckButton.TabIndex = 0;
            this.SpellCheckButton.Text = "SpellCheck";
            this.SpellCheckButton.UseVisualStyleBackColor = true;
            this.SpellCheckButton.Click += new System.EventHandler(this.SpellCheckButton_Click);
            // 
            // ImageTab
            // 
            this.ImageTab.Controls.Add(this.InsertImageFromUri);
            this.ImageTab.Controls.Add(this.InsertImageFromFileButton);
            this.ImageTab.Location = new System.Drawing.Point(779, 3);
            this.ImageTab.Name = "ImageTab";
            this.ImageTab.Size = new System.Drawing.Size(168, 71);
            this.ImageTab.TabIndex = 8;
            this.ImageTab.TabStop = false;
            this.ImageTab.Text = "Insert Image";
            // 
            // InsertImageFromUri
            // 
            this.InsertImageFromUri.Location = new System.Drawing.Point(88, 20);
            this.InsertImageFromUri.Name = "InsertImageFromUri";
            this.InsertImageFromUri.Size = new System.Drawing.Size(75, 23);
            this.InsertImageFromUri.TabIndex = 1;
            this.InsertImageFromUri.Text = "FromURL";
            this.InsertImageFromUri.UseVisualStyleBackColor = true;
            this.InsertImageFromUri.Click += new System.EventHandler(this.InsertImageFromUri_Click);
            // 
            // InsertImageFromFileButton
            // 
            this.InsertImageFromFileButton.Location = new System.Drawing.Point(7, 20);
            this.InsertImageFromFileButton.Name = "InsertImageFromFileButton";
            this.InsertImageFromFileButton.Size = new System.Drawing.Size(75, 23);
            this.InsertImageFromFileButton.TabIndex = 0;
            this.InsertImageFromFileButton.Text = "FromFile";
            this.InsertImageFromFileButton.UseVisualStyleBackColor = true;
            this.InsertImageFromFileButton.Click += new System.EventHandler(this.InsertImageFromFileButton_Click);
            // 
            // FileGroupBox
            // 
            this.FileGroupBox.Controls.Add(this.ToHTMLDocButton);
            this.FileGroupBox.Controls.Add(this.FetchFromURIButton);
            this.FileGroupBox.Controls.Add(this.PrintButton);
            this.FileGroupBox.Controls.Add(this.OpenButton);
            this.FileGroupBox.Controls.Add(this.SaveButton);
            this.FileGroupBox.Location = new System.Drawing.Point(523, 3);
            this.FileGroupBox.Name = "FileGroupBox";
            this.FileGroupBox.Size = new System.Drawing.Size(250, 71);
            this.FileGroupBox.TabIndex = 7;
            this.FileGroupBox.TabStop = false;
            this.FileGroupBox.Text = "File";
            // 
            // FetchFromURIButton
            // 
            this.FetchFromURIButton.Location = new System.Drawing.Point(7, 46);
            this.FetchFromURIButton.Name = "FetchFromURIButton";
            this.FetchFromURIButton.Size = new System.Drawing.Size(92, 23);
            this.FetchFromURIButton.TabIndex = 3;
            this.FetchFromURIButton.Text = "FetchFromURL";
            this.FetchFromURIButton.UseVisualStyleBackColor = true;
            this.FetchFromURIButton.Click += new System.EventHandler(this.FetchFromURIButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(169, 20);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 2;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(88, 20);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(7, 20);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FontGroupBox
            // 
            this.FontGroupBox.Controls.Add(this.ChangeColor);
            this.FontGroupBox.Controls.Add(this.RightButton);
            this.FontGroupBox.Controls.Add(this.LeftButton);
            this.FontGroupBox.Controls.Add(this.CenterButton);
            this.FontGroupBox.Controls.Add(this.BoldButton);
            this.FontGroupBox.Controls.Add(this.FontSizeSelection);
            this.FontGroupBox.Controls.Add(this.RegularButton);
            this.FontGroupBox.Controls.Add(this.FontFamilySelection);
            this.FontGroupBox.Controls.Add(this.ItalicButton);
            this.FontGroupBox.Controls.Add(this.UnderlineButton);
            this.FontGroupBox.Location = new System.Drawing.Point(6, 3);
            this.FontGroupBox.Name = "FontGroupBox";
            this.FontGroupBox.Size = new System.Drawing.Size(511, 71);
            this.FontGroupBox.TabIndex = 6;
            this.FontGroupBox.TabStop = false;
            this.FontGroupBox.Text = "Font";
            // 
            // ChangeColor
            // 
            this.ChangeColor.Location = new System.Drawing.Point(348, 17);
            this.ChangeColor.Name = "ChangeColor";
            this.ChangeColor.Size = new System.Drawing.Size(77, 23);
            this.ChangeColor.TabIndex = 9;
            this.ChangeColor.Text = "ChangeColor";
            this.ChangeColor.UseVisualStyleBackColor = true;
            this.ChangeColor.Click += new System.EventHandler(this.ChangeColor_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(431, 17);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(75, 23);
            this.RightButton.TabIndex = 8;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(431, 46);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(75, 23);
            this.LeftButton.TabIndex = 7;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // CenterButton
            // 
            this.CenterButton.Location = new System.Drawing.Point(348, 46);
            this.CenterButton.Name = "CenterButton";
            this.CenterButton.Size = new System.Drawing.Size(75, 23);
            this.CenterButton.TabIndex = 6;
            this.CenterButton.Text = "Center";
            this.CenterButton.UseVisualStyleBackColor = true;
            this.CenterButton.Click += new System.EventHandler(this.CenterButton_Click);
            // 
            // BoldButton
            // 
            this.BoldButton.Location = new System.Drawing.Point(2, 46);
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(75, 23);
            this.BoldButton.TabIndex = 2;
            this.BoldButton.Text = "Bold";
            this.BoldButton.UseVisualStyleBackColor = true;
            this.BoldButton.Click += new System.EventHandler(this.BoldButton_Click);
            // 
            // FontSizeSelection
            // 
            this.FontSizeSelection.FormattingEnabled = true;
            this.FontSizeSelection.Location = new System.Drawing.Point(232, 19);
            this.FontSizeSelection.Name = "FontSizeSelection";
            this.FontSizeSelection.Size = new System.Drawing.Size(96, 21);
            this.FontSizeSelection.TabIndex = 1;
            this.FontSizeSelection.SelectedIndexChanged += new System.EventHandler(this.UpdateFont);
            this.FontSizeSelection.SelectionChangeCommitted += new System.EventHandler(this.UpdateFont);
            this.FontSizeSelection.SelectedValueChanged += new System.EventHandler(this.UpdateFont);
            // 
            // RegularButton
            // 
            this.RegularButton.Location = new System.Drawing.Point(245, 46);
            this.RegularButton.Name = "RegularButton";
            this.RegularButton.Size = new System.Drawing.Size(75, 23);
            this.RegularButton.TabIndex = 5;
            this.RegularButton.Text = "Regular";
            this.RegularButton.UseVisualStyleBackColor = true;
            this.RegularButton.Click += new System.EventHandler(this.RegularButton_Click);
            // 
            // FontFamilySelection
            // 
            this.FontFamilySelection.DropDownHeight = 350;
            this.FontFamilySelection.DropDownWidth = 274;
            this.FontFamilySelection.FormattingEnabled = true;
            this.FontFamilySelection.IntegralHeight = false;
            this.FontFamilySelection.Location = new System.Drawing.Point(2, 19);
            this.FontFamilySelection.Name = "FontFamilySelection";
            this.FontFamilySelection.Size = new System.Drawing.Size(224, 21);
            this.FontFamilySelection.TabIndex = 0;
            this.FontFamilySelection.SelectedValueChanged += new System.EventHandler(this.UpdateFont);
            // 
            // ItalicButton
            // 
            this.ItalicButton.Location = new System.Drawing.Point(164, 46);
            this.ItalicButton.Name = "ItalicButton";
            this.ItalicButton.Size = new System.Drawing.Size(75, 23);
            this.ItalicButton.TabIndex = 4;
            this.ItalicButton.Text = "Italic";
            this.ItalicButton.UseVisualStyleBackColor = true;
            this.ItalicButton.Click += new System.EventHandler(this.ItalicButton_Click);
            // 
            // UnderlineButton
            // 
            this.UnderlineButton.Location = new System.Drawing.Point(83, 46);
            this.UnderlineButton.Name = "UnderlineButton";
            this.UnderlineButton.Size = new System.Drawing.Size(75, 23);
            this.UnderlineButton.TabIndex = 3;
            this.UnderlineButton.Text = "Underline";
            this.UnderlineButton.UseVisualStyleBackColor = true;
            this.UnderlineButton.Click += new System.EventHandler(this.UnderlineButton_Click);
            // 
            // AllTabs
            // 
            this.AllTabs.Controls.Add(this.HomeTab);
            this.AllTabs.Controls.Add(this.TextProcessingTab);
            this.AllTabs.ItemSize = new System.Drawing.Size(50, 25);
            this.AllTabs.Location = new System.Drawing.Point(0, 1);
            this.AllTabs.Name = "AllTabs";
            this.AllTabs.SelectedIndex = 0;
            this.AllTabs.Size = new System.Drawing.Size(1661, 113);
            this.AllTabs.TabIndex = 1;
            this.AllTabs.Tag = "";
            this.AllTabs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // TextProcessingTab
            // 
            this.TextProcessingTab.Controls.Add(this.HeaderGroupBox);
            this.TextProcessingTab.Controls.Add(this.BibliographyGroupBox);
            this.TextProcessingTab.Location = new System.Drawing.Point(4, 29);
            this.TextProcessingTab.Name = "TextProcessingTab";
            this.TextProcessingTab.Padding = new System.Windows.Forms.Padding(3);
            this.TextProcessingTab.Size = new System.Drawing.Size(1653, 80);
            this.TextProcessingTab.TabIndex = 2;
            this.TextProcessingTab.Text = "TextProcessing";
            this.TextProcessingTab.UseVisualStyleBackColor = true;
            // 
            // HeaderGroupBox
            // 
            this.HeaderGroupBox.Controls.Add(this.HeaderFormatLabel);
            this.HeaderGroupBox.Controls.Add(this.HeaderFormatInput);
            this.HeaderGroupBox.Controls.Add(this.PeriodLabel);
            this.HeaderGroupBox.Controls.Add(this.ClassNameLabel);
            this.HeaderGroupBox.Controls.Add(this.NameLabel);
            this.HeaderGroupBox.Controls.Add(this.ClassNameInput);
            this.HeaderGroupBox.Controls.Add(this.PeriodInput);
            this.HeaderGroupBox.Controls.Add(this.NameInput);
            this.HeaderGroupBox.Controls.Add(this.InsertHeadingButton);
            this.HeaderGroupBox.Location = new System.Drawing.Point(724, 7);
            this.HeaderGroupBox.Name = "HeaderGroupBox";
            this.HeaderGroupBox.Size = new System.Drawing.Size(618, 67);
            this.HeaderGroupBox.TabIndex = 1;
            this.HeaderGroupBox.TabStop = false;
            this.HeaderGroupBox.Text = "Header";
            // 
            // HeaderFormatLabel
            // 
            this.HeaderFormatLabel.AutoSize = true;
            this.HeaderFormatLabel.Location = new System.Drawing.Point(500, 18);
            this.HeaderFormatLabel.Name = "HeaderFormatLabel";
            this.HeaderFormatLabel.Size = new System.Drawing.Size(42, 13);
            this.HeaderFormatLabel.TabIndex = 8;
            this.HeaderFormatLabel.Text = "Format:";
            // 
            // HeaderFormatInput
            // 
            this.HeaderFormatInput.FormattingEnabled = true;
            this.HeaderFormatInput.Location = new System.Drawing.Point(543, 14);
            this.HeaderFormatInput.Name = "HeaderFormatInput";
            this.HeaderFormatInput.Size = new System.Drawing.Size(69, 21);
            this.HeaderFormatInput.TabIndex = 7;
            // 
            // PeriodLabel
            // 
            this.PeriodLabel.AutoSize = true;
            this.PeriodLabel.Location = new System.Drawing.Point(379, 19);
            this.PeriodLabel.Name = "PeriodLabel";
            this.PeriodLabel.Size = new System.Drawing.Size(37, 13);
            this.PeriodLabel.TabIndex = 6;
            this.PeriodLabel.Text = "Period";
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.AutoSize = true;
            this.ClassNameLabel.Location = new System.Drawing.Point(109, 44);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(63, 13);
            this.ClassNameLabel.TabIndex = 5;
            this.ClassNameLabel.Text = "Class Name";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(126, 18);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            // 
            // ClassNameInput
            // 
            this.ClassNameInput.Location = new System.Drawing.Point(178, 41);
            this.ClassNameInput.Name = "ClassNameInput";
            this.ClassNameInput.Size = new System.Drawing.Size(316, 20);
            this.ClassNameInput.TabIndex = 3;
            // 
            // PeriodInput
            // 
            this.PeriodInput.Location = new System.Drawing.Point(420, 15);
            this.PeriodInput.Name = "PeriodInput";
            this.PeriodInput.Size = new System.Drawing.Size(74, 20);
            this.PeriodInput.TabIndex = 2;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(178, 15);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(193, 20);
            this.NameInput.TabIndex = 1;
            // 
            // InsertHeadingButton
            // 
            this.InsertHeadingButton.Location = new System.Drawing.Point(6, 19);
            this.InsertHeadingButton.Name = "InsertHeadingButton";
            this.InsertHeadingButton.Size = new System.Drawing.Size(95, 23);
            this.InsertHeadingButton.TabIndex = 0;
            this.InsertHeadingButton.Text = "InsertHeading";
            this.InsertHeadingButton.UseVisualStyleBackColor = true;
            this.InsertHeadingButton.Click += new System.EventHandler(this.InsertHeadingButton_Click);
            // 
            // BibliographyGroupBox
            // 
            this.BibliographyGroupBox.Controls.Add(this.label2);
            this.BibliographyGroupBox.Controls.Add(this.label1);
            this.BibliographyGroupBox.Controls.Add(this.CiteOneSoureButton);
            this.BibliographyGroupBox.Controls.Add(this.RemoveSourceButton);
            this.BibliographyGroupBox.Controls.Add(this.AddSourceButton);
            this.BibliographyGroupBox.Controls.Add(this.CiteAllButton);
            this.BibliographyGroupBox.Controls.Add(this.BibliographyFormatSelector);
            this.BibliographyGroupBox.Controls.Add(this.SourceViewer);
            this.BibliographyGroupBox.Location = new System.Drawing.Point(9, 7);
            this.BibliographyGroupBox.Name = "BibliographyGroupBox";
            this.BibliographyGroupBox.Size = new System.Drawing.Size(709, 67);
            this.BibliographyGroupBox.TabIndex = 0;
            this.BibliographyGroupBox.TabStop = false;
            this.BibliographyGroupBox.Text = "Bibliography";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sources:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Format:";
            // 
            // CiteOneSoureButton
            // 
            this.CiteOneSoureButton.Location = new System.Drawing.Point(627, 10);
            this.CiteOneSoureButton.Name = "CiteOneSoureButton";
            this.CiteOneSoureButton.Size = new System.Drawing.Size(75, 23);
            this.CiteOneSoureButton.TabIndex = 5;
            this.CiteOneSoureButton.Text = "Cite";
            this.CiteOneSoureButton.UseVisualStyleBackColor = true;
            this.CiteOneSoureButton.Click += new System.EventHandler(this.CiteOneSoureButton_Click);
            // 
            // RemoveSourceButton
            // 
            this.RemoveSourceButton.Location = new System.Drawing.Point(627, 38);
            this.RemoveSourceButton.Name = "RemoveSourceButton";
            this.RemoveSourceButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveSourceButton.TabIndex = 4;
            this.RemoveSourceButton.Text = "DelSource";
            this.RemoveSourceButton.UseVisualStyleBackColor = true;
            this.RemoveSourceButton.Click += new System.EventHandler(this.RemoveSourceButton_Click);
            // 
            // AddSourceButton
            // 
            this.AddSourceButton.Location = new System.Drawing.Point(546, 39);
            this.AddSourceButton.Name = "AddSourceButton";
            this.AddSourceButton.Size = new System.Drawing.Size(75, 23);
            this.AddSourceButton.TabIndex = 3;
            this.AddSourceButton.Text = "AddSource";
            this.AddSourceButton.UseVisualStyleBackColor = true;
            this.AddSourceButton.Click += new System.EventHandler(this.AddSourceButton_Click);
            // 
            // CiteAllButton
            // 
            this.CiteAllButton.Location = new System.Drawing.Point(546, 9);
            this.CiteAllButton.Name = "CiteAllButton";
            this.CiteAllButton.Size = new System.Drawing.Size(75, 23);
            this.CiteAllButton.TabIndex = 2;
            this.CiteAllButton.Text = "CiteAll";
            this.CiteAllButton.UseVisualStyleBackColor = true;
            this.CiteAllButton.Click += new System.EventHandler(this.CiteAllButton_Click);
            // 
            // BibliographyFormatSelector
            // 
            this.BibliographyFormatSelector.FormattingEnabled = true;
            this.BibliographyFormatSelector.Location = new System.Drawing.Point(454, 10);
            this.BibliographyFormatSelector.Name = "BibliographyFormatSelector";
            this.BibliographyFormatSelector.Size = new System.Drawing.Size(77, 21);
            this.BibliographyFormatSelector.TabIndex = 1;
            // 
            // SourceViewer
            // 
            this.SourceViewer.FormattingEnabled = true;
            this.SourceViewer.Location = new System.Drawing.Point(61, 10);
            this.SourceViewer.Name = "SourceViewer";
            this.SourceViewer.Size = new System.Drawing.Size(339, 21);
            this.SourceViewer.TabIndex = 0;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // AddToDictionary
            // 
            this.AddToDictionary.Location = new System.Drawing.Point(6, 42);
            this.AddToDictionary.Name = "AddToDictionary";
            this.AddToDictionary.Size = new System.Drawing.Size(75, 23);
            this.AddToDictionary.TabIndex = 2;
            this.AddToDictionary.Text = "AddWord";
            this.AddToDictionary.UseVisualStyleBackColor = true;
            this.AddToDictionary.Click += new System.EventHandler(this.AddToDictionary_Click);
            // 
            // ToHTMLDocButton
            // 
            this.ToHTMLDocButton.Location = new System.Drawing.Point(105, 46);
            this.ToHTMLDocButton.Name = "ToHTMLDocButton";
            this.ToHTMLDocButton.Size = new System.Drawing.Size(139, 23);
            this.ToHTMLDocButton.TabIndex = 4;
            this.ToHTMLDocButton.Text = "ToHTMLDocument";
            this.ToHTMLDocButton.UseVisualStyleBackColor = true;
            this.ToHTMLDocButton.Click += new System.EventHandler(this.ToHTMLDocButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 736);
            this.Controls.Add(this.AllTabs);
            this.Controls.Add(this.Editor);
            this.Name = "Main";
            this.Text = "TextStudio";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.HomeTab.ResumeLayout(false);
            this.SpeechGroupBox.ResumeLayout(false);
            this.ZoomGroupBox.ResumeLayout(false);
            this.ZoomGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomFactor)).EndInit();
            this.OtherToolsTab.ResumeLayout(false);
            this.ImageTab.ResumeLayout(false);
            this.FileGroupBox.ResumeLayout(false);
            this.FontGroupBox.ResumeLayout(false);
            this.AllTabs.ResumeLayout(false);
            this.TextProcessingTab.ResumeLayout(false);
            this.HeaderGroupBox.ResumeLayout(false);
            this.HeaderGroupBox.PerformLayout();
            this.BibliographyGroupBox.ResumeLayout(false);
            this.BibliographyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Editor;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.ComboBox FontSizeSelection;
        private System.Windows.Forms.ComboBox FontFamilySelection;
        private System.Windows.Forms.TabControl AllTabs;
        private System.Windows.Forms.Button ItalicButton;
        private System.Windows.Forms.Button UnderlineButton;
        private System.Windows.Forms.Button BoldButton;
        private System.Windows.Forms.Button RegularButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox FileGroupBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox FontGroupBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.TabPage TextProcessingTab;
        private System.Windows.Forms.GroupBox BibliographyGroupBox;
        private System.Windows.Forms.Button AddSourceButton;
        private System.Windows.Forms.Button CiteAllButton;
        private System.Windows.Forms.ComboBox BibliographyFormatSelector;
        private System.Windows.Forms.ComboBox SourceViewer;
        private System.Windows.Forms.Button RemoveSourceButton;
        private System.Windows.Forms.Button CiteOneSoureButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button CenterButton;
        private System.Windows.Forms.GroupBox HeaderGroupBox;
        private System.Windows.Forms.TextBox ClassNameInput;
        private System.Windows.Forms.TextBox PeriodInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Button InsertHeadingButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PeriodLabel;
        private System.Windows.Forms.Label ClassNameLabel;
        private System.Windows.Forms.ComboBox HeaderFormatInput;
        private System.Windows.Forms.Label HeaderFormatLabel;
        private System.Windows.Forms.GroupBox ImageTab;
        private System.Windows.Forms.Button InsertImageFromFileButton;
        private System.Windows.Forms.Button InsertImageFromUri;
        private System.Windows.Forms.Button ChangeColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button FetchFromURIButton;
        private System.Windows.Forms.GroupBox OtherToolsTab;
        private System.Windows.Forms.Button SpellCheckButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ZoomGroupBox;
        private System.Windows.Forms.TrackBar ZoomFactor;
        private System.Windows.Forms.GroupBox SpeechGroupBox;
        private System.Windows.Forms.Button InsertSpeechButton;
        private System.Windows.Forms.Button ReadOutLoudButton;
        private System.Windows.Forms.Button AddToDictionary;
        private System.Windows.Forms.Button ToHTMLDocButton;
    }
}

