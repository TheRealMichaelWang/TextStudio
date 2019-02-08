namespace Updater
{
    partial class UpdateInfo
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
            this.HTMLDisplay = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // HTMLDisplay
            // 
            this.HTMLDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTMLDisplay.Location = new System.Drawing.Point(0, 0);
            this.HTMLDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.HTMLDisplay.Name = "HTMLDisplay";
            this.HTMLDisplay.Size = new System.Drawing.Size(800, 450);
            this.HTMLDisplay.TabIndex = 0;
            // 
            // UpdateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HTMLDisplay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "UpdateInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser HTMLDisplay;
    }
}