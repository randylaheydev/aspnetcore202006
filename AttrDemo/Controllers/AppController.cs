using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using attrdemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace attrdemo.Controllers
{
    public class AppController : Controller
    {
        [HttpGet("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("~/")]
        public IActionResult Index(Person model)
        {
            if (ModelState.IsValid) {
                // redirect
                // return RedirectToAction("Forside");
                return View();
            } else {
                return View();
            }
            
        }

        [HttpPost("~/validate")]
        public IActionResult Validate(string txt)
        {
            if (txt.Length < 5) {
                return Json(new { success= false, err = "****" });
            } else {
                return Json(new { success = true });
            }

        }



    }
}
