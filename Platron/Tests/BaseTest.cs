using System;
using Platron.Core.Service;

namespace Platron.Tests
{
    public class BaseTest : IDisposable
    {
        public BaseTest()
        {
            Console.WriteLine("Constructor");
            ServiceDriver.initilize();
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose");
            ServiceDriver.Quit();
        }
    }
}
    
