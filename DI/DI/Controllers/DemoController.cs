using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index([FromServices] IHelloWorldService helloWorldService)
        {
            ViewData["MyText"] = helloWorldService.SaysHello() + "Jignesh!";
            return View();
        }

        //public IActionResult Index1()
        //{
        //    var helloWorldService = (IHelloWorldService)this.HttpContext.RequestServices.GetService(typeof(IHelloWorldService));
        //    ViewData["MyText"] = helloWorldService.SaysHello() + "Jignesh Trivedi!";
        //    return View("index");
        //}
    }
}
