using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MCronberg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace view1demo.Controllers
{
    public class AppController : Controller
    {
        private readonly IPersonRepository rep;

        [HttpGet("~/")]
        public IActionResult Index()
        {
            return View(rep.GetPeople(10));
        }

        public AppController(IPersonRepository rep)
        {
            this.rep = rep;
        }

    }
}
