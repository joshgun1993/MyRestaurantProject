#pragma checksum "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3e83c4509c1d4c99c9afb40f36d910f4da14d9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Positions_Index), @"mvc.1.0.view", @"/Views/Positions/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3e83c4509c1d4c99c9afb40f36d910f4da14d9b", @"/Views/Positions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26eb05095af9cfa423ccb9b82f2eb96190d53cd9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Positions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Position>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Positions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePosition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:10px; color:white !important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdatePosition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActivityPosition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"
  
    ViewData["Title"] = "V??zif??l??r";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex justify-content-between align-items-center"">
                    <h4 class=""card-title"">V??zif??l??r</h4>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e83c4509c1d4c99c9afb40f36d910f4da14d9b7152", async() => {
                WriteLiteral("V??zif?? Yarat");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>

                <table class=""table table-hover table-dark"">
                    <thead>
                        <tr>
                            <th style=""color:orange !important""> V??zif?? Ad?? </th>
                            <th style=""color:orange !important""> Status </th>
                            <th style=""color:orange !important""> ??m??liyyatlar</th>
                        </tr>
                    </thead>

                    <tbody>
");
#nullable restore
#line 26 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"
                         foreach (Position position in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td style=\"color:white !important\"> ");
#nullable restore
#line 29 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"
                                                               Write(position.PositionName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td style=\"color:white !important\">\r\n\r\n");
#nullable restore
#line 32 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"
                                     if (!position.IsDeactive)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"text-success\">Aktiv</span>\r\n");
#nullable restore
#line 35 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"text-danger\">Deaktiv</span>\r\n");
#nullable restore
#line 39 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n\r\n                                <td style=\"color:white !important\">\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e83c4509c1d4c99c9afb40f36d910f4da14d9b11405", async() => {
                WriteLiteral("V??zif??ni Yenil??");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-positionId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"
                                                                                                        WriteLiteral(position.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["positionId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-positionId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["positionId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 46 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"
                                     if (!position.IsDeactive)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <!-- Button trigger modal -->\r\n                                        <button type=\"button\" class=\"btn btn-outline-danger\" style=\"color:white !important\" data-toggle=\"modal\" data-target=\"#position-");
#nullable restore
#line 49 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"
                                                                                                                                                                  Write(position.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                            Deaktiv Et\r\n                                        </button>\r\n");
            WriteLiteral("                                        <!-- Modal -->\r\n                                        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2660, "\"", 2686, 2);
            WriteAttributeValue("", 2665, "position-", 2665, 9, true);
#nullable restore
#line 54 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"
WriteAttributeValue("", 2674, position.Id, 2674, 12, false);

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
                                                        <h3>Deaktiv etm??k ist??diyiniz?? ??minsiniz?</h3>
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e83c4509c1d4c99c9afb40f36d910f4da14d9b16863", async() => {
                WriteLiteral("B??li");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-activityPositionId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"
                                                                                                                                      WriteLiteral(position.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activityPositionId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activityPositionId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activityPositionId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Ba??la</button>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
");
#nullable restore
#line 73 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"

                                    }
                                    else
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <!-- Button trigger modal -->\r\n                                        <button type=\"button\" class=\"btn btn-outline-success\" style=\"color:white !important\" data-toggle=\"modal\" data-target=\"#position-");
#nullable restore
#line 79 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"
                                                                                                                                                                   Write(position.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                            Aktiv Et\r\n                                        </button>\r\n");
            WriteLiteral("                                        <!-- Modal -->\r\n                                        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 5111, "\"", 5137, 2);
            WriteAttributeValue("", 5116, "position-", 5116, 9, true);
#nullable restore
#line 84 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"
WriteAttributeValue("", 5125, position.Id, 5125, 12, false);

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
                                                        <h3> Aktiv etm??k ist??diyiniz?? ??minsiniz?</h3>
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3e83c4509c1d4c99c9afb40f36d910f4da14d9b23095", async() => {
                WriteLiteral("B??li");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-activityPositionId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"
                                                                                                                                      WriteLiteral(position.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activityPositionId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activityPositionId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activityPositionId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                                                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Ba??la</button>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
");
#nullable restore
#line 103 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 108 "C:\Users\ASUS\source\repos\MyRestaurantProject\ByJoshgunFinalRestaurantProject\ByJoshgunFinalRestaurantProject\Views\Positions\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                    <thead>
                        <tr>
                            <th style=""color:orange !important""> V??zif?? Ad?? </th>
                            <th style=""color:orange !important""> Status </th>
                            <th style=""color:orange !important""> ??m??liyyatlar</th>
                        </tr>
                    </thead>

                </table>

            </div>
        </div>
    </div>
</div>

");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Position>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
