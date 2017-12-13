using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Configuration;

namespace IDobet_Automation_Test.PageObjectModel.ExternalPages
{
    public class External_InitClasses
    {
        public TempMail tempMail { get; set; }

        public External_InitClasses(IWebDriver driver)
        {
            tempMail = new TempMail();

            PageFactory.InitElements(driver, this);
            PageFactory.InitElements(driver, tempMail);
        }
    }
}
