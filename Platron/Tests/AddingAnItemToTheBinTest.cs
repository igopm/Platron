using System;
using NUnit.Framework;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using Platron.Pages.Helpers;

namespace Platron.Tests
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("Platron")]
    public class AddingAnItemToTheBinTest : BaseTest
    {
        [Test]
        public void AddingAnItemToTheBin()
        {
            Print("AddingAnItemToTheBin");
            new DemoshopHelper()
                .ClickInBinOnPage()
                .CheckExistRowsInBin(1);
        }
    }
}
