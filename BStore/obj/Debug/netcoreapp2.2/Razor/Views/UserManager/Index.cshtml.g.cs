#pragma checksum "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afca77e0f39c3260b98b843feb188aafc6c12876"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserManager_Index), @"mvc.1.0.view", @"/Views/UserManager/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserManager/Index.cshtml", typeof(AspNetCore.Views_UserManager_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afca77e0f39c3260b98b843feb188aafc6c12876", @"/Views/UserManager/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79727395343625607dcf075d3f1fe55892915d2c", @"/Views/_ViewImports.cshtml")]
    public class Views_UserManager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BStore.Models.TaiKhoan>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:70px; width:70px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Layout/AdminOK/_Layout.cshtml";

#line default
#line hidden
            BeginContext(142, 73, true);
            WriteLiteral("\r\n<h1> </h1>\r\n\r\n<div class=\"col-sm-4\">\r\n    <h1>Danh Sách User</h1>\r\n    ");
            EndContext();
            BeginContext(215, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afca77e0f39c3260b98b843feb188aafc6c128765322", async() => {
                BeginContext(238, 57, true);
                WriteLiteral("<i class=\"fas fa-plus-square\" style=\"font-size:40px\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(299, 96, true);
            WriteLiteral("\r\n</div>\r\n<div class=\"col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12\">\r\n    <div class=\"card\">\r\n");
            EndContext();
            BeginContext(452, 409, true);
            WriteLiteral(@"        <div class=""card-body p-0"">
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead style=""background-color:wheat"">
                        <tr class=""border-0"">
                            <th>
                                Tên Tài Khoản
                            </th>
                            <th>
                                ");
            EndContext();
            BeginContext(862, 41, false);
#line 26 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(903, 601, true);
            WriteLiteral(@"
                            </th>
                            <th>
                                Ảnh Đại Diện
                            </th>
                            <th>
                                Trạng Thái
                            </th>
                            <th>
                                Loại Tài Khoản
                            </th>
                            <th>
                                Option
                            </th>
                        </tr>
                    </thead>
                    <tbody style=""color:black"">
");
            EndContext();
#line 43 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
                         foreach (var item in ViewBag.listuser)
                        {

#line default
#line hidden
            BeginContext(1596, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1705, 16, false);
#line 47 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
                               Write(item.TenTaiKhoan);

#line default
#line hidden
            EndContext();
            BeginContext(1721, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1837, 10, false);
#line 50 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
                               Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1847, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1962, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "afca77e0f39c3260b98b843feb188aafc6c128769697", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1972, "~/user/avatar/", 1972, 14, true);
#line 53 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
AddHtmlAttributeValue("", 1986, item.AnhDaiDien, 1986, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2039, 43, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n");
            EndContext();
#line 56 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
                                  

                                    if (@item.DangHoatDong == 1)
                                    {

#line default
#line hidden
            BeginContext(2225, 66, true);
            WriteLiteral("                                        <td> Đang Hoạt Động</td>\r\n");
            EndContext();
#line 61 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2411, 58, true);
            WriteLiteral("                                        <td> Offine</td>\r\n");
            EndContext();
#line 65 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
                                    }
                                

#line default
#line hidden
            BeginContext(2543, 76, true);
            WriteLiteral("\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2620, 35, false);
#line 69 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
                               Write(item.MaPhanQuyenNavigation.QuyenHan);

#line default
#line hidden
            EndContext();
            BeginContext(2655, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2770, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afca77e0f39c3260b98b843feb188aafc6c1287613098", async() => {
                BeginContext(2823, 107, true);
                WriteLiteral("\r\n                                        <i class=\"fas fa-edit\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
                                                           WriteLiteral(item.MaTaiKhoan);

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
            BeginContext(2934, 39, true);
            WriteLiteral("|\r\n                                    ");
            EndContext();
            BeginContext(2973, 174, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afca77e0f39c3260b98b843feb188aafc6c1287615597", async() => {
                BeginContext(3029, 114, true);
                WriteLiteral("\r\n                                        <i class=\"fas fa-info-circle\"></i>\r\n                                    ");
                EndContext();
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
#line 75 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
                                                              WriteLiteral(item.MaTaiKhoan);

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
            BeginContext(3147, 75, true);
            WriteLiteral("|\r\n                                    <a data-toggle=\"modal\" data-target=\"");
            EndContext();
            BeginContext(3223, 48, false);
#line 78 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
                                                                   Write(String.Concat("#exampleModal1",@item.MaTaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(3271, 179, true);
            WriteLiteral("\">\r\n                                        <i class=\"fas fa-trash-alt\"></i>\r\n                                    </a>\r\n                                    <div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3450, "\"", 3503, 1);
#line 81 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
WriteAttributeValue("", 3455, String.Concat("exampleModal1",@item.MaTaiKhoan), 3455, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3504, 963, true);
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel1"" aria-hidden=""true"">
                                        <div class=""modal-dialog"" role=""document"">
                                            <div class=""modal-content"">
                                                <div class=""modal-header"">
                                                    <h5 class=""modal-title"" id=""exampleModalLabel"" style=""text-align:center"">Xóa Tài Khoản</h5>
                                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                        <span aria-hidden=""true"">&times;</span>
                                                    </button>
                                                </div>
                                                <div class=""modal-body"">
                                                    Bạn có muốn xóa tài khoản ");
            EndContext();
            BeginContext(4468, 16, false);
#line 91 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
                                                                         Write(item.TenTaiKhoan);

#line default
#line hidden
            EndContext();
            BeginContext(4484, 331, true);
            WriteLiteral(@" không ?
                                                </div>
                                                <div class=""modal-footer"">
                                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                                    ");
            EndContext();
            BeginContext(4815, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afca77e0f39c3260b98b843feb188aafc6c1287620899", async() => {
                BeginContext(4870, 69, true);
                WriteLiteral(" <button type=\"button\" class=\"btn btn-primary\">Xóa Tài Khoản</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
                                                                             WriteLiteral(item.MaTaiKhoan);

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
            BeginContext(4943, 276, true);
            WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                            </tr>
");
            EndContext();
#line 102 "E:\Net Core\Project Complete\BStore\BStore\Views\UserManager\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(5246, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(6000, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(6198, 114, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BStore.Models.TaiKhoan>> Html { get; private set; }
    }
}
#pragma warning restore 1591