using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace view3demo.Components
{
    public class CountTagHelper : TagHelper
    {

        public int CountTo { get; set; } = 1;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            int[] a = Enumerable.Range(1, CountTo).ToArray();
            string txt = string.Join(" ", a);
            output.Content.SetContent(txt);            
        }
    }
}
