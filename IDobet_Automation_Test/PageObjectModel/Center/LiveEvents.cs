using IDobet_Automation_Test.Configiruation;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IDobet_Automation_Test.PageObjectModel.Center
{
    public class LiveEvents
    {
        #region LiveEventsObject
        /******************************************************************************
                                LiveEventsObject
        *******************************************************************************/
        [FindsBy(How = How.ClassName, Using = ".live-container")]
        private IWebElement nowLive { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".live-container .list-container .event-list-item.live-events")]
        private IList<IWebElement> eventsLives { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".live-container .events-list .event-list-item.live-events event odd .odd")]
        private IWebElement oddsLives { get; set; }

        [FindsBy(How = How.ClassName, Using = ".live-container eventslistwithsportfilter .events-list .event-container odd .odd.is-locked")]
        private IWebElement oddIsLocked { get; set; }

        #endregion

        #region LiveEventsMethod
        /******************************************************************************
                                  LiveEventsMethod
        *******************************************************************************/

        private void LiveExists()
        {
            if (nowLive != null)
            {
                chososeLiveEvent();
            }
            else
            {
                Console.WriteLine("No Have Live Match");
            }
        }

        private void chososeLiveEvent()
        {
            int LiveOddSlection = Int32.Parse(ConfigurationManager.AppSettings["Live_Odd_Selection"]);
            var numbers = new List<int>(Enumerable.Range(0, eventsLives.Count - 1));
            numbers.Shuffle();
            numbers = numbers.Take(LiveOddSlection).ToList();
            for (var i = 0; i < LiveOddSlection; i++)
            {
                Console.WriteLine(eventsLives.Count - 1 + "eventsLivesList");
                var eventRnd = numbers[i];
                var upcomingEvent = eventsLives[eventRnd];
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

        public void chooseLiveOdd()
        {
            
            TestConfigManager.Instance.assertBefore(By.ClassName("live-container"));
            this.LiveExists();
        }
        #endregion
    }
}

































//int CurentLiveOddSlection = 0;
//int OddsCounter = 0;
//while (OddsCounter < (eventsLives.Count * 11) && CurentLiveOddSlection < LiveOddSlection)
//{
//    var eventRnd = random.Next(1, eventsLives.Count - 1);
//    var upcomingEvent = eventsLives[eventRnd];
//    var clickableList = upcomingEvent.FindElements(By.ClassName("odd"));
//    var oddRnd = random.Next(1, clickableList.Count - 1);
//    if (clickableList[oddRnd].Text != "")
//    {
//        Console.WriteLine(clickableList[oddRnd].Text);
//        clickableList[oddRnd].Click();
//        CurentLiveOddSlection ++;
//    }
//    OddsCounter++;
//}

