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
            PageObjectManager.Instance.north_InitClasses.loginPage.Login(ConfigurationManager.AppSettings["username"], ConfigurationManager.AppSettings["password"]);
        }

        [Test]
        public void ComboPlaceBetTest()
        {
            PageObjectManager.Instance.center_InitClasses.liveEvents.chooseLiveOdd();
            PageObjectManager.Instance.center_InitClasses.topEvents.chooseTopeventOdd();
            PageObjectManager.Instance.center_InitClasses.upcomingEvents.chooseupcomingEventOdd();
            PageObjectManager.Instance.east_Initclasses.betSlip.placeBet(ConfigurationManager.AppSettings["ComboAmount"]);
        }

        [Test]
        public void UpCommingPlaceBetTest()
        {
            PageObjectManager.Instance.center_InitClasses.upcomingEvents.chooseupcomingEventOdd();
            PageObjectManager.Instance.east_Initclasses.betSlip.placeBet(ConfigurationManager.AppSettings["ComboAmount"]);
        }

        [Test]
        public void TopEventPlaceBetTest()
        {
            PageObjectManager.Instance.center_InitClasses.topEvents.chooseTopeventOdd();
            PageObjectManager.Instance.east_Initclasses.betSlip.placeBet(ConfigurationManager.AppSettings["ComboAmount"]);
        }

        [Test]
        public void LivePlaceBetTest()
        {
            PageObjectManager.Instance.center_InitClasses.topEvents.chooseTopeventOdd();
            PageObjectManager.Instance.east_Initclasses.betSlip.placeBet(ConfigurationManager.AppSettings["ComboAmount"]);
        }

        [TearDown]
        public void CleanUp()
        {
            TestConfigManager.Instance.CleanUp(TestConfigManager.Instance.driver);
        }
    }
}
