using System;
using Xunit;
using Platron.Pages.Main;

namespace Platron.Tests
{
    public partial class XUnitTests
    {
        [Fact]
        public void CheckWorningMessageInLogInPage()
        {
            new MainHelper()
                .ClickButtonEnter()
                .SetLogIn("notCorrect")
                .SetPassword("password")
                .ClickButtonSubmit()
                .CheckAlertMessage("Введенная комбинация логин/пароль неверна");
        }
        [Fact]
        public void AddingAnItemToTheBin()
        {
            new MainHelper()
                .ClickInBinOnPage()
                .CheckExistRows(1);
        }
        [Fact]
        public void CliningBin()
        {
            new MainHelper()
                .ClickInBinOnPage()
                .CheckExistRows(1)
                .ActionRemoveElementFromBin()
                .CheckExistRows();
        }
    }
}
