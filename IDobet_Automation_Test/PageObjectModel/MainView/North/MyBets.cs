using IDobet_Automation_Test.Configiruation;
using IDobet_Automation_Test.Manager;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.PageObjectModel.MainView.North
{
    public class MyBets
    {
        #region myBetsPageObject
        /******************************************************************************
                                MyBetsPageObject
        *******************************************************************************/
        //click on MyBets button from the topbar
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/section/topbar/header/nav/ul/li[7]/a")]
        private IWebElement myBetsbtn { get; set; }

        #endregion

        #region
        private void clickMyBetsTopBar()
        {
            myBetsbtn.Click();
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "click on myBets button");
        }
        public void clickMyBets()
        {
            //TestConfigManager.Instance.assertBefore(By.XPath("/html/body/app/div/section/topbar/header/nav/ul/li[6]/a"));
            this.clickMyBetsTopBar();
        }
        #endregion
    }
}
