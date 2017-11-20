using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Configuration;

namespace IDobet_Automation_Test.PageObjectModel.North
{
    class TopBar
    {
        public LoginPageObject loginPageObject { get; set; }
        public RegisterPageObject registerPageObject { get; set; }

        public TopBar()
        {
            loginPageObject = new LoginPageObject();
            registerPageObject = new RegisterPageObject();
            PageFactory.InitElements(PropertiesCollection.driver, this);
            PageFactory.InitElements(PropertiesCollection.driver, loginPageObject);
            PageFactory.InitElements(PropertiesCollection.driver, registerPageObject);
        }
    }
}
