using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Roauting.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Roauting.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

/*        [Route("{id}")]
        public IActionResult Test(int? id)
        {
            return Content($"The cow moos at you {id?.ToString()} times");
        }*/

        [Route("EatMoreChicken")]
        public IActionResult TopSecret()
        {
            return Redirect("https://www.chick-fil-a.com/");
        }

        [Route("{num:int}/{name?}")]
        public IActionResult CowsName(int? num, string name)
        {
            return Content($"The cow, {name?.ToString() ?? "Default Cow"}, moos at you {num?.ToString() ?? "Null"} times.");
        }

        [Route("AllCows/Gallery/{id:int}/{page?}")]
        public IActionResult AllCows(int? id, int? page)
        {
            return Content($"There is {id?.ToString() ?? "Null"} Cows on page {page?.ToString()}");

        }
        [Route("AllCows/Gallery/{id:int}/Page{page}")]
        public IActionResult AllCowsTake2(int? id, int? page)
        {
                return Content($"There are {id?.ToString()} cows per page, page {page?.ToString()}");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
