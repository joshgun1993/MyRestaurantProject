#pragma checksum "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Employees\DetailEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97592b8b3729ba7986aaa12bc5827293b2b20a61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_DetailEmployee), @"mvc.1.0.view", @"/Views/Employees/DetailEmployee.cshtml")]
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
#line 1 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\_ViewImports.cshtml"
using ByJoshgunFinalRestaurantProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\_ViewImports.cshtml"
using ByJoshgunFinalRestaurantProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\_ViewImports.cshtml"
using ByJoshgunFinalRestaurantProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97592b8b3729ba7986aaa12bc5827293b2b20a61", @"/Views/Employees/DetailEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26eb05095af9cfa423ccb9b82f2eb96190d53cd9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employees_DetailEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Employees\DetailEmployee.cshtml"
  
    ViewData["Title"] = "İşçi Təfərrüatı";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Employees\DetailEmployee.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Employees\DetailEmployee.cshtml"
Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Employees\DetailEmployee.cshtml"
Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 9 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Employees\DetailEmployee.cshtml"
Write(Model.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 10 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Employees\DetailEmployee.cshtml"
Write(Model.Position.PositionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 11 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Employees\DetailEmployee.cshtml"
Write(Model.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591