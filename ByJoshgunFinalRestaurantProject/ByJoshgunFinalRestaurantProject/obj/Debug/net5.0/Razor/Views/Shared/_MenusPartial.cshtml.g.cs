#pragma checksum "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Shared\_MenusPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7f79861d07a22b1cfa79d791ea7d50438dbd236"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MenusPartial), @"mvc.1.0.view", @"/Views/Shared/_MenusPartial.cshtml")]
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
#line 1 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\_ViewImports.cshtml"
using ByJoshgunFinalRestaurantProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\_ViewImports.cshtml"
using ByJoshgunFinalRestaurantProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\_ViewImports.cshtml"
using ByJoshgunFinalRestaurantProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7f79861d07a22b1cfa79d791ea7d50438dbd236", @"/Views/Shared/_MenusPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26eb05095af9cfa423ccb9b82f2eb96190d53cd9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__MenusPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Menu>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\" id=\"MyDataTable\">\r\n    <div class=\"col-lg-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Shared\_MenusPartial.cshtml"
                 foreach (Menu menu in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"container\" style=\"margin-top: 20px;\">\r\n                        <h4 class=\"card-title\" data-id=\"menuId-");
#nullable restore
#line 12 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Shared\_MenusPartial.cshtml"
                                                          Write(menu.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 12 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Shared\_MenusPartial.cshtml"
                                                                    Write(menu.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                        <div class=""d-flex justify-content-end align-items-center"">
                            <table class=""table table-hover table-dark"" style=""color:white !important"">
                                <thead>
                                    <tr>
                                        <th>
");
#nullable restore
#line 18 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Shared\_MenusPartial.cshtml"
                                             if (!menu.IsDeactive)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"text-success\">Aktiv</span>\r\n");
#nullable restore
#line 21 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Shared\_MenusPartial.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"text-danger\">Deaktiv</span>\r\n");
#nullable restore
#line 25 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Shared\_MenusPartial.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </th>
                                    </tr>
                                </thead>
                            </table>

                        </div>

                        <table class=""table table-hover table-dark"" style=""color:white !important"">
                            <thead>
                                <tr>
                                    <th style=""color:orange !important""> Ad?? </th>
                                    <th style=""color:orange !important""> ????ind??kil??r</th>
                                    <th style=""color:orange !important""> Qiym??ti </th>
                                    <th style=""color:orange !important""> Status </th>
                                </tr>
                            </thead>

                            <tbody>
");
#nullable restore
#line 44 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Shared\_MenusPartial.cshtml"
                                 foreach (Food food in menu.Foods)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td style=\"color:white !important\"> ");
#nullable restore
#line 47 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Shared\_MenusPartial.cshtml"
                                                                       Write(food.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td style=\"color:white !important\"> ");
#nullable restore
#line 48 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Shared\_MenusPartial.cshtml"
                                                                       Write(food.Ingredient);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td style=\"color:white !important\"> ??? ");
#nullable restore
#line 49 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Shared\_MenusPartial.cshtml"
                                                                         Write(food.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                        <td>\r\n");
#nullable restore
#line 51 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Shared\_MenusPartial.cshtml"
                                             if (!food.IsDeactive)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"text-success\">Aktiv</span>\r\n");
#nullable restore
#line 54 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Shared\_MenusPartial.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"text-danger\">Deaktiv</span>\r\n");
#nullable restore
#line 58 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Shared\_MenusPartial.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 61 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Shared\_MenusPartial.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                            <tfoot>
                                <tr>
                                    <th style=""color:orange !important""> Ad?? </th>
                                    <th style=""color:orange !important""> ????ind??kil??r</th>
                                    <th style=""color:orange !important""> Qiym??ti </th>
                                    <th style=""color:orange !important""> Status </th>
                                </tr>
                            </tfoot>
                        </table>

                    </div>
");
#nullable restore
#line 84 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Shared\_MenusPartial.cshtml"
                            
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Menu>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
