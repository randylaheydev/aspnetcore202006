using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoweb.Models.ViewModels;
using MCronberg;
using Microsoft.AspNetCore.Mvc;

namespace demoweb.Controllers
{
    public class AppController : Controller
    {
        private readonly IPersonRepository rep;

        [HttpGet("~/")]
        [HttpGet("~/forside")]
        public IActionResult Index()
        {
            
            demoweb.Models.DatoHjælper d = new demoweb.Models.DatoHjælper();
            var a = d.FindDag();
            ViewBag.dato = a;

            AppIndexViewModel v = 
                    new AppIndexViewModel { Personer = rep.GetPeople(), Faktura = new Models.Faktura { Id = 1 } };

            
            return View(v);
        }

        public AppController(MCronberg.IPersonRepository rep)
        {
            this.rep = rep;
        }
    }

    
}
