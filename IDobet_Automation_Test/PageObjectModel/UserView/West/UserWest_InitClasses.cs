using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Configuration;

namespace IDobet_Automation_Test.PageObjectModel.UserView.West
{
    public class UserWest_InitClasses
    {
        public UserMenu userMenu { get; set; }
        public UserCard userCard { get; set; }

        public UserWest_InitClasses(IWebDriver driver)
        {
            userMenu = new UserMenu();
            userCard = new UserCard();
            PageFactory.InitElements(driver, this);
            PageFactory.InitElements(driver, userMenu);
            PageFactory.InitElements(driver, userCard);
        }
    }
}
