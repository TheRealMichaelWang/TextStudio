using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Updater
{
    public partial class UpdateInfo : Form
    {
        public UpdateInfo(string info)
        {
            InitializeComponent();
            HTMLDisplay.DocumentText = info;
            this.ShowDialog();
        }
    }
}
