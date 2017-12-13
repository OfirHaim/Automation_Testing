using IDobet_Automation_Test.Configiruation;
using IDobet_Automation_Test.Manager;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IDobet_Automation_Test.Manager.BrowsersFactory;

namespace IDobet_Automation_Test.TestCases.North
{
    class RegisterTest
    {
        [SetUp]
        public void Init()
        {
            TestConfigManager.Instance.Initialize(ConfigurationManager.AppSettings["BrowserName"]);
            BrowsersFactory.Instance.OpenNewTab();
            PageObjectManager.Instance.external_InitClasses.tempMail.GetMail();
        }

        [Test]
        public static void RegisterTests()
        {
            PageObjectManager.Instance.north_InitClasses.registerPage.Register(
                PageObjectManager.Instance.external_InitClasses.tempMail.email,
                ConfigurationManager.AppSettings["Password"],
                ConfigurationManager.AppSettings["Promtion"]);
            TestConfigManager.Instance.driver.SwitchTo().Window(BrowsersFactory.Instance.newTabInstance);
            PageObjectManager.Instance.external_InitClasses.tempMail.WaitToEmail();
        }

        [TearDown]
        public void CleanUp()
        {
            TestConfigManager.Instance.CleanUp(TestConfigManager.Instance.driver);
        }
    }
}
