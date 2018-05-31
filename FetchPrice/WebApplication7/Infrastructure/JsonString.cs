using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp; 

namespace WebApplication7.Infrastructure
{
    public class JsonString
    {
        public static string GetJsonString(string url) //Returning Json String
        {
            //Postman Code  
            var client = new RestClient("https://api.diffbot.com/v3/product?token=5d39d826ba3b5d1f330a94424970a212&url=" + UrlManipulation.EncodedString(url)); //URL Percentage Encoding
            var request = new RestRequest(Method.GET);
            request.AddHeader("Postman-Token", "16e2e72c-2860-44da-a757-a9a2956155e7");
            request.AddHeader("Cache-Control", "no-cache");
            IRestResponse response = client.Execute(request);
            return response.Content.ToString();  //Returning Json String        
        }
    }
}
