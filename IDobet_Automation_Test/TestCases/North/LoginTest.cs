using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IDobet_Automation_Test.Configiruation;
using NUnit.Framework;
using static IDobet_Automation_Test.Manager.BrowsersFactory;

namespace IDobet_Automation_Test.TestCases.North
{
    [TestFixture]
    public class Login
    {
        [SetUp]
        public void Init()
        {
            TestConfigManager.Instance.Initialize(ConfigurationManager.AppSettings["BrowserName"]);
        }

        [Test]
        public void loginTest()
        {
            PageObjectManager.Instance.topBar.loginPage.Login(ConfigurationManager.AppSettings["username"],ConfigurationManager.AppSettings["password"]);
        }

        [TearDown]
        public void CleanUp()
        {
            TestConfigManager.Instance.CleanUp(TestConfigManager.Instance.driver);
        }
    }
}
