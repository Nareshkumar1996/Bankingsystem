#pragma checksum "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbc27023e45a7b4cbe343c6020dcbbcd7f2308a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_MoreDetails), @"mvc.1.0.view", @"/Views/Account/MoreDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbc27023e45a7b4cbe343c6020dcbbcd7f2308a2", @"/Views/Account/MoreDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7cb4160e3347cc132d423df2e983ec0a2931b3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_MoreDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUser>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dbc27023e45a7b4cbe343c6020dcbbcd7f2308a24280", async() => {
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
<div class=""col-md-9"">
    <table class=""table table-striped table-dark"">
        <tr class=""head"">
            <th>User ID</th>
            <th>User Name</th>
            <th>Account Number</th>
            <th>Email</th>
            <th>EmailConfirmed</th>
            <th>Phone Number</th>
            <th>PhoneNumberConfirmed</th>
            <th>Age</th>
            <th>Balance Amount</th>
        </tr>

        <tr>
            <td>");
#nullable restore
#line 18 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.AccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.EmailConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.PhoneNumberConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.BalanceAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
        </tr>
    </table>
    <table class=""table table-striped table-dark"">
        <tr class=""head"">
            <th>Address</th>
            <th>Age</th>
            <th>Marital Status</th>
            <th>Gender</th>
            <th>State</th>
            <th>City</th>
            <th>Pincode</th>
            <th>Nearest Branch</th>
            <th>Date of Birth</th>
            <th>Aadhaar No</th>
        </tr>

        <tr>
            <td>");
#nullable restore
#line 44 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 46 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.MartialStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 48 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 49 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 50 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.Pincode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 51 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.NearestBranch);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 52 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 53 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
           Write(Model.AadhaarNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 56 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
     if (Model.EmailConfirmed.Equals(false))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbc27023e45a7b4cbe343c6020dcbbcd7f2308a211564", async() => {
                WriteLiteral("\r\n            <input type=\"button\" class=\"w3-bar-item w3-button w3-dark-grey\" value=\"Send Email Confirmation Link\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1892, "\"", 1984, 3);
                WriteAttributeValue("", 1902, "location.href=\'", 1902, 15, true);
#nullable restore
#line 59 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
WriteAttributeValue("", 1917, Url.Action("EmailConfirm", "Account", new { email = Model.Email}), 1917, 66, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1983, "\'", 1983, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 61 "D:\present git bank project\Bankingsystem\Bankingsystem\Views\Account\MoreDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
