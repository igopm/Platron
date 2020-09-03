using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Platron.Pages
{
    public class ShopCartPage : BasePage
    {
        public string RowsOnBinPage = "//tbody/tr[contains(@class, 'cart-form')]";
        public string RemoveRowOnBinPage = ".//preceding-sibling::td[@class='product-remove']";

        [FindsBy(How = How.XPath, Using = "//p[@class='cart-empty'][text()=.]")]
        public IWebElement TheBinIsClearMessage { get; set; }
    }
}
