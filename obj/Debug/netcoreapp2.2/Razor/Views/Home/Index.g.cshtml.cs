#pragma checksum "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f47a48eb43536db44f76f9fa2936121fcbb616b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/_ViewImports.cshtml"
using Chef_Dishes;

#line default
#line hidden
#line 2 "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/_ViewImports.cshtml"
using Chef_Dishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f47a48eb43536db44f76f9fa2936121fcbb616b6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f00ea43bd1b2438c9d16beec6e62c0f6af1f6d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 957, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <nav class=""navbar navbar-dark"">
                <a class=""navbar-brand"" href=""#"">Menu By Restaurant</a>
                <a href=""/Chefs"" class=""btn btn-info"">Chefs</a>
                <a href=""/Dishes"" class=""btn btn-primary"">Dishes</a>
            </nav>
        </div>
        <div class=""col-lg-12"">
            <h1>CHeck out our Roster of Chefs</h1>
            <p>
            <a href=""/add"" class=""btn btn-primary"">Add a Chef</a>
            </p>
            <hr>
            
            <table class=""table table-striped table-bordered"" >
                <thead>
                    <tr>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Age</th>
                        <th># Of Dishes</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 28 "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/Home/Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1049, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1112, 14, false);
#line 31 "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/Home/Index.cshtml"
                           Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1126, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1166, 13, false);
#line 32 "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/Home/Index.cshtml"
                           Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1179, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 33 "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/Home/Index.cshtml"
                              
                                DateTime today = DateTime.Today;
                                int age = today.Year - @item.DOB.Year;
                            

#line default
#line hidden
            BeginContext(1387, 32, true);
            WriteLiteral("                            <td>");
            EndContext();
            BeginContext(1420, 3, false);
#line 37 "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/Home/Index.cshtml"
                           Write(age);

#line default
#line hidden
            EndContext();
            BeginContext(1423, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1463, 23, false);
#line 38 "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/Home/Index.cshtml"
                           Write(item.DishesByChef.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1486, 68, true);
            WriteLiteral("</td>\r\n                            \r\n                        </tr>\r\n");
            EndContext();
#line 41 "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/Home/Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1577, 104, true);
            WriteLiteral("                    \r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591
