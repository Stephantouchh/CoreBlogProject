#pragma checksum "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminMessage\SendBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b85bfb5d94483883ab7dd14bff36b03fcfb7cddc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminMessage_SendBox), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminMessage/SendBox.cshtml")]
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
#line 1 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\_ViewImports.cshtml"
using DotNetCoreCamp.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\_ViewImports.cshtml"
using DotNetCoreCamp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b85bfb5d94483883ab7dd14bff36b03fcfb7cddc", @"/Areas/Admin/Views/AdminMessage/SendBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"846ee9a585c1fabbfae7f0ad49f68ae0e4b037fc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminMessage_SendBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("index.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right mail-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
  
    ViewData["Title"] = "SendBox";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b85bfb5d94483883ab7dd14bff36b03fcfb7cddc5253", async() => {
                WriteLiteral(@"
    <div class=""wrapper wrapper-content"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""ibox "">
                    <div class=""ibox-content mailbox-content"">
                        <div class=""file-manager"">
                            <a class=""btn btn-block btn-primary compose-mail"" href=""/Admin/AdminMessage/ComposeMessage/"">Yeni Mesaj</a>
                            <div class=""space-25""></div>
                            <h5>Klasörler</h5>
                            <ul class=""folder-list m-b-md"" style=""padding: 0"">
                                <li><a href=""/Admin/AdminMessage/Inbox/""> <i class=""fa fa-inbox ""></i> Gelen Mesajlar <span class=""label label-warning float-right"">16</span> </a></li>
                                <li><a href=""/Admin/AdminMessage/SendBox/""> <i class=""fa fa-envelope-o""></i> Giden Mesajlar</a></li>
                                <li><a href=""mailbox.html""> <i class=""fa fa-certificate""></i> Önemli Mesajlar</a></li>
 ");
                WriteLiteral(@"                               <li><a href=""mailbox.html""> <i class=""fa fa-file-text-o""></i> Taslaklar <span class=""label label-danger float-right"">2</span></a></li>
                                <li><a href=""mailbox.html""> <i class=""fa fa-trash-o""></i> Çöp Kutusu</a></li>
                            </ul>
                            <h5>Kategoriler</h5>
                            <ul class=""category-list"" style=""padding: 0"">
                                <li><a href=""#""> <i class=""fa fa-circle text-navy""></i> İş </a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-danger""></i> Dokümanlar</a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-primary""></i> Sosyal</a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-info""></i> Tanıtımlar</a></li>
                                <li><a href=""#""> <i class=""fa fa-circle text-warning""></i> Talepler</a></li>
                            </ul>
           ");
                WriteLiteral(@"                 <div class=""clearfix""></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-9 animated fadeInRight"">
                <div class=""mail-box-header"">

                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b85bfb5d94483883ab7dd14bff36b03fcfb7cddc7981", async() => {
                    WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control form-control-sm"" name=""search"" placeholder=""Mailde ara..."">
                            <div class=""input-group-btn"">
                                <button type=""submit"" class=""btn btn-sm btn-primary"">
                                    Ara
                                </button>
                            </div>
                        </div>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <h2>
                        Giden Mesajlar (0)
                    </h2>
                    <div class=""mail-tools tooltip-demo m-t-md"">
                        <div class=""btn-group float-right"">
                            <button class=""btn btn-white btn-sm""><i class=""fa fa-arrow-left""></i></button>
                            <button class=""btn btn-white btn-sm""><i class=""fa fa-arrow-right""></i></button>
                        </div>
                        <button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""left"" title=""Gelen Kutusunu Yenile""><i class=""fa fa-refresh""></i> Yenile</button>
                        <button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Okundu olarak işaretle""><i class=""fa fa-eye""></i> </button>
                        <button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Önemli Olarak İşaretle""><i class=""fa fa-exclamation""></i> </button>
               ");
                WriteLiteral(@"         <button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Çöp Kutusuna Taşı""><i class=""fa fa-trash-o""></i> </button>

                    </div>
                </div>
                <div class=""mail-box"">

                    <table class=""table table-hover table-mail"">
                        <tbody>
");
#nullable restore
#line 72 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <tr class=""read"">
                                    <td class=""check-mail"">
                                        <input type=""checkbox"" class=""i-checks"">
                                    </td>
                                    <td class=""mail-ontact""><a href=""mail_detail.html"">");
#nullable restore
#line 78 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
                                                                                  Write(item.ReceiverUser.WriterName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                    <td class=\"mail-subject\"><a href=\"mail_detail.html\">");
#nullable restore
#line 79 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
                                                                                   Write(item.Subject);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                    <td>\r\n");
#nullable restore
#line 81 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
                                         if (item.MessageStatus)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <span class=\"badge badge-info\">Mesaj Okundu!</span>\r\n");
#nullable restore
#line 84 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <span class=\"badge badge-success\">Mesaj Okunmadı!</span>\r\n");
#nullable restore
#line 88 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </td>\r\n                                    <td class=\"text-right mail-date\">");
#nullable restore
#line 90 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
                                                                 Write(((DateTime)item.MessageDate).ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 92 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminMessage\SendBox.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; }
    }
}
#pragma warning restore 1591
