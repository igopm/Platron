using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Platron.Pages.Helpers
{
    public class DemoshopHelper : BaseHelper
    {
        #region Buttons
        public AuthHelper ClickButtonEnter()
        {
            WaitElementHelper(UIDemoshopPage.ButtonEnter).Click();
            driverHelper.SwitchTo().DefaultContent();
            driverHelper.SwitchTo().Frame(0);
            return AuthHelper;
        }

        public ShopCartHelper ClickInBinOnPage(int index = 1)
        {
            var elements = driverHelper.FindElements(By.XPath(UIDemoshopPage.ThingsOnMainPage));
            IWebElement element = WaitElementHelper(elements[index]);
            DrawHighlight(element);
            var inBinElement = element.FindElement(By.XPath(UIDemoshopPage.InBinOnMainPage));
            inBinElement.Click();
            return ShopCartHelper;
        }
        #endregion
    }
}
