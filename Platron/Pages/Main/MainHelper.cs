using System;
using Xunit;
using OpenQA.Selenium;

namespace Platron.Pages.Main
{
    class MainHelper : BaseHelper
    {
       
        public MainHelper() : base() { }

        #region Buttons
        public MainHelper ClickButtonEnter()
        {
            WaitElementHelper(UIMainPage.ButtonEnter).Click();
            driverHelper.SwitchTo().DefaultContent();
            driverHelper.SwitchTo().Frame(0);
            return this;
        }

        public MainHelper ClickButtonSubmit()
        {
            UIMainPage.ButtonSubmit.Click();
            return this;
        }

        public MainHelper ClickInBinOnPage(int index = 1)
        {
            var elements = driverHelper.FindElements(By.XPath(UIMainPage.ThingsOnMainPage));
            IWebElement element = WaitElementHelper(elements[index]);
            DrawHighlight(element);
            var inBinElement = element.FindElement(By.XPath(UIMainPage.InBinOnMainPage));
            inBinElement.Click();
            ImplicitWaitElementHelper();
            driverHelper.SwitchTo();
            return this;
        }

        public MainHelper ClickBack()
        {
            driverHelper.Navigate().Back();
            return this;
        }

        public MainHelper ActionRemoveElementFromBin()
        {
            var element = driverHelper.FindElement(By.XPath(UIMainPage.RowsOnBinPage))
                .FindElement(By.XPath(UIMainPage.RemoveRowOnBinPage));
            element.Click();
            WaitInvisibilityOfElementLocated(UIMainPage.RowsOnBinPage);
            return this;
        }
        #endregion
        #region SetFields
        public MainHelper SetLogIn(string login)
        {
            this.ActionFillField(UIMainPage.FieldLogIn, login);
            return this;
        }

        public MainHelper SetPassword(string password)
        {
            this.ActionFillField(UIMainPage.FieldPassword, password);
            return this;
        }
        #endregion
        #region Checks
        public MainHelper CheckExistRows(int expectedElement = 0)
        {
            ImplicitWaitElementHelper();
            var temp = driverHelper.FindElements(By.XPath(UIMainPage.RowsOnBinPage));
            Assert.Equal(expectedElement, temp.Count);
            return this;
        }
        public MainHelper CheckAlertMessage(string expected)
        {
            Assert.Equal(expected, WaitElementHelper(UIMainPage.AlertMessage).Text.ToString());
            return this;
        }
        #endregion
    }
}
