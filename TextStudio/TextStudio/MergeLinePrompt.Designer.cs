namespace TextStudio
{
    partial class MergeLinePrompt
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
            this.NewValueGroupBox = new System.Windows.Forms.GroupBox();
            this.NewValueInput = new System.Windows.Forms.TextBox();
            this.OriginalValueGroupBox = new System.Windows.Forms.GroupBox();
            this.OriginalValueOutput = new System.Windows.Forms.TextBox();
            this.ToMergeValueGroupBox = new System.Windows.Forms.GroupBox();
            this.ToMergeOutut = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.NewValueGroupBox.SuspendLayout();
            this.OriginalValueGroupBox.SuspendLayout();
            this.ToMergeValueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewValueGroupBox
            // 
            this.NewValueGroupBox.Controls.Add(this.NewValueInput);
            this.NewValueGroupBox.Location = new System.Drawing.Point(12, 110);
            this.NewValueGroupBox.Name = "NewValueGroupBox";
            this.NewValueGroupBox.Size = new System.Drawing.Size(776, 43);
            this.NewValueGroupBox.TabIndex = 1;
            this.NewValueGroupBox.TabStop = false;
            this.NewValueGroupBox.Text = "NewValue";
            // 
            // NewValueInput
            // 
            this.NewValueInput.Location = new System.Drawing.Point(7, 17);
            this.NewValueInput.Name = "NewValueInput";
            this.NewValueInput.Size = new System.Drawing.Size(763, 20);
            this.NewValueInput.TabIndex = 0;
            // 
            // OriginalValueGroupBox
            // 
            this.OriginalValueGroupBox.Controls.Add(this.OriginalValueOutput);
            this.OriginalValueGroupBox.Location = new System.Drawing.Point(12, 61);
            this.OriginalValueGroupBox.Name = "OriginalValueGroupBox";
            this.OriginalValueGroupBox.Size = new System.Drawing.Size(776, 43);
            this.OriginalValueGroupBox.TabIndex = 2;
            this.OriginalValueGroupBox.TabStop = false;
            this.OriginalValueGroupBox.Text = "Original Value";
            // 
            // OriginalValueOutput
            // 
            this.OriginalValueOutput.Location = new System.Drawing.Point(7, 17);
            this.OriginalValueOutput.Name = "OriginalValueOutput";
            this.OriginalValueOutput.ReadOnly = true;
            this.OriginalValueOutput.Size = new System.Drawing.Size(763, 20);
            this.OriginalValueOutput.TabIndex = 1;
            this.OriginalValueOutput.Click += new System.EventHandler(this.OriginalValueOutput_TextChanged);
            // 
            // ToMergeValueGroupBox
            // 
            this.ToMergeValueGroupBox.Controls.Add(this.ToMergeOutut);
            this.ToMergeValueGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ToMergeValueGroupBox.Name = "ToMergeValueGroupBox";
            this.ToMergeValueGroupBox.Size = new System.Drawing.Size(776, 43);
            this.ToMergeValueGroupBox.TabIndex = 3;
            this.ToMergeValueGroupBox.TabStop = false;
            this.ToMergeValueGroupBox.Text = "To Merge Value";
            // 
            // ToMergeOutut
            // 
            this.ToMergeOutut.Location = new System.Drawing.Point(7, 17);
            this.ToMergeOutut.Name = "ToMergeOutut";
            this.ToMergeOutut.ReadOnly = true;
            this.ToMergeOutut.Size = new System.Drawing.Size(763, 20);
            this.ToMergeOutut.TabIndex = 1;
            this.ToMergeOutut.Click += new System.EventHandler(this.ToMergeOutut_TextChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(713, 171);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // MergeLinePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 206);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ToMergeValueGroupBox);
            this.Controls.Add(this.OriginalValueGroupBox);
            this.Controls.Add(this.NewValueGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MergeLinePrompt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MergeLinePrompt";
            this.Load += new System.EventHandler(this.MergeLinePrompt_Load);
            this.NewValueGroupBox.ResumeLayout(false);
            this.NewValueGroupBox.PerformLayout();
            this.OriginalValueGroupBox.ResumeLayout(false);
            this.OriginalValueGroupBox.PerformLayout();
            this.ToMergeValueGroupBox.ResumeLayout(false);
            this.ToMergeValueGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NewValueGroupBox;
        private System.Windows.Forms.TextBox NewValueInput;
        private System.Windows.Forms.GroupBox OriginalValueGroupBox;
        private System.Windows.Forms.TextBox OriginalValueOutput;
        private System.Windows.Forms.GroupBox ToMergeValueGroupBox;
        private System.Windows.Forms.TextBox ToMergeOutut;
        private System.Windows.Forms.Button OKButton;
    }
}