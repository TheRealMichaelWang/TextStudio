namespace TextStudio
{
    partial class ResearchHelper
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
            this.SearchEngine = new System.Windows.Forms.ComboBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchEngine
            // 
            this.SearchEngine.FormattingEnabled = true;
            this.SearchEngine.Location = new System.Drawing.Point(549, 11);
            this.SearchEngine.Name = "SearchEngine";
            this.SearchEngine.Size = new System.Drawing.Size(239, 21);
            this.SearchEngine.TabIndex = 1;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(74, 12);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(451, 20);
            this.Input.TabIndex = 2;
            this.Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search for";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "at";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(0, 65);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Output.Size = new System.Drawing.Size(801, 389);
            this.Output.TabIndex = 5;
            this.Output.WordWrap = false;
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(74, 39);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(451, 20);
            this.Input2.TabIndex = 6;
            this.Input2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input2_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search for";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "In these results";
            // 
            // ResearchHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.SearchEngine);
            this.MaximizeBox = false;
            this.Name = "ResearchHelper";
            this.ShowIcon = false;
            this.Text = "ResearchHelper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox SearchEngine;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}