#pragma checksum "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d11c7561676019e4e1160e58e405221102f139b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Index), @"mvc.1.0.view", @"/Views/Checkout/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Checkout/Index.cshtml", typeof(AspNetCore.Views_Checkout_Index))]
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
#line 1 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d11c7561676019e4e1160e58e405221102f139b1", @"/Views/Checkout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79727395343625607dcf075d3f1fe55892915d2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Layout/User/Layout.cshtml";

#line default
#line hidden
            BeginContext(126, 514, true);
            WriteLiteral(@"
<section class=""generic-banner relative"">
    <div class=""container"">
        <div class=""row height align-items-center justify-content-center"">
            <div class=""col-lg-10"">
                <div class=""generic-banner-content"">
                    <h2 class=""text-white"">THANH TOÁN</h2>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- End banner Area -->
<!-- About Generic Start -->

<div class=""main-wrapper"">
    <div class=""container checkout-area"">
");
            EndContext();
#line 23 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
         if (ViewBag.Success != null)
        {
            if (ViewBag.Success == true)
            {

#line default
#line hidden
            BeginContext(747, 142, true);
            WriteLiteral("                <div class=\"alert alert-success\" role=\"alert\">\r\n                    Đơn hàng của bạn đã được gửi đi.\r\n                </div>\r\n");
            EndContext();
#line 30 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(937, 155, true);
            WriteLiteral("                <div class=\"alert alert-danger\" role=\"alert\">\r\n                    Giỏ hàng đang trống. Bạn không thể thanh toán.\r\n                </div>\r\n");
            EndContext();
#line 36 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
            }

        }

#line default
#line hidden
            BeginContext(1120, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 39 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
         if (Context.Session.GetString("USERNAME_SESSION") == null && ViewBag.Success == null)
        {


#line default
#line hidden
            BeginContext(1229, 99, true);
            WriteLiteral("            <div class=\"alert alert-info\" role=\"alert\">\r\n                Nếu bạn có tài khoản. Hãy ");
            EndContext();
            BeginContext(1328, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d11c7561676019e4e1160e58e405221102f139b17243", async() => {
                BeginContext(1373, 9, true);
                WriteLiteral("đăng nhập");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1386, 55, true);
            WriteLiteral(" để có thể xem thông tin đơn hàng\r\n            </div>\r\n");
            EndContext();
#line 45 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1452, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1460, 4307, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d11c7561676019e4e1160e58e405221102f139b19115", async() => {
                BeginContext(1514, 38, true);
                WriteLiteral("\r\n            <input name=\"account_id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1552, "\"", 1600, 1);
#line 47 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
WriteAttributeValue("", 1560, Context.Session.GetString("ID_SESSION"), 1560, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1601, 1300, true);
                WriteLiteral(@" hidden />
            <div class=""form-field"">
                <label for=""fullname"" style=""text-align: left"">
                    Họ tên
                    <abbr title=""required"" class=""required"">*</abbr>
                </label>
                <input type=""text"" name=""fullname"" id=""fullname"" class=""form-control"">
            </div>
            <div class=""form-field"">
                <label for=""address"" style=""text-align: left"">
                    Địa chỉ
                    <abbr title=""required"" class=""required"">*</abbr>
                </label>
                <input type=""text"" name=""address"" id=""address"" class=""form-control"">
            </div>
            <div class=""form-field"">
                <label for=""email"" style=""text-align: left"">
                    Email
                    <abbr title=""required"" class=""required"">*</abbr>
                </label>
                <input type=""text"" name=""email"" id=""email"" class=""form-control"">
            </div>
            <div cl");
                WriteLiteral(@"ass=""form-field"">
                <label for=""city"" style=""text-align: left"">
                    Thành phố
                    <abbr title=""required"" class=""required"">*</abbr>
                </label>
                <select name=""city"" id=""city"" class=""form-control"">
");
                EndContext();
#line 75 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
                     foreach (var city in ViewBag.City)
                    {

#line default
#line hidden
                BeginContext(2981, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(3005, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d11c7561676019e4e1160e58e405221102f139b111713", async() => {
                    BeginContext(3040, 17, false);
#line 77 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
                                                     Write(city.TenTinhThanh);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 77 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
                           WriteLiteral(city.MaTinhThanh);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3066, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 78 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(3091, 1094, true);
                WriteLiteral(@"                </select>
            </div>
            <div class=""form-field"">
                <label for=""email"" style=""text-align: left"">
                    Số điện thoại
                    <abbr title=""required"" class=""required"">*</abbr>
                </label>
                <input type=""text"" name=""tel"" id=""email"" class=""form-control"">
            </div>
            <div class=""form-field"">
                <label for=""email"" style=""text-align: left"">
                    Ghi chú đặt hàng
                </label>
                <textarea name="""" id="""" cols=""30"" rows=""5"" class=""form-control"" placeholder=""Ghi chú về đơn đặt hàng""></textarea>
            </div>
            <div class=""form-field cart-checkout"">
                <h5>Đơn hàng của bạn</h5>
                <table class=""cart-item"">
                    <thead>
                        <tr>
                            <th>Sản phẩm</th>
                            <th style=""width: 70%"">Tổng cộng</th>
                    ");
                WriteLiteral("    </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
                EndContext();
#line 104 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
                         if (ViewBag.Cart != null)
                        {
                            foreach (var item in ViewBag.Cart)
                            {

#line default
#line hidden
                BeginContext(4359, 78, true);
                WriteLiteral("                                <tr>\r\n                                    <td>");
                EndContext();
                BeginContext(4438, 15, false);
#line 109 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
                                   Write(item.TenThucDon);

#line default
#line hidden
                EndContext();
                BeginContext(4453, 3, true);
                WriteLiteral(" x ");
                EndContext();
                BeginContext(4457, 12, false);
#line 109 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
                                                      Write(item.SoLuong);

#line default
#line hidden
                EndContext();
                BeginContext(4469, 48, true);
                WriteLiteral("</td>\r\n                                    <td>$");
                EndContext();
                BeginContext(4518, 36, false);
#line 110 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
                                    Write(string.Format("{0:N2}", item.GiaBan));

#line default
#line hidden
                EndContext();
                BeginContext(4554, 46, true);
                WriteLiteral("</td>\r\n                                </tr>\r\n");
                EndContext();
#line 112 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
                            }
                        }

#line default
#line hidden
                BeginContext(4658, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 114 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
                         if (ViewBag.Total == 0)
                        {

#line default
#line hidden
                BeginContext(4735, 177, true);
                WriteLiteral("                            <tr>\r\n                                <td colspan=\"2\" style=\"padding-left: 80px\">Chưa có sản phẩm trong giỏ</td>\r\n                            </tr>\r\n");
                EndContext();
#line 119 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(4939, 129, true);
                WriteLiteral("\r\n                        <tr>\r\n                            <td><strong>Subtotal</strong></td>\r\n                            <td>$");
                EndContext();
                BeginContext(5069, 38, false);
#line 123 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
                            Write(string.Format("{0:N2}", ViewBag.Total));

#line default
#line hidden
                EndContext();
                BeginContext(5107, 336, true);
                WriteLiteral(@"</td>
                        </tr>
                        <tr>
                            <td><strong>Coupon</strong></td>
                            <td>None</td>
                        </tr>
                        <tr>
                            <td><strong>Total</strong></td>
                            <td><strong>$");
                EndContext();
                BeginContext(5444, 38, false);
#line 131 "E:\Net Core\Project Complete\BStore\BStore\Views\Checkout\Index.cshtml"
                                    Write(string.Format("{0:N2}", ViewBag.Total));

#line default
#line hidden
                EndContext();
                BeginContext(5482, 278, true);
                WriteLiteral(@"</strong></td>
                        </tr>

                    </tbody>
                </table>
            </div>
            <div class=""form-field"">
                <button class=""checkout-button btn btn-default"">THANH TOÁN</button>
            </div>

        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5767, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
