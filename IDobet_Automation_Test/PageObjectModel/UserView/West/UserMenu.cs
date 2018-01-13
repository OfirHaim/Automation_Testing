using IDobet_Automation_Test.Configiruation;
using IDobet_Automation_Test.Manager;
using IDobet_Automation_Test.TestCases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.PageObjectModel.UserView.West
{
    public class UserMenu
    {
        #region UserMenuPageObject
        /******************************************************************************
                                UserMenuPage
        *******************************************************************************/
        //click on editProfil button from userMenu
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/userview/div/section[1]/div/usermenu/div/ul/li[1]/a")]
        private IWebElement editProfilebtn { get; set; }

        //click on MyBets button from userMenu
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/userview/div/section[1]/div/usermenu/div/ul/li[2]/a")]
        private IWebElement myBetsbtn { get; set; }

        //click on accountStatement button from userMenu
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/userview/div/section[1]/div/usermenu/div/ul/li[3]/a")]
        private IWebElement accountStatementbtn { get; set; }

        //click on bonuses button from userMenu
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/userview/div/section[1]/div/usermenu/div/ul/li[4]/a")]
        private IWebElement bonusesbtn { get; set; }

        //click on withdraw button from userMenu
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/userview/div/section[1]/div/usermenu/div/ul/li[5]/a")]
        private IWebElement withdrawbtn { get; set; }

        //click on deposit button from userMenu
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/userview/div/section[1]/div/usermenu/div/ul/li[6]/a")]
        private IWebElement depositbtn { get; set; }

        //click on logOut button from userMenu
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/userview/div/section[1]/div/usermenu/div/ul/li[7]/a")]
        private IWebElement logOutbtn { get; set; }
        #endregion

        #region UserMenuPageMethod
        /******************************************************************************
                                    UserMenuPageMethod
        *******************************************************************************/

        public void editProfileUserMenu()
        {
            editProfilebtn.Click();
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "click on editProfile button");
        }
        
        public void clickMyBets()
        {
            myBetsbtn.Click();
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "click on MyBets button");
        }
        
        public void clickAccountStatement()
        {
            accountStatementbtn.Click();
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "click on accountStatement button");
        }

        public void clickaBbonuses()
        {
            bonusesbtn.Click();
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "click on bonuses button");
        }

        public void clickWithdraw()
        {
            withdrawbtn.Click();
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "click on Withdraw button");
        }

        public void clickDepsoit()
        {
            depositbtn.Click();
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "click on Depsoit button");
            System.Threading.Thread.Sleep(22000);
        }

        public void clickLogOut()
        {
            logOutbtn.Click();
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "click on LogOut button");
        }
        #endregion
    }
}
