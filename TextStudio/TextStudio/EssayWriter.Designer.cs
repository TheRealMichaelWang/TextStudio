namespace TextStudio
{
    partial class EssayWriter
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
            this.Input = new System.Windows.Forms.TextBox();
            this.DownloadDocumentButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(13, 32);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(775, 20);
            this.Input.TabIndex = 0;
            // 
            // DownloadDocumentButton
            // 
            this.DownloadDocumentButton.Location = new System.Drawing.Point(713, 58);
            this.DownloadDocumentButton.Name = "DownloadDocumentButton";
            this.DownloadDocumentButton.Size = new System.Drawing.Size(75, 23);
            this.DownloadDocumentButton.TabIndex = 1;
            this.DownloadDocumentButton.Text = "Write";
            this.DownloadDocumentButton.UseVisualStyleBackColor = true;
            this.DownloadDocumentButton.Click += new System.EventHandler(this.DownloadDocumentButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(619, 58);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Essay Name:";
            // 
            // EssayWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 95);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DownloadDocumentButton);
            this.Controls.Add(this.Input);
            this.Name = "EssayWriter";
            this.Text = "EssayWriter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button DownloadDocumentButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
    }
}