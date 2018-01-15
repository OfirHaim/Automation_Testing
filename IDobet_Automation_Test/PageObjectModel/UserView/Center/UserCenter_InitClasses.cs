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
        public AccountStatementPage accountStatementPage        { get; set; }
        public BonusesPage          bonusesPage                 { get; set; }
        public DepositPage          depositPage                 { get; set; }
        public MyBetsPage           myBetsPage                  { get; set; }
        public EditProfilePage      editProfilePage             { get; set; }
        public WithdrawPage         withdrawPage                { get; set; }

        public UserCenter_InitClasses(IWebDriver driver)
        {
            accountStatementPage = new AccountStatementPage();
            bonusesPage = new BonusesPage();
            depositPage = new DepositPage();
            myBetsPage = new MyBetsPage();
            editProfilePage = new EditProfilePage();
            withdrawPage = new WithdrawPage();
            PageFactory.InitElements(driver, this);
            PageFactory.InitElements(driver, accountStatementPage);
            PageFactory.InitElements(driver, bonusesPage);
            PageFactory.InitElements(driver, depositPage);
            PageFactory.InitElements(driver, myBetsPage);
            PageFactory.InitElements(driver, editProfilePage);
            PageFactory.InitElements(driver, withdrawPage);
        }
    }
}
