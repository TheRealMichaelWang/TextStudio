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
            this.Run = new System.Windows.Forms.Button();
            this.RunAndTestGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunAndTestGroupBox
            // 
            this.RunAndTestGroupBox.Controls.Add(this.Run);
            this.RunAndTestGroupBox.Location = new System.Drawing.Point(13, 13);
            this.RunAndTestGroupBox.Name = "RunAndTestGroupBox";
            this.RunAndTestGroupBox.Size = new System.Drawing.Size(775, 69);
            this.RunAndTestGroupBox.TabIndex = 0;
            this.RunAndTestGroupBox.TabStop = false;
            this.RunAndTestGroupBox.Text = "Run and Test";
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(7, 20);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(157, 23);
            this.Run.TabIndex = 0;
            this.Run.Text = "Run Program";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // RunProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 98);
            this.Controls.Add(this.RunAndTestGroupBox);
            this.Name = "RunProgram";
            this.Text = "Run Your Program";
            this.RunAndTestGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RunAndTestGroupBox;
        private System.Windows.Forms.Button Run;
    }
}