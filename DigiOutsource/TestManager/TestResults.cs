using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiOutsource.TestManager
{
    public class TestResults
    {
        string testName;
        string testResult;
        string testDescription;
        List<string> testInformation = new List<string>();


        public TestResults(string testName, string testResult, string testDescription, List<string> testInformation)
        {
            this.testName = testName; this.testInformation = testInformation;
            this.testResult = testResult; this.testDescription = testDescription;
        }

        public string TestName
        {
            get { return testName; }
            set { testName = value; }
        }
        public string TestResult
        {
            get { return testResult; }
            set { testResult = value; }
        }
        public string TestDescription
        {
            get { return testDescription; }
            set { testDescription = value; }
        }
        public List<string> TestInformation
        {
            get { return testInformation; }
            set { testInformation = value; }
        }
    }
}
