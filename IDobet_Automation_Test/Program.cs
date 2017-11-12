﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test
{
    class Program
    {
        //crate a referance for our browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
        }

        //SetUp run Before any test
        [SetUp]
        public void Initialize()
        {
            //write to the console
            Console.WriteLine("OpenUrl");

            //neavigate to any url 
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&amp;Password=&amp;Login=Login﻿");
        }

        //Test is the test case
        [Test]
        public void ExecuiteTest()
        {
            //Title
            SeleniumSetMethods.SlectDropDown(driver, "TitleId", "Mr.", "Id");

            //Intail
            SeleniumSetMethods.EnterText(driver, "Initial", "executeautomation", "Name");

            Console.WriteLine("The value from my title is: " + SeleniumGetMethods.GetText(driver,"TitleId","Id"));

            Console.WriteLine("The value from my Intail is: " + SeleniumGetMethods.GetText(driver,"Intail","Name"));

            //Click
            SeleniumSetMethods.Click(driver, "Save", "Name");
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
            driver.Close();
        }
    }
}
