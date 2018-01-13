using IDobet_Automation_Test.Configiruation;
using IDobet_Automation_Test.Manager;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.PageObjectModel.ExternalPages
{
    public class TempMail
    {
        #region TempMailObject
        /******************************************************************************
                                TempMail
        *******************************************************************************/
        public string email { get; set; }

        //click on Delete to get new email address
        [FindsBy(How = How.Id, Using = "click-to-delete")]
        private IWebElement clickDelete { get; set; }

        //get the email value
        [FindsBy(How = How.Id, Using = "mail")]
        private IWebElement getTheMail { get; set; }

        //get the email value
        [FindsBy(How = How.Id, Using = "mails")]
        private IWebElement emailArrive { get; set; }

        //click on the link are arrive
        [FindsBy(How = How.ClassName, Using = "mailView")]
        private IWebElement activationlink { get; set; }
        #endregion

        #region LoginPageMethod
        /******************************************************************************
                                    TempMailMethod
        *******************************************************************************/
        private void checkOpenTempMail()
        {
            if (BrowsersFactory.Instance.newTabInstance == null)
            {
                BrowsersFactory.Instance.OpenNewTab();
                TestConfigManager.Instance.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["TempMail"]);
            }
        }

        private void ClickOnDelete()
        {
            clickDelete.Click();
            Thread.Sleep(2000);
        }

        private void CopyMail()
        {
            this.email = getTheMail.GetAttribute("value");
        }

        private void enterToLink()
        {
            if (emailArrive.Displayed)
            {
                TestConfigManager.Instance.assertBefore(By.LinkText("iDoBet Activation"));
                emailArrive.FindElement(By.XPath("//*[@id='mails']/tbody/tr/td[3]/a")).Click();
                System.Threading.Thread.Sleep(5000);
            }
            else
            {
                enterToLink();
            }
        } 

        private void aactivationlink()
        {
            if (activationlink.Displayed)
            {
                activationlink.FindElement(By.CssSelector(".mailView .pm-text a")).Click();
            }
            System.Threading.Thread.Sleep(22000);
        }

        private void WaitToEmail()
        {
            enterToLink();
            aactivationlink();
        }

        public void GetMail()
        {
            this.checkOpenTempMail();
            this.ClickOnDelete();
            this.CopyMail();
            TestConfigManager.Instance.driver.SwitchTo().Window(BrowsersFactory.Instance.originalTabInstance);
            Console.WriteLine(this.email);
        }

        #endregion
    }
}
