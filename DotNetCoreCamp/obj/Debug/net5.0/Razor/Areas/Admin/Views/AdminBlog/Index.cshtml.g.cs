#pragma checksum "C:\Users\tb\source\repos\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminBlog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a8b5aba450f16fcda13aa2cdca91f7feee59d48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminBlog_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminBlog/Index.cshtml")]
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
#line 1 "C:\Users\tb\source\repos\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\_ViewImports.cshtml"
using DotNetCoreCamp.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tb\source\repos\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\_ViewImports.cshtml"
using DotNetCoreCamp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\tb\source\repos\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminBlog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a8b5aba450f16fcda13aa2cdca91f7feee59d48", @"/Areas/Admin/Views/AdminBlog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"846ee9a585c1fabbfae7f0ad49f68ae0e4b037fc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminBlog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\tb\source\repos\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminBlog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a8b5aba450f16fcda13aa2cdca91f7feee59d483782", async() => {
                WriteLiteral("\r\n    <div class=\"wrapper wrapper-content animated fadeInRight\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 14 "C:\Users\tb\source\repos\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminBlog\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-md-3\">\r\n                    <div class=\"ibox\">\r\n                        <div class=\"ibox-content product-box\">\r\n\r\n                            <div>\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 542, "\"", 563, 1);
#nullable restore
#line 21 "C:\Users\tb\source\repos\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminBlog\Index.cshtml"
WriteAttributeValue("", 548, item.BlogImage, 548, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" height=\"250\" width=\"325\" />\r\n                            </div>\r\n                            <div class=\"product-desc\">\r\n                                <span class=\"product-price\">\r\n                                    ");
#nullable restore
#line 25 "C:\Users\tb\source\repos\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                Write(((DateTime)item.BlogCreateDate).ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </span>\r\n                                <small class=\"text-muted\">");
#nullable restore
#line 27 "C:\Users\tb\source\repos\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                                     Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 1015, "\"", 1052, 2);
                WriteAttributeValue("", 1022, "/Blog/BlogReadAll/", 1022, 18, true);
#nullable restore
#line 28 "C:\Users\tb\source\repos\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminBlog\Index.cshtml"
WriteAttributeValue("", 1040, item.BlogID, 1040, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"product-name\"> ");
#nullable restore
#line 28 "C:\Users\tb\source\repos\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminBlog\Index.cshtml"
                                                                                          Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n\r\n\r\n\r\n                                <div class=\"small m-t-xs\">\r\n                                    ");
#nullable restore
#line 33 "C:\Users\tb\source\repos\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminBlog\Index.cshtml"
                               Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 130).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
                WriteLiteral("...\r\n                                </div>\r\n                                <div class=\"m-t text-righ\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 1426, "\"", 1463, 2);
                WriteAttributeValue("", 1433, "/Blog/BlogReadAll/", 1433, 18, true);
#nullable restore
#line 36 "C:\Users\tb\source\repos\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminBlog\Index.cshtml"
WriteAttributeValue("", 1451, item.BlogID, 1451, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-xs btn-outline btn-primary"">Detaylar <i class=""fa fa-long-arrow-right""></i> </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 42 "C:\Users\tb\source\repos\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminBlog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
