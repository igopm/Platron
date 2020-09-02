using System;
using System.Configuration;

namespace Platron.Core
{
    public static class Config
    {
        public static string urlDriverChrome { get { return ConfigurationManager.AppSettings["urlChromeDriver"]; } }

        public static string UrlWebPlatron { get { return ConfigurationManager.AppSettings["urlWebPlatron"]; } }
    }
}