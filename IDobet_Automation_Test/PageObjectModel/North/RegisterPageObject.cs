using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.PageObjectModel.North
{
    class RegisterPageObject
    {
        #region RegisterPageObject
        /******************************************************************************
                                RegisterPageObject
        *******************************************************************************/
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/section/topbar/header/nav/ul/li[5]")]
        private IWebElement RegisterButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".register-modal form input[type=email]")]
        private IWebElement InputEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app/div/onlinemodal/div[2]/registermodal/div/div[2]/form/div[1]/input[1]")]
        private IWebElement InputPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app/div/onlinemodal/div[2]/registermodal/div/div[2]/form/div[1]/input[2]")]
        private IWebElement ConfirimPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app/div/onlinemodal/div[2]/registermodal/div/div[2]/form/div[2]/input")]
        private IWebElement PromotionCode { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".register-modal form div.text-row noCaptcha input[type=checkbox]")]
        private IWebElement IAccept { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".register-modal form .button-row button[type=submit]")]
        private IWebElement ClickSignup { get; set; }
        #endregion
        
        #region RegisterPageMethod
        /******************************************************************************
                                RegisterPageMethod
        *******************************************************************************/
        public void ClickOnRegisterButtonTopBar()
        {
            RegisterButton.Click();
        }
        public void RegisterInputEmail()
        {
            InputEmail.SendKeys(ConfigurationManager.AppSettings["username"]);
        }
        public void RegisterInputPassword()
        {
            InputPassword.SendKeys(ConfigurationManager.AppSettings["password"]);
        }
        public void RegisterConfirimPassword()
        {
            ConfirimPassword.SendKeys(ConfigurationManager.AppSettings["password"]);
        }
        public void RegisterPromotionCode()
        {
            PromotionCode.SendKeys(ConfigurationManager.AppSettings["password"]);
        }
        public void RegisterIAccept()
        {
            IAccept.Click();
        }
        public void RegisterClickSignup()
        {
            ClickSignup.Click();
        }
        #endregion
    }
}
