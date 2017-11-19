using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.WrapperFactory
{
    class BrowserFactory
    {
        public static void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    if (PropertiesCollection.driver == null)
                    {
                        PropertiesCollection.driver = new FirefoxDriver();
                    }
                    break;

                case "IE":
                    if (PropertiesCollection.driver == null)
                    {
                        PropertiesCollection.driver = new InternetExplorerDriver();
                    }
                    break;

                case "Chrome":
                    if (PropertiesCollection.driver == null)
                    {
                        PropertiesCollection.driver = new ChromeDriver();
                    }
                    break;
            }
        }
    }
}
