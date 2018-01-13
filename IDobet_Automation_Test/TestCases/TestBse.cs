//using IDobet_Automation_Test.Configiruation;
//using IDobet_Automation_Test.Manager;
//using NUnit.Framework;
//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace IDobet_Automation_Test.TestCases.TestBae
//{
//    [TestFixture]
//    public class TestBse
//    {
//        private class Login
//        {
//            [SetUp]
//            public void Init()
//            {
//                TestConfigManager.Instance.Initialize(ConfigurationManager.AppSettings["BrowserName"]);
//            }

//            [Test]
//            public void loginTest()
//            {
//                PageObjectManager.Instance.north_InitClasses.loginPage.Login(ConfigurationManager.AppSettings["username"], ConfigurationManager.AppSettings["password"]);
//            }

//            [TearDown]
//            public void CleanUp()
//            {
//                TestConfigManager.Instance.CleanUp(TestConfigManager.Instance.driver);
//            }
//        }

//        private class Register
//        {
//            [SetUp]
//            public void Init()
//            {
//                TestConfigManager.Instance.Initialize(ConfigurationManager.AppSettings["BrowserName"]);
//                PageObjectManager.Instance.external_InitClasses.tempMail.GetMail();
//            }

//            [Test]
//            public static void RegisterTests()
//            {
//                PageObjectManager.Instance.north_InitClasses.registerPage.Register(PageObjectManager.Instance.external_InitClasses.tempMail.email,
//                        ConfigurationManager.AppSettings["Password"],
//                        ConfigurationManager.AppSettings["Promtion"]);
//            }

//            [TearDown]
//            public void CleanUp()
//            {
//                TestConfigManager.Instance.CleanUp(TestConfigManager.Instance.driver);
//            }
//        }
//    }
//}
