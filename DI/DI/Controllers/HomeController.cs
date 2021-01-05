using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DI.Models;

namespace DI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
      private readonly  IHelloWorldService _helloWorldService;

        public HomeController(ILogger<HomeController> logger , IHelloWorldService helloWorldService)
        {
            _logger = logger;
            _helloWorldService = helloWorldService;
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
