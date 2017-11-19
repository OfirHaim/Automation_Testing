using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        public static string GetText(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("Value");
            else if (elementtype == PropertyType.Name)
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("Value");
            else if(elementtype == PropertyType.ClassName)
                return PropertiesCollection.driver.FindElement(By.ClassName(element)).GetAttribute("Value");
            else return string.Empty;
        }
        public static string GetTextFromDDL(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            else if(elementtype == PropertyType.Name)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else if(elementtype == PropertyType.ClassName)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.ClassName(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return string.Empty;
        }
    }
}  