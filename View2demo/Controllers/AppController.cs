using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace view2demo.Controllers
{
    public class AppController : Controller
    {
        [HttpGet("~/")]
        public IActionResult Index()
        {
            return View(MCronberg.PersonRepositoryRandom.JustGetPeople()[0]);
        }

        [HttpGet("~/liste5")]
        public IActionResult Liste5()
        {            
            return View();
        }


        [HttpPost("~/salg")]
        public IActionResult Salg(int? år)
        {
            return View();
        }

    }
}
