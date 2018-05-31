using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;

namespace WebApplication7.Infrastructure
{
    public class RootObject
    {
            public Request request { get; set; }
        public List<Object> Objects { get; set; } = new List<Object>();
            
    }
    
    
    public class Request
    {
        public string pageUrl { get; set; }
        public string api { get; set; }
        public int version { get; set; }
    }

    public class Image
    {
        public int width { get; set; }
        public int naturalHeight { get; set; }
        public string url { get; set; }
        public int naturalWidth { get; set; }
        public bool primary { get; set; }
        public int height { get; set; }
    }

    public class OfferPriceDetails
    {
        public int amount { get; set; }
        public string text { get; set; }
    }

    public class Specs
    {
        public string date_first_available_at_amazonin { get; set; }
        public string average_customer_review { get; set; }
        public string amazon_bestsellers_rank { get; set; }
        public string asin { get; set; }
    }

    public class NormalizedSpecs
    {
    }

    public class Breadcrumb
    {
        public string link { get; set; }
        public string name { get; set; }
    }

    public class Object
    {
        public List<Image> images { get; set; }
        public string offerPrice { get; set; }
        public string productId { get; set; }
        public string diffbotUri { get; set; }
        public bool multipleProducts { get; set; }
        public bool availability { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public OfferPriceDetails offerPriceDetails { get; set; }
        public Specs specs { get; set; }
        public NormalizedSpecs normalizedSpecs { get; set; }
        public List<Breadcrumb> breadcrumb { get; set; }
        public string humanLanguage { get; set; }
        public string pageUrl { get; set; }
        public string text { get; set; }
        public string category { get; set; }
        public string sku { get; set; }
        public string brand { get; set; }
    }
}

