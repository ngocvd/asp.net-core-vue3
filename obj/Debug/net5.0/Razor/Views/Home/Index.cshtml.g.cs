#pragma checksum "D:\CS\Vue\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3176cf62dd7b8f101ce47dafa22e3d68ca20e71e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\CS\Vue\Views\_ViewImports.cshtml"
using vue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CS\Vue\Views\_ViewImports.cshtml"
using vue.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3176cf62dd7b8f101ce47dafa22e3d68ca20e71e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8a6b1b7ff61bf3521b8497f46ed94dbacbacad7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\CS\Vue\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n<script>\r\n    let myMixin = {\r\n        data() {\r\n            return {\r\n                date: null,\r\n                url: \'http://url\',\r\n                options: {},\r\n            }\r\n        },\r\n\r\n    };\r\n</script>\r\n");
            }
            );
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome\r\n        <b-icon-facebook />\r\n    </h1>\r\n    <bar-chart");
            BeginWriteAttribute(":url", " :url=\"", 398, "\"", 405, 0);
            EndWriteAttribute();
            WriteLiteral(@"></bar-chart>
    <input v-maska=""{ mask: ['!#HHHHHH', '!#HHHHHH-HH'], tokens: { 'H': { pattern: /[0-9a-fA-F]/, uppercase: true }}}"">n
</div>
<p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
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
