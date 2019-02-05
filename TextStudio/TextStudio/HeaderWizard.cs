using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextStudio
{
    class HeaderWizard
    {
        public string ShortDate
        {
            get
            {
                return DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
            }
        }

        public string LongDate
        {
            get
            {
                int m = DateTime.Now.Month;
                string month = "";
                if (m == 1)
                {
                    month = "January";
                }
                if(m == 2)
                {
                    month = "Febuary";
                }
                if(m == 3)
                {
                    month = "March";
                }
                if(m == 4)
                {
                    month = "April";
                }
                if(m == 5)
                {
                    month = "May";
                }
                if(m == 6)
                {
                    month = "June";
                }
                if(m == 7)
                {
                    month = "July";
                }
                if(m == 8)
                {
                    month = "August";
                }
                if(m == 9)
                {
                    month = "September";
                }
                if(m == 10)
                {
                    month = "October";
                }
                if(m == 11)
                {
                    month = "November";
                }
                if(m == 12)
                {
                    month = "December";
                }
                return month + ", " + DateTime.Now.Day + ", " + DateTime.Now.Year;
            }
        }

        public string name;
        public string classname;
        public int period;

        public HeaderWizard()
        {

        }

        public string MakeHeader(Format format)
        {
            if(format == Format.Standard)
            {
                return name + "\r\nPeriod " + period.ToString() + "\r\n"+ShortDate;
            }
            if(format == Format.Mla)
            {
                var firstn = name.Split(' ')[0];
                var lastn = name.Split(' ')[1];
                return lastn + ", " + firstn + "\r\nPeriod " + period.ToString() + "\r\n" + LongDate + "\r\n"+classname;
            }
            return "Invalid Format";
        }
    }
}
