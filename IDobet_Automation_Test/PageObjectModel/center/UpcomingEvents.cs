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
            for (var i = 0; i < Int32.Parse(ConfigurationManager.AppSettings["Upcoming _Odd_Selection"]); i++)
            {
                var eventRnd = random.Next(upcomingEvents.Count - 1);
                var upcomingEvent = upcomingEvents[eventRnd];
                var clickableList = upcomingEvent.FindElements(By.ClassName("odd"));
                var oddRnd = random.Next(clickableList.Count - 1);
                if (clickableList[oddRnd].Text != "")
                {
                    Console.WriteLine(clickableList[oddRnd].Text);
                    clickableList[oddRnd].Click();
                }
            }
        }

        private readonly Random random = new Random((int)DateTime.Now.Ticks);

        public void chooseupcomingEventOdd()
        {
            this.UpcomingEventsExists();
        }
        #endregion
    }
}
