#pragma checksum "D:\AutoMotiveWorkshopManagement\AutoMotiveWorkshop\AutoMotiveWorkshop\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d61a6c27c9dc0960c6282e5c8a6665bff95fc53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#line 1 "D:\AutoMotiveWorkshopManagement\AutoMotiveWorkshop\AutoMotiveWorkshop\Views\_ViewImports.cshtml"
using AutoMotiveWorkshop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AutoMotiveWorkshopManagement\AutoMotiveWorkshop\AutoMotiveWorkshop\Views\_ViewImports.cshtml"
using AutoMotiveWorkshop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d61a6c27c9dc0960c6282e5c8a6665bff95fc53", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"204b04cc2f5a7d9774f2392a8e667c2512106e5c", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AutoMotiveWorkshop.Models.ServiceDueViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\AutoMotiveWorkshopManagement\AutoMotiveWorkshop\AutoMotiveWorkshop\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\AutoMotiveWorkshopManagement\AutoMotiveWorkshop\AutoMotiveWorkshop\Views\Service\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\AutoMotiveWorkshopManagement\AutoMotiveWorkshop\AutoMotiveWorkshop\Views\Service\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.VehicleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\AutoMotiveWorkshopManagement\AutoMotiveWorkshop\AutoMotiveWorkshop\Views\Service\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ServiceDueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 24 "D:\AutoMotiveWorkshopManagement\AutoMotiveWorkshop\AutoMotiveWorkshop\Views\Service\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "D:\AutoMotiveWorkshopManagement\AutoMotiveWorkshop\AutoMotiveWorkshop\Views\Service\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "D:\AutoMotiveWorkshopManagement\AutoMotiveWorkshop\AutoMotiveWorkshop\Views\Service\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.VehicleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "D:\AutoMotiveWorkshopManagement\AutoMotiveWorkshop\AutoMotiveWorkshop\Views\Service\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ServiceDueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "D:\AutoMotiveWorkshopManagement\AutoMotiveWorkshop\AutoMotiveWorkshop\Views\Service\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AutoMotiveWorkshop.Models.ServiceDueViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591