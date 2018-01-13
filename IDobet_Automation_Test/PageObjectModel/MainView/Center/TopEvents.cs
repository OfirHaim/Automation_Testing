using IDobet_Automation_Test.Configiruation;
using IDobet_Automation_Test.Manager;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.PageObjectModel.MainView.Center
{
    public class TopEvents
    {
        #region TopEventsObject
        /******************************************************************************
                        TopEventsObject
        *******************************************************************************/
        [FindsBy(How = How.ClassName, Using = ".top-container")]
        private IWebElement topEvent { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".top-container .list-container .events-list .event-list-item")]
        private IList<IWebElement> topEvents { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".top-container .list-container .events-list .event-list-item event odd .odd")]
        private IWebElement TopEventsodds { get; set; }

        [FindsBy(How = How.ClassName, Using = ".top-container .list-container .events-list .event-list-item event odd .odd.is-locked")]
        private IWebElement oddIsLocked { get; set; }
        #endregion

        #region LiveEventsMethod
        /******************************************************************************
                                  TopEventsMethod
        *******************************************************************************/

        private void TopEventExists()
        {
            if (topEvent != null)
            {
                chososeTopEvent();
            }
            else
            {
                LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, "No Have TopEvent");
            }
        }

        private void chososeTopEvent()
        {
            int TopEventsOddSlection = Int32.Parse(ConfigurationManager.AppSettings["TopEvent_Odd_Selection"]);
            var numbers = new List<int>(Enumerable.Range(0, topEvents.Count - 1));
            numbers.Shuffle();
            numbers = numbers.Take(TopEventsOddSlection).ToList();
            LogManager.Instance.WriteToLog(LogManager.elogLevel.Debug, topEvents.Count - 1 + " topEventsList");
            for (var i = 0; i < Int32.Parse(ConfigurationManager.AppSettings["TopEvent_Odd_Selection"]); i++)
            {
                var eventRnd = numbers[i];
                var topEvent = topEvents[eventRnd];
                var clickableList = topEvent.FindElements(By.ClassName("odd"));
                if (clickableList.Count > 0)
                {
                    var oddRnd = random.Next(0, clickableList.Count - 1);
                    if (clickableList[oddRnd].Text != "")
                    {
                        clickableList[oddRnd].Click();
                    }
                }
            }
        }

        private readonly Random random = new Random((int)DateTime.Now.Ticks);

        public void chooseTopeventOdd()
        {
            TestConfigManager.Instance.assertBefore(By.ClassName("top-container"));
            this.TopEventExists();
        }
        #endregion
    }
}
