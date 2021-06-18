using AutomationChallengeTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AutomationChallengeFrontEndTesting.Test
{
    public class CheckOutTest
    {
        private IWebDriver _driver;

        public CheckOutTest()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            _driver.Manage().Window.Maximize();
        }

        [Fact]
        public void Checkout()
        {
            LoginPage login = new LoginPage(_driver);
            login.LoginWithAValidCredential();

            InventoryPage inventory = new InventoryPage(_driver);
            inventory.AddProductsToCart();
            inventory.ClickOnCartIcon();

            CartPage cart = new CartPage(_driver);
            cart.ClickOnCheckOutButton();

            CheckOutYourInformationPage checkout = new CheckOutYourInformationPage(_driver);
            checkout.FillOutTheInformation("Name", "Last", "122345");

            CheckOutOverview checkoutTwo = new CheckOutOverview(_driver);
            checkoutTwo.CheckOutLastStep();
        }
        
       
    }
}
