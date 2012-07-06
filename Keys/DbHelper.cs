using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFPcrawler.Keys
{
    public class DbHelper
    {
        public static string ConectionString
        {
            get
            {
#if DEBUG
                return "put here";
#else
                return "put here";
#endif
            }
        }
    }
}
