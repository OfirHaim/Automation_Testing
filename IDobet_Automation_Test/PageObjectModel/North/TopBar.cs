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
    public class TopBar
    {
        public LoginPage loginPage { get; set; }
        public RegisterPage registerPage { get; set; }
        public TempMail tempMail { get; set; }

        public TopBar(IWebDriver driver)
        {
            loginPage = new LoginPage();
            registerPage = new RegisterPage();
            tempMail = new TempMail();
            PageFactory.InitElements(driver, this);
            PageFactory.InitElements(driver, loginPage);
            PageFactory.InitElements(driver, registerPage);
            PageFactory.InitElements(driver, tempMail);
        }
    }
}
