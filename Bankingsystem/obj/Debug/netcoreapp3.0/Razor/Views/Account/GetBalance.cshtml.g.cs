#pragma checksum "E:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\GetBalance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43f0e46181998df7f1f028ea37fb8665469b6a11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_GetBalance), @"mvc.1.0.view", @"/Views/Account/GetBalance.cshtml")]
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
#line 1 "E:\present git bank project\Bankingsystem\Bankingsystem\Views\_ViewImports.cshtml"
using Bankingsystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\present git bank project\Bankingsystem\Bankingsystem\Views\_ViewImports.cshtml"
using Bankingsystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\present git bank project\Bankingsystem\Bankingsystem\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\present git bank project\Bankingsystem\Bankingsystem\Views\_ViewImports.cshtml"
using Bankingsystem.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\present git bank project\Bankingsystem\Bankingsystem\Views\_ViewImports.cshtml"
using static Bankingsystem.Models.RoleViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43f0e46181998df7f1f028ea37fb8665469b6a11", @"/Views/Account/GetBalance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7cb4160e3347cc132d423df2e983ec0a2931b3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_GetBalance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bankingsystem.Models.ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Your Balance Amount is ");
#nullable restore
#line 4 "E:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\GetBalance.cshtml"
                      Write(Model.BalanceAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bankingsystem.Models.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
