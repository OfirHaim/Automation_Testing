using IDobet_Automation_Test.Configiruation;
using IDobet_Automation_Test.Manager;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.PageObjectModel.UserView.Center
{
    public class EditProfilePage
    {
        #region EditProfilePagePageObject
        /******************************************************************************
                                EditProfilePage
        *******************************************************************************/
        //Edit Profile Title
        [FindsBy(How = How.CssSelector, Using = ".user-view.closeMenu .center .title")]
        private IWebElement editProfileTitle { get; set; }

        //userName Field
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/userview/div/section[2]/div/updateprofile/div/div[2]/div[1]/ul/li[1]")]
        private IWebElement userName { get; set; }

        //Email Field
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/userview/div/section[2]/div/updateprofile/div/div[2]/div[1]/ul/li[2]")]
        private IWebElement email { get; set; }

        //Password Field
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/userview/div/section[2]/div/updateprofile/div/div[2]/div[1]/ul/li[3]")]
        private IWebElement password { get; set; }

        //Change Password Button
        [FindsBy(How = How.CssSelector, Using = ".page-body button.change-btn")]
        private IWebElement changePasswordbtn  { get; set; }

        //your Passeord Input 
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/userview/div/section[2]/div/updateprofile/div/div[2]/div[1]/ul/li[4]/form/div/ul/li[1]/span/input")]
        private IWebElement yourPasswordField { get; set; }

        //New Passeord Input 
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/userview/div/section[2]/div/updateprofile/div/div[2]/div[1]/ul/li[4]/form/div/ul/div/li[1]/span/input")]
        private IWebElement newPasswordField { get; set; }

        //Cnfirm Passeord Input 
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/userview/div/section[2]/div/updateprofile/div/div[2]/div[1]/ul/li[4]/form/div/ul/div/li[2]/span/input")]
        private IWebElement confirmPasswordField { get; set; }

        //cancel button in change passwors
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/userview/div/section[2]/div/updateprofile/div/div[2]/div[1]/ul/li[4]/form/div/ul/li[2]/span/button[2]")]
        private IWebElement cancelBtnPassword { get; set; }

        //Save button in change passwors
        [FindsBy(How = How.XPath, Using = "/html/body/app/div/userview/div/section[2]/div/updateprofile/div/div[2]/div[1]/ul/li[4]/form/div/ul/li[2]/span/button[1]")]
        private IWebElement saveBtnPassword { get; set; }

        #endregion

        #region UserMenuPageMethod
        /******************************************************************************
                                    EditProfileMethod
        *******************************************************************************/

        public void changePasswordValid(string oldPassword, string newPassword, string confirmPassword)
        {
            changePasswordbtn.Click();
            MyAssert.ElementFoundByClassName("open");            
            yourPasswordField.SendKeys(oldPassword);
            newPasswordField.SendKeys(newPassword);
            confirmPasswordField.SendKeys(confirmPassword);
            saveBtnPassword.Click();
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "Click on Change Password");
        }
        #endregion
    }
}
