#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\Shared\_Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "438e5a7ae9bb633bf490ed047f9a52cca76cc427"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Login), @"mvc.1.0.view", @"/Views/Shared/_Login.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\_ViewImports.cshtml"
using MyErp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\_ViewImports.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\Shared\_Login.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"438e5a7ae9bb633bf490ed047f9a52cca76cc427", @"/Views/Shared/_Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "438e5a7ae9bb633bf490ed047f9a52cca76cc4273990", async() => {
                WriteLiteral("\r\n\r\n  <div class=\"visible\">\r\n    <Table>\r\n    <tr>\r\n        <td><label for=\"UserName\"><b>");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\Shared\_Login.cshtml"
                                Write(SharedLocalizer.GetLocalizedHtmlString("Username"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></label></td>\r\n        <td><input type=\"text\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 289, "\"", 359, 1);
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\Shared\_Login.cshtml"
WriteAttributeValue("", 303, SharedLocalizer.GetLocalizedHtmlString("EnterUsername"), 303, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"UserName\" ></td>\r\n    </tr>\r\n    <tr>\r\n        <td><label for=\"Password\"><b>");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\Shared\_Login.cshtml"
                                Write(SharedLocalizer.GetLocalizedHtmlString("Password"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></label></td>\r\n        <td><input type=\"password\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 547, "\"", 617, 1);
#nullable restore
#line 15 "C:\Users\mgdel\VSProjects\MyErp\Views\Shared\_Login.cshtml"
WriteAttributeValue("", 561, SharedLocalizer.GetLocalizedHtmlString("EnterPassword"), 561, 56, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Password\" ></td>\r\n    </tr>\r\n    <tr>\r\n        <td><button name = \"actionType\" value=\"Login\" type=\"submit\">");
#nullable restore
#line 18 "C:\Users\mgdel\VSProjects\MyErp\Views\Shared\_Login.cshtml"
                                                               Write(SharedLocalizer.GetLocalizedHtmlString("LogIn"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button></td>\r\n        <td><button name =\"actionType\" value=\"Cancel\" type=\"submit\" class=\"cancelbtn\">");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\Shared\_Login.cshtml"
                                                                                 Write(SharedLocalizer.GetLocalizedHtmlString("Cancell"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button></td>\r\n    </tr>\r\n  </Table>\r\n  </div>\r\n  <div>\r\n    <Table>\r\n      <tr>\r\n        <td>\r\n          ");
#nullable restore
#line 27 "C:\Users\mgdel\VSProjects\MyErp\Views\Shared\_Login.cshtml"
     Write(Html.ActionLink(@SharedLocalizer.GetLocalizedHtmlString("ChangePassword"), "ChLogin"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </td>\r\n      </tr>  \r\n    </Table>\r\n  </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LocService SharedLocalizer { get; private set; }
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