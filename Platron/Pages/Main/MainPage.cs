using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Platron.Pages.Main
{
    public class MainPage : BasePage
    {
        [FindsBy(How = How.LinkText, Using = "Войти")]
        public IWebElement ButtonEnter { get; set; }

        [FindsBy(How = How.LinkText, Using = "В корзину")]
        public IWebElement InBin { get; set; }

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement ButtonSubmit { get; set; }

        [FindsBy(How = How.Id, Using = "inputLogin")]
        public IWebElement FieldLogIn { get; set; }

        [FindsBy(How = How.Id, Using = "inputPassword")]
        public IWebElement FieldPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/div[contains(@class, 'form-message')]")]
        public IWebElement AlertMessage { get; set; }

        public string ThingsOnMainPage = "//li/a/h2";
        public string InBinOnMainPage = "./ancestor::a//following-sibling::a";
        public string RowsOnBinPage = "//tbody/tr[contains(@class, 'cart-form')]";
        public string RemoveRowOnBinPage = ".//preceding-sibling::td[@class='product-remove']";
    }
}
