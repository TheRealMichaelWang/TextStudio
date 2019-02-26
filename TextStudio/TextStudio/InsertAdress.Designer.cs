namespace TextStudio
{
    partial class InsertAdress
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
            this.StreetAdressInput = new System.Windows.Forms.TextBox();
            this.StreetAdressGroupBox = new System.Windows.Forms.GroupBox();
            this.CityGroupBox = new System.Windows.Forms.GroupBox();
            this.CityInput = new System.Windows.Forms.TextBox();
            this.StateGroupBox = new System.Windows.Forms.GroupBox();
            this.StateInput = new System.Windows.Forms.TextBox();
            this.ZipCodeGroupBox = new System.Windows.Forms.GroupBox();
            this.ZipCodeInput = new System.Windows.Forms.TextBox();
            this.BuildingNameGroupBox = new System.Windows.Forms.GroupBox();
            this.BuildingNameInput = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StreetAdressGroupBox.SuspendLayout();
            this.CityGroupBox.SuspendLayout();
            this.StateGroupBox.SuspendLayout();
            this.ZipCodeGroupBox.SuspendLayout();
            this.BuildingNameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StreetAdressInput
            // 
            this.StreetAdressInput.Location = new System.Drawing.Point(7, 20);
            this.StreetAdressInput.Name = "StreetAdressInput";
            this.StreetAdressInput.Size = new System.Drawing.Size(762, 20);
            this.StreetAdressInput.TabIndex = 0;
            // 
            // StreetAdressGroupBox
            // 
            this.StreetAdressGroupBox.Controls.Add(this.StreetAdressInput);
            this.StreetAdressGroupBox.Location = new System.Drawing.Point(13, 13);
            this.StreetAdressGroupBox.Name = "StreetAdressGroupBox";
            this.StreetAdressGroupBox.Size = new System.Drawing.Size(775, 55);
            this.StreetAdressGroupBox.TabIndex = 0;
            this.StreetAdressGroupBox.TabStop = false;
            this.StreetAdressGroupBox.Text = "Street Adress";
            // 
            // CityGroupBox
            // 
            this.CityGroupBox.Controls.Add(this.CityInput);
            this.CityGroupBox.Location = new System.Drawing.Point(13, 74);
            this.CityGroupBox.Name = "CityGroupBox";
            this.CityGroupBox.Size = new System.Drawing.Size(775, 55);
            this.CityGroupBox.TabIndex = 1;
            this.CityGroupBox.TabStop = false;
            this.CityGroupBox.Text = "City";
            // 
            // CityInput
            // 
            this.CityInput.Location = new System.Drawing.Point(7, 20);
            this.CityInput.Name = "CityInput";
            this.CityInput.Size = new System.Drawing.Size(762, 20);
            this.CityInput.TabIndex = 0;
            // 
            // StateGroupBox
            // 
            this.StateGroupBox.Controls.Add(this.StateInput);
            this.StateGroupBox.Location = new System.Drawing.Point(13, 135);
            this.StateGroupBox.Name = "StateGroupBox";
            this.StateGroupBox.Size = new System.Drawing.Size(775, 55);
            this.StateGroupBox.TabIndex = 2;
            this.StateGroupBox.TabStop = false;
            this.StateGroupBox.Text = "State";
            // 
            // StateInput
            // 
            this.StateInput.Location = new System.Drawing.Point(7, 20);
            this.StateInput.Name = "StateInput";
            this.StateInput.Size = new System.Drawing.Size(762, 20);
            this.StateInput.TabIndex = 0;
            // 
            // ZipCodeGroupBox
            // 
            this.ZipCodeGroupBox.Controls.Add(this.ZipCodeInput);
            this.ZipCodeGroupBox.Location = new System.Drawing.Point(13, 198);
            this.ZipCodeGroupBox.Name = "ZipCodeGroupBox";
            this.ZipCodeGroupBox.Size = new System.Drawing.Size(775, 55);
            this.ZipCodeGroupBox.TabIndex = 3;
            this.ZipCodeGroupBox.TabStop = false;
            this.ZipCodeGroupBox.Text = "Zip Code";
            // 
            // ZipCodeInput
            // 
            this.ZipCodeInput.Location = new System.Drawing.Point(7, 20);
            this.ZipCodeInput.Name = "ZipCodeInput";
            this.ZipCodeInput.Size = new System.Drawing.Size(762, 20);
            this.ZipCodeInput.TabIndex = 0;
            // 
            // BuildingNameGroupBox
            // 
            this.BuildingNameGroupBox.Controls.Add(this.BuildingNameInput);
            this.BuildingNameGroupBox.Location = new System.Drawing.Point(13, 259);
            this.BuildingNameGroupBox.Name = "BuildingNameGroupBox";
            this.BuildingNameGroupBox.Size = new System.Drawing.Size(775, 55);
            this.BuildingNameGroupBox.TabIndex = 4;
            this.BuildingNameGroupBox.TabStop = false;
            this.BuildingNameGroupBox.Text = "Building Name (Leave this blank if this isn\'t applicable)";
            // 
            // BuildingNameInput
            // 
            this.BuildingNameInput.Location = new System.Drawing.Point(7, 20);
            this.BuildingNameInput.Name = "BuildingNameInput";
            this.BuildingNameInput.Size = new System.Drawing.Size(762, 20);
            this.BuildingNameInput.TabIndex = 0;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(713, 320);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 5;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(632, 320);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // InsertAdress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 348);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.BuildingNameGroupBox);
            this.Controls.Add(this.ZipCodeGroupBox);
            this.Controls.Add(this.StateGroupBox);
            this.Controls.Add(this.CityGroupBox);
            this.Controls.Add(this.StreetAdressGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsertAdress";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "InsertAdress";
            this.StreetAdressGroupBox.ResumeLayout(false);
            this.StreetAdressGroupBox.PerformLayout();
            this.CityGroupBox.ResumeLayout(false);
            this.CityGroupBox.PerformLayout();
            this.StateGroupBox.ResumeLayout(false);
            this.StateGroupBox.PerformLayout();
            this.ZipCodeGroupBox.ResumeLayout(false);
            this.ZipCodeGroupBox.PerformLayout();
            this.BuildingNameGroupBox.ResumeLayout(false);
            this.BuildingNameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox StreetAdressInput;
        private System.Windows.Forms.GroupBox StreetAdressGroupBox;
        private System.Windows.Forms.GroupBox CityGroupBox;
        private System.Windows.Forms.TextBox CityInput;
        private System.Windows.Forms.GroupBox StateGroupBox;
        private System.Windows.Forms.TextBox StateInput;
        private System.Windows.Forms.GroupBox ZipCodeGroupBox;
        private System.Windows.Forms.TextBox ZipCodeInput;
        private System.Windows.Forms.GroupBox BuildingNameGroupBox;
        private System.Windows.Forms.TextBox BuildingNameInput;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button CancelButton;
    }
}