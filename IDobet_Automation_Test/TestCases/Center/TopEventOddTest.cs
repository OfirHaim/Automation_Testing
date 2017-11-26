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
    class TopEventOddTest
    {
        [SetUp]
        public void Init()
        {
            TestConfigManager.Instance.Initialize(ConfigurationManager.AppSettings["BrowserName"]);
        }

        [Test]
        public void chooseTopEvent()
        {
            PageObjectManager.Instance.centerFireScrollBar.topEvents.chooseTopeventOdd();
        }

        [TearDown]
        public void CleanUp()
        {
            // TestConfigManager.Instance.CleanUp(TestConfigManager.Instance.driver);
        }
    }
}
