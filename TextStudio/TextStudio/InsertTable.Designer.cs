namespace TextStudio
{
    partial class InsertTable
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
            this.InsertButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ColWidthInput = new System.Windows.Forms.TextBox();
            this.SetWidth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(1, 2);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(799, 407);
            this.Input.TabIndex = 0;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(713, 415);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 1;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(632, 415);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ColWidthInput
            // 
            this.ColWidthInput.Location = new System.Drawing.Point(13, 417);
            this.ColWidthInput.Name = "ColWidthInput";
            this.ColWidthInput.Size = new System.Drawing.Size(152, 20);
            this.ColWidthInput.TabIndex = 3;
            // 
            // SetWidth
            // 
            this.SetWidth.Location = new System.Drawing.Point(171, 415);
            this.SetWidth.Name = "SetWidth";
            this.SetWidth.Size = new System.Drawing.Size(155, 23);
            this.SetWidth.TabIndex = 4;
            this.SetWidth.Text = "Set Col Width in Char Length";
            this.SetWidth.UseVisualStyleBackColor = true;
            this.SetWidth.Click += new System.EventHandler(this.SetWidth_Click);
            // 
            // InsertTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetWidth);
            this.Controls.Add(this.ColWidthInput);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.Input);
            this.Name = "InsertTable";
            this.Text = "InsertTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox ColWidthInput;
        private System.Windows.Forms.Button SetWidth;
    }
}