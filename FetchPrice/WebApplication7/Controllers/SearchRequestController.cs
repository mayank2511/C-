using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication7.Controllers
{
    public class SearchRequestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult DeserializeJson(string url)
        {
            ViewBag.Value = Infrastructure.JsonToCsharp.DeserializeJson(url);
            return View("Index");
        }
        
    }
}