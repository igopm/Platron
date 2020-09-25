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
    public class CliningBinTest : BaseTest
    {
        [Test]
        public void CliningBin()
        {
            Print("CliningBin");
            new DemoshopHelper()
                .ClickInBinOnPage()
                .CheckExistRowsInBin(1)
                .ActionRemoveElementFromBin()
                .CheckExistRowsInBin();
        }
    }
}
