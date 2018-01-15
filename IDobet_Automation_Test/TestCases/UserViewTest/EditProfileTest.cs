using IDobet_Automation_Test.Configiruation;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.TestCases.UserViewTest
{
    [TestFixture]
    public class EditProfileTest
    {
        [SetUp]
        public void Init()
        {
            TestConfigManager.Instance.Initialize(ConfigurationManager.AppSettings["BrowserName"]);
            PageObjectManager.Instance.mainNorth_InitClasses.loginPage.login(ConfigurationManager.AppSettings["username"], ConfigurationManager.AppSettings["password"]);
            PageObjectManager.Instance.mainNorth_InitClasses.mybets.clickMyBets();
        }

        [Test]
        public void editProfileTest()
        {
            PageObjectManager.Instance.userWest_InitClasses.userMenu.clickEditProfile();
            PageObjectManager.Instance.userCenter_InitClasses.editProfilePage.changePassword("1q2w3e4r", "1q2w3e4r", "1q2w3e4r");
        }

        [TearDown]
        public void CleanUp()
        {
            TestConfigManager.Instance.CleanUp(TestConfigManager.Instance.driver);
        }
    }
}
