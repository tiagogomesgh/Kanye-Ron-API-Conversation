using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {
            // var client = new HttpClient();
            new QuoteGenerator();
            for (int i = 0; i < 5; i++)
            {
                QuoteGenerator.ronQuote();
                QuoteGenerator.kanyeQuote();
            }
            
            // var kanyeURL = "https://api.kanye.rest";
            
            // var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            // var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            // System.Console.WriteLine($"{kanyeQuote}");


            // var client2 = new HttpClient();
            
            // var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            
            // var ronResponse = client.GetStringAsync(ronURL).Result;

            // var ronQuote = JObject.Parse(ronResponse).GetValue("quote").ToString();

            // System.Console.WriteLine($"{ronQuote}");


        }
    }

    public class QuoteGenerator
    {
        public static void kanyeQuote()
        {
            var client = new HttpClient();
            
            var kanyeURL = "https://api.kanye.rest";
            
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            System.Console.WriteLine($"-----------------------");
            System.Console.WriteLine($"Kanye:   '{kanyeQuote}'.");
            System.Console.WriteLine($"-----------------------");
        }
        
        public static void ronQuote()
        {
            var client = new HttpClient();
            
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            
            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            System.Console.WriteLine($"-----------------------");
            System.Console.WriteLine($"Ron:   '{ronQuote}'.");
            System.Console.WriteLine($"-----------------------");
        }
    }
}
