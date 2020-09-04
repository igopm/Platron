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
            WhenIsClickable(UIDemoshopPage.ButtonEnter).Click();
            WaiteUntilPageLoad();
            driverHelper.SwitchTo().DefaultContent();
            driverHelper.SwitchTo().Frame(0);

            return AuthHelper;
        }

        public ShopCartHelper ClickInBinOnPage(int index = 1)
        {
            var elements = driverHelper.FindElements(By.XPath(UIDemoshopPage.ThingsOnMainPage));
            var inBinElement = WhenIsClickable(elements[index]).FindElement(By.XPath(UIDemoshopPage.InBinOnMainPage));
            inBinElement.Click();
            return ShopCartHelper;
        }
        #endregion
    }
}
