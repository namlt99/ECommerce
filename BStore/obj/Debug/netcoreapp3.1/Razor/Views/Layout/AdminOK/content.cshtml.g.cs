#pragma checksum "E:\Net Core\Project Complete\BStore\BStore\Views\Layout\AdminOK\content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08e709a33ba11f1ed0db50938c3e4d5aeda3f70d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Layout_AdminOK_content), @"mvc.1.0.view", @"/Views/Layout/AdminOK/content.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08e709a33ba11f1ed0db50938c3e4d5aeda3f70d", @"/Views/Layout/AdminOK/content.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79727395343625607dcf075d3f1fe55892915d2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Layout_AdminOK_content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- ============================================================== -->
<!-- main wrapper -->
<!-- ============================================================== -->
<div class=""dashboard-main-wrapper"">
    <!-- ============================================================== -->
    <!-- navbar -->
    <!-- ============================================================== -->
    <div class=""dashboard-header"">
        <nav class=""navbar navbar-expand-lg bg-white fixed-top"">
            <a class=""navbar-brand"" href=""/Home"">BStore</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse "" id=""navbarSupportedContent"">
                <ul class=""navbar-nav ml-auto navbar-right-top"">
                    <li class=""nav-ite");
            WriteLiteral(@"m"">
                        <div id=""custom-search"" class=""top-search-bar"">
                            <input class=""form-control"" type=""text"" placeholder=""Search.."">
                        </div>
                    </li>
                    <li class=""nav-item dropdown notification"">
                        <a class=""nav-link nav-icons"" href=""#"" id=""navbarDropdownMenuLink1"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><i class=""fas fa-fw fa-bell""></i> <span class=""indicator""></span></a>
                        <ul class=""dropdown-menu dropdown-menu-right notification-dropdown"">
                            <li>
                                <div class=""notification-title""> Notification</div>
                                <div class=""notification-list"">
                                    <div class=""list-group"">
                                        <a href=""#"" class=""list-group-item list-group-item-action active"">
                                            <div cla");
            WriteLiteral("ss=\"notification-info\">\r\n                                                <div class=\"notification-list-user-img\"><img src=\"assets/images/avatar-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 2198, "\"", 2204, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""user-avatar-md rounded-circle""></div>
                                                <div class=""notification-list-user-block"">
                                                    <span class=""notification-list-user-name"">Jeremy Rakestraw</span>accepted your invitation to join the team.
                                                    <div class=""notification-date"">2 min ago</div>
                                                </div>
                                            </div>
                                        </a>
                                        <a href=""#"" class=""list-group-item list-group-item-action"">
                                            <div class=""notification-info"">
                                                <div class=""notification-list-user-img""><img src=""assets/images/avatar-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3062, "\"", 3068, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""user-avatar-md rounded-circle""></div>
                                                <div class=""notification-list-user-block"">
                                                    <span class=""notification-list-user-name"">John Abraham </span>is now following you
                                                    <div class=""notification-date"">2 days ago</div>
                                                </div>
                                            </div>
                                        </a>
                                        <a href=""#"" class=""list-group-item list-group-item-action"">
                                            <div class=""notification-info"">
                                                <div class=""notification-list-user-img""><img src=""assets/images/avatar-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3902, "\"", 3908, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""user-avatar-md rounded-circle""></div>
                                                <div class=""notification-list-user-block"">
                                                    <span class=""notification-list-user-name"">Monaan Pechi</span> is watching your main repository
                                                    <div class=""notification-date"">2 min ago</div>
                                                </div>
                                            </div>
                                        </a>
                                        <a href=""#"" class=""list-group-item list-group-item-action"">
                                            <div class=""notification-info"">
                                                <div class=""notification-list-user-img""><img src=""assets/images/avatar-5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4753, "\"", 4759, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""user-avatar-md rounded-circle""></div>
                                                <div class=""notification-list-user-block"">
                                                    <span class=""notification-list-user-name"">Jessica Caruso</span>accepted your invitation to join the team.
                                                    <div class=""notification-date"">2 min ago</div>
                                                </div>
                                            </div>
                                        </a>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class=""list-footer""> <a href=""#"">View all notifications</a></div>
                            </li>
                        </ul>
                    </li>
                    <li class=""nav-item dropdown connection"">
                        <a class=""nav-link"" href=""#"" id=""na");
            WriteLiteral(@"vbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""> <i class=""fas fa-fw fa-th""></i> </a>
                        <ul class=""dropdown-menu dropdown-menu-right connection-dropdown"">
                            <li class=""connection-list"">
                                <div class=""row"">
                                    <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-12 col-12 "">
                                        <a href=""#"" class=""connection-item""><img src=""assets/images/github.png""");
            BeginWriteAttribute("alt", " alt=\"", 6325, "\"", 6331, 0);
            EndWriteAttribute();
            WriteLiteral(@"> <span>Github</span></a>
                                    </div>
                                    <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-12 col-12 "">
                                        <a href=""#"" class=""connection-item""><img src=""assets/images/dribbble.png""");
            BeginWriteAttribute("alt", " alt=\"", 6612, "\"", 6618, 0);
            EndWriteAttribute();
            WriteLiteral(@"> <span>Dribbble</span></a>
                                    </div>
                                    <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-12 col-12 "">
                                        <a href=""#"" class=""connection-item""><img src=""assets/images/dropbox.png""");
            BeginWriteAttribute("alt", " alt=\"", 6900, "\"", 6906, 0);
            EndWriteAttribute();
            WriteLiteral(@"> <span>Dropbox</span></a>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-12 col-12 "">
                                        <a href=""#"" class=""connection-item""><img src=""assets/images/bitbucket.png""");
            BeginWriteAttribute("alt", " alt=\"", 7280, "\"", 7286, 0);
            EndWriteAttribute();
            WriteLiteral(@"> <span>Bitbucket</span></a>
                                    </div>
                                    <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-12 col-12 "">
                                        <a href=""#"" class=""connection-item""><img src=""assets/images/mail_chimp.png""");
            BeginWriteAttribute("alt", " alt=\"", 7572, "\"", 7578, 0);
            EndWriteAttribute();
            WriteLiteral(@"><span>Mail chimp</span></a>
                                    </div>
                                    <div class=""col-xl-4 col-lg-4 col-md-6 col-sm-12 col-12 "">
                                        <a href=""#"" class=""connection-item""><img src=""assets/images/slack.png""");
            BeginWriteAttribute("alt", " alt=\"", 7859, "\"", 7865, 0);
            EndWriteAttribute();
            WriteLiteral(@"> <span>Slack</span></a>
                                    </div>
                                </div>
                            </li>
                            <li>
                                <div class=""conntection-footer""><a href=""#"">More</a></div>
                            </li>
                        </ul>
                    </li>
                    <li class=""nav-item dropdown nav-user"">
                        <a class=""nav-link nav-user-img"" href=""#"" id=""navbarDropdownMenuLink2"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><img src=""assets/images/avatar-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8489, "\"", 8495, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""user-avatar-md rounded-circle""></a>
                        <div class=""dropdown-menu dropdown-menu-right nav-user-dropdown"" aria-labelledby=""navbarDropdownMenuLink2"">
                            <div class=""nav-user-info"">
                                <h5 class=""mb-0 text-white nav-user-name"">John Abraham </h5>
                                <span class=""status""></span><span class=""ml-2"">Available</span>
                            </div>
                            <a class=""dropdown-item"" href=""#""><i class=""fas fa-user mr-2""></i>Account</a>
                            <a class=""dropdown-item"" href=""#""><i class=""fas fa-cog mr-2""></i>Setting</a>
                            <a class=""dropdown-item"" href=""#""><i class=""fas fa-power-off mr-2""></i>Logout</a>
                        </div>
                    </li>
                </ul>
            </div>
        </nav>
    </div>
    <!-- ============================================================== -->
    <!-- end navbar -->
    <!");
            WriteLiteral(@"-- ============================================================== -->
    <!-- ============================================================== -->
    <!-- left sidebar -->
    <!-- ============================================================== -->
    <div class=""nav-left-sidebar sidebar-dark"">
        <div class=""menu-list"">
            <nav class=""navbar navbar-expand-lg navbar-light"">
                <a class=""d-xl-none d-lg-none"" href=""#"">Dashboard</a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarNav"">
                    <ul class=""navbar-nav flex-column"">
                        <li class=""nav-divider"">
                            ADMIN
                        </li>
                        <li cla");
            WriteLiteral(@"ss=""nav-item "">
                            <a class=""nav-link active"" href=""/dashboard""""><i class=""fa fa-fw fa-user-circle""></i>Dashboard <span class=""badge badge-success"">6</span></a>
   
                        </li>
                        <li class=""nav-divider"">
                            Menu
                        </li>
                        <!-- =====================Start 1 Controller========================================= -->
                        <li class=""nav-item "">
                            <a class=""nav-link active"" href=""#"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#submenu-1"" aria-controls=""submenu-1""><i class=""fa fa-fw fa-user-circle""></i>User <span class=""badge badge-success"">6</span></a>
                            <div id=""submenu-1"" class=""collapse submenu"" style="""">
                                <ul class=""nav flex-column"">
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" href=");
            WriteLiteral(@"""/UserManager/Index"">Quản Lý User</a>
                                    </li>

                                </ul>
                            </div>
                        </li>
                        <!-- =====================End 1 Controller========================================= -->
                        <!-- =====================Start 1 Controller========================================= -->
                        <li class=""nav-item "">
                            <a class=""nav-link active"" href=""#"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#submenu-2"" aria-controls=""submenu-2""><i class=""fa fa-fw fa-user-circle""></i>Khách Hàng <span class=""badge badge-success"">6</span></a>
                            <div id=""submenu-2"" class=""collapse submenu""");
            BeginWriteAttribute("style", " style=\"", 12364, "\"", 12372, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <ul class=""nav flex-column"">
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" href=""/CustomerManager/Index"">Quản Lý Khách Hàng</a>
                                    </li>

                                </ul>
                            </div>
                        </li>
                        <!-- =====================End 1 Controller========================================= -->
                        <!-- =====================Start 1 Controller========================================= -->
                        <li class=""nav-item "">
                            <a class=""nav-link active"" href=""#"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#submenu-3"" aria-controls=""submenu-3""><i class=""fa fa-fw fa-user-circle""></i>Hoá Đơn <span class=""badge badge-success"">6</span></a>
                            <div id=""submenu-3"" class=""collapse submenu""");
            BeginWriteAttribute("style", " style=\"", 13365, "\"", 13373, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <ul class=""nav flex-column"">
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" href=""/OrderManager/Index"">Quản Lý Hoá Đơn</a>
                                    </li>

                                </ul>
                            </div>
                        </li>
                        <!-- =====================End 1 Controller========================================= -->
                        <!-- =====================Start 1 Controller========================================= -->
                        <li class=""nav-item "">
                            <a class=""nav-link active"" href=""#"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#submenu-4"" aria-controls=""submenu-4""><i class=""fa fa-fw fa-user-circle""></i>Sản Phẩm <span class=""badge badge-success"">6</span></a>
                            <div id=""submenu-4"" class=""collapse submenu""");
            BeginWriteAttribute("style", " style=\"", 14361, "\"", 14369, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <ul class=""nav flex-column"">
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" href=""/ProductManager/Index"">Quản Lý Sản Phẩm</a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" href=""/CategoryManager/Index"">Quản Lý Category</a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" href=""/TrademarkManager/Index"">Quản Lý Thương Hiệu</a>
                                    </li>
                                </ul>
                            </div>
                        </li>
                        <!-- =====================End 1 Controller========================================= -->
                        <!-- =====================Start 1 Controller===========================");
            WriteLiteral(@"============== -->
                        <li class=""nav-item "">
                            <a class=""nav-link active"" href=""#"" data-toggle=""collapse"" aria-expanded=""false"" data-target=""#submenu-5"" aria-controls=""submenu-5""><i class=""fa fa-fw fa-user-circle""></i>Banner <span class=""badge badge-success"">6</span></a>
                            <div id=""submenu-5"" class=""collapse submenu""");
            BeginWriteAttribute("style", " style=\"", 15788, "\"", 15796, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <ul class=""nav flex-column"">
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" href=""/BannerQuangCaos/Index"">Quản Lý Banner</a>
                                    </li>
                                </ul>
                            </div>
                        </li>
                        <!-- =====================End 1 Controller========================================= -->



                    </ul>
                </div>
            </nav>
        </div>
    </div>
    </div>
");
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
