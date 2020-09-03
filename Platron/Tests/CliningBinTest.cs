using System;
using Xunit;
using Xunit.Abstractions;
using Platron.Pages.Helpers;

namespace Platron.Tests
{
    public class CliningBinTest : BaseTest
    {
        public CliningBinTest(ITestOutputHelper output) : base(output) {}
        [Fact]
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
