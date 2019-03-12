using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JakobHendrixCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            // TODO: https://scottsauber.com/2017/04/03/adding-global-error-handling-and-logging-in-asp-net-core/
            // what else do we want to do to capture error data?
            return View();
        }
    }
}