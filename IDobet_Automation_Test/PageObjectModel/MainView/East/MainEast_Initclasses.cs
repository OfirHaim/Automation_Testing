using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Configuration;

namespace IDobet_Automation_Test.PageObjectModel.MainView.East
{
    public class MainEast_Initclasses
    {
        public BetSlip betSlip { get; set; }

        public MainEast_Initclasses(IWebDriver driver)
        {
            betSlip = new BetSlip();
            PageFactory.InitElements(driver, this);
            PageFactory.InitElements(driver, betSlip);
        }
    }
}
