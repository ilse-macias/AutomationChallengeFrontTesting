using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomationChallengeFrontEndTesting.PageObjectModel
{
    public class LoginPage
    {
        protected IWebDriver _driver;
        
        public LoginPage(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        public void LoginWithAValidCredential()
        {
            IWebElement usernameField = _driver.FindElement(By.Id("username"));
            IWebElement passwordField = _driver.FindElement(By.Id("password"));
            IWebElement loginButton = _driver.FindElement(By.Id("login-button"));

            usernameField.SendKeys("standard_user");
            passwordField.SendKeys("secret_sauce");
            loginButton.Click();
        }
    }
}
