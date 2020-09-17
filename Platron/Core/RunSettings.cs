using System;
using System.IO;
using NUnit.Framework;

namespace Platron.Core
{
    public class RunSettings
    {
        private static string slash = @"\";
        private static string pathPlatronCurrentDirectory = Path.Combine(Environment.CurrentDirectory);
        private static string pathPlatronFolder = pathPlatronCurrentDirectory + slash + pathPlatronCurrentDirectory.Split('\\')[3];
        private static string pathAllureConfig = pathPlatronFolder + slash + "allureConfig.json";
        private static string pathAllureFolder = pathPlatronCurrentDirectory + slash + "allure-results";
        private static string pathDebugFolder = pathPlatronFolder + slash + @"bin\Debug" + slash;

        private static void CreateDirectoryAllure()
        {
            if (!Directory.Exists(pathAllureFolder))
                Directory.CreateDirectory(pathAllureFolder);
        }

        private static void CoppyAllureConfig()
        {
            var temp = pathDebugFolder + "allureConfig.json";
            if (!File.Exists(temp))
                File.Copy(pathAllureConfig, temp);
        }

        public void ConfigurationFiles()
        {
            CreateDirectoryAllure();
            CoppyAllureConfig();
        }

        public static void TETST()
        {

            Console.WriteLine(pathPlatronFolder);
            //foreach (var d in temp)
            //    Console.WriteLine(d);
        }
    }
}
