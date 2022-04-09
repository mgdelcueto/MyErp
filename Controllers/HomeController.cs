using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyErp.Models;

namespace MyErp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string mensaje="LO")
        {   
            string myName ="LO";
            try{
            myName=mensaje;}
            catch{myName="LO";}
            ViewData["Name"]=myName;
            return View();
        }
/*      [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Privacy(string actiontype)
        {
            ViewData["Name"]="LO";
            return RedirectToAction("Index", "Home",new{mensaje="LO"});
            //return View();
        }
*/
        public IActionResult Journal()
        {
            return View();
        }
        public IActionResult Months()
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
