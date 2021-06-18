using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationChallengeFrontEndTesting
{
    public class CheckOutYourInformationPage
    {
        protected IWebDriver _driver;
        protected IWebElement _firstNameField;
        protected IWebElement _lastNameField;
        protected IWebElement _zipCodeField;
        protected IWebElement _continueButton;

        public CheckOutYourInformationPage(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        public void FillOutTheInformation(string firstName, string lastName, string zipCode)
        {
            _firstNameField = _driver.FindElement(By.Id("first-name"));
            _firstNameField.SendKeys(firstName);

            _lastNameField = _driver.FindElement(By.Id("last-name"));
            _lastNameField.SendKeys(lastName);

            _zipCodeField = _driver.FindElement(By.Id("postal-code"));
            _zipCodeField.SendKeys(zipCode);
            
            _continueButton = _driver.FindElement(By.Id("continue"));
            _continueButton.Click();
        }
    }
}
