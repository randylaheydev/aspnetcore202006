using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using controllerdemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace controllerdemo.Controllers
{
    public class AppController : Controller
    {
        [HttpGet("~/HentData")]
        public IActionResult HentData()
        {
            var p = MCronberg.PersonRepositoryRandom.JustGetPeople();
            return Json(p);
        }

        [HttpGet("~/")]

        public IActionResult Index()
        {
            //return StatusCode(401, "Fejl i .....");
            //return RedirectToAction("Test");

            ViewBag.Klokken = DateTime.Now.ToLongTimeString();
            // ViewData["kl"] = DateTime.Now.ToLongTimeString();

            dynamic a = new ExpandoObject();
            a.navn = "a";
            a.alder = 11;

            return View(a);
        }

        [HttpGet("~/Test")]
        public IActionResult Test()
        {
            return View();
        }


    }
}
