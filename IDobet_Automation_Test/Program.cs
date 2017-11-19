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

        //SetUp run Before any test
        [SetUp]
        public void Initialize()   
        {
            PropertiesCollection.driver = new ChromeDriver();
            //write to the console
                Console.WriteLine("OpenUrl");

            //neavigate to any url 
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?Username=&amp;Password=&amp;Login=Login﻿");

            //Maximize to full screen
                //driver.Manage().Window.Maximize();
                //Console.WriteLine("Maximize to full screen");

            //wait untill the page loaded
                //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
                //Console.WriteLine("the page loaded");
        }
        //Test is the test case
        [Test]
        public void ExecuteTest()
        {
            //Title
            SeleniumSetMethods.SlectDropDown("TitleId", "Mr.", PropertyType.Id);

            //Intail
            SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            Console.WriteLine("The value from my TitleId is: " + SeleniumGetMethods.GetTextFromDDL("TitleId",PropertyType.Id));
            string name = SeleniumGetMethods.GetText("Initial", PropertyType.Name);
            Console.WriteLine(name);

            Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //Click
            SeleniumSetMethods.Click("Save", PropertyType.Name);
            Console.WriteLine("click");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Method");
        }

        //TearDown run after any TEST
        [TearDown]
        public void CleanUp()
        {
            //write to the console
            Console.WriteLine("CleanUp");

            //close the driver
                //driver.Close();
        }
    }
}
