using System;
using Xunit.Abstractions;
using Platron.Core.Service;

namespace Platron.Tests
{
    public class BaseTest : IDisposable
    {
        private readonly ITestOutputHelper _output;

        public BaseTest(ITestOutputHelper output)
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
    
