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
    public class TempMail
    {
        #region TempMailObject
        /******************************************************************************
                                TempMail
        *******************************************************************************/
        //click on login button from the topbar
        [FindsBy(How = How.Id, Using = "click-to-delete")]
        private IWebElement ClickDelete { get; set; }

        //enter email addres to input fild
        [FindsBy(How = How.Id, Using = "mail")]
        private IWebElement GetTheMail { get; set; }

        public string Email { get; set; }
        #endregion

        #region LoginPageMethod
        /******************************************************************************
                                    TempMailMethod
        *******************************************************************************/
        private void NavigateToTempMail()
        {
            TestConfigManager.Instance.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["TempMail"]);
        }
        //private void ClickOnDelete()
        //{
        //    ClickDelete.Click();
        //}
        private void CopyMail()
        {
            this.Email = GetTheMail.GetAttribute("value");
        }
        public void TempMail1()
        {
            this.NavigateToTempMail();
            //this.ClickOnDelete();
            this.CopyMail();
            TestConfigManager.Instance.driver.SwitchTo().Window(BrowsersFactory.Instance.originalTabInstance);
            Console.WriteLine(this.Email);
        }
        #endregion
    }
}
