using IDobet_Automation_Test.Configiruation;
using IDobet_Automation_Test.Manager;
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
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "click on  Register button from the topbar");
        }

        private void RegisterInputEmail(string userName)
        {
            InputEmail.SendKeys(userName);
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "enter the  email: " + userName + " to input field");
        }

        private void RegisterInputPassword(string password)
        {
            InputPassword.SendKeys(password);
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "enter Password: " + password + " to input field");
        }

        private void RegisterConfirimPassword(string password)
        {   
            ConfirimPassword.SendKeys(password);
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "enter Confirim Password: " + password + " to input field");
        }

        private void RegisterPromotionCode(string promtionCode)
        {
            PromotionCode.SendKeys(promtionCode);
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "enter promtionCode: " + promtionCode + " to input field");
        }

        private void RegisterIAccept()
        {
            IAccept.Click();
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "Click On Iaccept");
        }

        private void RegisterClickSignup()
        {
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "Click On Signup");
            ClickSignup.Click();
        }

        public void Register(string userName, string password, string promtionCode)
        {
            TestConfigManager.Instance.assertBefore(By.XPath("/html/body/app/div/section/topbar/header/nav/ul/li[5]"));
            this.ClickOnRegisterButtonTopBar();
            this.RegisterInputEmail(userName);
            this.RegisterInputPassword(password);
            this.RegisterConfirimPassword(password);
            this.RegisterPromotionCode(promtionCode);
            this.RegisterIAccept();
            this.RegisterClickSignup();
            TestConfigManager.Instance.assertAfter(By.ClassName("user-menu"));
        }
        #endregion
    }
}
