using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using routedemo2.Models;

namespace routedemo2.Controllers
{
    public class AppController : Controller
    {
        [HttpGet("~/")]
        [HttpGet("~/Forside", Name = "forside")]
        [HttpGet("~/Home" )]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("salg/{år:range(2000,2030)}")]
        public IActionResult Salg(int år)
        {
            
            return View();
        }

        [HttpGet("data")]
        public IActionResult Data()
        {
            Person p = new Person();
            p.Navn = "aa";
            p.Alder = 10;
            return View(p);
        }

        [HttpPost("data")]
        public IActionResult Data(Person p)
        {

            return View();
        }


    }
}
