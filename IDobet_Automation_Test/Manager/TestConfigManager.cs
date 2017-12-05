using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static IDobet_Automation_Test.Manager.BrowsersFactory;
using System.Drawing.Imaging;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Firefox;
using IDobet_Automation_Test.Manager;
using System.IO;

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
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "!----------------------------The: "+TestContext.CurrentContext.Test.Name.ToString()+" Start----------------------------!" );

            //open the Browser
            driver = Manager.BrowsersFactory.Instance.InitBrowser(browserName);
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "Open: " + browserName.ToString() + " browser");

            //neavigate to any url 
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "navigate to URL: " + ConfigurationManager.AppSettings["URL"]);

            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "Wait until the page loaded");
            var ready = WebDriverExtension.SeleniumSetMethods.WaitUntilElementIsPresent(driver, By.ClassName("top-container"));
            if (ready)
            {
                //Maximize to full screen
                driver.Manage().Window.Maximize();
                LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "Maximize to full screen");
            }
        }

        public void CleanUp(IWebDriver driver)
        {
            var testResult = TestContext.CurrentContext.Result.Outcome.Status.ToString();
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "The result test is: " + testResult);

            if (testResult == "Failed" || testResult == "Inconclusive")
            {
                var testMessage = TestContext.CurrentContext.Result.Message.ToString();
                LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "The reason is: " + testMessage);
                TestConfigManager.Instance.TakeScreenShot(TestContext.CurrentContext.Test.Name);
            }
            //LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "CleanUp");
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "!----------------------------The: "+TestContext.CurrentContext.Test.Name.ToString()+" Finsh----------------------------! \r\n\r\n");
            driver.Close();
            driver.Quit();

            //if (testResult.ToString() == "Passed")
            //{
            //    LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "The result test is: " + testResult);
            //    LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "CleanUp");
            //    driver.Close();
            //    driver.Quit();
            //}
            //if (testResult == "Failed" || testResult == "Inconclusive")
            //{
            //    var testMessage = TestContext.CurrentContext.Result.Message.ToString();
            //    TestConfigManager.Instance.TakeScreenShot(TestContext.CurrentContext.Test.Name);
            //    LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "The result test is: " + testResult);
            //    LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "The reason is: " + testMessage);
            //    LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "CleanUp");
            //    driver.Close();
            //    driver.Quit();
            //}
        }

        public void assertBefore(By by)
        {
            WebDriverExtension.SeleniumSetMethods.WaitUntilElementIsHide(By.CssSelector("onlineloader .loader"), 20);
            WebDriverExtension.SeleniumSetMethods.WaitUntilElementIsPresent(Configiruation.TestConfigManager.Instance.driver, by);
        }

        public void assertAfter(By by)
        {
            WebDriverExtension.SeleniumSetMethods.WaitUntilElementIsPresent(Configiruation.TestConfigManager.Instance.driver, by);
            WebDriverExtension.SeleniumSetMethods.WaitUntilElementIsHide(By.CssSelector("onlineloader .loader"), 20);
        }

        public void TakeScreenShot(string testName)
        {
            Screenshot ss = ((ITakesScreenshot)TestConfigManager.Instance.driver).GetScreenshot();
            var timeNow = DateTime.Now.ToString("dd.MM.yyyy_HH.mm.ss");
            ss.SaveAsFile(Path.Combine(LogManager.Instance.ImageFolder, $"{testName + "_" + timeNow}.png"), ScreenshotImageFormat.Png);
        }
    }
}

