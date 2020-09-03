using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Platron.Core.Service;
using Platron.Pages.Helpers;

namespace Platron.Pages
{
    public class BaseHelper
    {
        protected readonly IWebDriver driverHelper;
        protected readonly WebDriverWait wait;
        #region Helpers/Pages
        public DemoshopHelper DemoshopHelper { get { return new DemoshopHelper(); } }
        protected DemoshopPage UIDemoshopPage { get { return new DemoshopPage(); } }

        public AuthHelper AuthHelper { get { return new AuthHelper(); } }
        protected AuthPage UIAuthPage { get { return new AuthPage(); } }

        public ShopCartHelper ShopCartHelper { get { return new ShopCartHelper(); } }
        protected ShopCartPage UIShopCartPage { get { return new ShopCartPage(); } }
        #endregion

        public BaseHelper()
        {
            this.driverHelper = ServiceDriver.Driver;
            wait = new WebDriverWait(driverHelper, TimeSpan.FromMilliseconds(2000));
        }

        protected void ActionFillField(IWebElement element, string value)
        {
            WaitElementHelper(element).SendKeys(value);
        }

        protected IWebElement WaitElementHelper(IWebElement element)
        {
            return wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        protected void ImplicitWaitElementHelper(int time = 3)
        {
            driverHelper.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
        }

        protected void WaitInvisibilityOfElementLocated(string xpath)
        {
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(xpath)));
        }

        protected void DrawHighlight(IWebElement element)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driverHelper;
            jse.ExecuteScript(
@"arguments[0].style.border='3px solid red';
setTimeout(() => arguments[0].style.border='0px solid red', 3000);", element);
        }
    }
}
