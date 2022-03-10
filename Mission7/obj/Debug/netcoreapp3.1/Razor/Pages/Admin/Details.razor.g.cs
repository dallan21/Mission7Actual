#pragma checksum "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f478449f6b3d5df4d8d6d1925cbbde73c8333832"
// <auto-generated/>
#pragma warning disable 1591
namespace Mission7.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/_Imports.razor"
using Mission7.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"bg-info text-white text-center p-1\">Details</h3>\n\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "<th>Book ID:</th>");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 9 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/Details.razor"
                                  book.BookId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n\n        ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "<th>Name:</th>");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 11 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/Details.razor"
                               book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n\n        ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "<th>Author:</th>");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 13 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/Details.razor"
                                 book.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n\n        ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "<th>Publisher:</th>");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 15 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/Details.razor"
                                    book.Publisher

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n\n        ");
            __builder.OpenElement(26, "tr");
            __builder.AddMarkupContent(27, "<th>Isbn:</th>");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 17 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/Details.razor"
                               book.Isbn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n\n        ");
            __builder.OpenElement(31, "tr");
            __builder.AddMarkupContent(32, "<th>Classification:</th>");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 19 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/Details.razor"
                                         book.Classification

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n\n        ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "<th>Category:</th>");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 21 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/Details.razor"
                                   book.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n\n        ");
            __builder.OpenElement(41, "tr");
            __builder.AddMarkupContent(42, "<th>Page Count:</th>");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 23 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/Details.razor"
                                     book.PageCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n\n        ");
            __builder.OpenElement(46, "tr");
            __builder.AddMarkupContent(47, "<th>Price:</th>");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, "$");
            __builder.AddContent(50, 
#nullable restore
#line 25 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/Details.razor"
                                 book.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
            __builder.AddAttribute(55, "class", "btn btn-warning");
            __builder.AddAttribute(56, "href", 
#nullable restore
#line 30 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/Details.razor"
                                        EditUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(58, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(60);
            __builder.AddAttribute(61, "class", "btn btn-secondary");
            __builder.AddAttribute(62, "href", "admin/books");
            __builder.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(64, "Back");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "/Users/dallanhernandez/Documents/GitHub/Mission7Actual/Mission7/Pages/Admin/Details.razor"
       

    [Inject]
    public BookListRepository repo { get; set; }

    [Parameter]
    public long Id { get; set; }

    public Book book { get; set; }

    protected override void OnParametersSet()
    {
        book = repo.Books.FirstOrDefault(x => x.BookId == Id);
    }

    public string EditUrl => $"/admin/books/edit/{book.BookId}";


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
