using IDobet_Automation_Test.Configiruation;
using IDobet_Automation_Test.Manager;
using IDobet_Automation_Test.TestCases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.PageObjectModel.MainView.North
{
    public class RegistePager
    {
        #region RegisterPageObject
        /******************************************************************************
                                RegisterPageObject
        *******************************************************************************/
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/section/topbar/header/nav/ul/li[6]")]
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

        [FindsBy(How = How.CssSelector, Using = ".modal-container .success-popup button")]
        private IWebElement btnOKSuccess { get; set; }
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

        private void clickOKSuccess()
        {
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "Click On OK from Success Alert");
            btnOKSuccess.Click();
        }

        public void Register(string password, string promtionCode)
        {
            TestConfigManager.Instance.assertBefore(By.XPath("/html/body/app/div/section/topbar/header/nav/ul/li[5]"));
            PageObjectManager.Instance.external_InitClasses.tempMail.GetMail();
            string email = PageObjectManager.Instance.external_InitClasses.tempMail.email;
            this.ClickOnRegisterButtonTopBar();
            this.RegisterInputEmail("ofir@idobet.com");
            this.RegisterInputPassword(password);
            this.RegisterConfirimPassword(password);
            this.RegisterPromotionCode(promtionCode);
            if (WebDriverExtension.SeleniumSetMethods.IsFound(By.CssSelector(".error-email .error-box")))
            {
                TestConfigManager.Instance.driver.SwitchTo().Window(BrowsersFactory.Instance.newTabInstance);
                PageObjectManager.Instance.external_InitClasses.tempMail.GetMail();
                InputEmail.Clear();
                this.RegisterInputEmail(email);
            }
            this.RegisterIAccept();
            this.RegisterClickSignup();
            TestConfigManager.Instance.assertAfter(By.CssSelector(".modal-container .success-popup"));
            this.clickOKSuccess();
            System.Threading.Thread.Sleep(2000);
        }
        #endregion
    }
}
