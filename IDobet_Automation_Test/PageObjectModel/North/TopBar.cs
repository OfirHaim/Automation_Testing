using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace IDobet_Automation_Test.PageObjectModel.north
{
    class TopBar
    {
        public TopBar()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        #region  LoginPgObject
        /******************************************************************************
                                    LoginPgObject
        *******************************************************************************/
        //login click
        [FindsBy(How = How.CssSelector, Using = "nav.main-menu li:last-child a span")]
            public IWebElement Loginbtn { get; set; }

            [FindsBy(How = How.CssSelector, Using = ".login-modal form input[type=email]")]
            public IWebElement InputEmail { get; set; }

            [FindsBy(How = How.CssSelector, Using = ".login-modal form input[type=password]")]
            public IWebElement InputPassword { get; set; }

            [FindsBy(How = How.CssSelector, Using = ".login-modal form .button-row button")]
            public IWebElement ClickLogin { get; set; }

        /******************************************************************************
                                     LoginPgObject
        *******************************************************************************/
        #endregion

        #region RegisterPgObject
        /******************************************************************************
                                     RegisterPgObject
        *******************************************************************************/
        //login click
        [FindsBy(How = How.CssSelector, Using = "nav.main-menu li:last-child a span")]
        public IWebElement Loginbtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".login-modal form input[type=email]")]
        public IWebElement InputEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".login-modal form input[type=password]")]
        public IWebElement InputPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".login-modal form .button-row button")]
        public IWebElement ClickLogin { get; set; }

        /******************************************************************************
                                LoginPgObject
        *******************************************************************************/
        #endregion
    }
}
