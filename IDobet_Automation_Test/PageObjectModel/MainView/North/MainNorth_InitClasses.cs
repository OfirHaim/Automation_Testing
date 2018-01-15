using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Configuration;

namespace IDobet_Automation_Test.PageObjectModel.MainView.North
{
    public class MainNorth_InitClasses
    {
        public Login loginPage { get; set; }
        public RegistePager registerPage { get; set; }
        public MyBets mybets { get; set; }

        public MainNorth_InitClasses(IWebDriver driver)
        {
            loginPage = new Login();
            registerPage = new RegistePager();
            mybets = new MyBets();
            PageFactory.InitElements(driver, this);
            PageFactory.InitElements(driver, loginPage);
            PageFactory.InitElements(driver, registerPage);
            PageFactory.InitElements(driver, mybets);
        }
    }
}
