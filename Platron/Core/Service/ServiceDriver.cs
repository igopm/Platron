//#define RWD
#define IWD

using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace Platron.Core.Service
{
    public enum BrowserName
    {
        Chrome,
        Firefox
    }

    public class ServiceDriver
    {
#if (RWD)
        public static RemoteWebDriver Driver = null;
#elif (IWD)
        public static IWebDriver Driver = null;
#endif

        public static void initilize(BrowserName bn = BrowserName.Chrome)
        {
            if (Driver == null)
            {
                switch (bn)
                {
                    case BrowserName.Chrome:
                        StartChrome();
                        break;
                    default:
                        throw new Exception($"initilize: {bn} not found");
                }
            }
            Driver.Navigate().GoToUrl(Config.UrlWebPlatron);
        }
        public static void Quit()
        {
            Driver.Quit();
            Driver = null;
        }

        #region private section
        private static void StartChrome()
        {
#if (RWD)
            Driver = new RemoteWebDriver(new Uri(Config.UrlRemoveWebDriver), Options());
#elif (IWD)
            Driver = new ChromeDriver(PathDriver(), Options());
#endif
            WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }
        private static ChromeOptions Options()
        {
            var chromeOptions = new ChromeOptions();

            // headless mode
            if (Config.ModeForChrome != "")
                chromeOptions.AddArgument(Config.ModeForChrome);
            chromeOptions.AddArgument("--start-maximized");
            chromeOptions.PageLoadStrategy = PageLoadStrategy.Normal;
            return chromeOptions;
        }
        private static string PathDriver()
        {
            string pathToZip = Path.Combine(Path.GetDirectoryName(new System.Diagnostics.StackFrame(true).GetFileName()), "chromedriver.zip");
            string pathToExe = Path.Combine(Path.GetDirectoryName(new System.Diagnostics.StackFrame(true).GetFileName()), "chromedriver.exe");
            if (!File.Exists(pathToZip) || !File.Exists(pathToExe))
            {
                if (File.Exists(pathToZip))
                    File.Delete(pathToZip);

                if (File.Exists(pathToExe))
                    File.Delete(pathToExe);

                using (WebClient wc = new WebClient())
                {
                    File.WriteAllBytes(pathToZip, wc.DownloadData(new Uri(Config.UrlDriverChrome)));
                }

                ZipFile.ExtractToDirectory(pathToZip, Path.GetDirectoryName(pathToZip));
            }
            return Path.GetDirectoryName(pathToZip);
        }
        #endregion
    }
}
