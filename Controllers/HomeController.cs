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
        private IDistributedCache _cache;
         public HomeController (IDistributedCache cache)
          {
           _cache = cache;
          }
       public IActionResult Index ()
        {
            string value = _cache.GetString ("Time");
            if (value == null)
        {
            DateTime.Now.ToString value = ();
            _cache.SetString ("CacheTime", value);
        }
            ViewData ["CacheTime"] = value;
            ViewData ["CurrentTime"] = DateTime.Now.ToString ();
            return View ();
        }

        public IActionResult About()
        {
            var userContent = HttpContext.Session.GetString("User");
            return Json(userContent);
        }
    }
}
