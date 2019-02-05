using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextStudio
{
    public enum Format
    {
        Apa,
        Mla,
        Standard
    }
    
    public class Source
    {
        public string title;
        public string firstnameauthor;
        public string lastnameauthor;
        public string fullnameauthor;
        public string url;
        public string datepublished;
        public string yearpublished;
        public string monthpublished;
        public string daypublished;
        public string publisher;

        public static Source Parse(string text)
        {
            //title,author,url,date published
            string[] args = text.Split(',');
            return new Source(args[0], args[1], args[2], args[3],args[3]);
        }

        public Source(string title, string author,string url, string datepublished,string publisher)
        {
            this.title = title;
            this.url = url;
            this.publisher = publisher;
            this.fullnameauthor = author;
            this.firstnameauthor = author.Split(' ')[0];
            this.lastnameauthor = author.Split(' ')[1];
            this.datepublished = datepublished;
            this.monthpublished = datepublished.Split('/')[0];
            this.daypublished = datepublished.Split('/')[1];
            this.yearpublished = datepublished.Split('/')[2];
        }

        public string Cite(Format format)
        {
            int m = int.Parse(monthpublished);
            string month = "";
            if (m == 1)
            {
                month = "January";
            }
            if (m == 2)
            {
                month = "Febuary";
            }
            if (m == 3)
            {
                month = "March";
            }
            if (m == 4)
            {
                month = "April";
            }
            if (m == 5)
            {
                month = "May";
            }
            if (m == 6)
            {
                month = "June";
            }
            if (m == 7)
            {
                month = "July";
            }
            if (m == 8)
            {
                month = "August";
            }
            if (m == 9)
            {
                month = "September";
            }
            if (m == 10)
            {
                month = "October";
            }
            if (m == 11)
            {
                month = "November";
            }
            if (m == 12)
            {
                month = "December";
            }
            if (format == Format.Apa)
            {
                return lastnameauthor + ", " + firstnameauthor[0] + ". (" + yearpublished + ", " + month + ", " + daypublished + ") " + title + ". Retrieved from " + url;
            }
            else if(format == Format.Mla)
            {
                return lastnameauthor+", "+firstnameauthor + ". '"+title+"'. "+publisher+". Published "+daypublished+", "+month+", "+yearpublished+ ". Retrieved from "+url;
            }
            else if(format == Format.Standard)
            {
                return url;
            }
            else
            {
                return "No format";
            }
        }
    }

    class BibliographyWizard
    {
        public List<Source> sources;
        public BibliographyWizard()
        {
            sources = new List<Source>();
        }

        public void Cite(RichTextBox editor,Format format)
        {
            string toappend = "Bibliography";
            foreach(Source source in sources)
            {
                toappend += "\r\n\r\n"+source.Cite(format);
            }
            editor.AppendText(toappend);
        }
    }
}
