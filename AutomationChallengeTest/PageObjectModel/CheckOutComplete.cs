using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationChallengeFrontEndTesting.PageObjectModel
{
    public class CheckOutComplete
    {
        protected IWebDriver _driver;
        protected IWebElement _thankYouConfirmationText;
        protected IWebElement _backHomeButton;

        public CheckOutComplete(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        public void GoToProductsPage()
        { 
            _backHomeButton = _driver.FindElement(By.Id("back-to-products"));
            _backHomeButton.Click();
        }
    }
}
