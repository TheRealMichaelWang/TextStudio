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
    public partial class InsertTable : Form
    {
        public Bitmap bitmap = null;
        public int choplength = 10;

        public InsertTable()
        {
            InitializeComponent();
            ColWidthInput.Text = "10";
        }

        public string CutString(string text,int choplenght)
        {
            string ret = text;
            while(ret.Length!=choplenght)
            {
                if(ret.Length >choplenght)
                {
                    ret.Remove(ret.Length - 1, 1);
                }
                if(ret.Length < choplenght)
                {
                    ret += " ";
                }
            }
            return ret;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            List<List<string>> table = new List<List<string>>();
            foreach(string line in Input.Lines)
            {
                List<string> row = new List<string>();
                
                foreach (string col in line.Split(','))
                {
                    row.Add(CutString(col, choplength));
                }
                table.Add(row);
            }
            bitmap = new Bitmap(choplength * table[0].Count*10, table.Count * 21);
            Graphics gfx = Graphics.FromImage(bitmap);
            int colint = 0;
            foreach(List<string> line in table)
            {
                string todraw = "|";
                foreach(string col in line)
                {
                    todraw += col + "|";
                }
                gfx.DrawString(todraw, new Font("Consolas", 10), Brushes.Black, new Rectangle(0,colint,bitmap.Width,bitmap.Height/table.Count));
                colint = colint + 21; 
            }
            this.Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetWidth_Click(object sender, EventArgs e)
        {
            try
            {
                choplength = int.Parse(ColWidthInput.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid integer", "TextStudio Insert Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
