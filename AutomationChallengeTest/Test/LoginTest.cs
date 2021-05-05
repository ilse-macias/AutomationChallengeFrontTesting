using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace AutomationChallengeTest
{
    public class LoginTest
    {
        protected IWebDriver _driver;

        public LoginTest()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            _driver.Manage().Window.Maximize();
        }

      
        [Fact]
        public void LoginValidUser()
        {
            LoginPage login = new LoginPage(_driver);
            login.LoginWithAValidCredential();
        }

        [Fact]
        public void LoginInvalidUser()
        {
            LoginPage login = new LoginPage(_driver);
            login.LoginWithAnInvalidCredential();
        }
    }
}
