using IDobet_Automation_Test.Configiruation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.TestCases.TestBae
{
    class PlaceBetTestcs
    {
        [SetUp]
        public void Init()
        {
            TestConfigManager.Instance.Initialize(ConfigurationManager.AppSettings["BrowserName"]);
            PageObjectManager.Instance.mainNorth_InitClasses.loginPage.login(ConfigurationManager.AppSettings["username"], ConfigurationManager.AppSettings["password"]);
        }

        [Test]
        public void ComboPlaceBetTest()
        {
            PageObjectManager.Instance.mainCenter_InitClasses.liveEvents.chooseLiveOdd();
            PageObjectManager.Instance.mainCenter_InitClasses.topEvents.chooseTopeventOdd();
            PageObjectManager.Instance.mainCenter_InitClasses.upcomingEvents.chooseupcomingEventOdd();
            PageObjectManager.Instance.mainEast_Initclasses.betSlip.placeBet(ConfigurationManager.AppSettings["ComboAmount"]);
        }

        [Test]
        public void UpCommingPlaceBetTest()
        {
            PageObjectManager.Instance.mainCenter_InitClasses.upcomingEvents.chooseupcomingEventOdd();
            PageObjectManager.Instance.mainEast_Initclasses.betSlip.placeBet(ConfigurationManager.AppSettings["ComboAmount"]);
        }

        [Test]
        public void TopEventPlaceBetTest()
        {
            PageObjectManager.Instance.mainCenter_InitClasses.topEvents.chooseTopeventOdd();
            PageObjectManager.Instance.mainEast_Initclasses.betSlip.placeBet(ConfigurationManager.AppSettings["ComboAmount"]);
        }

        [Test]
        public void LivePlaceBetTest()
        {
            PageObjectManager.Instance.mainCenter_InitClasses.topEvents.chooseTopeventOdd();
            PageObjectManager.Instance.mainEast_Initclasses.betSlip.placeBet(ConfigurationManager.AppSettings["ComboAmount"]);
        }

        [TearDown]
        public void CleanUp()
        {
            TestConfigManager.Instance.CleanUp(TestConfigManager.Instance.driver);
        }
    }
}
