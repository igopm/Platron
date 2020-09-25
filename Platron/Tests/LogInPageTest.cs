using System;
using NUnit.Framework;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using Platron.Pages.Helpers;
using Platron.Core;

namespace Platron.Tests
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("Platron")]
    public class LogInPageTest : BaseTest
    {
        [Test]
        public void CheckWorningMessageInLogInPage()
        {
            //RunSettings.TETST();

            // Print("CheckWorningMessageInLogInPage");
            //throw new Exception("CheckWorningMessageInLogInPage");
            new DemoshopHelper()
                .ClickButtonEnter()
                .ActionSetLogIn("notCorrect")
                .ActionSetPassword("password")
                .ActionClickButtonSubmit()
                .CheckAlertMessage("Введенная комбинация логин/пароль неверна");
        }
    }
}
