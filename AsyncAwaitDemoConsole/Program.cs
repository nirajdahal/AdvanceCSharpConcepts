using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncAwaitDemoConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();


            for (int i = 0; i < 3; i++)
            {
                var data = await RunDownloadAsyncParallel();
            }
           


            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
        }


        public static List<WebsiteDataModel> RunDownloadSync()
        {
            List<WebsiteDataModel> models = new List<WebsiteDataModel>();
            var listWebUrl = PopulateUrl();
        
            foreach (var url in listWebUrl)
            {
                var wedDataModel = GetDataSync(url);
                models.Add(wedDataModel);
            }

            return models;
        }

        public async static Task<List<WebsiteDataModel>> RunDownloadAsync()
        {
            List<WebsiteDataModel> models = new List<WebsiteDataModel>();
            var listWebUrl = PopulateUrl();

            foreach (var url in listWebUrl)
            {
                var wedDataModel = await GetDataAsync(url);
                models.Add(wedDataModel);
            }

            return models;
        }

        public async static Task<List<WebsiteDataModel>> RunDownloadAsyncParallel()
        {
            List<Task<WebsiteDataModel>> models = new List<Task<WebsiteDataModel>>();
            var listWebUrl = PopulateUrl();

            foreach (var url in listWebUrl)
            {
                
                models.Add(GetDataAsync(url));
            }


            var result =await Task.WhenAll(models);
            return result.ToList();
        }
        public static WebsiteDataModel GetDataSync(string url)
        {
            WebClient client = new WebClient();
            var dataFromWeb = client.DownloadString(url);
            WebsiteDataModel data = new WebsiteDataModel() { Data = dataFromWeb, WebsiteUrl = url };
            return data;
        }

        public async static Task<WebsiteDataModel> GetDataAsync(string url)
        {
            WebClient client = new WebClient();
            var dataFromWeb = await client.DownloadStringTaskAsync(url);
            WebsiteDataModel data = new WebsiteDataModel() { Data = dataFromWeb, WebsiteUrl = url };
            return data;
        }
        public static List<string> PopulateUrl()
        {
            {
                List<string> output = new List<string>();
                output.Add("https://www.yahoo.com");
                output.Add("https://www.google.com");
                output.Add("https://www.microsoft.com");
                output.Add("https://www.cnn.com");
                output.Add("https://www.codeproject.com");
                output.Add("https://www.stackoverflow.com");

                return output;
            }


        }

        public class WebsiteDataModel
        {
            public string WebsiteUrl { get; set; }

            public string Data { get; set; }
        }
    }
}
