#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\RolCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9471ef6c76ec029ec87b06728fb3e839921664c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TOrganiza_RolCreate), @"mvc.1.0.view", @"/Views/TOrganiza/RolCreate.cshtml")]
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\RolCreate.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\RolCreate.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9471ef6c76ec029ec87b06728fb3e839921664c", @"/Views/TOrganiza/RolCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TOrganiza_RolCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TUsRol>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
            WriteLiteral("<div class=\" clearfix position-relative o_form_sheet center\">\r\n\r\n<div class=\"cont-titles\">\r\n<h3>");
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\RolCreate.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("AdRol"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\RolCreate.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("   <div class=\"visible\">\r\n    ");
#nullable restore
#line 16 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\RolCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-norm\" border =\"1\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\RolCreate.cshtml"
           Write(Html.LabelFor(p => p.UsRolName,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                ");
#nullable restore
#line 21 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\RolCreate.cshtml"
           Write(Html.DropDownListFor(p => p.UsRolName,
               new SelectList(DataSource.GetAppRols(), "Code", "Name"),new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>        \r\n        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\RolCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.UsRolName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n         <tr>\r\n            <td><input type=\"submit\" value=\"Add\"  name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 34 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\RolCreate.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TUsRol> Html { get; private set; }
    }
}
#pragma warning restore 1591
