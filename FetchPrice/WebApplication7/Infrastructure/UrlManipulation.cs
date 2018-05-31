using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Infrastructure
{
    public class UrlManipulation
    {
        public static string EncodedString(string Link)
        {
            string result = Uri.EscapeDataString(Link);

            return result;
        }


    }
}
