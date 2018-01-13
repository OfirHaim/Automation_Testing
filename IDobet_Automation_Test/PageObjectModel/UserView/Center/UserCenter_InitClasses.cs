using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.PageObjectModel.UserView.Center
{
    public class UserCenter_InitClasses
    {
        public AccountStatement accountStatement        { get; set; }
        public Bonuses          bonuses                 { get; set; }
        public Deposit          deposit                 { get; set; }
        public MyBets           myBets                  { get; set; }
        public UpdateProfile    updateProfile           { get; set; }
        public Withdraw         withdraw                { get; set; }

        public UserCenter_InitClasses(IWebDriver driver)
        {
            accountStatement = new AccountStatement();
            bonuses = new Bonuses();
            deposit = new Deposit();
            myBets = new MyBets();
            updateProfile = new UpdateProfile();
            withdraw = new Withdraw();
            PageFactory.InitElements(driver, this);
            PageFactory.InitElements(driver, accountStatement);
            PageFactory.InitElements(driver, bonuses);
            PageFactory.InitElements(driver, deposit);
            PageFactory.InitElements(driver, myBets);
            PageFactory.InitElements(driver, updateProfile);
            PageFactory.InitElements(driver, withdraw);
        }
    }
}
