#pragma checksum "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19956f2ef68a79a72b9cf75abad0b5f5a6b06112"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19956f2ef68a79a72b9cf75abad0b5f5a6b06112", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26eb05095af9cfa423ccb9b82f2eb96190d53cd9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserVM>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white !important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateUsernameAndEmail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:10px; color:white !important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Activity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Hesablar";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex justify-content-between align-items-center"">
                    <h4 class=""card-title"">Hesablar</h4>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19956f2ef68a79a72b9cf75abad0b5f5a6b061127052", async() => {
                WriteLiteral("Yarat");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>

                <div class=""table-responsive"">
                    <table class=""table table-hover table-dark"" style=""color:white !important"">
                        <thead>
                            <tr>
                                <th style=""color:orange !important"">
                                    Ad Soyad
                                </th>
                                <th style=""color:orange !important"">
                                    İstifadəçi Adı
                                </th>
                                <th style=""color:orange !important"">
                                    Email
                                </th>
                                <th style=""color:orange !important"">
                                    İstifadəçi Rolu
                                </th>
                                <th style=""color:orange !important"">
                                    Status
                                </th>
 ");
            WriteLiteral(@"                               <th style=""color:orange !important"">
                                    Əməliyyatlar
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 40 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                             foreach (UserVM userVM in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n\r\n                                    <td style=\"color:white !important\">\r\n                                        ");
#nullable restore
#line 45 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                   Write(userVM.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td style=\"color:white !important\">\r\n                                        ");
#nullable restore
#line 48 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                   Write(userVM.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td style=\"color:white !important\">\r\n                                        ");
#nullable restore
#line 51 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                   Write(userVM.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 54 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                         if (userVM.Role == "SuperAdmin")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"text-success\">");
#nullable restore
#line 56 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                                                  Write(userVM.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 57 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"text-danger\">");
#nullable restore
#line 60 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                                                 Write(userVM.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 61 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 64 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                         if (!userVM.IsDeactive)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"text-success\">Aktiv</span>\r\n");
#nullable restore
#line 67 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"text-danger\">Deaktiv</span>\r\n");
#nullable restore
#line 71 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19956f2ef68a79a72b9cf75abad0b5f5a6b0611214610", async() => {
                WriteLiteral("Yenilə");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                                                                 WriteLiteral(userVM.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 76 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                         if (User.Identity.Name != userVM.Username)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                             if (!userVM.IsDeactive)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <!-- Button trigger modal -->
                                                <button type=""button"" class=""btn btn-outline-danger"" style=""margin-right:10px; color:white !important"" data-toggle=""modal"" data-target=""#user-");
#nullable restore
#line 83 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                                                                                                                                                                         Write(userVM.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                    Deaktiv Et
                                                </button>
                                                <!-- Modal -->
                                                <div class=""modal fade""");
            BeginWriteAttribute("id", " id=\"", 4968, "\"", 4988, 2);
            WriteAttributeValue("", 4973, "user-", 4973, 5, true);
#nullable restore
#line 87 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
WriteAttributeValue("", 4978, userVM.Id, 4978, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                                    <div class=""modal-dialog"" role=""document"">
                                                        <div class=""modal-content"">
                                                            <div class=""modal-header"">
                                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                                    <span aria-hidden=""true"">&times;</span>
                                                                </button>
                                                            </div>
                                                            <div class=""modal-body"">
                                                                <h3>Deaktiv etmək istədiyinizə əminsiniz ? </h3>
                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19956f2ef68a79a72b9cf75abad0b5f5a6b0611220202", async() => {
                WriteLiteral("Bəli");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                                                                           WriteLiteral(userVM.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                                <button type=""button"" class=""btn btn-outline-danger"" style=""margin-right:10px; color:white !important"" data-dismiss=""modal"">Xeyr</button>
                                                            </div>
                                                            <div class=""modal-footer"">
                                                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Bağla</button>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
");
#nullable restore
#line 106 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"

                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <!-- Button trigger modal -->
                                                <button type=""button"" class=""btn btn-outline-success"" style=""margin-right:10px; color:white !important"" data-toggle=""modal"" data-target=""#user-");
#nullable restore
#line 111 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                                                                                                                                                                          Write(userVM.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                                    Aktiv\r\n                                                </button>\r\n");
            WriteLiteral("                                                <!-- Modal -->\r\n                                                <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 7586, "\"", 7606, 2);
            WriteAttributeValue("", 7591, "user-", 7591, 5, true);
#nullable restore
#line 116 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
WriteAttributeValue("", 7596, userVM.Id, 7596, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                                    <div class=""modal-dialog"" role=""document"">
                                                        <div class=""modal-content"">
                                                            <div class=""modal-header"">
                                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                                    <span aria-hidden=""true"">&times;</span>
                                                                </button>
                                                            </div>
                                                            <div class=""modal-body"">
                                                                <h3>Aktiv etmək istədiyinizə əminsiniz ?</h3>
                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19956f2ef68a79a72b9cf75abad0b5f5a6b0611226266", async() => {
                WriteLiteral("Bəli");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                                                                           WriteLiteral(userVM.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                                <button type=""button"" class=""btn btn-outline-danger"" style=""margin-right:10px; color:white !important"" data-dismiss=""modal"">Xeyr</button>
                                                            </div>
                                                            <div class=""modal-footer"">
                                                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Bağla</button>

                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
");
#nullable restore
#line 136 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"

                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 142 "C:\Users\ASUS\source\repos\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Users\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </tbody>
                        <tfoot>
                            <tr>
                                <th style=""color:orange !important"">
                                    Ad Soyad
                                </th>
                                <th style=""color:orange !important"">
                                    İstifadəçi Adı
                                </th>
                                <th style=""color:orange !important"">
                                    Email
                                </th>
                                <th style=""color:orange !important"">
                                    İstifadəçi Rolu
                                </th>
                                <th style=""color:orange !important"">
                                    Status
                                </th>
                                <th style=""color:orange !important"">
                                    Əməliyyatlar
                  ");
            WriteLiteral("              </th>\r\n                            </tr>\r\n                        </tfoot>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserVM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591