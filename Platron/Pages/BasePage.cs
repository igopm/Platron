using System;
using OpenQA.Selenium;
using Platron.Core.Service;
using SeleniumExtras.PageObjects;

namespace Platron.Pages
{
    public class BasePage
    {
        private readonly IWebDriver driver;
        protected BasePage()
        {
            this.driver = ServiceDriver.Driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Войти")]
        public IWebElement ButtonEnter { get; set; }
    }
}
