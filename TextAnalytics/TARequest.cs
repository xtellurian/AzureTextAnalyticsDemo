using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TextAnalyticsDemo
{
    public class TARequest
    {
        const string English = "en";

        [JsonProperty("documents")]
        public List<Document> Documents{get;set;}
        public TARequest()
        {
            Documents = new List<Document>();
        }

        public void AddDocument(string id, string text)
        {
            Documents.Add(new TARequestDocument{Id = id, Text = text, Language = English});
        }

    }

   
}
