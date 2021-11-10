#pragma checksum "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "588f15cfe8875f43647d409c5b33b9fda4d0186b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
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
#line 1 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\_ViewImports.cshtml"
using DotNetCoreCamp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\_ViewImports.cshtml"
using DotNetCoreCamp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"588f15cfe8875f43647d409c5b33b9fda4d0186b", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e06a52ab9f63d5c9aacfe452a58100eb701d9ad8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogListDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Son 10 Blog</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Başlık</th>
                                <th>Kategori</th>
                                <th>Tarih</th>
                                <th>Detaylar</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 21 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 945, "\"", 966, 1);
#nullable restore
#line 25 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 951, item.BlogImage, 951, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\">\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 27 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                   Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <label class=\"badge badge-gradient-success\">");
#nullable restore
#line 29 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                                                               Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                    </td>\r\n                                    <td> ");
#nullable restore
#line 31 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                     Write(((DateTime)item.BlogCreateDate).ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1455, "\"", 1492, 2);
            WriteAttributeValue("", 1462, "/Blog/BlogReadAll/", 1462, 18, true);
#nullable restore
#line 32 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 1480, item.BlogID, 1480, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Detaylar</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 34 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
