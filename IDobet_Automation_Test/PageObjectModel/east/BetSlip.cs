using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private void PlaceBetBtn()
        {
            placeBetBtn.Click();
        }

        private void ConfirmBtn()
        {
            confirmBtn.Click();
        }

        private void assertAfter()
        {
            WebDriverExtension.SeleniumSetMethods.WaitUntilElementIsPresent(
                Configiruation.TestConfigManager.Instance.driver, By.CssSelector(".successful-message.active"));
            Console.WriteLine("Assert PlaceBet success ");
        }

        public void placeBet(string Amount)
        {
            this.EnterComboStake(Amount);
            this.PlaceBetBtn();
            this.ConfirmBtn();
            this.assertAfter();
        }
        #endregion
    }
}
