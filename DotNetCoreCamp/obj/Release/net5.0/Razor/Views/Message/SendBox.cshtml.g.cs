#pragma checksum "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Message\SendBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8578479026d302a54394e0bd6bb691bec7ff86e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_SendBox), @"mvc.1.0.view", @"/Views/Message/SendBox.cshtml")]
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
#line 1 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Message\SendBox.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8578479026d302a54394e0bd6bb691bec7ff86e0", @"/Views/Message/SendBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e06a52ab9f63d5c9aacfe452a58100eb701d9ad8", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_SendBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Message\SendBox.cshtml"
  
    ViewData["Title"] = "SendBox";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Giden Kutusu</h1>\r\n<br />\r\n<table class=\"table table-hover\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Konu</th>\r\n        <th>Alıcı</th>\r\n        <th>Tarih</th>\r\n        <th>Mesaj Durumu</th>\r\n        <th>Mesajı Aç</th>\r\n    </tr>\r\n");
#nullable restore
#line 26 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Message\SendBox.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 29 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Message\SendBox.cshtml"
           Write(item.MessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Message\SendBox.cshtml"
           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Message\SendBox.cshtml"
           Write(item.ReceiverUser.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 32 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Message\SendBox.cshtml"
             Write(((DateTime)item.MessageDate).ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 34 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Message\SendBox.cshtml"
                 if (item.MessageStatus)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-info\">Mesaj Okundu!</span>\r\n");
#nullable restore
#line 37 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Message\SendBox.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-success\">Mesaj Okunmadı!</span>\r\n");
#nullable restore
#line 41 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Message\SendBox.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1126, "\"", 1172, 2);
            WriteAttributeValue("", 1133, "/Message/MessageDetails/", 1133, 24, true);
#nullable restore
#line 43 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Message\SendBox.cshtml"
WriteAttributeValue("", 1157, item.MessageID, 1157, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Mesajı Aç</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Views\Message\SendBox.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\n<a href=\"/Message/SendMessage/\" class=\"btn btn-primary\">Yeni Mesaj Oluştur</a>");
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