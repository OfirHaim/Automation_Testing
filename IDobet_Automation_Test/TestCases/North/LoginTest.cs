using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.TestCases.North
{
    class Login
    {
        [SetUp]
        public void Initialize()
        {
            //open the Browser
            WrapperFactory.BrowserFactory.InitBrowser(ConfigurationManager.AppSettings["BrowserName"]);
            Console.WriteLine("OpenUrl");

            //neavigate to any url 
            //executeautomation.com/demosite/index.html?Username=&amp;Password=&amp;Login=Login﻿
            PropertiesCollection.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
            Thread.Sleep(8000);
           
            //Maximize to full screen
            PropertiesCollection.driver.Manage().Window.Maximize();
            Console.WriteLine("Maximize to full screen");

            //Console.WriteLine("the page loaded");
        }

        //Test is the test case
        [Test]
        public void LoginTests()
        {
            PageObjectModel.north.TopBar topbar = new PageObjectModel.north.TopBar();
            topbar.Loginbtn.Click();
            topbar.InputEmail.SendKeys(ConfigurationManager.AppSettings["username"]);
            topbar.InputPassword.SendKeys(ConfigurationManager.AppSettings["Password"]);
            topbar.ClickLogin.Click();
        }

        //TearDown run after any TEST
        [TearDown]
        public void CleanUp()
        {
            //write to the console
            Console.WriteLine("CleanUp");

            //close the driver
            //PropertiesCollection.driver.Close();
        }
    }
}
