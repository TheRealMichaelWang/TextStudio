using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextStudio
{
    public partial class InsertAdress : Form
    {
        public string returnstring = null;
        public InsertAdress()
        {
            InitializeComponent();
            this.ShowDialog();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if(BuildingNameInput.Text == "")
            {
                returnstring = StreetAdressInput.Text + "\r\n" + CityInput.Text + ", " + StateInput.Text + " " + ZipCodeInput.Text;
            }
            else
            {
                returnstring = BuildingNameInput.Text+"\r\n"+StreetAdressInput.Text + "\r\n" + CityInput.Text + ", " + StateInput.Text + " " + ZipCodeInput.Text;
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
