using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutomationChallengeFrontEndTesting
{
    public class CartPage
    {
        protected IWebDriver _driver;
        protected IWebElement checkoutButton;

        public CartPage(IWebDriver _driver)
        {
            this._driver = _driver;
            checkoutButton = _driver.FindElement(By.Id("checkout"));
        }

        public void ClickOnCheckOutButton()
        {
            
            checkoutButton.Click();
            Thread.Sleep(3000);
        }


    }
}
