﻿using OpenQA.Selenium;
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
            for (var i = 0; i < Int32.Parse(ConfigurationManager.AppSettings["Live_Odd_Selection"]); i++)
            {
                var eventRnd = random.Next(1, eventsLives.Count - 1);
                var upcomingEvent = eventsLives[eventRnd];
                var clickableList = upcomingEvent.FindElements(By.ClassName("odd"));
                var oddRnd = random.Next(1, clickableList.Count - 1);
                if (clickableList[oddRnd].Text != "")
                {
                    Console.WriteLine(clickableList[oddRnd].Text);
                    clickableList[oddRnd].Click();
                }
            }
        }

        private readonly Random random = new Random((int)DateTime.Now.Ticks);

        public void chooseLiveOdd()
        {
            this.LiveExists();
        }
        #endregion
    }
}

