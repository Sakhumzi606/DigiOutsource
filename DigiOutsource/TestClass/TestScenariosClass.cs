using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DigiOutsource.TestManager;
using DigiOutsource.TestClass;

namespace DigiOutsource.TestClass
{
    public class TestScenariosClass
    {
        TestResults Results;
        List<string> testInformation = new List<string>();
        TestReportGenerator Report;
        SeleniumDriverClass SelDriver;
        TestObjectsClass testObjects;
        string testURL;
        string testName;

        public TestScenariosClass(string testName, string testURL)
        {
            SelDriver = new SeleniumDriverClass();
            testObjects = new TestObjectsClass();
            this.testURL = testURL;
            this.testName = testName;
        }

        public void RunTests()
        {
            //loadtestData

            if (testName == "PrintHeadlines")
            {
                this.EnsureNewBrowserInstance();
                if (getAllNewsHeadlines())
                {
                    Results = new TestResults("Print Headlines", "Pass", "Go to http://news.google.com/ and print out all the headlines displayed on the page.", testInformation);
                }
                else
                {
                    Results = new TestResults("Print Headlines", "Fail", "Go to http://news.google.com/ and print out all the headlines displayed on the page.", testInformation);
                }
                Report = new TestReportGenerator(Results);
                Report.generateTestReport();
                SelDriver.ShutDown();
            }
            else if (testName == "BetWayRegistration")
            {
                this.EnsureNewBrowserInstance();
                if (CaptureRegistrationDetails())
                {
                    Results = new TestResults("Betway Account Registration", "Pass", "Go to https://www.betway.co.za and complete a full Registration form on the site.", testInformation);
                }
                else
                {
                    Results = new TestResults("Betway Account Registration", "Fail", "Go to https://www.betway.co.za and complete a full Registration form on the site.", testInformation);
                }
                Report = new TestReportGenerator(Results);
                Report.generateTestReport();
                SelDriver.ShutDown();
            }
        }


        /// <summary>
        /// Test Scenarios
        /// </summary>

        public bool getAllNewsHeadlines()
        {
            if (!SelDriver.waitForElementByXpath(testObjects.pageHeader()))
            {
                return false;
            }
            Thread.Sleep(5000);

            int headlinesCount = SelDriver.getNumberOfElementsByXpath(testObjects.allheadlinesXpath());

            if (headlinesCount > 0)
            {
                for (int i = 1; i < headlinesCount; i++)
                {
                    if (SelDriver.waitForElementByXpathWithTimer(testObjects.headlinesXpath(i), 5))
                    {
                        testInformation.Add(SelDriver.getElementText(testObjects.headlinesXpath(i)));
                    }
                    else if (SelDriver.waitForElementByXpathWithTimer(testObjects.headlines2Xpath(i), 5))
                    {
                        testInformation.Add(SelDriver.getElementText(testObjects.headlines2Xpath(i)));
                    }
                }
            }
            else
            {
                testInformation.Add("Headlines not found");
            }

            return true;
        }
        public bool CaptureRegistrationDetails()
        {
            if (SelDriver.waitForElementByXpath(testObjects.modalContentDivXpath()))
            {
                if (!SelDriver.waitForElementByXpath(testObjects.modalSignUpButtonXpath()))
                {
                    return false;
                }
                if (!SelDriver.ClickElementByXpath(testObjects.modalSignUpButtonXpath()))
                {
                    return false;
                }
                if (SelDriver.waitForElementByXpath(testObjects.signUpModalXpath()))
                {

                    //fill in registration form
                    if (!SelDriver.EnterTextByXpath(testObjects.signUpModalMobileNumberXpath(), "0637372971"))
                    {
                        return false;
                    }
                    if (!SelDriver.EnterTextByXpath(testObjects.signUpModalPasswordXpath(), "Password"))
                    {
                        return false;
                    }
                    if (!SelDriver.EnterTextByXpath(testObjects.signUpModalFirstnameXpath(), "James"))
                    {
                        return false;
                    }
                    if (!SelDriver.EnterTextByXpath(testObjects.signUpModalLastNameXpath(), "Dome"))
                    {
                        return false;
                    }
                    if (!SelDriver.EnterTextByXpath(testObjects.signUpModalEmailXpath(), "JamesDome@mail.com"))
                    {
                        return false;
                    }
                    if (!SelDriver.ClickElementByXpath(testObjects.signUpModalNextButtonXpath()))
                    {
                        return false;
                    }

                    if (SelDriver.waitForElementByXpath(testObjects.signUpRegisterButtonxpath()))
                    {
                        if (!SelDriver.ClickElementByXpath(testObjects.signUpModalIdTypeXpath()))
                        {
                            return false;
                        }
                        if (!SelDriver.ClickElementByXpath(testObjects.signUpModalIdTypeXpath("South African ID")))
                        {
                            return false;
                        }
                        if (!SelDriver.EnterTextByXpath(testObjects.signUpModalIDNumberXpath(), "7502265866085"))
                        {
                            return false;
                        }
                        ///day
                        //if (!SelDriver.ClickElementByXpath(testObjects.signUpModalDayXpath()))
                        //{
                        //    return false;
                        //}
                        //if (!SelDriver.ClickElementByXpath(testObjects.signUpModalDayXpath("26")))
                        //{
                        //    return false;
                        //}
                        /////month
                        //if (!SelDriver.ClickElementByXpath(testObjects.signUpModalMonthXpath()))
                        //{
                        //    return false;
                        //}
                        //if (!SelDriver.ClickElementByXpath(testObjects.signUpModalMonthXpath("January")))
                        //{
                        //    return false;
                        //}
                        /////year
                        //if (!SelDriver.ClickElementByXpath(testObjects.signUpModalYearXpath()))
                        //{
                        //    return false;
                        //}
                        //if (!SelDriver.ClickElementByXpath(testObjects.signUpModalYearXpath("February")))
                        //{
                        //    return false;
                        //}
                        ///salary
                        if (!SelDriver.ClickElementByXpath(testObjects.signUpModalSalaryXpath()))
                        {
                            return false;
                        }
                        if (!SelDriver.ClickElementByXpath(testObjects.signUpModalSalaryXpath("Wages")))
                        {
                            return false;
                        }

                        testInformation.Add("New Batway account created successfully");
                    }
                    else
                    {
                        testInformation.Add("SignUp Modal Page 2 not found");
                    }

                }
                else
                {
                    testInformation.Add("SignUp Modal not found");
                    return false;
                }
            }
            else
            {
                testInformation.Add("SignIn Modal not found");
                return false;
            }
            return true;

        }

        public void EnsureNewBrowserInstance()
        {
            if (SelDriver.isDriverRunning())
            {
                SelDriver.ShutDown();
            }

            SelDriver.StartDriver(testURL);
        }

    }
}
