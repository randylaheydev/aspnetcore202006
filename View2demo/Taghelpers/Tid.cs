using MCronberg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace view2demo
{
    public class TidTagHelper : TagHelper
    {
        public bool LangtFormat { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("class", "minTid");
            if (LangtFormat)
                output.Content.SetContent(DateTime.Now.ToLongTimeString());
            else
                output.Content.SetContent(DateTime.Now.ToShortTimeString());
        }
    }

    public class PersonTagHelper : TagHelper
    {
        public Person PersonModel { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Content.SetHtmlContent(
                $@"{PersonModel.FirstName} er {PersonModel.Height} cm høj og bor i ...");
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }

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
