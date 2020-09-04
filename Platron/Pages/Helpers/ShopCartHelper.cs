using System;
using Xunit;
using OpenQA.Selenium;

namespace Platron.Pages.Helpers
{
    public class ShopCartHelper : BaseHelper
    {
        public ShopCartHelper CheckExistRowsInBin(int expectedElement = 0)
        {
            WaiteUntilPageLoad();
            var temp = driverHelper.FindElements(By.XPath(UIShopCartPage.RowsOnBinPage));
            Assert.Equal(expectedElement, temp.Count);
            return this;
        }

        public ShopCartHelper ActionRemoveElementFromBin()
        {
            var element = driverHelper.FindElement(By.XPath(UIShopCartPage.RowsOnBinPage))
                .FindElement(By.XPath(UIShopCartPage.RemoveRowOnBinPage));
            element.Click();
            WaitInvisibilityOfElementLocated(UIShopCartPage.RowsOnBinPage);
            return this;
        }
    }
}
