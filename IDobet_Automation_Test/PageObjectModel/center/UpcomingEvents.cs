using IDobet_Automation_Test.Configiruation;
using NUnit.Framework;
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
    public class UpcomingEvents
    {
        #region UpcomingEventsObject
        /******************************************************************************
                        UpcomingEventsObject
        *******************************************************************************/
        [FindsBy(How = How.ClassName, Using = ".upcoming-container")]
        private IWebElement upcomingEvent { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".upcoming-container .list-container .events-list .event-list-item")]
        private IList<IWebElement> upcomingEvents { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".upcoming-container .list-container .events-list .event-list-item event odd .odd")]
        private IWebElement upcomingEventsodds { get; set; }

        [FindsBy(How = How.ClassName, Using = ".upcoming-container .list-container .events-list .event-list-item event odd .odd.is-locked")]
        private IWebElement oddIsLocked { get; set; }
        #endregion

        #region UpcomingEventsMethod
        /******************************************************************************
                                  UpcomingEventsMethod
        *******************************************************************************/

        private void UpcomingEventsExists()
        {
            if (upcomingEvent != null)
            {
                chososeUpcomingEvent();
            }
            else
            {
                Console.WriteLine("No Have chososeUpcoming Event");
            }
        }

        private void chososeUpcomingEvent()
        {
            int upcomingEventsOddSlection = Int32.Parse(ConfigurationManager.AppSettings["Upcoming _Odd_Selection"]);
            var numbers = new List<int>(Enumerable.Range(0, upcomingEvents.Count - 1));
            numbers.Shuffle();
            numbers = numbers.Take(upcomingEventsOddSlection).ToList();

            for (var i = 0; i < Int32.Parse(ConfigurationManager.AppSettings["Upcoming _Odd_Selection"]); i++)
            {
                var eventRnd = numbers[i];
                var upcomingEvent = upcomingEvents[eventRnd];
                var clickableList = upcomingEvent.FindElements(By.ClassName("odd"));
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

        public void chooseupcomingEventOdd()
        {
            TestConfigManager.Instance.assertBefore(By.ClassName("upcoming-container"));
            this.UpcomingEventsExists();
        }
        #endregion
    }
}
