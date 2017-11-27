using IDobet_Automation_Test.PageObjectModel.east;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.PageObjectModel.East
{
    public class EastFireScrollBar
    {
        public BetSlip betSlip { get; set; }

        public EastFireScrollBar(IWebDriver driver)
        {
            betSlip = new BetSlip();
            PageFactory.InitElements(driver, this);
            PageFactory.InitElements(driver, betSlip);
        }
    }
}
