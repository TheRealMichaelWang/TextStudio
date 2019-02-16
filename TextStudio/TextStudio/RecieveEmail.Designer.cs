namespace TextStudio
{
    partial class RecieveEmail
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
            this.PortGroupBox = new System.Windows.Forms.GroupBox();
            this.PortInput = new System.Windows.Forms.TextBox();
            this.HostGroupBox = new System.Windows.Forms.GroupBox();
            this.HostInput = new System.Windows.Forms.TextBox();
            this.PasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.EmailGroupBox = new System.Windows.Forms.GroupBox();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.SubjectGroupBox = new System.Windows.Forms.GroupBox();
            this.SubjectInput = new System.Windows.Forms.TextBox();
            this.UseSSLSecurityCheckBox = new System.Windows.Forms.CheckBox();
            this.InsertTextButton = new System.Windows.Forms.Button();
            this.InsertWithFormatingButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PortGroupBox.SuspendLayout();
            this.HostGroupBox.SuspendLayout();
            this.PasswordGroupBox.SuspendLayout();
            this.EmailGroupBox.SuspendLayout();
            this.SubjectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortGroupBox
            // 
            this.PortGroupBox.Controls.Add(this.PortInput);
            this.PortGroupBox.Location = new System.Drawing.Point(622, 186);
            this.PortGroupBox.Name = "PortGroupBox";
            this.PortGroupBox.Size = new System.Drawing.Size(160, 52);
            this.PortGroupBox.TabIndex = 12;
            this.PortGroupBox.TabStop = false;
            this.PortGroupBox.Text = "Port";
            // 
            // PortInput
            // 
            this.PortInput.Location = new System.Drawing.Point(6, 19);
            this.PortInput.Name = "PortInput";
            this.PortInput.Size = new System.Drawing.Size(148, 20);
            this.PortInput.TabIndex = 0;
            // 
            // HostGroupBox
            // 
            this.HostGroupBox.Controls.Add(this.HostInput);
            this.HostGroupBox.Location = new System.Drawing.Point(12, 186);
            this.HostGroupBox.Name = "HostGroupBox";
            this.HostGroupBox.Size = new System.Drawing.Size(604, 52);
            this.HostGroupBox.TabIndex = 9;
            this.HostGroupBox.TabStop = false;
            this.HostGroupBox.Text = "Host";
            // 
            // HostInput
            // 
            this.HostInput.Location = new System.Drawing.Point(9, 19);
            this.HostInput.Name = "HostInput";
            this.HostInput.Size = new System.Drawing.Size(589, 20);
            this.HostInput.TabIndex = 0;
            // 
            // PasswordGroupBox
            // 
            this.PasswordGroupBox.Controls.Add(this.PasswordInput);
            this.PasswordGroupBox.Location = new System.Drawing.Point(12, 70);
            this.PasswordGroupBox.Name = "PasswordGroupBox";
            this.PasswordGroupBox.Size = new System.Drawing.Size(770, 52);
            this.PasswordGroupBox.TabIndex = 11;
            this.PasswordGroupBox.TabStop = false;
            this.PasswordGroupBox.Text = "Password";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(9, 19);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(755, 20);
            this.PasswordInput.TabIndex = 0;
            // 
            // EmailGroupBox
            // 
            this.EmailGroupBox.Controls.Add(this.EmailInput);
            this.EmailGroupBox.Location = new System.Drawing.Point(12, 12);
            this.EmailGroupBox.Name = "EmailGroupBox";
            this.EmailGroupBox.Size = new System.Drawing.Size(770, 52);
            this.EmailGroupBox.TabIndex = 10;
            this.EmailGroupBox.TabStop = false;
            this.EmailGroupBox.Text = "Your Email";
            // 
            // EmailInput
            // 
            this.EmailInput.Location = new System.Drawing.Point(9, 19);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(755, 20);
            this.EmailInput.TabIndex = 0;
            // 
            // SubjectGroupBox
            // 
            this.SubjectGroupBox.Controls.Add(this.SubjectInput);
            this.SubjectGroupBox.Location = new System.Drawing.Point(12, 128);
            this.SubjectGroupBox.Name = "SubjectGroupBox";
            this.SubjectGroupBox.Size = new System.Drawing.Size(770, 52);
            this.SubjectGroupBox.TabIndex = 8;
            this.SubjectGroupBox.TabStop = false;
            this.SubjectGroupBox.Text = "Subject";
            // 
            // SubjectInput
            // 
            this.SubjectInput.Location = new System.Drawing.Point(9, 19);
            this.SubjectInput.Name = "SubjectInput";
            this.SubjectInput.Size = new System.Drawing.Size(755, 20);
            this.SubjectInput.TabIndex = 0;
            // 
            // UseSSLSecurityCheckBox
            // 
            this.UseSSLSecurityCheckBox.AutoSize = true;
            this.UseSSLSecurityCheckBox.Checked = true;
            this.UseSSLSecurityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseSSLSecurityCheckBox.Location = new System.Drawing.Point(21, 244);
            this.UseSSLSecurityCheckBox.Name = "UseSSLSecurityCheckBox";
            this.UseSSLSecurityCheckBox.Size = new System.Drawing.Size(82, 17);
            this.UseSSLSecurityCheckBox.TabIndex = 13;
            this.UseSSLSecurityCheckBox.Text = "Enable SSL";
            this.UseSSLSecurityCheckBox.UseVisualStyleBackColor = true;
            // 
            // InsertTextButton
            // 
            this.InsertTextButton.Location = new System.Drawing.Point(707, 270);
            this.InsertTextButton.Name = "InsertTextButton";
            this.InsertTextButton.Size = new System.Drawing.Size(75, 23);
            this.InsertTextButton.TabIndex = 14;
            this.InsertTextButton.Text = "InsertText";
            this.InsertTextButton.UseVisualStyleBackColor = true;
            this.InsertTextButton.Click += new System.EventHandler(this.InsertTextButton_Click);
            // 
            // InsertWithFormatingButton
            // 
            this.InsertWithFormatingButton.Location = new System.Drawing.Point(587, 270);
            this.InsertWithFormatingButton.Name = "InsertWithFormatingButton";
            this.InsertWithFormatingButton.Size = new System.Drawing.Size(110, 23);
            this.InsertWithFormatingButton.TabIndex = 15;
            this.InsertWithFormatingButton.Text = "InsertWithFormating";
            this.InsertWithFormatingButton.UseVisualStyleBackColor = true;
            this.InsertWithFormatingButton.Click += new System.EventHandler(this.InsertWithFormatingButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(528, 270);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(53, 23);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RecieveEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 301);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.InsertWithFormatingButton);
            this.Controls.Add(this.InsertTextButton);
            this.Controls.Add(this.UseSSLSecurityCheckBox);
            this.Controls.Add(this.PortGroupBox);
            this.Controls.Add(this.HostGroupBox);
            this.Controls.Add(this.PasswordGroupBox);
            this.Controls.Add(this.EmailGroupBox);
            this.Controls.Add(this.SubjectGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecieveEmail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "RecieveEmail";
            this.PortGroupBox.ResumeLayout(false);
            this.PortGroupBox.PerformLayout();
            this.HostGroupBox.ResumeLayout(false);
            this.HostGroupBox.PerformLayout();
            this.PasswordGroupBox.ResumeLayout(false);
            this.PasswordGroupBox.PerformLayout();
            this.EmailGroupBox.ResumeLayout(false);
            this.EmailGroupBox.PerformLayout();
            this.SubjectGroupBox.ResumeLayout(false);
            this.SubjectGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PortGroupBox;
        private System.Windows.Forms.TextBox PortInput;
        private System.Windows.Forms.GroupBox HostGroupBox;
        private System.Windows.Forms.TextBox HostInput;
        private System.Windows.Forms.GroupBox PasswordGroupBox;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.GroupBox EmailGroupBox;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.GroupBox SubjectGroupBox;
        private System.Windows.Forms.TextBox SubjectInput;
        private System.Windows.Forms.CheckBox UseSSLSecurityCheckBox;
        private System.Windows.Forms.Button InsertTextButton;
        private System.Windows.Forms.Button InsertWithFormatingButton;
        private System.Windows.Forms.Button CancelButton;
    }
}