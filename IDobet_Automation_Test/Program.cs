using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;



namespace IDobet_Automation_Test
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
        //SetUp run Before any test
        /*[SetUp]
        public void Initialize()   
        {
            PropertiesCollection.driver = new ChromeDriver();
            //write to the console
                Console.WriteLine("OpenUrl");

            //neavigate to any url 
            //executeautomation.com/demosite/index.html?Username=&amp;Password=&amp;Login=Login﻿
            PropertiesCollection.driver.Navigate().GoToUrl("http://qa.idobet.com/online");

            //Maximize to full screen
            PropertiesCollection.driver.Manage().Window.Maximize();
                Console.WriteLine("Maximize to full screen");

            //wait untill the page loaded
                PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                //Console.WriteLine("the page loaded");
        }
        //Test is the test case

        [Test]
        public void ExecuteTest()
        {
            PageObjectModel.north.TopBar topbar = new PageObjectModel.north.TopBar();
            topbar.Loginbtn.Click();
            /*Title
            SeleniumSetMethods.SlectDropDown("TitleId", "Mr.", PropertyType.Id);

            //Intail
            SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            Console.WriteLine("The value from my TitleId is: " + SeleniumGetMethods.GetTextFromDDL("TitleId",PropertyType.Id));

            Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //Click
            SeleniumSetMethods.Click("Save", PropertyType.Name);
            Console.WriteLine("click");*/

            //SeleniumSetMethods.Click("download-fixture-btn", PropertyType.ClassName);
       //}

        //TearDown run after any TEST
        /*[TearDown]
        public void CleanUp()
        {
            //write to the console
            Console.WriteLine("CleanUp");

            //close the driver
                //PropertiesCollection.driver.Close();
        }
    }
}
*/
