using Microsoft.AspNetCore.Mvc;
using System.Text;
using WebCache.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;

namespace WebCache.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var watch = Stopwatch.StartNew();
            //watch.Stop();
            // string jSONText = RetrieveOrUpdateRedis();


            //TempData["DataLoadTime"] = watch.ElapsedMilliseconds;
            //var itemsFromjSON = JsonConvert.DeserializeObject<IEnumerable<TwitterItem>>(jSONText);
            //return View();
            HttpContext.Session.SetString("User", "Rami");
            
            return Json(true);
        }

        public IActionResult About()
        {
            var userContent = HttpContext.Session.GetString("User");
            return Json(userContent);
        }
    }
}
