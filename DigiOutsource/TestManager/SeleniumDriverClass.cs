using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace DigiOutsource.TestManager
{
    public class SeleniumDriverClass
    {
        IWebDriver Driver = null;
        bool DriverRunning = false;


        public SeleniumDriverClass()
        { }

        public IWebDriver StartDriver(string TestUrl)
        {
            Driver = new ChromeDriver();
            DriverRunning = true;

            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(TestUrl);

            return Driver;
        }
        public bool isDriverRunning()
        {
            return DriverRunning;
        }
        public void ShutDown()
        {
            try
            {
                if (isDriverRunning())
                {
                    Driver.Close(); 
                }
            }
            catch (Exception )
            {
            }
            DriverRunning = false;
        }

        public bool ClickElementById(string elementId) 
        {
            try
            {
                Thread.Sleep(1000);
                Driver.FindElement(By.Id(elementId)).Click();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ClickElementByXpath(string elementXpath)
        {
            try
            {
                Thread.Sleep(1000);
                Driver.FindElement(By.XPath(elementXpath)).Click();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EnterTextById(string elementId,string textToEnter) 
        {
            try
            {
                Thread.Sleep(1000);
                Driver.FindElement(By.Id(elementId)).Clear();
                Driver.FindElement(By.Id(elementId)).SendKeys(textToEnter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }
        public bool EnterTextByXpath(string elementXpath, string textToEnter)
        {
            try
            {
                Thread.Sleep(1000);
                Driver.FindElement(By.XPath(elementXpath)).Clear();
                Driver.FindElement(By.XPath(elementXpath)).SendKeys(textToEnter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public string getElementText(string elementXpath)
        {
            try
            {
                Thread.Sleep(2000);
                elementXpath = Driver.FindElement(By.XPath(elementXpath)).Text;
            }
            catch(Exception)
            {
                
            }

            return elementXpath;
        }

        public int getNumberOfElementsByXpath(string elementXpath)
        {
            int number = 0;
            try
            {
                number = Driver.FindElements(By.XPath(elementXpath)).Count;

            }
            catch (Exception)
            {
            }

            return number;
        }

        public bool waitForElementByXpath(String elementXpath)
        {
            bool elementFound = false;
            try
            {
                int waitCount = 0;
                while (!elementFound && waitCount < 5000)
                {
                    try
                    {
                        Driver.FindElement(By.XPath(elementXpath));
                        elementFound = true;
                        break;
                    }
                    catch (Exception)
                    {
                        elementFound = false;
                    }
                    Thread.Sleep(500);
                    waitCount++;
                }
            }
            catch (Exception)
            {
            }
            return elementFound;
        }
        public bool waitForElementByXpathWithTimer(String elementXpath,int timer)
        {
            bool elementFound = false;
            try
            {
                int waitCount = 0;
                while (!elementFound && waitCount < timer)
                {
                    try
                    {
                        Driver.FindElement(By.XPath(elementXpath));
                        elementFound = true;
                        break;
                    }
                    catch (Exception)
                    {
                        elementFound = false;
                    }
                    Thread.Sleep(500);
                    waitCount++;
                }
            }
            catch (Exception)
            {
            }
            return elementFound;
        }
    }
}
