using MadForInputs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MadForInputs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy(string noun, string nounPlural, string Adjective, string Verb, string nounPlural1, string Color)
        {
            ViewBag.noun = noun;
            ViewBag.nounPlural = nounPlural;
            ViewBag.adjective = Adjective;
            ViewBag.verb = Verb;
            ViewBag.nounPlural1 = nounPlural1;
            ViewBag.color = Color;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
