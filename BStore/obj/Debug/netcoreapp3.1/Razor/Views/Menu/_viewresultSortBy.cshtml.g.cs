#pragma checksum "E:\Net Core\Project Complete\BStore\BStore\Views\Menu\_viewresultSortBy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4419755613f8f9848ebb61180b84c9c779e7bb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu__viewresultSortBy), @"mvc.1.0.view", @"/Views/Menu/_viewresultSortBy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4419755613f8f9848ebb61180b84c9c779e7bb1", @"/Views/Menu/_viewresultSortBy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79727395343625607dcf075d3f1fe55892915d2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu__viewresultSortBy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:225px ; height:225px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "InfomationProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <ul class=\"gategory-product\">\r\n");
#nullable restore
#line 6 "E:\Net Core\Project Complete\BStore\BStore\Views\Menu\_viewresultSortBy.cshtml"
          
            foreach (var item in ViewBag.ListProduct)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <!-- SINGLE ITEM START -->
                <li class=""gategory-product-list col-lg-3 col-md-4 col-sm-6 col-xs-12"">
                    <div class=""single-product-item"">
                        <div class=""product-image"">
                            <a href=""single-product.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4419755613f8f9848ebb61180b84c9c779e7bb15209", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 567, "~/user/products/", 567, 16, true);
#nullable restore
#line 13 "E:\Net Core\Project Complete\BStore\BStore\Views\Menu\_viewresultSortBy.cshtml"
AddHtmlAttributeValue("", 583, item.HinhAnh, 583, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 15 "E:\Net Core\Project Complete\BStore\BStore\Views\Menu\_viewresultSortBy.cshtml"
                              
                                if (item.KhuyenMai != 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a href=\"single-product.html\" class=\"new-mark-box\">Sale - ");
#nullable restore
#line 18 "E:\Net Core\Project Complete\BStore\BStore\Views\Menu\_viewresultSortBy.cshtml"
                                                                                         Write(item.KhuyenMai);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</a>\r\n");
#nullable restore
#line 19 "E:\Net Core\Project Complete\BStore\BStore\Views\Menu\_viewresultSortBy.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"overlay-content\">\r\n                                <ul>\r\n                                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4419755613f8f9848ebb61180b84c9c779e7bb17994", async() => {
                WriteLiteral("<button><i class=\"fa fa-search\"></i></button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "E:\Net Core\Project Complete\BStore\BStore\Views\Menu\_viewresultSortBy.cshtml"
                                                                                                   WriteLiteral(item.MaThucDon);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</li>\r\n\r\n                                    <li class=\"order-button\"><a><button type=\"button\" title=\"Quick view\" data-id=\"");
#nullable restore
#line 25 "E:\Net Core\Project Complete\BStore\BStore\Views\Menu\_viewresultSortBy.cshtml"
                                                                                                             Write(item.MaThucDon);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fa fa-shopping-cart\"></i></button></a></li>\r\n");
            WriteLiteral(@"                                </ul>
                            </div>
                        </div>
                        <div class=""product-info"">
                            <div class=""customar-comments-box"">

                            </div>
                            <a href=""single-product.html"">");
#nullable restore
#line 35 "E:\Net Core\Project Complete\BStore\BStore\Views\Menu\_viewresultSortBy.cshtml"
                                                     Write(item.TenThucDon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <div class=\"price-box\">\r\n                                <span class=\"price\">");
#nullable restore
#line 37 "E:\Net Core\Project Complete\BStore\BStore\Views\Menu\_viewresultSortBy.cshtml"
                                               Write(String.Concat(string.Format("{0:N0}", @item.GetGiaKhuyenMai), "Đ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n");
#nullable restore
#line 39 "E:\Net Core\Project Complete\BStore\BStore\Views\Menu\_viewresultSortBy.cshtml"
                                  
                                    if (item.KhuyenMai != 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"old-price\">");
#nullable restore
#line 42 "E:\Net Core\Project Complete\BStore\BStore\Views\Menu\_viewresultSortBy.cshtml"
                                                           Write(String.Concat(string.Format("{0:N0}", @item.Gia), "Đ"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 43 "E:\Net Core\Project Complete\BStore\BStore\Views\Menu\_viewresultSortBy.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n                <!-- SINGLE ITEM END -->\r\n");
#nullable restore
#line 51 "E:\Net Core\Project Complete\BStore\BStore\Views\Menu\_viewresultSortBy.cshtml"
            }
        
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n</div>");
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
