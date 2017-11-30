using IDobet_Automation_Test.Configiruation;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
namespace IDobet_Automation_Test.PageObjectModel.east
{
    public class BetSlip
    {
        #region BetSlipObject
        /******************************************************************************
                                BetSlipObject
        *******************************************************************************/
        //click on login button from the topbar
        [FindsBy(How = How.CssSelector, Using = ".betslip")]
        private IWebElement betslip { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".bet-configuration-tabs .active")]
        private IWebElement singleBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".bet-configuration-tabs .active")]
        private IWebElement comboBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".betslip .bet-pool .bets-pool-list .bet-sum input")]
        private IList<IWebElement> betPoolList { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".bet-configuration-tabs .active")]
        private IWebElement enterSingleStake { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".betslip .bet-pool .bets-pool-list .total-bet")]
        private IWebElement totalBet { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".betslip .bet-pool .bets-pool-list .total-bet .bet-sum input")]
        private IWebElement enterComboStake { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".betslip .bet-pool .bet-pool-footer .place-bets-btn")]
        private IWebElement placeBetBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".betslip .bet-pool .bet-pool-footer .place-bets-btn.accept-changes")]
        private IWebElement acceptChangesBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".betslip .bet-pool .bet-pool-footer .place-bets-btn.confirm-btn")]
        private IWebElement confirmBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".bet-date-box .bet-date.live ")]
        private IList<IWebElement> LivebetSlipMatch { get; set; }

        private Stopwatch stopWtach = null;
        private bool isLiveInBettingSlip = false;

        #endregion BetSlipObject

        #region BetSlipMethod
        /******************************************************************************
                                     BetSlipMethod
        *******************************************************************************/
        private void EnterComboStake(string Amount)
        {
            enterComboStake.SendKeys(Amount);

        }

        private void EnterSingleStake(string Amount)
        {
            enterSingleStake.SendKeys(Amount);
        }

        private void AcceptAllChangesBtn()
        {
            acceptChangesBtn.Click();
        }

        private void PlaceBetBtn()
        {
            placeBetBtn.Click();
            this.isLiveInBettingSlip = LiveInBetslip();
        }

        private bool LiveInBetslip()
        {
            return (LivebetSlipMatch.Count > 0);
        }

        private void ConfirmBtn()
        {
            if (this.stopWtach == null)
            {
                this.stopWtach = new Stopwatch();
            }
            else
            {
                this.stopWtach.Reset();
            }
            confirmBtn.Click();
            this.stopWtach.Start();
            var waitingForApprovalEND = WebDriverExtension.SeleniumSetMethods.WaitUntilElementIsHide(By.CssSelector(".place-bets-btn.waiting"), 20); // true 
            if (waitingForApprovalEND)
            {
                this.stopWtach.Stop();
                if (WebDriverExtension.SeleniumSetMethods.IsFound(By.CssSelector(".place-bets-btn.accept-changes")))
                {
                    this.AcceptAllChangesBtn();
                    this.PlaceBetBtn();
                    this.ConfirmBtn();
                }
            }
        }

        public void placeBet(string Amount)
        {
            this.EnterComboStake(Amount);
            if (WebDriverExtension.SeleniumSetMethods.IsFound(By.CssSelector(".place-bets-btn.accept-changes")))
            {
                this.AcceptAllChangesBtn();
            }
            this.PlaceBetBtn();
            this.ConfirmBtn();
            TestConfigManager.Instance.assertAfter(By.CssSelector(".successful-message.active"));
            Console.WriteLine("There is live in betting slip: " + this.isLiveInBettingSlip + " the time are take to made bet: " + this.stopWtach.Elapsed);
        }

        #endregion
    }
}
