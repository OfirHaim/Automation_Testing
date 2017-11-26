using IDobet_Automation_Test.Configiruation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.TestCases.Center
{
    class UpcomingOddTest
    {
        [SetUp]
        public void Init()
        {
            TestConfigManager.Instance.Initialize(ConfigurationManager.AppSettings["BrowserName"]);
        }

        [Test]
        public void chooseUpcomingEvent()
        {
            PageObjectManager.Instance.centerFireScrollBar.upcomingEvents.chooseupcomingEventOdd(); 
        }

        [TearDown]
        public void CleanUp()
        {
            // TestConfigManager.Instance.CleanUp(TestConfigManager.Instance.driver);
        }
    }
}
