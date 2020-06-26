using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace view3demo.Components
{
    public class CountViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int countTo)
        {
            int[] a = Enumerable.Range(1, countTo).ToArray();
            return View(a);
        }
    }
}
