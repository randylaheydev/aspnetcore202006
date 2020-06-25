using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using repdemo.Models;

namespace repdemo.Controllers
{
    public class AppController : Controller
    {
        private readonly IPersonRespository rep;

        [HttpGet("~/")]
        public IActionResult Index()
        {            
            return View(rep.HentData());
        }

        public AppController(IPersonRespository rep)
        {
            this.rep = rep;
        }

    }
}
