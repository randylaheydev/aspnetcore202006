using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace rute1.Controllers
{
    public class AppController : Controller
    {
        
        //[HttpGet("~/{id:int}")]
        [HttpGet("salg/{�r:int}/{mdr?:range(1,12)}")]
        public IActionResult Index(string id, int �r, int? mdr)
        {
            ViewBag.id = id;
            return View();
        }

    }
}
