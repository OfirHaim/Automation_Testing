using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.PageObjectModel
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
                Console.WriteLine("No Have TopEvent");
            }
        }

        private void chososeTopEvent()
        {
            for (var i = 0; i < Int32.Parse(ConfigurationManager.AppSettings["TopEvent_Odd_Selection"]); i++)
            {
                var eventRnd = random.Next(1, topEvents.Count - 1);
                var topEvent = topEvents[eventRnd];
                var clickableList = topEvent.FindElements(By.ClassName("odd"));
                var oddRnd = random.Next(1, clickableList.Count - 1);
                if (clickableList[oddRnd].Text != "")
                {
                    Console.WriteLine(clickableList[oddRnd].Text);
                    clickableList[oddRnd].Click();
                }
            }
        }

        private readonly Random random = new Random((int)DateTime.Now.Ticks);

        public void chooseTopeventOdd()
        {
            this.TopEventExists();
        }
        #endregion
    }
}
