using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace AutomationChallengeFrontEndTesting
{
    public class InventoryPage
    {
        private IWebDriver _driver;
        private IWebElement _burgerMenuIcon;
        private IWebElement _logoutLink;
        private IWebElement _sortProduct;

        public InventoryPage(IWebDriver _driver)
        {
            this._driver = _driver;
            _burgerMenuIcon = _driver.FindElement(By.Id("react-burger-menu-btn"));
        }

        public void ClickOnLogout()
        {
            _burgerMenuIcon.Click();
            Thread.Sleep(5000);
            //Add the wait

          // _menuOption = _driver.FindElement(By.ClassName("bm-menu-wrap"));
           _logoutLink = _driver.FindElement(By.Id("logout_sidebar_link"));
           _logoutLink.Click();
           
        }

        public void SortProducts()
        {
            _sortProduct = _driver.FindElement(By.ClassName("product_sort_container"));

            SelectElement selectElement = new SelectElement(_sortProduct);
            selectElement.SelectByValue("hilo");
            Thread.Sleep(5000);
        }
    }
}
