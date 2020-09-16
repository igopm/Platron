using System;
using NUnit.Framework;
using Platron.Pages.Helpers;

namespace Platron.Tests
{
    [TestFixture]
    public class AddingAnItemToTheBinTest : BaseTest
    {
        [Test]
        public void AddingAnItemToTheBin()
        {
            new DemoshopHelper()
                .ClickInBinOnPage()
                .CheckExistRowsInBin(1);
        }
    }
}
