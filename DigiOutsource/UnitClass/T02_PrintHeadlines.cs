using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigiOutsource.TestClass;

namespace DigiOutsource
{
    [TestClass]
    public class T02_PrintHeadlines
    {
        TestScenariosClass runTests;

        [TestMethod]
        public void runPrintHeadlinesTest()
        {
            ////runTest 
            runTests = new TestScenariosClass("PrintHeadlines", "http://news.google.com/");
            runTests.RunTests();
        }
    }
}
