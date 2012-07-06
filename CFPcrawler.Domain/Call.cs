using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFPcrawler.Domain
{
    public class Call
    {
        private int _id;
        private string _fair;
        private DateTime _date;
        private string _mainTopic;
        private string _url;
        private string _country;
        private bool _open;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Fair
        {
            get { return _fair; }
            set { _fair = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string MainTopic
        {
            get { return _mainTopic; }
            set { _mainTopic = value; }
        }
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public bool Open
        {
            get { return _open; }
            set { _open = value; }
        }
    }
}
