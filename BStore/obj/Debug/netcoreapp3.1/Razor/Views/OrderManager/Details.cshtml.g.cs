#pragma checksum "E:\Net Core\Project Complete\BStore\BStore\Views\OrderManager\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82d447e33290263e02af2db70c4d241fce497d1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderManager_Details), @"mvc.1.0.view", @"/Views/OrderManager/Details.cshtml")]
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
#line 1 "E:\Net Core\Project Complete\BStore\BStore\Views\_ViewImports.cshtml"
using BStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Net Core\Project Complete\BStore\BStore\Views\_ViewImports.cshtml"
using BStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82d447e33290263e02af2db70c4d241fce497d1c", @"/Views/OrderManager/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79727395343625607dcf075d3f1fe55892915d2c", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderManager_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BStore.Models.OderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Net Core\Project Complete\BStore\BStore\Views\OrderManager\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Layout/AdminOK/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1> </h1>
<br />
<div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
    <div class=""card"">
        <h5 class=""card-header"" style=""text-align:center"">Chi Tiết Giỏ Hàng</h5>
        <div class=""card-body p-0"">
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead class=""bg-light"">
                        <tr class=""border-0"">
                            <th>Mã sản phẩm</th>
                            <th>Tên sản phẩm</th>
                            <th>Số lượng</th>
                            <th>Đơn giá</th>
                            <th>Thành tiền</th>
                        </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 27 "E:\Net Core\Project Complete\BStore\BStore\Views\OrderManager\Details.cshtml"
                         foreach (var item in Model.ctgiohangs)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 31 "E:\Net Core\Project Complete\BStore\BStore\Views\OrderManager\Details.cshtml"
                               Write(item.masp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 34 "E:\Net Core\Project Complete\BStore\BStore\Views\OrderManager\Details.cshtml"
                               Write(item.tensp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 37 "E:\Net Core\Project Complete\BStore\BStore\Views\OrderManager\Details.cshtml"
                               Write(item.soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 40 "E:\Net Core\Project Complete\BStore\BStore\Views\OrderManager\Details.cshtml"
                               Write(item.gia);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 43 "E:\Net Core\Project Complete\BStore\BStore\Views\OrderManager\Details.cshtml"
                               Write(item.thanhtien);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 46 "E:\Net Core\Project Complete\BStore\BStore\Views\OrderManager\Details.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>
<hr />
<div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
    <div class=""card"">
        <div class=""card-body p-0"">
            <div class=""table-responsive"" >
                <table class=""table"">
                    <thead class=""bg-light"">
                        <tr class=""border-0"">
                        <tr>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td>Tổng Tiền :</td>
                            <td>
                                <strong style=""font-size: 25px"">");
#nullable restore
#line 68 "E:\Net Core\Project Complete\BStore\BStore\Views\OrderManager\Details.cshtml"
                                                           Write(Html.DisplayFor(model => model.giohang.TongCong));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>  
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td>Ngày Đặt ");
#nullable restore
#line 75 "E:\Net Core\Project Complete\BStore\BStore\Views\OrderManager\Details.cshtml"
                                    Write(Html.DisplayFor(model => model.giohang.NgayDat));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>\r\n                                Trạng Thái :  ");
#nullable restore
#line 77 "E:\Net Core\Project Complete\BStore\BStore\Views\OrderManager\Details.cshtml"
                                         Write(Html.DisplayFor(model => model.giohang.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82d447e33290263e02af2db70c4d241fce497d1c9100", async() => {
                WriteLiteral("<input type=\"button\" class=\"btn btn-icon-split\" value=\"Back\" />");
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
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                        </tr>\r\n                    </thead>\r\n\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BStore.Models.OderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591