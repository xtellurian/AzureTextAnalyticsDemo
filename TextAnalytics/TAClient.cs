using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TextAnalyticsDemo
{
    class TAClient
    {
        private string _apiKey;
        private const string _endpoint = "https://westus.api.cognitive.microsoft.com/text/analytics/v2.0/sentiment";
        public TAClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<TAResponse> AnalyseSentiment(TARequest req)
        {
            HttpResponseMessage res;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _apiKey);

                var content = new StringContent( JsonConvert.SerializeObject( req));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                Console.WriteLine("Posting to endpoint");
                res = await client.PostAsync(_endpoint,content );
                Console.WriteLine($"Response: {res.StatusCode}");
            }

            var data = JsonConvert.DeserializeObject<TAResponse>(await res.Content.ReadAsStringAsync());
            return data;
        }
    }
}
