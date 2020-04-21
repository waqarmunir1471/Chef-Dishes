#pragma checksum "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02059e1959a74f1fd33dfdb3cfa4eda1c6492ef0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02059e1959a74f1fd33dfdb3cfa4eda1c6492ef0", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f00ea43bd1b2438c9d16beec6e62c0f6af1f6d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 951, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <nav class=""navbar navbar-dark"">
                <a class=""navbar-brand"" href=""#"">Menu By Restaurant</a>
                <a href=""/"" class=""btn btn-info"">Chefs</a>
                <a href=""/AddDish"" class=""btn btn-primary"">Dishes</a>
            </nav>
        </div>
        <div class=""col-lg-12"">
            <h1>Yum, Take a look are our tasty Dishes !!! </h1>
            <p>
            <a href=""/AddDish"" class=""btn btn-primary"">Add a Dish</a>
            </p>
            <hr>
            
            <table class=""table table-striped table-bordered"" >
                <thead>
                    <tr>
                        <th>Dish Name</th>
                        <th>Chef Name</th>
                        <th>TastiNess</th>
                        <th># Of Calories</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 28 "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/Home/Dishes.cshtml"
                     foreach (var item in ViewBag.AllDisshes)
                    {

#line default
#line hidden
            BeginContext(1053, 61, true);
            WriteLiteral("                        <tr>\n                            <td>");
            EndContext();
            BeginContext(1115, 13, false);
#line 31 "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/Home/Dishes.cshtml"
                           Write(item.DishName);

#line default
#line hidden
            EndContext();
            BeginContext(1128, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1167, 26, false);
#line 32 "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/Home/Dishes.cshtml"
                           Write(item.DishCreator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1193, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1232, 14, false);
#line 33 "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/Home/Dishes.cshtml"
                           Write(item.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(1246, 38, true);
            WriteLiteral("</td>\n                            <td>");
            EndContext();
            BeginContext(1285, 17, false);
#line 34 "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/Home/Dishes.cshtml"
                           Write(item.NoOfCalories);

#line default
#line hidden
            EndContext();
            BeginContext(1302, 36, true);
            WriteLiteral("</td>\n                        </tr>\n");
            EndContext();
#line 36 "/Users/admin/Desktop/C#-MVC/Chef-Dishes/Views/Home/Dishes.cshtml"
                    }

#line default
#line hidden
            BeginContext(1360, 99, true);
            WriteLiteral("                    \n                </tbody>\n            </table>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
