using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigiOutsource.TestClass;


namespace DigiOutsource
{
    [TestClass]
    public class T01_RegisterNewBetwayAccount
    {
        TestScenariosClass runTests;

        [TestMethod]
        public void runRegisterNewBetwayAccountTest()
        {
            runTests = new TestScenariosClass("BetWayRegistration", "https://www.betway.co.za");
            runTests.RunTests();
        }
    }
}
