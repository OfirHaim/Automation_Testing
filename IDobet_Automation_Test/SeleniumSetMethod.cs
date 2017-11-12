using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace IDobet_Automation_Test
{
    class SeleniumSetMethod
    {
        //Enter Text
        public static void EnterText(IWebDriver driver,string element, string value, string elementtype)
        {
            if(elementtype == "id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Click into a button , Checkbox, Optin etc
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
        }

        //Slecting a drop down control
        public static void SlectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);

            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
