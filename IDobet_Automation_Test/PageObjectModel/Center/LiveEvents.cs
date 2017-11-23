using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
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

        [FindsBy(How = How.CssSelector, Using = ".live-container eventslistwithsportfilter .events-list .event-container odd .odd")]
        private IList<IWebElement> oddsLives { get; set; }

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
                chososeLiveOdd();
            }
            else
            {
                Console.WriteLine("No Have Live Match");
            }
        }

        private void chososeLiveOdd()
        {
            Random rnd = new Random();
            foreach (var oddsLive in oddsLives)
            {
                if (oddsLive.Text != "")
                {
                    if (float.Parse(oddsLive.Text) < RandomNumberBetween(1.05,10))
                    {
                        oddsLive.Click();
                        Console.WriteLine(oddsLive.Text);
                    }
                }
                else
                {
                    Console.WriteLine("not Odds :" + oddsLive.Text);
                }
            }
        }

        private readonly Random random = new Random();

        private double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }

        public void chooseLiveOdd()
        {
            this.LiveExists();
        }
        #endregion
    }
}