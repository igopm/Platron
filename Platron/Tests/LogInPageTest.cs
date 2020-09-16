using System;
using NUnit.Framework;
using Platron.Pages.Helpers;

namespace Platron.Tests
{
    [TestFixture]
    public class LogInPageTest : BaseTest
    {
        [Test]
        public void CheckWorningMessageInLogInPage()
        {
            new DemoshopHelper()
                .ClickButtonEnter()
                .ActionSetLogIn("notCorrect")
                .ActionSetPassword("password")
                .ActionClickButtonSubmit()
                .CheckAlertMessage("Введенная комбинация логин/пароль неверна");
        }
    }
}
