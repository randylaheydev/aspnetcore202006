using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace asyncdemo.Controllers
{
    public class AppController : Controller
    {
        [HttpGet("~/")]
        public IActionResult Index()
        {
            string txt = System.IO.File.ReadAllText("x:\\test.txt");
            ViewBag.Tekst = txt;
            return View();
        }

        [HttpGet("~/async")]
        public async Task<IActionResult> AsyncDemo()
        {
            try
            {
                string txt = await System.IO.File.ReadAllTextAsync("x:\\test.txt");
                ViewBag.Tekst = txt;
                return View();
            }
            catch (Exception ex)
            {
                return View("error");                
            }            
        }


    }
}
