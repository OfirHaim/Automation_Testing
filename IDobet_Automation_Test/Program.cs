using NUnit.Framework;
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
            driver.Navigate().GoToUrl("http://qa.idobet.com/online");

            //Maximize to full screen
            driver.Manage().Window.Maximize();
            Console.WriteLine("Maximize to full screen");

            //wait untill the page loaded
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            Console.WriteLine("the page loaded");
        }


        //Test is the test case
        [Test]
        public void ExecuiteTest()
        {
            //Title
            //SeleniumSetMethods.SlectDropDown(driver, "TitleId", "Mr.", "Id");

            //Intail
            //SeleniumSetMethods.EnterText(driver, "Initial", "executeautomation", "Name");

            //Console.WriteLine("The value from my title is: " + SeleniumGetMethods.GetText(driver,"TitleId","Id"));

            //Console.WriteLine("The value from my Intail is: " + SeleniumGetMethods.GetText(driver,"Intail","Name"));

            //Click
            SeleniumSetMethods.Click(driver, " drop-down-bar", "class");
            Console.WriteLine("click");
        }


        //TearDown run after any TEST
        [TearDown]
        public void CleanUp()
        {
            //write to the console
            Console.WriteLine("CleanUp");

            //close the driver
           // driver.Close();
        }
    }
}
