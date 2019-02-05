namespace TextStudio
{
    partial class FromUrl
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
            this.UrlGroupBox = new System.Windows.Forms.GroupBox();
            this.URLInput = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Download = new System.Windows.Forms.Button();
            this.UrlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UrlGroupBox
            // 
            this.UrlGroupBox.Controls.Add(this.URLInput);
            this.UrlGroupBox.Location = new System.Drawing.Point(12, 12);
            this.UrlGroupBox.Name = "UrlGroupBox";
            this.UrlGroupBox.Size = new System.Drawing.Size(776, 63);
            this.UrlGroupBox.TabIndex = 0;
            this.UrlGroupBox.TabStop = false;
            this.UrlGroupBox.Text = "Url";
            // 
            // URLInput
            // 
            this.URLInput.Location = new System.Drawing.Point(7, 20);
            this.URLInput.Name = "URLInput";
            this.URLInput.Size = new System.Drawing.Size(763, 20);
            this.URLInput.TabIndex = 0;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(710, 81);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(78, 23);
            this.Confirm.TabIndex = 1;
            this.Confirm.Text = "ReturnObject";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(546, 81);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(627, 81);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(75, 23);
            this.Download.TabIndex = 4;
            this.Download.Text = "Download";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // FromUrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 112);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.UrlGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FromUrl";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Obtain an Object from a URL";
            this.UrlGroupBox.ResumeLayout(false);
            this.UrlGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UrlGroupBox;
        private System.Windows.Forms.TextBox URLInput;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Download;
    }
}