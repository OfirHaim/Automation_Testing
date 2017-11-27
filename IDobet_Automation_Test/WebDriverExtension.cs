using IDobet_Automation_Test.Configiruation;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test
{
    public class WebDriverExtension
    {
        public static class SeleniumSetMethods
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

            //Wait until the element it preseent  
            public static bool WaitUntilElementIsPresent(IWebDriver driver, By by, int timeout = 10)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(d => d.FindElement(by)).Displayed;
            }
        }
        public static class SeleniumGetMethods
        {
            ////Getting value out from Textbox
            public static string GetText(IWebElement element)
            {
                return element.GetAttribute("value");
            }
            public static string GetTextFromDDL(IWebElement element)
            {
                return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
            }
        }
    }
}
