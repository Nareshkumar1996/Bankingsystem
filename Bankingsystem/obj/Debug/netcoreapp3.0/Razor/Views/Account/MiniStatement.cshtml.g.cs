#pragma checksum "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MiniStatement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7848e0f59dfe83809e0f73a90c3e830e9e5c2f6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_MiniStatement), @"mvc.1.0.view", @"/Views/Account/MiniStatement.cshtml")]
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
#line 1 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\_ViewImports.cshtml"
using Bankingsystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\_ViewImports.cshtml"
using Bankingsystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\_ViewImports.cshtml"
using Bankingsystem.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\_ViewImports.cshtml"
using static Bankingsystem.Models.RoleViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7848e0f59dfe83809e0f73a90c3e830e9e5c2f6e", @"/Views/Account/MiniStatement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7cb4160e3347cc132d423df2e983ec0a2931b3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_MiniStatement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Transaction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SideBars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7848e0f59dfe83809e0f73a90c3e830e9e5c2f6e4052", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div id=""pdfconverter"" class=""col-md-9"">

    <table class=""table table-striped table-dark"">
        <tr>
            <th>Transaction ID</th>
            <th>Date Time</th>
            <th>Narration</th>
            <th>Withdrawl</th>
            <th>Deposit</th>
            <th>Closing Balance</th>
        </tr>
");
#nullable restore
#line 15 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MiniStatement.cshtml"
         foreach (var transaction in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MiniStatement.cshtml"
               Write(transaction.TransactionID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MiniStatement.cshtml"
               Write(transaction.Datetime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MiniStatement.cshtml"
               Write(transaction.Narration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MiniStatement.cshtml"
               Write(transaction.Withdrawl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MiniStatement.cshtml"
               Write(transaction.Deposit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MiniStatement.cshtml"
               Write(transaction.ClosingBalance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MiniStatement.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
