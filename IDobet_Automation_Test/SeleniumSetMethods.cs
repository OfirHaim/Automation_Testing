using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;



namespace IDobet_Automation_Test
{
    static class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //Click into a button , Checkbox, Optin etc
        public static void Click(IWebElement element)
        {
            element.Click();
        }

        //Slecting a drop down control   
        public static void SlectDropDown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}