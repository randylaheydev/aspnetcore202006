using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using mbtest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mbtest.Controllers
{
    public class AppController : Controller
    {
        //[HttpGet("~/")]
        //public IActionResult Index(MinModel test)
        //{
        //    return View();
        //}

        [HttpGet("~/")]
        [ResponseCache(Duration = 1000)]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("~/")]
        public IActionResult Index([FromBody] MinModel m)
        {
            // ----
            return View("start" , m);
        }

        [HttpGet("~/adminret")]
        public IActionResult AdminRet()
        {
            return View();
        }

        [HttpPost("~/adminret")]
        public IActionResult AdminRet( Person p)
        {
            //Context c;
            // p
            //c.SaveChanges();
            // ----
            return View();
        }


    }
}
