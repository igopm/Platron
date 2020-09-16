using System;
using NUnit.Framework;
using Platron.Pages.Helpers;

namespace Platron.Tests
{
    [TestFixture]
    public class CliningBinTest : BaseTest
    {
        [Test]
        public void CliningBin()
        {
            new DemoshopHelper()
                .ClickInBinOnPage()
                .CheckExistRowsInBin(1)
                .ActionRemoveElementFromBin()
                .CheckExistRowsInBin();
        }
    }
}
