using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace RestSharpExample
{
    [TestClass]
    public class RestSharpExample
    {
        private object lt;

        public bool Is { get; private set; }

        [TestMethod]
        public void GetWeatherInfo()
        {
            const string url = "http://api.zippopotam.us/us/90210";
            // arrange
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest("us/90210", Method.GET);

            //// act
            IRestResponse response = client.Execute(request);
        }
    }
}
