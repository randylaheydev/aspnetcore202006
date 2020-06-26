using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace view3demo.Controllers
{
    public class AppController : Controller
    {
        [HttpGet("~/")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
