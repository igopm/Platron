using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
        public static IWebDriver Driver = null;

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
            //Config.UrlRemoveWebDriver
            Driver = new ChromeDriver(PathDriver(), Options());
            WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        }
        private static ChromeOptions Options()
        {
            var chromeOptions = new ChromeOptions();
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
