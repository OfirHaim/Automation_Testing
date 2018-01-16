using IDobet_Automation_Test.Configiruation;
using IDobet_Automation_Test.TestCases;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDobet_Automation_Test_GUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            TestConfigManager.Instance.Initialize(ConfigurationManager.AppSettings["BrowserName"]);
            PageObjectManager.Instance.mainNorth_InitClasses.loginPage.login(ConfigurationManager.AppSettings["username"], ConfigurationManager.AppSettings["password"]);
            TestConfigManager.Instance.CleanUp(TestConfigManager.Instance.driver);
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}