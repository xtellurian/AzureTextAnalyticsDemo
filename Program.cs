using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace TextAnalyticsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a message, and let Azure CS tell you the sentiment");
            Run().Wait();

        }

        private static async Task Run()
        {
            var client = new TAClient(LoadApiKey());
            while(true)
            {
                Console.Write("Your message: ");
                var line = Console.ReadLine();
                if(!string.IsNullOrEmpty(line))
                {
                     var req = new TARequest();
                    req.AddDocument("1", line);
                    var res = await client.AnalyseSentiment(req);
                    var prev = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    foreach(var d in res.Documents)
                    {
                        Console.WriteLine($"Sentiment: {d.Score}");
                    }
                    Console.ForegroundColor = prev;
                }
            }
        }



        private static string LoadApiKey()
        {
            var fileContents = System.IO.File.ReadAllText("AppSettings.json");
            var settings = JObject.Parse(fileContents);
            return settings["api-key"].Value<string>();
        }
    }
}
