using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Platron.Pages
{
    public class AuthPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "inputLogin")]
        public IWebElement FieldLogIn { get; set; }

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement ButtonSubmit { get; set; }

        [FindsBy(How = How.Id, Using = "inputPassword")]
        public IWebElement FieldPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/div[contains(@class, 'form-message')]")]
        public IWebElement AlertMessage { get; set; }
    }
}
