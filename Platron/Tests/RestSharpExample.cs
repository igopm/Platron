using System;
using NUnit.Framework;
using RestSharp;

namespace RestSharpExample
{
    [TestFixture]
    public class RestSharpExample
    {
        private object lt;

        public bool Is { get; private set; }

        [Test]
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
