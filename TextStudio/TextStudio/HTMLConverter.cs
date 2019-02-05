using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextStudio
{
    class HTMLConverter
    {
        public HTMLConverter()
        {

        }

        public string ToHtmlDocument(string name,RichTextBox Editor)
        {
            char c = '"';
            string toret = "<html><head><title>"+name+"</title></head><body style = "+c+"font-family: '"+Editor.Font.FontFamily.Name+"' font-size: "+Editor.Font.Size+"px"+c+">"+Editor.Text+"</body></html>";
            return toret;
        }
    }
}
