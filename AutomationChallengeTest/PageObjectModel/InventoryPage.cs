using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;

namespace AutomationChallengeFrontEndTesting
{
    public class InventoryPage
    {
        private IWebDriver _driver;
        private IWebElement _burgerMenuIcon;
        private IWebElement _logoutLink;
        private IWebElement _sortProduct;
        private IWebElement _cartIcon;

        private IList<IWebElement> _AddToCart;
        private IList<IWebElement> _ProductPrice;

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

        public void AddProductToCarSimple()
        {
            _AddToCart = _driver.FindElements(By.CssSelector(".btn.btn_primary.btn_small.btn_inventory"));
            _ProductPrice = _driver.FindElements(By.ClassName("inventory_item_price"));

            foreach (var item in _AddToCart)
            {
                item.Click();
            }
        }

        public void ClickOnCartIcon()
        {
            _cartIcon = _driver.FindElement(By.ClassName("shopping_cart_link"));
            _cartIcon.Click();
            Thread.Sleep(5000);
        }

        public List<InventoryItem> AddProductsToCart()
        {
            List<InventoryItem> items = new List<InventoryItem>();
            var inventoryItemElements = _driver.FindElements(By.ClassName("inventory_item"));

            foreach (var inventoryItemElement in inventoryItemElements)
            {
                var title = inventoryItemElement.FindElement(By.ClassName("inventory_item_name")).Text;
                var price = inventoryItemElement.FindElement(By.ClassName("inventory_item_price")).Text;
                var description = inventoryItemElement.FindElement(By.ClassName("inventory_item_desc")).Text;

                var inventoryItem = new InventoryItem
                {
                    Title = title,
                    Price = price,
                    Description = description
                };

                items.Add(inventoryItem);

                var addButton = inventoryItemElement.FindElement(By.CssSelector(".btn.btn_primary.btn_small.btn_inventory"));

                addButton.Click();
            }

            return items;
        }

        public int GetCartCount()
        {
            var cartBadgeElement =  _driver.FindElement(By.CssSelector(".shopping_cart_badge"));
            var carBadgeText = cartBadgeElement.Text;
            return int.Parse(carBadgeText);
        }

        //Data Tranfer Object
        public class InventoryItem
        {
            public string Title { get; set; }
            public string Price { get; set; }
            public string Description { get; set; }

        }
    }
}
