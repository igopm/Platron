using System;
using Xunit.Abstractions;
using Platron.Core.Service;

namespace Platron.Tests
{
    public partial class XUnitTests : IDisposable
    {
        private readonly ITestOutputHelper _output;

        public XUnitTests(ITestOutputHelper output)
        {
            _output = output;
            _output.WriteLine("Constructor");
            ServiceDriver.initilize();
        }
        public void Dispose()
        {
            _output.WriteLine("Dispose");
            ServiceDriver.Quit();
        }
}
}
