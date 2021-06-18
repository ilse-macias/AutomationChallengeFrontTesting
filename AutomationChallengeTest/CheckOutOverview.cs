using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationChallengeFrontEndTesting
{
    public class CheckOutOverview
    {
        protected IWebDriver _driver;
        protected IWebElement _finishButton;

        public CheckOutOverview(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        public void CheckOutLastStep()
        {
            _finishButton = _driver.FindElement(By.Id("finish"));
            _finishButton.Click();
        }
    }
}
