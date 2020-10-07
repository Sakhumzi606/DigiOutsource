using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiOutsource.TestClass
{
    public class TestObjectsClass
    {
        public string pageHeader()
        {
            return "//h2[@jsname='smh91d']//a[contains(text(),'Headline')]";
        }
        public string headlinesXpath()
        {
            return "//div[@jscontroller='d0DtYd']//h3";
        }
        public string allheadlinesXpath()
        {
            return "//div[@jscontroller='d0DtYd']//h3 | //div[@jslog='93789']//h3";
        }
        public string headlines2Xpath()
        {
            return "//div[@jslog='93789']//h3";
        }
        public string headlinesXpath(int headlineNo)
        {
            return "//div[@jsname='esK7Lc']/div[" + headlineNo + "][@jscontroller='d0DtYd']//h3";
        }
        public string headlines2Xpath(int headlineNo)
        {
            return "//div[@jsname='esK7Lc']/div[" + headlineNo + "][@jslog='93789']//h3";
        }
        
        //BetwayElements
        public string modalContentDivXpath()
        {
            return "//div[@class = 'modal fade in'][contains(@style, 'display: block')]/div";
        }
        public string modalSignUpButtonXpath()
        {
            return "//div[@class = 'modal fade in'][contains(@style, 'display: block')]//div/a[contains(text(),'Sign Up')]";
        }
        public string signUpModalXpath()
        {
            return "//div[@id ='SignUpModal'][contains(@style, 'display: block')]";
        }
        public string signUpModalMobileNumberXpath()
        {
            return "//div[@id ='SignUpModal'][contains(@style, 'display: block')]//input[@id='MobileNumber_tmpl']";
        }
        public string signUpModalPasswordXpath()
        {
            return "//div[@id ='SignUpModal'][contains(@style, 'display: block')]//input[@id='Password_tmpl']";
        }
        public string signUpModalFirstnameXpath()
        {
            return "//div[@id ='SignUpModal'][contains(@style, 'display: block')]//input[@id='FirstName_tmpl']";
        }
        public string signUpModalLastNameXpath()
        {
            return "//div[@id ='SignUpModal'][contains(@style, 'display: block')]//input[@id='LastName_tmpl']";
        }
        public string signUpModalEmailXpath()
        {
            return "//div[@id ='SignUpModal'][contains(@style, 'display: block')]//input[@id='Email_tmpl']";
        }
        public string signUpModalNextButtonXpath()
        {
            return "//div[@id ='SignUpModal'][contains(@style, 'display: block')]//button[@id = 'nxtBtn']";
        }
        public string signUpModalIdTypeXpath()
        {
            return "//div[@id ='SignUpModal'][contains(@style, 'display: block')]//Select[@id = 'IDType_tmpl']";
        }
        public string signUpModalIdTypeXpath(string IdType)
        {
            return "//div[@id ='SignUpModal'][contains(@style, 'display: block')]//select/option[contains(text(),'" + IdType + "')]";
        }
        public string signUpModalIDNumberXpath()
        {
            return "//div[@id ='SignUpModal'][contains(@style, 'display: block')]//input[@id='IDNumber_tmpl']";
        }
        public string signUpModalDayXpath()
        {
            return "//div[@id ='SignUpModal'][contains(@style, 'display: block')]//Select[@id = 'Template_TemplateFieldModels_13__Value_Day']";
        }
        public string signUpModalDayXpath(string day)
        {
            return "//select[@id ='Template_TemplateFieldModels_13__Value_Day']/option[@value='" + day + "')]";
        }
        public string signUpModalMonthXpath()
        {
            return "//div[@id ='SignUpModal'][contains(@style, 'display: block')]//Select[@id = 'Template_TemplateFieldModels_13__Value_Month']";
        }
        public string signUpModalMonthXpath(string Month)
        {
            return "//select[@id ='Template_TemplateFieldModels_13__Value_Month']/option[@value='" + Month + "')]";
        }
        public string signUpModalYearXpath()
        {
            return "//div[@id ='SignUpModal'][contains(@style, 'display: block')]//Select[@id = 'Template_TemplateFieldModels_13__Value_Year']";
        }
        public string signUpModalYearXpath(string Year)
        {
            return "//select[@id ='Template_TemplateFieldModels_13__Value_Year']/option[@value='" + Year + "')]";
        }
        public string signUpModalSalaryXpath()
        {
            return "//div[@id ='SignUpModal'][contains(@style, 'display: block')]//Select[@id = 'SourceOfFunds_tmpl']";
        }
        public string signUpModalSalaryXpath(string Salary)
        {
            return "//select[@id ='SourceOfFunds_tmpl']/option[contains(text(),'" + Salary + "')]";
        }
        public string signUpModalImOver18CheckboxXpath()
        {
            return "//div[@id ='SignUpModal'][contains(@style, 'display: block')]//input[@id='ConfirmAge_tmpl']";
        }
        public string signUpRegisterButtonxpath()
        {
            return "//button[@id = 'regBtn']";
        }
    }
}
