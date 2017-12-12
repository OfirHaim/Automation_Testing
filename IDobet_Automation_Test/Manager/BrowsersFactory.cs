using IDobet_Automation_Test.Configiruation;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.Manager
{
    #region
    /*public class BrowsersFactory
    {
        public enum BrowsersType
        {
            Firefox,
            Chrome,
            IE
        }

        private class BrowserInfo
        {
            public IWebDriver driver { get; set; }
            public int ID { get; set; }

            public BrowserInfo (IWebDriver driver, int ID)
            {   

                this.driver = driver;
                this.ID = ID;
            }
        }

        private static BrowsersFactory _instance { get; set; }

        private List <BrowserInfo> browsers;

        public BrowsersType browserType { get; set; }

        private BrowsersFactory()
        {

        }

        public static BrowsersFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BrowsersFactory();
                    _instance.browsers = new List <BrowserInfo>();
                }
                return _instance;
            }
        }

        public IWebDriver getWebDriver(int browserID, BrowsersType browsersType)
        {
            //first search for browser info with id  
            foreach (BrowserInfo browserInfo in browsers)
            {
                if(browserID == browserInfo.ID)
                {
                    return browserInfo.driver;
                }
            }
            //browserinfo dosnt exsisit please crate one 
            return createBrowser(browserID, browsersType).driver;
        }

        private BrowserInfo createBrowser(int browserID, BrowsersType BrowsersType)
        {
            BrowserInfo browserInfo = null;

            switch (BrowsersType)
            {
                case BrowsersType.Firefox:
                    browserInfo = new BrowserInfo(new FirefoxDriver(), browserID);
                    break;
                case BrowsersType.IE:
                    browserInfo = new BrowserInfo(new InternetExplorerDriver(), browserID);
                    break;
                case BrowsersType.Chrome:
                    browserInfo = new BrowserInfo(new ChromeDriver(), browserID);
                    break;
            }

            if (browserInfo != null)
            {
                browsers.Add(browserInfo);
            }

            return browserInfo;
        }

        //Delete the current browser 
        /*public bool deleteBrowser(int browserID,)
                {
                    foreach (BrowserInfo browserInfo in browsers)
                    {
                        if (browserID == browserInfo.ID)
                        {
                            return browsers.Remove(browserInfo);
                        }
                    }
                }
    }*/
    #endregion

    public class BrowsersFactory
    {
        private static BrowsersFactory _instance { get; set; }

        public string originalTabInstance { get; set; }

        public string newTabInstance { get; set; }

        private BrowsersFactory()
        {

        }

        public static BrowsersFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BrowsersFactory();
                }
                return _instance;
            }
        }

        public IWebDriver InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    if (TestConfigManager.Instance.driver == null)
                    {
                        return new FirefoxDriver();
                    }
                    break;

                case "IE":
                    if (TestConfigManager.Instance.driver == null)
                    {
                        return new InternetExplorerDriver();
                    }
                    break;

                case "Chrome":
                    if (TestConfigManager.Instance.driver == null)
                    {
                        return new ChromeDriver();
                    }
                    break;
            }

            return TestConfigManager.Instance.driver;
        }

        public void OpenNewTab()
        {
            // save a reference to our original tab's window handle
            BrowsersFactory.Instance.originalTabInstance = TestConfigManager.Instance.driver.CurrentWindowHandle;
            
            // execute some JavaScript to open a new window
            TestConfigManager.Instance.driver.ExecuteJavaScript("window.open();");
            
            // save a reference to our new tab's window handle, this would be the last entry in the WindowHandles collection
            BrowsersFactory.Instance.newTabInstance = TestConfigManager.Instance.driver.WindowHandles[TestConfigManager.Instance.driver.WindowHandles.Count - 1];
            
            // switch our WebDriver to the new tab's window handle
            TestConfigManager.Instance.driver.SwitchTo().Window(newTabInstance);

            // lets navigate to a web site in our new tab
            //TestConfigManager.Instance.driver.Navigate().GoToUrl("www.crowbarsolutions.com");

            // now lets close our new tab
            //TestConfigManager.Instance.driver.ExecuteJavaScript("window.close();");

            //// and switch our WebDriver back to the original tab's window handle
//            TestConfigManager.Instance.driver.SwitchTo().Window(originalTabInstance);

            //// and have our WebDriver focus on the main document in the page to send commands to 
            //TestConfigManager.Instance.driver.SwitchTo().DefaultContent();
            //System.Threading.Thread.Sleep(5000);
        }
    }
}