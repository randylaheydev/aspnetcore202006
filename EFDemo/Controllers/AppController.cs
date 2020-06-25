using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace efdemo.Controllers
{
    public class AppController : Controller
    {
        [HttpGet("~/")]
        public IActionResult Index()
        {

            SQLiteEF.PeopleContext c = new SQLiteEF.PeopleContext();
            var r = c.People.OrderBy(i => i.PersonId).ToList();

            //var p = c.People.FirstOrDefault(i => i.PersonId == 1);
            //p.LastName = "****";
            //c.SaveChanges();
            return View(r);
        }

    }
}
