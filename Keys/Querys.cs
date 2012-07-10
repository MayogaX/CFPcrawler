using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFPcrawler.Helper
{
    public class Querys
    {
        public List<String> getTwitterQueys()
        {
            List<String> querys = new List<string>();
            querys.Add("call for paper");
            querys.Add("keynote");
            querys.Add("subimit your paper");

            return querys;
        }
    }
}
