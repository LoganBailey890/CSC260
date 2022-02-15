using CSC260.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CSC260.Controllers
{
    public class HomeController : Controller
    {
        private static int count = 0;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.count = count++;
            ViewData["Title"] = "Home Page - in View";
            DateTime d = DateTime.Now;
            return View();
        }

        public IActionResult Test(int? id)
        {
            //int id = 0;

            //if (Request.RouteValues["id"] != null)
            //{
            //    var idparam = Request.RouteValues["id"];
            //    id = int.Parse(idparam.ToString());
            //}
            //return Content("Hello" + id);
            return Content($"id = {id?.ToString() ?? "VERY NULL"}");
        }

        public IActionResult Colors(string colors)
        {
            var colorList = colors.Split('/');
            return Content(string.Join(",", colorList));
            //return Content(colors);
        }
        [Route("SHHH")]
        public IActionResult TopSecret()
        {
            return Content("Secret");
        }

        public IActionResult Privacy(string version)
        {
            ViewBag.Version = version;
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Result(string FirstName)
        {
            //ViewBag.FirstName = Request.Form["FirstName"];
            ViewBag.FirstName = FirstName;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
