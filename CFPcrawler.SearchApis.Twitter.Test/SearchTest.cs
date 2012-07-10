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

        Dictionary<String, String> result = new Dictionary<String, String>();
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
        public void Search_And_Not_Return_Complex_Error()
        {
            result.Add("error", "Sorry, your query is too complex. Please reduce complexity and try again.");
            Search search = new Search();
            Assert.AreNotEqual(result, search.SearchAll());
        }

        [TestMethod]
        public void Search_And_Not_Return_420_Error()
        {
            result.Add("error", "You have been rate limited. Enhance your calm.");
            Search search = new Search();
            Assert.AreNotEqual(result, search.SearchAll());
        }
    }
}
