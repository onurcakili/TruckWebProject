#pragma checksum "C:\Users\Onur\Desktop\TruckWebProject\TruckWebProject\TruckWebProject\Views\Home\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28cfc777199fca75653fe168b83fb61084c52386"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Test), @"mvc.1.0.view", @"/Views/Home/Test.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28cfc777199fca75653fe168b83fb61084c52386", @"/Views/Home/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6442a179f92f46295ca10b1b66842a6a714769d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Onur\Desktop\TruckWebProject\TruckWebProject\TruckWebProject\Views\Home\Test.cshtml"
  
    ViewData["Title"] = "Test";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Test</h1>
<h3>Burası kendi oluşturduğumuz view sayfasıdır</h3>

<table>
    <tr>
        <th>ID</th>
        <th>Adi</th>
        <th>Soyadi</th> 
    </tr>
    
    <tr>
        <td>1</td>
        <td>Onur</td>
        <td>Cakili</td>
    </tr>

    <tr>
        <td>2</td>
        <td>Kazim</td>
        <td>Cakili</td>
    </tr>

</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
