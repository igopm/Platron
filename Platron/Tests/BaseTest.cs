using System;
using NUnit.Framework;
using Platron.Core;
using Platron.Core.Service;

namespace Platron.Tests
{
    public class BaseTest : IDisposable
    {
        public BaseTest()
        {
            //RunSettings.ConfigurationFiles();
            Print("Constructor");
            ServiceDriver.initilize();
        }

        public void Print(string m)
        {
            TestContext.Error.WriteLine(m);
        }
        [TearDown]
        public void Close()
        {
            Print("TearDown");
        }

        public void Dispose()
        {
            Print("Dispose");
            ServiceDriver.Quit();
        }
    }
}
    
