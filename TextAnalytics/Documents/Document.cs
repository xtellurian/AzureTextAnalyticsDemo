using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TextAnalyticsDemo
{
    public abstract class Document
    {
        [JsonProperty("id")]
        public string Id {get;set;}
    }

    public class TAResponseDocument : Document
    {
        [JsonProperty("score")]
        public float Score {get; set;}
    }

     public class TARequestDocument : Document
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
