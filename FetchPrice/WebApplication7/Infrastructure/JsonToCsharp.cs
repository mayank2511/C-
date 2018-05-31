using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;




namespace WebApplication7.Infrastructure
{
    public class JsonToCsharp
    {
        public static string DeserializeJson(string InputString)
        {
            
            string JsonCode = JsonString.GetJsonString(InputString);

            RootObject  ProductDetails = JsonConvert.DeserializeObject<RootObject>(JsonCode);

            foreach(Object i in ProductDetails.Objects)
            {
                return i.offerPrice;

            }

            return "";         
        }


    }
}



