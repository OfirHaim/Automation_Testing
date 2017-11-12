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

        public static string GetText(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "id")
                return driver.FindElement(By.Id(element)).Text;
            if (elementtype == "name")
                return driver.FindElement(By.Name(element)).Text;
            else return string.Empty;
        }

    }
}
