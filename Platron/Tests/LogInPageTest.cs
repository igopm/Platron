using System;
using Xunit;
using Platron.Pages.Helpers;
using Xunit.Abstractions;

namespace Platron.Tests
{
    public class LogInPageTest : BaseTest
    {
        public LogInPageTest(ITestOutputHelper output) : base(output) { }
        [Fact]
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
