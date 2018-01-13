using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium;
using System.Configuration;
using IDobet_Automation_Test.Configiruation;
using IDobet_Automation_Test.Manager;

namespace IDobet_Automation_Test.PageObjectModel.MainView.North
{
    public class Login
    {
        #region LoginPageObject
        /******************************************************************************
                                LoginPage
        *******************************************************************************/
        //click on login button from the topbar
        [FindsBy(How = How.CssSelector, Using = "nav.main-menu li:last-child a span")]
        private IWebElement loginbtn { get; set; }

        //enter email addres to input fild
        [FindsBy(How = How.CssSelector, Using = ".login-modal form input[type=email]")]
        private IWebElement loginInputEmail { get; set; }

        //enter Password  to input fild
        [FindsBy(How = How.CssSelector, Using = ".login-modal form input[type=password]")]
        private IWebElement loginInputPassword { get; set; }

        //click on login button from login popup
        [FindsBy(How = How.CssSelector, Using = ".login-modal form .button-row button")]
        private IWebElement loginPopupBtn { get; set; }
        #endregion

        #region LoginPageMethod
        /******************************************************************************
                                     LoginPageMethod
        *******************************************************************************/

        private void clickOnLoginTopBar()
        {
            loginbtn.Click();
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug,"click on login button from the topbar");
        }
        private void enterUserName(string userName)
        {
            loginInputEmail.SendKeys(userName);
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "enter the  email: "+ userName + " to input field");
        }
        private void enterPassword(string password)
        {
            loginInputPassword.SendKeys(password);
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "enter Password: " +password+" to input field");
        }
        private void clickLogin()
        {
            loginPopupBtn.Click();
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "click on login button from login popup");
        }
        public void login(string userName, string password)
        {
            TestConfigManager.Instance.assertBefore(By.XPath("/html/body/app/div/section/topbar/header/nav/ul/li[6]/a"));
            this.clickOnLoginTopBar();
            this.enterUserName(userName);
            this.enterPassword(password);
            this.clickLogin();
            TestConfigManager.Instance.assertAfter(By.ClassName("user-menu"));
        }
        #endregion
    }
}
