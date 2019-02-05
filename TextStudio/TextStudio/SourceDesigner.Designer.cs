namespace TextStudio
{
    partial class SourceDesigner
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
            this.DatePublishedInput = new System.Windows.Forms.TextBox();
            this.DatePublishedGroupBox = new System.Windows.Forms.GroupBox();
            this.TitleGroupBox = new System.Windows.Forms.GroupBox();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.AuthorGroupBox = new System.Windows.Forms.GroupBox();
            this.AuthorInput = new System.Windows.Forms.TextBox();
            this.UrlGroupBox = new System.Windows.Forms.GroupBox();
            this.UrlInput = new System.Windows.Forms.TextBox();
            this.PublisherGroupBox = new System.Windows.Forms.GroupBox();
            this.PublisherInput = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.DatePublishedGroupBox.SuspendLayout();
            this.TitleGroupBox.SuspendLayout();
            this.AuthorGroupBox.SuspendLayout();
            this.UrlGroupBox.SuspendLayout();
            this.PublisherGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatePublishedInput
            // 
            this.DatePublishedInput.Location = new System.Drawing.Point(13, 19);
            this.DatePublishedInput.Name = "DatePublishedInput";
            this.DatePublishedInput.Size = new System.Drawing.Size(734, 20);
            this.DatePublishedInput.TabIndex = 0;
            // 
            // DatePublishedGroupBox
            // 
            this.DatePublishedGroupBox.Controls.Add(this.DatePublishedInput);
            this.DatePublishedGroupBox.Location = new System.Drawing.Point(12, 267);
            this.DatePublishedGroupBox.Name = "DatePublishedGroupBox";
            this.DatePublishedGroupBox.Size = new System.Drawing.Size(765, 53);
            this.DatePublishedGroupBox.TabIndex = 1;
            this.DatePublishedGroupBox.TabStop = false;
            this.DatePublishedGroupBox.Text = "DatePublished";
            // 
            // TitleGroupBox
            // 
            this.TitleGroupBox.Controls.Add(this.TitleInput);
            this.TitleGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TitleGroupBox.Name = "TitleGroupBox";
            this.TitleGroupBox.Size = new System.Drawing.Size(765, 53);
            this.TitleGroupBox.TabIndex = 2;
            this.TitleGroupBox.TabStop = false;
            this.TitleGroupBox.Text = "Title";
            // 
            // TitleInput
            // 
            this.TitleInput.Location = new System.Drawing.Point(13, 19);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(734, 20);
            this.TitleInput.TabIndex = 0;
            // 
            // AuthorGroupBox
            // 
            this.AuthorGroupBox.Controls.Add(this.AuthorInput);
            this.AuthorGroupBox.Location = new System.Drawing.Point(12, 81);
            this.AuthorGroupBox.Name = "AuthorGroupBox";
            this.AuthorGroupBox.Size = new System.Drawing.Size(765, 53);
            this.AuthorGroupBox.TabIndex = 3;
            this.AuthorGroupBox.TabStop = false;
            this.AuthorGroupBox.Text = "Author";
            // 
            // AuthorInput
            // 
            this.AuthorInput.Location = new System.Drawing.Point(13, 19);
            this.AuthorInput.Name = "AuthorInput";
            this.AuthorInput.Size = new System.Drawing.Size(734, 20);
            this.AuthorInput.TabIndex = 0;
            // 
            // UrlGroupBox
            // 
            this.UrlGroupBox.Controls.Add(this.UrlInput);
            this.UrlGroupBox.Location = new System.Drawing.Point(12, 149);
            this.UrlGroupBox.Name = "UrlGroupBox";
            this.UrlGroupBox.Size = new System.Drawing.Size(765, 53);
            this.UrlGroupBox.TabIndex = 4;
            this.UrlGroupBox.TabStop = false;
            this.UrlGroupBox.Text = "Url";
            // 
            // UrlInput
            // 
            this.UrlInput.Location = new System.Drawing.Point(13, 19);
            this.UrlInput.Name = "UrlInput";
            this.UrlInput.Size = new System.Drawing.Size(734, 20);
            this.UrlInput.TabIndex = 0;
            // 
            // PublisherGroupBox
            // 
            this.PublisherGroupBox.Controls.Add(this.PublisherInput);
            this.PublisherGroupBox.Location = new System.Drawing.Point(12, 208);
            this.PublisherGroupBox.Name = "PublisherGroupBox";
            this.PublisherGroupBox.Size = new System.Drawing.Size(765, 53);
            this.PublisherGroupBox.TabIndex = 5;
            this.PublisherGroupBox.TabStop = false;
            this.PublisherGroupBox.Text = "Publisher";
            // 
            // PublisherInput
            // 
            this.PublisherInput.Location = new System.Drawing.Point(13, 19);
            this.PublisherInput.Name = "PublisherInput";
            this.PublisherInput.Size = new System.Drawing.Size(734, 20);
            this.PublisherInput.TabIndex = 0;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(684, 415);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 6;
            this.Confirm.Text = "OK";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(603, 415);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SourceDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.PublisherGroupBox);
            this.Controls.Add(this.UrlGroupBox);
            this.Controls.Add(this.AuthorGroupBox);
            this.Controls.Add(this.TitleGroupBox);
            this.Controls.Add(this.DatePublishedGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SourceDesigner";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add a new Source";
            this.DatePublishedGroupBox.ResumeLayout(false);
            this.DatePublishedGroupBox.PerformLayout();
            this.TitleGroupBox.ResumeLayout(false);
            this.TitleGroupBox.PerformLayout();
            this.AuthorGroupBox.ResumeLayout(false);
            this.AuthorGroupBox.PerformLayout();
            this.UrlGroupBox.ResumeLayout(false);
            this.UrlGroupBox.PerformLayout();
            this.PublisherGroupBox.ResumeLayout(false);
            this.PublisherGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox DatePublishedInput;
        private System.Windows.Forms.GroupBox DatePublishedGroupBox;
        private System.Windows.Forms.GroupBox TitleGroupBox;
        private System.Windows.Forms.TextBox TitleInput;
        private System.Windows.Forms.GroupBox AuthorGroupBox;
        private System.Windows.Forms.TextBox AuthorInput;
        private System.Windows.Forms.GroupBox UrlGroupBox;
        private System.Windows.Forms.TextBox UrlInput;
        private System.Windows.Forms.GroupBox PublisherGroupBox;
        private System.Windows.Forms.TextBox PublisherInput;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
    }
}