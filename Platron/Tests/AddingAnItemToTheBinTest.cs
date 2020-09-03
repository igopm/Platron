using System;
using Xunit;
using Xunit.Abstractions;
using Platron.Pages.Helpers;

namespace Platron.Tests
{
    public class AddingAnItemToTheBinTest : BaseTest
    {
        public AddingAnItemToTheBinTest(ITestOutputHelper output) : base(output) { }

        [Fact]
        public void AddingAnItemToTheBin()
        {
            new DemoshopHelper()
                .ClickInBinOnPage()
                .CheckExistRowsInBin(1);
        }
    }
}
