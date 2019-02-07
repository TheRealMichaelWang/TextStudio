namespace TextStudio
{
    partial class RunProgram
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
            this.RunAndTestGroupBox = new System.Windows.Forms.GroupBox();
            this.RunAsBatchFile = new System.Windows.Forms.Button();
            this.RunAsPythonProgram = new System.Windows.Forms.Button();
            this.DeployHtmlToChrome = new System.Windows.Forms.Button();
            this.ProcessInfo = new System.Windows.Forms.GroupBox();
            this.ProcessInformation = new System.Windows.Forms.TextBox();
            this.RunAndTestGroupBox.SuspendLayout();
            this.ProcessInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunAndTestGroupBox
            // 
            this.RunAndTestGroupBox.Controls.Add(this.DeployHtmlToChrome);
            this.RunAndTestGroupBox.Controls.Add(this.RunAsPythonProgram);
            this.RunAndTestGroupBox.Controls.Add(this.RunAsBatchFile);
            this.RunAndTestGroupBox.Location = new System.Drawing.Point(13, 13);
            this.RunAndTestGroupBox.Name = "RunAndTestGroupBox";
            this.RunAndTestGroupBox.Size = new System.Drawing.Size(775, 81);
            this.RunAndTestGroupBox.TabIndex = 0;
            this.RunAndTestGroupBox.TabStop = false;
            this.RunAndTestGroupBox.Text = "Run and Test";
            // 
            // RunAsBatchFile
            // 
            this.RunAsBatchFile.Location = new System.Drawing.Point(7, 20);
            this.RunAsBatchFile.Name = "RunAsBatchFile";
            this.RunAsBatchFile.Size = new System.Drawing.Size(157, 23);
            this.RunAsBatchFile.TabIndex = 0;
            this.RunAsBatchFile.Text = "Run As Windows Batch File";
            this.RunAsBatchFile.UseVisualStyleBackColor = true;
            this.RunAsBatchFile.Click += new System.EventHandler(this.RunAsBatchFile_Click);
            // 
            // RunAsPythonProgram
            // 
            this.RunAsPythonProgram.Location = new System.Drawing.Point(7, 50);
            this.RunAsPythonProgram.Name = "RunAsPythonProgram";
            this.RunAsPythonProgram.Size = new System.Drawing.Size(157, 23);
            this.RunAsPythonProgram.TabIndex = 1;
            this.RunAsPythonProgram.Text = "Run As A Python Program";
            this.RunAsPythonProgram.UseVisualStyleBackColor = true;
            this.RunAsPythonProgram.Click += new System.EventHandler(this.RunAsPythonProgram_Click);
            // 
            // DeployHtmlToChrome
            // 
            this.DeployHtmlToChrome.Location = new System.Drawing.Point(171, 20);
            this.DeployHtmlToChrome.Name = "DeployHtmlToChrome";
            this.DeployHtmlToChrome.Size = new System.Drawing.Size(165, 23);
            this.DeployHtmlToChrome.TabIndex = 2;
            this.DeployHtmlToChrome.Text = "Deploy Html Code to Chrome";
            this.DeployHtmlToChrome.UseVisualStyleBackColor = true;
            this.DeployHtmlToChrome.Click += new System.EventHandler(this.DeployHtmlToChrome_Click);
            // 
            // ProcessInfo
            // 
            this.ProcessInfo.Controls.Add(this.ProcessInformation);
            this.ProcessInfo.Location = new System.Drawing.Point(13, 101);
            this.ProcessInfo.Name = "ProcessInfo";
            this.ProcessInfo.Size = new System.Drawing.Size(775, 100);
            this.ProcessInfo.TabIndex = 1;
            this.ProcessInfo.TabStop = false;
            this.ProcessInfo.Text = "Process";
            // 
            // ProcessInformation
            // 
            this.ProcessInformation.Location = new System.Drawing.Point(7, 20);
            this.ProcessInformation.Multiline = true;
            this.ProcessInformation.Name = "ProcessInformation";
            this.ProcessInformation.ReadOnly = true;
            this.ProcessInformation.Size = new System.Drawing.Size(762, 74);
            this.ProcessInformation.TabIndex = 0;
            // 
            // RunProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 223);
            this.Controls.Add(this.ProcessInfo);
            this.Controls.Add(this.RunAndTestGroupBox);
            this.Name = "RunProgram";
            this.Text = "Run Your Program";
            this.RunAndTestGroupBox.ResumeLayout(false);
            this.ProcessInfo.ResumeLayout(false);
            this.ProcessInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RunAndTestGroupBox;
        private System.Windows.Forms.Button DeployHtmlToChrome;
        private System.Windows.Forms.Button RunAsPythonProgram;
        private System.Windows.Forms.Button RunAsBatchFile;
        private System.Windows.Forms.GroupBox ProcessInfo;
        private System.Windows.Forms.TextBox ProcessInformation;
    }
}