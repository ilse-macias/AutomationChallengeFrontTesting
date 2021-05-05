using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationChallengeTest
{
    public class LoginPage
    {
        protected IWebDriver _driver;
        protected IWebElement usernameField;
        protected IWebElement passwordField;
        protected IWebElement loginButton;
        protected IWebElement errorMessage;

        public LoginPage(IWebDriver _driver)
        {
            this._driver = _driver;
            usernameField = _driver.FindElement(By.Id("user-name"));
            passwordField = _driver.FindElement(By.Id("password"));
            loginButton = _driver.FindElement(By.Id("login-button"));
        }

        public void LoginWithAValidCredential()
        {
            usernameField.SendKeys("standard_user");
            passwordField.SendKeys("secret_sauce");
            loginButton.Click();
        }

        public string LoginWithAnInvalidCredential()
        {
            
            usernameField.SendKeys("standard_user");
            passwordField.SendKeys("secret_saucex");
            loginButton.Click();
            errorMessage = _driver.FindElement(By.XPath("//*[@id='login_button_container']/div/form/div[3]/h3"));

            return errorMessage.Text;
        }
    }
}
