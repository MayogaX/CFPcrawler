using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using CFPcrawler.Helper;

namespace CFPcrawler.SearchApis.Twitter
{
    public class Search
    {
        public Dictionary<String,String> SearchAll()
        {
            Dictionary<String, String> teste = new Dictionary<string, string>();

            Querys querys = new Querys();
            foreach (String query in querys.getTwitterQueys())
            {

            }

            return teste;
        }
    }
}
