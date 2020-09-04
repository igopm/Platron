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
            WhenIsClickable(element).SendKeys(value);
        }
        protected IWebElement WhenIsClickable(IWebElement element)
        {
            return wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        //protected IWebElement WhenIsClickable(IWebElement element, int delimeter = 30)
        //{
        //    try
        //    {
        //        var wait_ic = new WebDriverWait(driverHelper, TimeSpan.FromSeconds(10 / delimeter))
        //        {
        //            PollingInterval = TimeSpan.FromMilliseconds(500)
        //        };
        //        wait_ic.IgnoreExceptionTypes(typeof(NoSuchElementException));
        //        wait_ic.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
        //        wait_ic.Until(e => ExpectedConditions.ElementToBeClickable(element));
        //        return element;
        //    }
        //    catch (Exception e) when (e is NoSuchElementException || e is StaleElementReferenceException)
        //    {
        //        return null;
        //    }
        //}
        protected void WaiteUntilPageLoad(int time = 10)
        {
            //driverHelper.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
            var wait_pl = new WebDriverWait(driverHelper, TimeSpan.FromSeconds(time));
            wait_pl.Until(driverHelper =>
               (long)((IJavaScriptExecutor)driverHelper).ExecuteScript("return jQuery.active") == 0);
        }

        protected void WaitInvisibilityOfElementLocated(string xpath)
        {
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(xpath)));
        }
    }
}
