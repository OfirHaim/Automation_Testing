using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IDobet_Automation_Test.Configiruation;

namespace IDobet_Automation_Test.TestCases.North
{
    class Login
    {
        [SetUp]
        public void Init()
        {
            SetupConfiguration config = new SetupConfiguration();
            config.Initialize();
        }

        [Test]
        public void LoginTests()
        {
            PageObjectModel.North.TopBar Login = new PageObjectModel.North.TopBar();
            Login.loginPageObject.ClickOnloginTopBar();
            Login.loginPageObject.EnterUserName();
            Login.loginPageObject.EnterPassword();
            Login.loginPageObject.Clicklogin();
        }

        [Test]
        public void RegisterTests()
        {
            PageObjectModel.North.TopBar Register = new PageObjectModel.North.TopBar();
            Register.registerPageObject.ClickOnRegisterButtonTopBar();
            Register.registerPageObject.RegisterInputEmail();
            Register.registerPageObject.RegisterInputPassword();
            Register.registerPageObject.RegisterConfirimPassword();
            Register.registerPageObject.RegisterPromotionCode();
            Register.registerPageObject.RegisterClickSignup();
        }

        [TearDown]
        public void CleanUp()
        {
            //write to the console
            Console.WriteLine("CleanUp");

            //close the driver
            //PropertiesCollection.driver.Close();
        }
    }
}
