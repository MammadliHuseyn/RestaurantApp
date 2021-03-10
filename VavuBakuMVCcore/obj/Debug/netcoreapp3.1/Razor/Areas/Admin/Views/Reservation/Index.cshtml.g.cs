#pragma checksum "C:\Users\Husey\source\repos\VavuBakuMVCcore\VavuBakuMVCcore\Areas\Admin\Views\Reservation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "723addc0cdcc0932bca34e396e3b5bff36548007"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Reservation_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Reservation/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Husey\source\repos\VavuBakuMVCcore\VavuBakuMVCcore\Areas\Admin\Views\_ViewImports.cshtml"
using VavuBakuMVCcore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Husey\source\repos\VavuBakuMVCcore\VavuBakuMVCcore\Areas\Admin\Views\_ViewImports.cshtml"
using VavuBakuMVCcore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"723addc0cdcc0932bca34e396e3b5bff36548007", @"/Areas/Admin/Views/Reservation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5850a90feb86452679db36c8ba29217dd327953d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Reservation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 5 "C:\Users\Husey\source\repos\VavuBakuMVCcore\VavuBakuMVCcore\Areas\Admin\Views\Reservation\Index.cshtml"
     foreach (var book in Model.OrderByDescending(x=>x.Id))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-xl-4 col-lg-4 col-md-4 col-sm-12 col-12  mt-3"">
            <div class=""card"" style=""width:100%; background-color:#4e73df"">
                <div class=""card-body"">
                    <h5 class=""card-title font-weight-bold text-white"">");
#nullable restore
#line 10 "C:\Users\Husey\source\repos\VavuBakuMVCcore\VavuBakuMVCcore\Areas\Admin\Views\Reservation\Index.cshtml"
                                                                  Write(book.BookDate.ToString("dd MMMM HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"text-gray-300\">(");
#nullable restore
#line 10 "C:\Users\Husey\source\repos\VavuBakuMVCcore\VavuBakuMVCcore\Areas\Admin\Views\Reservation\Index.cshtml"
                                                                                                                                        Write(book.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" nəfər)</span></h5>\r\n                </div>\r\n                <ul class=\"list-group list-group-flush bg-light\">\r\n                    <li class=\"list-group-item\"><span class=\"text-dark\">Email: </span> ");
#nullable restore
#line 13 "C:\Users\Husey\source\repos\VavuBakuMVCcore\VavuBakuMVCcore\Areas\Admin\Views\Reservation\Index.cshtml"
                                                                                  Write(book.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\"><span class=\"text-dark\">Tel: </span> ");
#nullable restore
#line 14 "C:\Users\Husey\source\repos\VavuBakuMVCcore\VavuBakuMVCcore\Areas\Admin\Views\Reservation\Index.cshtml"
                                                                                Write(book.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\"><span class=\"text-dark\">Ad: </span>");
#nullable restore
#line 15 "C:\Users\Husey\source\repos\VavuBakuMVCcore\VavuBakuMVCcore\Areas\Admin\Views\Reservation\Index.cshtml"
                                                                              Write(book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\"><span class=\"text-dark\">Tarix: </span>");
#nullable restore
#line 16 "C:\Users\Husey\source\repos\VavuBakuMVCcore\VavuBakuMVCcore\Areas\Admin\Views\Reservation\Index.cshtml"
                                                                                 Write(book.Date.ToString("dd MMMM HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 20 "C:\Users\Husey\source\repos\VavuBakuMVCcore\VavuBakuMVCcore\Areas\Admin\Views\Reservation\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
