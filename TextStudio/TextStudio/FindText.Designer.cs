namespace TextStudio
{
    partial class FindText
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
            this.ToFindInput = new System.Windows.Forms.TextBox();
            this.FindGroupBox = new System.Windows.Forms.GroupBox();
            this.FindAll = new System.Windows.Forms.Button();
            this.ResetFind = new System.Windows.Forms.Button();
            this.FindGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToFindInput
            // 
            this.ToFindInput.Location = new System.Drawing.Point(6, 28);
            this.ToFindInput.Name = "ToFindInput";
            this.ToFindInput.Size = new System.Drawing.Size(764, 20);
            this.ToFindInput.TabIndex = 0;
            // 
            // FindGroupBox
            // 
            this.FindGroupBox.Controls.Add(this.ToFindInput);
            this.FindGroupBox.Location = new System.Drawing.Point(12, 12);
            this.FindGroupBox.Name = "FindGroupBox";
            this.FindGroupBox.Size = new System.Drawing.Size(776, 66);
            this.FindGroupBox.TabIndex = 1;
            this.FindGroupBox.TabStop = false;
            this.FindGroupBox.Text = "To Find";
            // 
            // FindAll
            // 
            this.FindAll.Location = new System.Drawing.Point(707, 84);
            this.FindAll.Name = "FindAll";
            this.FindAll.Size = new System.Drawing.Size(75, 23);
            this.FindAll.TabIndex = 2;
            this.FindAll.Text = "Find";
            this.FindAll.UseVisualStyleBackColor = true;
            this.FindAll.Click += new System.EventHandler(this.FindAll_Click);
            // 
            // ResetFind
            // 
            this.ResetFind.Location = new System.Drawing.Point(626, 84);
            this.ResetFind.Name = "ResetFind";
            this.ResetFind.Size = new System.Drawing.Size(75, 23);
            this.ResetFind.TabIndex = 3;
            this.ResetFind.Text = "ResetFinder";
            this.ResetFind.UseVisualStyleBackColor = true;
            this.ResetFind.Click += new System.EventHandler(this.ResetFind_Click);
            // 
            // FindText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 120);
            this.Controls.Add(this.ResetFind);
            this.Controls.Add(this.FindAll);
            this.Controls.Add(this.FindGroupBox);
            this.MaximizeBox = false;
            this.Name = "FindText";
            this.ShowIcon = false;
            this.Text = "FindText";
            this.FindGroupBox.ResumeLayout(false);
            this.FindGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ToFindInput;
        private System.Windows.Forms.GroupBox FindGroupBox;
        private System.Windows.Forms.Button FindAll;
        private System.Windows.Forms.Button ResetFind;
    }
}