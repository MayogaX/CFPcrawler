using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using CFPcrawler.SearchApis.Twitter;
using CFPcrawler.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CFPcrawler.SearchApis.Twitter.Test
{
    [TestClass]
    public class SearchTest
    {
        public SearchTest()
        {
            
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void Search_Anything_Return_Anything()
        {
            Search search = new Search();
            string result = search.Search();
            Assert.AreNotEqual(result, ResultTypes.ComplexQuery);
        }
    }
}
