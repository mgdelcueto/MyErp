#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e642323325bb2dcfbc7d252a4dbeb44b10e8a38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TOrganiza_Edit), @"mvc.1.0.view", @"/Views/TOrganiza/Edit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 2 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e642323325bb2dcfbc7d252a4dbeb44b10e8a38", @"/Views/TOrganiza/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TOrganiza_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TOrganizacion>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
  Layout = "_LyIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(" \r\n");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
 using (Html.BeginForm()) {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
Write(Html.HiddenFor(p => p.OrgId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    <table>\r\n        <div class=\"cont-titles\">\r\n        <h2>");
#nullable restore
#line 17 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("OrgData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        </div>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.LabelFor(p => p.OrgCode,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.EditorFor(p => p.OrgCode, new { htmlAttributes = new { @class = "norm-text", @style = "width:300px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.OrgCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.LabelFor(p => p.OrgName,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.EditorFor(p => p.OrgName, new { htmlAttributes = new { @class = "norm-text", @style = "width:300px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.OrgName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.LabelFor(p => p.OrgNif,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.EditorFor(p => p.OrgNif, new { htmlAttributes = new { @class = "norm-text", @style = "width:120px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.OrgNif));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.LabelFor(p => p.OrgDate,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 45 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.EditorFor(p => p.OrgDate, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 49 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.OrgDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.LabelFor(p => p.OrgCity,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 53 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.EditorFor(p => p.OrgCity, new { htmlAttributes = new { @class = "norm-text", @style = "width:200px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 57 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.OrgCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 60 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.LabelFor(p => p.OrgCtry,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"norm-text\">\r\n                ");
#nullable restore
#line 62 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.DropDownListFor(p => p.OrgCtry,
               new SelectList(DataSource.GetCountry(), "Code", "Name"),new { @class = "norm-text" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 67 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.LabelFor(p => p.OrgAdress,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 68 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.EditorFor(p => p.OrgAdress, new { htmlAttributes = new { @class = "norm-text", @style = "width:300px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 69 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.LabelFor(p => p.OrgEmail,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 70 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.EditorFor(p => p.OrgEmail, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 74 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.OrgAdress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 76 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.OrgEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 79 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.LabelFor(p => p.OrgAdressad,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 80 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.EditorFor(p => p.OrgAdressad, new { htmlAttributes = new { @class = "norm-text", @style = "width:300px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 81 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.LabelFor(p => p.OrgTel,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 82 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.EditorFor(p => p.OrgTel, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 86 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.OrgAdressad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 88 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.OrgTel));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 91 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.LabelFor(p => p.OrgWeb,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 92 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.EditorFor(p => p.OrgWeb, new { htmlAttributes = new { @class = "norm-text", @style = "width:300px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 96 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
           Write(Html.ValidationMessageFor(p => p.OrgWeb));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
        </tr>
        <tr>
            <td></td>
            <td><input type=""submit"" value=""Update""  name=""actionType""/></td>
            <td><input type=""submit"" value=""Cancel""  name=""actionType""/></td>
        </tr>
    </table>
    </div>
");
#nullable restore
#line 105 "C:\Users\mgdel\VSProjects\MyErp\Views\TOrganiza\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TOrganizacion> Html { get; private set; }
    }
}
#pragma warning restore 1591
