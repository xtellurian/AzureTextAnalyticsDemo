using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TextAnalyticsDemo
{
    public class TAResponse
    {

        [JsonProperty("documents")]
        public List<TAResponseDocument> Documents{get;set;}

    }

   
}
