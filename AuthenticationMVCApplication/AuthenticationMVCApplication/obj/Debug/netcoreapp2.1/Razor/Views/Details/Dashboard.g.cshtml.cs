#pragma checksum "D:\DotNet\AuthenticationMVCCoreApplication\AuthenticationMVCApplication\AuthenticationMVCApplication\Views\Details\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "759d6fc53ea14373bb555040177b3914b0b015ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Details_Dashboard), @"mvc.1.0.view", @"/Views/Details/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Details/Dashboard.cshtml", typeof(AspNetCore.Views_Details_Dashboard))]
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
#line 1 "D:\DotNet\AuthenticationMVCCoreApplication\AuthenticationMVCApplication\AuthenticationMVCApplication\Views\_ViewImports.cshtml"
using AuthenticationMVCApplication;

#line default
#line hidden
#line 2 "D:\DotNet\AuthenticationMVCCoreApplication\AuthenticationMVCApplication\AuthenticationMVCApplication\Views\_ViewImports.cshtml"
using AuthenticationMVCApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"759d6fc53ea14373bb555040177b3914b0b015ee", @"/Views/Details/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4046007a81e82b5b2145e1bdbd578a6352b0bc80", @"/Views/_ViewImports.cshtml")]
    public class Views_Details_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserProfile>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\DotNet\AuthenticationMVCCoreApplication\AuthenticationMVCApplication\AuthenticationMVCApplication\Views\Details\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(65, 34, true);
            WriteLiteral("<h2>Dashboard</h2>\r\n\r\n<h3>Welcome ");
            EndContext();
            BeginContext(100, 10, false);
#line 7 "D:\DotNet\AuthenticationMVCCoreApplication\AuthenticationMVCApplication\AuthenticationMVCApplication\Views\Details\Dashboard.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(110, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserProfile> Html { get; private set; }
    }
}
#pragma warning restore 1591
