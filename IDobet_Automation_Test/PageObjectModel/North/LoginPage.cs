using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Configuration;
using IDobet_Automation_Test.Configiruation;

namespace IDobet_Automation_Test.PageObjectModel.North
{
    public class LoginPage
    {
        #region LoginPageObject
        /******************************************************************************
                                LoginPage
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
        private IWebElement LoginPopupBtn { get; set; }
        #endregion

        #region LoginPageMethod
        /******************************************************************************
                                     LoginPageMethod
        *******************************************************************************/

        private void ClickOnloginTopBar()
        {
            Loginbtn.Click();
            Console.WriteLine("click on login button from the topbar");
        }
        private void EnterUserName(string userName)
        {
            LoginInputEmail.SendKeys(userName);
            Console.WriteLine("enter email address to input field");
        }
        private void EnterPassword(string password)
        {
            LoginInputPassword.SendKeys(password);
            Console.WriteLine("enter Password  to input field");
        }
        private void Clicklogin()
        {
            LoginPopupBtn.Click();
            Console.WriteLine("click on login button from login popup");
        }
        public void Login(string userName, string password)
        {
            TestConfigManager.Instance.assertBefore(By.XPath("/html/body/app/div/section/topbar/header/nav/ul/li[6]/a"));
            this.ClickOnloginTopBar();
            this.EnterUserName(userName);
            this.EnterPassword(password);
            this.Clicklogin();
            TestConfigManager.Instance.assertAfter(By.ClassName("user-sub-menu"));
        }
        #endregion
    }
}
