using System;
using System.IO;
using System.Net;
using System.Threading;

namespace ROCKET{
    class updates{
        //static readonly HttpClient client = new HttpClient();
        public static void minor(){
            //weatherKey
            /*HttpResponseMessage response = await client.GetAsync("https://api.openweathermap.org/data/2.5/weather?q=London&appid=df623357fb1e0d5bf4a681eb67ab0830");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);*/
            var webClient = new WebClient();
            string json = webClient.DownloadString("https://api.openweathermap.org/data/2.5/weather?q=London&appid=df623357fb1e0d5bf4a681eb67ab0830");
               //string json = File.ReadAllText("test.json");
            Console.WriteLine(json+"\n end");
        }
    }
}