using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.TestCases.North
{
    class Login
    {
        [SetUp]
        public void Initialize()
        {
            WrapperFactory.BrowserFactory.InitBrowser("Chrome");
            //write to the console
            Console.WriteLine("OpenUrl");

            //neavigate to any url 
            //executeautomation.com/demosite/index.html?Username=&amp;Password=&amp;Login=Login﻿
            PropertiesCollection.driver.Navigate().GoToUrl("http://qa.idobet.com/online");
            
            //wait untill the page loaded
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

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
