using IDobet_Automation_Test.Configiruation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.TestCases.East
{
    class PlaceBetTestcs
    {
        [SetUp]
        public void Init()
        {
            TestConfigManager.Instance.Initialize(ConfigurationManager.AppSettings["BrowserName"]);
            PageObjectManager.Instance.topBar.loginPage.Login(ConfigurationManager.AppSettings["username"], ConfigurationManager.AppSettings["password"]);
        }

        [Test]
        public void ComboPlaceBetTest()
        {
            PageObjectManager.Instance.centerFireScrollBar.liveEvents.chooseLiveOdd();
            PageObjectManager.Instance.centerFireScrollBar.topEvents.chooseTopeventOdd();
            PageObjectManager.Instance.centerFireScrollBar.upcomingEvents.chooseupcomingEventOdd();
            PageObjectManager.Instance.eastFireScrollBar.betSlip.placeBet(ConfigurationManager.AppSettings["ComboAmount"]);
        }

        [Test]
        public void UpCommingPlaceBetTest()
        {
            PageObjectManager.Instance.centerFireScrollBar.upcomingEvents.chooseupcomingEventOdd();
            PageObjectManager.Instance.eastFireScrollBar.betSlip.placeBet(ConfigurationManager.AppSettings["ComboAmount"]);
        }

        [Test]
        public void TopEventPlaceBetTest()
        {
            PageObjectManager.Instance.centerFireScrollBar.topEvents.chooseTopeventOdd();
            PageObjectManager.Instance.eastFireScrollBar.betSlip.placeBet(ConfigurationManager.AppSettings["ComboAmount"]);
        }

        [Test]
        public void LivePlaceBetTest()
        {
            PageObjectManager.Instance.centerFireScrollBar.topEvents.chooseTopeventOdd();
            PageObjectManager.Instance.eastFireScrollBar.betSlip.placeBet(ConfigurationManager.AppSettings["ComboAmount"]);
        }

        [TearDown]
        public void CleanUp()
        {
            TestConfigManager.Instance.CleanUp(TestConfigManager.Instance.driver);
        }
    }
}
