#pragma checksum "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\DanhGia\_reviewresult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67a058f3e31bf4e5fa8fd8c769a0bb03ef9a996c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DanhGia__reviewresult), @"mvc.1.0.view", @"/Views/DanhGia/_reviewresult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DanhGia/_reviewresult.cshtml", typeof(AspNetCore.Views_DanhGia__reviewresult))]
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
#line 1 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\_ViewImports.cshtml"
using BStore;

#line default
#line hidden
#line 2 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\_ViewImports.cshtml"
using BStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a058f3e31bf4e5fa8fd8c769a0bb03ef9a996c", @"/Views/DanhGia/_reviewresult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79727395343625607dcf075d3f1fe55892915d2c", @"/Views/_ViewImports.cshtml")]
    public class Views_DanhGia__reviewresult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 70px; height:70px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\DanhGia\_reviewresult.cshtml"
  
    foreach (var item in @ViewBag.ListDanhGia)
    {

#line default
#line hidden
            BeginContext(181, 187, true);
            WriteLiteral("        <div class=\"row tab-review-row\">\r\n            <div class=\"col-xs-5 col-sm-4 col-md-4 col-lg-3 padding-5\">\r\n                <div class=\"tab-rating-box\">\r\n                    <span>");
            EndContext();
            BeginContext(369, 16, false);
#line 10 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\DanhGia\_reviewresult.cshtml"
                     Write(item.TenTaiKhoan);

#line default
#line hidden
            EndContext();
            BeginContext(385, 95, true);
            WriteLiteral("</span>\r\n                    <div class=\"review-author-info\">\r\n                        <strong>");
            EndContext();
            BeginContext(480, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "67a058f3e31bf4e5fa8fd8c769a0bb03ef9a996c4547", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 490, "~/user/img/profile/", 490, 19, true);
#line 12 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\DanhGia\_reviewresult.cshtml"
AddHtmlAttributeValue("", 509, item.AnhDaiDien, 509, 16, false);

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
            BeginContext(560, 41, true);
            WriteLiteral("</strong>\r\n                        <span>");
            EndContext();
            BeginContext(602, 16, false);
#line 13 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\DanhGia\_reviewresult.cshtml"
                         Write(item.NgayDanhGia);

#line default
#line hidden
            EndContext();
            BeginContext(618, 234, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-xs-7 col-sm-8 col-md-8 col-lg-9 padding-5\">\r\n                <div class=\"write-your-review\">\r\n                    <p><strong>");
            EndContext();
            BeginContext(853, 16, false);
#line 19 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\DanhGia\_reviewresult.cshtml"
                          Write(item.TenTaiKhoan);

#line default
#line hidden
            EndContext();
            BeginContext(869, 105, true);
            WriteLiteral(" \'s Comment</strong></p>\r\n                    <p></p>\r\n                    <span class=\"usefull-comment\">");
            EndContext();
            BeginContext(975, 15, false);
#line 21 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\DanhGia\_reviewresult.cshtml"
                                             Write(item.LoiNhanXet);

#line default
#line hidden
            EndContext();
            BeginContext(990, 73, true);
            WriteLiteral("</span>\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
            EndContext();
#line 27 "C:\Users\demon\Downloads\BStore (1)\BStore\BStore\Views\DanhGia\_reviewresult.cshtml"
        }

    

#line default
#line hidden
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
