using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TextStudio
{
    public partial class ResearchHelper : Form
    {
        List<string> results;
        public ResearchHelper()
        {
            InitializeComponent();
            results = new List<string>();
            SearchEngine.Items.Add("https://www.google.com/search?q=");
            SearchEngine.Items.Add("https://duckduckgo.com/?q=");
            SearchEngine.Items.Add("https://www.bing.com/search?q=");
            SearchEngine.Items.Add("https://search.yahoo.com/search?p=");
            SearchEngine.SelectedItem = "https://www.google.com/search?q=";
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                WebBrowser WebBrowser = new WebBrowser();
                WebBrowser.Navigate(SearchEngine.SelectedItem + Input.Text);
                WebBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
            }
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            PutIntoReaderMode((WebBrowser)sender);
        }

        public void PutIntoReaderMode(WebBrowser webBrowser)
        {
            HtmlDocument doc = webBrowser.Document;
            Output.Text = "Results:";
            results = new List<string>();
            foreach(HtmlElement link in doc.Links)
            {
                Output.Text += "\r\n\r\n"+link.GetAttribute("href")+"";
                results.Add(link.GetAttribute("href"));
            }
        }

        private void Input2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                {
                Output.Text = "Results:";
                foreach(string result in results)
                {
                    if(result.Contains(Input2.Text))
                    {
                        Output.Text += "\r\n\r\n" + result + "";
                    }
                }
            }
        }
    }
}
