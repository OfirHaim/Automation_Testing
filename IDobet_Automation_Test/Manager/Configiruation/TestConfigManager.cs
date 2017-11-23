using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static IDobet_Automation_Test.Manager.BrowsersFactory;

namespace IDobet_Automation_Test.Configiruation
{
    public class TestConfigManager
    {
        private static TestConfigManager _instance { get; set; }

        public IWebDriver driver { get; set; }

        private TestConfigManager()
        {

        }

        public static TestConfigManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TestConfigManager();
                }
                return _instance;
            }
        }

        public void Initialize(string browserName)
        {
            //open the Browser
            driver = Manager.BrowsersFactory.Instance.InitBrowser(browserName);
            Console.WriteLine("OpenBrowser");

            //neavigate to any url 
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
            Console.WriteLine("navigate to URL: " + ConfigurationManager.AppSettings["URL"]);

            //wait until the page loaded
            Thread.Sleep(8000);
            Console.WriteLine("Wait until the page loaded");

            //Maximize to full screen
            driver.Manage().Window.Maximize();
            Console.WriteLine("Maximize to full screen");
        }

        public void CleanUp(IWebDriver driver)
        {
            //close the driver
            driver.Close();
            driver.Quit();

            //write to the console
            Console.WriteLine("CleanUp");
        }
    }
}
