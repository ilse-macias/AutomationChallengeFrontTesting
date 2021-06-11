using AutomationChallengeTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace AutomationChallengeFrontEndTesting.Test
{
    public class InventoryTest
    {
        private IWebDriver _driver;

        public InventoryTest()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            _driver.Manage().Window.Maximize();
        }

        [Fact]
        public void Logout()
        {
            LoginPage login = new LoginPage(_driver);
            login.LoginWithAValidCredential();

            InventoryPage inventoryPage = new InventoryPage(_driver);
            inventoryPage.ClickOnLogout();
        }

        [Fact]
        public void SortProductByPriceDescending()
        {
            LoginPage login = new LoginPage(_driver);
            login.LoginWithAValidCredential();

            InventoryPage inventory = new InventoryPage(_driver);
            inventory.SortProducts();
        }

        [Fact]
        public void AddMultipleItems()
        {
            LoginPage login = new LoginPage(_driver);
            login.LoginWithAValidCredential();

            InventoryPage inventory = new InventoryPage(_driver);
            var inventoryItems = inventory.AddProductsToCart();

            var badgeCount = inventory.GetCartCount();

            Assert.Equal(badgeCount, inventoryItems.Count);
        }
    }
}
