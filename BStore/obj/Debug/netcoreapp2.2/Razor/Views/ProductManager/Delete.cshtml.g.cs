#pragma checksum "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19719afb81bc663676e174b5ce388043d9c68b3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductManager_Delete), @"mvc.1.0.view", @"/Views/ProductManager/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductManager/Delete.cshtml", typeof(AspNetCore.Views_ProductManager_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19719afb81bc663676e174b5ce388043d9c68b3d", @"/Views/ProductManager/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79727395343625607dcf075d3f1fe55892915d2c", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductManager_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BStore.Models.ThucDon>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Layout/AdminOK/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 177, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>ThucDon</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(307, 46, false);
#line 16 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TenThucDon));

#line default
#line hidden
            EndContext();
            BeginContext(353, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(417, 42, false);
#line 19 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TenThucDon));

#line default
#line hidden
            EndContext();
            BeginContext(459, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(522, 43, false);
#line 22 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HinhAnh));

#line default
#line hidden
            EndContext();
            BeginContext(565, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(629, 39, false);
#line 25 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HinhAnh));

#line default
#line hidden
            EndContext();
            BeginContext(668, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(731, 39, false);
#line 28 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Gia));

#line default
#line hidden
            EndContext();
            BeginContext(770, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(834, 35, false);
#line 31 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Gia));

#line default
#line hidden
            EndContext();
            BeginContext(869, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(932, 45, false);
#line 34 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.KhuyenMai));

#line default
#line hidden
            EndContext();
            BeginContext(977, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1041, 41, false);
#line 37 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayFor(model => model.KhuyenMai));

#line default
#line hidden
            EndContext();
            BeginContext(1082, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1145, 40, false);
#line 40 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1249, 36, false);
#line 43 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MoTa));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1348, 44, false);
#line 46 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MoreInfo));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1456, 40, false);
#line 49 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MoreInfo));

#line default
#line hidden
            EndContext();
            BeginContext(1496, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1559, 43, false);
#line 52 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LuotXem));

#line default
#line hidden
            EndContext();
            BeginContext(1602, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1666, 39, false);
#line 55 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LuotXem));

#line default
#line hidden
            EndContext();
            BeginContext(1705, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1768, 43, false);
#line 58 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LuotMua));

#line default
#line hidden
            EndContext();
            BeginContext(1811, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1875, 39, false);
#line 61 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LuotMua));

#line default
#line hidden
            EndContext();
            BeginContext(1914, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1977, 52, false);
#line 64 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NongDoNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2029, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2093, 57, false);
#line 67 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NongDoNavigation.MaNongDo));

#line default
#line hidden
            EndContext();
            BeginContext(2150, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2219, 54, false);
#line 70 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DungTichNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2273, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2337, 61, false);
#line 73 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DungTichNavigation.MaDungTich));

#line default
#line hidden
            EndContext();
            BeginContext(2398, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2467, 52, false);
#line 76 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaLoaiNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2519, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2583, 55, false);
#line 79 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaLoaiNavigation.MaLoai));

#line default
#line hidden
            EndContext();
            BeginContext(2638, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2707, 50, false);
#line 82 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaTHNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2757, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2821, 51, false);
#line 85 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaTHNavigation.MaTH));

#line default
#line hidden
            EndContext();
            BeginContext(2872, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2916, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19719afb81bc663676e174b5ce388043d9c68b3d15245", async() => {
                BeginContext(2942, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2952, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19719afb81bc663676e174b5ce388043d9c68b3d15638", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 90 "E:\Net Core\Project Complete\BStore\BStore\Views\ProductManager\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MaThucDon);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2995, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(3078, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19719afb81bc663676e174b5ce388043d9c68b3d17549", async() => {
                    BeginContext(3100, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3116, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3129, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BStore.Models.ThucDon> Html { get; private set; }
    }
}
#pragma warning restore 1591
