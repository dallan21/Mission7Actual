using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Mission7.Models.ViewModels;

namespace Mission7.Infrastructure
{
    [HtmlTargetElement("div", Attributes ="page-model")]
    public class PaginationTagHelper : TagHelper 
    {
        //Dynamically create page links
        private IUrlHelperFactory uhf;

        public PaginationTagHelper (IUrlHelperFactory temp)
        {
            uhf = temp;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext vc { get; set; }

        //Different than the View Context


        public PageInfo PageModel { get; set; }

        public string PageAction { get; set; }

        public string PageClass { get; set; }

        public bool PageClassesEnabled { get; set; }

        public string PageClassNormal { get; set; }

        public string PageClassSelected { get; set; }

        public override void Process (TagHelperContext thc, TagHelperOutput tho)
        {
            IUrlHelper uh = uhf.GetUrlHelper(vc);

            //creates our final result, in a div tag
            TagBuilder final = new TagBuilder("div");

            //create a for loop that will create/display a link (a tag) to the next page
            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder tb = new TagBuilder("a");

                tb.Attributes["href"] = uh.Action(PageAction, new { pageNum = i });

                if (PageClassesEnabled)
                {
                    tb.AddCssClass(PageClass);
                    //short hand for an if statement. ? = then, : = else
                    tb.AddCssClass(i == PageModel.CurrentPage ? PageClassSelected : PageClassNormal);
                }
                //this will pull in the styles that you set using the PageClass string
                tb.AddCssClass(PageClass);
                tb.InnerHtml.Append(i.ToString());

                final.InnerHtml.AppendHtml(tb);
            }
            //appends to the html each instance of the final result
            tho.Content.AppendHtml(final.InnerHtml);
        }
    }
}
