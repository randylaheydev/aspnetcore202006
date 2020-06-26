using MCronberg;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asyncdemo.Models
{
    public class PersonerViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(int antal)
        {
            var p = new List<Person>();
            for (int i = 0; i < antal; i++)
            {
                p.Add(new Person() { PersonId = i + 1, FirstName = ((char)(i + 65)).ToString() });
            }
            return View(p);
        }
    }
}
