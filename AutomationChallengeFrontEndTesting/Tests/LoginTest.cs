using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AutomationChallengeFrontEndTesting.PageObjectModel;

namespace Tests
{
    public class LoginTest
    {
        protected IWebDriver _driver;

        [SetUp]
        public void Initialization()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            _driver.Manage().Window.Maximize();
        }

        [Test, Description("Validate the user navigates to the products page when logged in.")]
        public void LoginSuccessfully()
        {
            System.Console.WriteLine("Hello!");
            LoginPage login = new LoginPage(_driver);
            login.LoginWithAValidCredential();
        }

        [TearDown]
        public void CloseBrowser()
        {
            _driver.Close();
        }
    }
}
