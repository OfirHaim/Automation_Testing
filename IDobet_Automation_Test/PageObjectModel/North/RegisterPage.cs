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
    public class RegisterPage
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

        [FindsBy(How = How.XPath, Using = "/html/body/app/div/onlinemodal/div[2]/registermodal/div/div[2]/form/div[3]/input")]
        private IWebElement IAccept { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".register-modal form .button-row button[type=submit]")]
        private IWebElement ClickSignup { get; set; }
        #endregion

        #region RegisterPageMethod
        /******************************************************************************
                                RegisterPageMethod
        *******************************************************************************/
        private void ClickOnRegisterButtonTopBar()
        {
            RegisterButton.Click();
        }
        private void RegisterInputEmail(string username)
        {
            InputEmail.SendKeys(username);
        }
        private void RegisterInputPassword(string password)
        {
            InputPassword.SendKeys(password);
        }
        private void RegisterConfirimPassword(string password)
        {
            ConfirimPassword.SendKeys(password);
        }
        private void RegisterPromotionCode(string promtionCode)
        {
            PromotionCode.SendKeys(promtionCode);
        }
        private void RegisterIAccept()
        {
            IAccept.Click();
        }
        private void RegisterClickSignup()
        {
            ClickSignup.Click();
        }
        public void Register(string username , string password, string promtionCode)
        {
            this.RegisterButton.Click();
            this.InputEmail.SendKeys(username);
            this.InputPassword.SendKeys(password);
            this.ConfirimPassword.SendKeys(password);
            this.PromotionCode.SendKeys(promtionCode);
            this.IAccept.Click();
            this.ClickSignup.Click();

        }
        #endregion
    }
}
