#pragma checksum "C:\Users\Onur\Desktop\TruckWebProject\TruckWebProject\TruckWebProject\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "222d3af22729c62f1adbae176683bb1268e1aed9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\Onur\Desktop\TruckWebProject\TruckWebProject\TruckWebProject\Views\_ViewImports.cshtml"
using TruckWebProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Onur\Desktop\TruckWebProject\TruckWebProject\TruckWebProject\Views\_ViewImports.cshtml"
using TruckWebProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Onur\Desktop\TruckWebProject\TruckWebProject\TruckWebProject\Views\Category\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"222d3af22729c62f1adbae176683bb1268e1aed9", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6442a179f92f46295ca10b1b66842a6a714769d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Onur\Desktop\TruckWebProject\TruckWebProject\TruckWebProject\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>CategoryID</th>\r\n        <th>CategoryAdi</th>\r\n        <th>CategoryDescription</th>\r\n        <th>CategorySil</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\Onur\Desktop\TruckWebProject\TruckWebProject\TruckWebProject\Views\Category\Index.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <tr>\r\n           <td>");
#nullable restore
#line 19 "C:\Users\Onur\Desktop\TruckWebProject\TruckWebProject\TruckWebProject\Views\Category\Index.cshtml"
          Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 20 "C:\Users\Onur\Desktop\TruckWebProject\TruckWebProject\TruckWebProject\Views\Category\Index.cshtml"
          Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 21 "C:\Users\Onur\Desktop\TruckWebProject\TruckWebProject\TruckWebProject\Views\Category\Index.cshtml"
          Write(item.CategoryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td><a href=\"#\" class=\"btn btn-warning\">CategoryDescription</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-danger\">Sil</a></td>\r\n       </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Onur\Desktop\TruckWebProject\TruckWebProject\TruckWebProject\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
