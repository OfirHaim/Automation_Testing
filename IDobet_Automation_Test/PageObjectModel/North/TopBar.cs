using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace IDobet_Automation_Test.PageObjectModel.north
{
    class TopBar
    {
        public TopBar()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }


        [FindsBy(How = How.XPath,Using = "/html/body/app/div/section/topbar/header/nav/ul/li[6]")][CacheLookup]
        public IWebElement Loginbtn { get; set; }


    }
}
