using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test
{
    class SeleniumGetMethods
    {
        
        ////Getting value out from Textbox
        public static string GetText(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                return driver.FindElement(By.Id(element)).Text;
            if (elementtype == "Name")
                return driver.FindElement(By.Name(element)).Text;
            if (elementtype == "Class")
                return driver.FindElement(By.ClassName(element)).Text;
            else return string.Empty;
        }
    }
}  