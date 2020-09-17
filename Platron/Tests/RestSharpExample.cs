using System;
using NUnit.Framework;
using RestSharp;

namespace RestSharpExample
{
    public class RunSettings
    {
        
        private static RunSettings instance = null;

        public string Name { get; private set; }

        protected RunSettings()
        {
            Console.WriteLine("RunSettings Constructor");
        }

        public static RunSettings getInstance()
        {
            if (instance == null)
                instance = new RunSettings();
            else
                Console.WriteLine("RunSettings is exist");
            return instance;
        }
    }

    public class SingletonHandle
    {
        public RunSettings rs { get; set; }
        public void Start()
        {
            rs = RunSettings.getInstance();
        }
    }

    [TestFixture]
    public class RestSharpExample
    {
        //    private object lt;

        //    public bool Is { get; private set; }

        [Test]
        public void GetWeatherInfo()
        {


            var sh = new SingletonHandle();
            sh.Start();

            // у нас не получится изменить ОС, так как объект уже создан    
            sh.rs = RunSettings.getInstance();

            //const string url = "http://api.zippopotam.us/us/90210";
            //// arrange
            //RestClient client = new RestClient(url);
            //RestRequest request = new RestRequest("us/90210", Method.GET);

            ////// act
            //IRestResponse response = client.Execute(request);
        }
    }
}
