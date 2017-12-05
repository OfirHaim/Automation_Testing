using IDobet_Automation_Test.Configiruation;
using IDobet_Automation_Test.Manager;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test
{
    public static class WebDriverExtension
    {
        //random but not repaet on the random
        public static void Shuffle<T>(this IList<T> list)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

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
            public static bool WaitUntilElementIsPresent(IWebDriver driver, By by, int timeout = 20)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                var elementDisplayd = wait.Until(d => d.FindElement(by)).Displayed;
                if (elementDisplayd)
                {
                    LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "Assert The element :" + by + " Is Displayed");
                }
                return elementDisplayd;
            }

            //Wait until the Element Disappear
            public static bool WaitUntilElementIsHide(By by, int timeout)
            {
                var wait = new WebDriverWait(TestConfigManager.Instance.driver, TimeSpan.FromSeconds(timeout));
                var elementIsPresent = wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
                if (!elementIsPresent)
                {
                    WaitUntilElementIsHide(by, timeout);
                }
                LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "Assert The element :" + by + " Disappear");
                return true;
            }

            //is Found the Element 
            public static bool IsFound(By by)
            {
                bool isFound = true;
                try
                {
                    TestConfigManager.Instance.driver.FindElement(by);
                }
                catch (NoSuchElementException)
                {
                    isFound = false;
                }
                return isFound;
            }

            public static class SeleniumGetMethods
            {
                ////Getting value out from Textbox
                public static string GetText(IWebElement element)
                {
                    return element.GetAttribute("value");
                }

                ////Getting value out from DropDown
                public static string GetTextFromDDL(IWebElement element)
                {
                    return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
                }
            }
        }
    }
}