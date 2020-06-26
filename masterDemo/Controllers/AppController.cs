using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace masterdemo.Controllers
{
    public class AppController : Controller
    {
        private readonly IConfiguration config;

        [HttpGet("~/")]
        public IActionResult Index()
        {
            string t = config["settings:s"];
            return View();
        }
        public AppController(IConfiguration config)
        {
            this.config = config;
        }
    }
}
