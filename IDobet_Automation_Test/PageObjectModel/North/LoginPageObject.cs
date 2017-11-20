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
    internal class LoginPageObject
    {
        #region LoginPageObject
        /******************************************************************************
                            LoginPageObject
        *******************************************************************************/
        //click on login button from the topbar
        [FindsBy(How = How.CssSelector, Using = "nav.main-menu li:last-child a span")]
        private IWebElement Loginbtn { get; set; }

        //enter email addres to input fild
        [FindsBy(How = How.CssSelector, Using = ".login-modal form input[type=email]")]
        private IWebElement LoginInputEmail { get; set; }

        //enter Password  to input fild
        [FindsBy(How = How.CssSelector, Using = ".login-modal form input[type=password]")]
        private IWebElement LoginInputPassword { get; set; }

        //click on login button from login popup
        [FindsBy(How = How.CssSelector, Using = ".login-modal form .button-row button")]
        private IWebElement LoginPopupBtn{ get; set; }
        #endregion

        #region LoginPageMethod
        /******************************************************************************
                                     LoginPageMethod
        *******************************************************************************/
        public void ClickOnloginTopBar()
        {
            Loginbtn.Click();
        }
        public void EnterUserName()
        {
            LoginInputEmail.SendKeys(ConfigurationManager.AppSettings["username"]);
        }
        public void EnterPassword()
        {
            LoginInputPassword.SendKeys(ConfigurationManager.AppSettings["password"]);
        }
        public void Clicklogin()
        {
            LoginPopupBtn.Click();
        }
        #endregion
    }
}
