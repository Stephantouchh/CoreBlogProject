#pragma checksum "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminRole\UpdateRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf11f1d10ee9a5baa6bcd9e3ad025b7e7096c5af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminRole_UpdateRole), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminRole/UpdateRole.cshtml")]
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
#line 1 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminRole\UpdateRole.cshtml"
using DotNetCoreCamp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf11f1d10ee9a5baa6bcd9e3ad025b7e7096c5af", @"/Areas/Admin/Views/AdminRole/UpdateRole.cshtml")]
    public class Areas_Admin_Views_AdminRole_UpdateRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleUpdateViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminRole\UpdateRole.cshtml"
  
    ViewData["Title"] = "UpdateRole";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Rol Düzenleme Sayfası</h1>\r\n<form method=\"post\">\r\n    <div class=\"form-group\">\r\n        <input type=\"hidden\" name=\"Id\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 300, "\"", 317, 1);
#nullable restore
#line 11 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminRole\UpdateRole.cshtml"
WriteAttributeValue("", 308, Model.Id, 308, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n        <label>Rol Başlığı</label>\r\n        <input type=\"text\" name=\"name\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 417, "\"", 436, 1);
#nullable restore
#line 13 "C:\Users\by\source\repos\Asp.Net Core Mvc5 Blog Projesi\Github\CoreBlogProject\DotNetCoreCamp\Areas\Admin\Views\AdminRole\UpdateRole.cshtml"
WriteAttributeValue("", 425, Model.name, 425, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n    </div>\r\n    <button class=\"btn btn-success\">Güncelle</button>\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleUpdateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
