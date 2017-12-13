using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Configuration;

namespace IDobet_Automation_Test.PageObjectModel.Center
{
    public class Center_InitClasses
    {
        public LiveEvents liveEvents { get; set; }
        public TopEvents topEvents { get; set; }
        public UpcomingEvents upcomingEvents { get; set; }

        public Center_InitClasses(IWebDriver driver)
        {
            liveEvents = new LiveEvents();
            topEvents = new TopEvents();
            upcomingEvents = new UpcomingEvents();
            PageFactory.InitElements(driver, this);
            PageFactory.InitElements(driver, liveEvents);
            PageFactory.InitElements(driver, topEvents);
            PageFactory.InitElements(driver, upcomingEvents);
        }
    }
}
