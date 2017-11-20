using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.Configiruation
{
    public class SetupConfiguration
    {
        public void Initialize() {
            //open the Browser
            WrapperFactory.BrowserFactory.InitBrowser(ConfigurationManager.AppSettings["BrowserName"]);
            Console.WriteLine("OpenBrowser");

            //neavigate to any url 
            PropertiesCollection.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
            Console.WriteLine("neavigate to URL");
            
            //wait until the page loaded
            Thread.Sleep(8000);
            Console.WriteLine("Wait until the page loaded");

            //Maximize to full screen
            PropertiesCollection.driver.Manage().Window.Maximize();
            Console.WriteLine("Maximize to full screen");
        }
    }
}
