#pragma checksum "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78d07e19fcfaeaca5bf6c0c51f488ef9e818dcfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserManager_Details), @"mvc.1.0.view", @"/Views/UserManager/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserManager/Details.cshtml", typeof(AspNetCore.Views_UserManager_Details))]
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
#line 1 "E:\Net Core\Project Complete\BStore\BStore\Views\_ViewImports.cshtml"
using BStore;

#line default
#line hidden
#line 2 "E:\Net Core\Project Complete\BStore\BStore\Views\_ViewImports.cshtml"
using BStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78d07e19fcfaeaca5bf6c0c51f488ef9e818dcfd", @"/Views/UserManager/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79727395343625607dcf075d3f1fe55892915d2c", @"/Views/_ViewImports.cshtml")]
    public class Views_UserManager_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BStore.Models.TaiKhoan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:70px; width:70px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Layout/AdminOK/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 212, true);
            WriteLiteral("\r\n<h1> </h1>\r\n\r\n<div class=\"col-6 offset-3\">\r\n    <h1 style=\"text-align:center\">Thông Tin Tài Khoản</h1>\r\n    <hr />\r\n    <div class=\"col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12\">\r\n        <div class=\"card\">\r\n");
            EndContext();
            BeginContext(404, 339, true);
            WriteLiteral(@"            <div class=""card-body p-0"">
                <div class=""table-responsive"">
                    <table class=""table"">
                       
                        <tbody style=""color:black"">
                            <tr>

                                <td> Tên tài khoản</td>
                                <td>");
            EndContext();
            BeginContext(744, 43, false);
#line 24 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Details.cshtml"
                               Write(Html.DisplayFor(model => model.TenTaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(787, 172, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n\r\n                                <td>  Ảnh đại diện</td>\r\n                                <td> ");
            EndContext();
            BeginContext(959, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "78d07e19fcfaeaca5bf6c0c51f488ef9e818dcfd5880", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 969, "~/user/avatar/", 969, 14, true);
#line 29 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Details.cshtml"
AddHtmlAttributeValue("", 983, Model.AnhDaiDien, 983, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1037, 162, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n\r\n                                <td>Email</td>\r\n                                <td>");
            EndContext();
            BeginContext(1200, 37, false);
#line 34 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 167, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n\r\n                                <td>Trạng thái</td>\r\n                                <td>");
            EndContext();
            BeginContext(1405, 44, false);
#line 39 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Details.cshtml"
                               Write(Html.DisplayFor(model => model.DangHoatDong));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 168, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n\r\n                                <td> Quyền hạn</td>\r\n                                <td> ");
            EndContext();
            BeginContext(1618, 17, false);
#line 44 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Details.cshtml"
                                Write(Model.MaPhanQuyen);

#line default
#line hidden
            EndContext();
            BeginContext(1635, 135, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n\r\n                                <td style=\"float:right\"> ");
            EndContext();
            BeginContext(1770, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78d07e19fcfaeaca5bf6c0c51f488ef9e818dcfd9317", async() => {
                BeginContext(1824, 50, true);
                WriteLiteral("<i style=\"font-size:30px\" class=\"fas fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Details.cshtml"
                                                                                WriteLiteral(Model.MaTaiKhoan);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1878, 44, true);
            WriteLiteral("</td>\r\n                                <td> ");
            EndContext();
            BeginContext(1922, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78d07e19fcfaeaca5bf6c0c51f488ef9e818dcfd11783", async() => {
                BeginContext(1944, 36, true);
                WriteLiteral("<input type=\"button\" value=\"Back\" />");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1984, 178, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BStore.Models.TaiKhoan> Html { get; private set; }
    }
}
#pragma warning restore 1591
