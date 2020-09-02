using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Platron.Core.Service;
using Platron.Pages.Main;

namespace Platron.Pages
{
    class BaseHelper
    {
        protected readonly IWebDriver driverHelper;
        #region Helpers/Pages
        public MainHelper MainHelper { get { return new MainHelper(); } }
        protected MainPage UIMainPage { get { return new MainPage(); } }
        #endregion

        public BaseHelper()
        {
            this.driverHelper = ServiceDriver.Driver;
        }

        public void ActionFillField(IWebElement element, string value)
        {
            WaitElementHelper(element).SendKeys(value);
        }

        public IWebElement WaitElementHelper(IWebElement element)
        {
            WebDriverWait waitTemp = new WebDriverWait(driverHelper, TimeSpan.FromMilliseconds(20000));
            waitTemp.Until(ExpectedConditions.ElementToBeClickable(element));
            return element;
        }

        public void ImplicitWaitElementHelper(int time = 5)
        {
            driverHelper.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
        }

        public void WaitInvisibilityOfElementLocated(string xpath)
        {
            WebDriverWait waitTemp = new WebDriverWait(driverHelper, TimeSpan.FromMilliseconds(20000));
            waitTemp.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(xpath)));
        }

        public void DrawHighlight(IWebElement element)
        {
            IWebDriver wd = driverHelper;
            IJavaScriptExecutor jse = (IJavaScriptExecutor)wd;
            jse.ExecuteScript(
@"arguments[0].style.border='3px solid red';
setTimeout(() => arguments[0].style.border='0px solid red', 3000);", element);
        }
    }
}
