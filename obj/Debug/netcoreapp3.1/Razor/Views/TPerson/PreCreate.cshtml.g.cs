#pragma checksum "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c7d09bf80fbe7bd4d75d796a52d83dadb626582"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TPerson_PreCreate), @"mvc.1.0.view", @"/Views/TPerson/PreCreate.cshtml")]
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
#line 1 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/_ViewImports.cshtml"
using MyErp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c7d09bf80fbe7bd4d75d796a52d83dadb626582", @"/Views/TPerson/PreCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TPerson_PreCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TPPresen>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"cont-titles\">\n<h1>Add a New Presence record</h1>\n</div>\n");
#nullable restore
#line 6 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\n    ");
#nullable restore
#line 8 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <table class=\"table-norm\" border=\"1\">\n        <tr>\n            <input type=\"hidden\" name=\"PresPerId\"");
            BeginWriteAttribute("value", " value=\"", 296, "\"", 338, 1);
#nullable restore
#line 11 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml"
WriteAttributeValue("", 304, ((TPerson)ViewBag.Person).PerId, 304, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\n            <td>Nombre :</td>\n            <td>");
#nullable restore
#line 13 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml"
            Write(((TPerson)ViewBag.Person).PerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td> </td>\n            <td>");
#nullable restore
#line 15 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml"
            Write(((TPerson)ViewBag.Person).PerName1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </table>\n    <table class=\"table-norm\" border=\"1\">\n        <tr>\n            <td>");
#nullable restore
#line 20 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml"
           Write(Html.LabelFor(p => p.PresLocal,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 21 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml"
           Write(Html.EditorFor(p => p.PresLocal, new { htmlAttributes = new { @class = "norm-text", @style = "width:225px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 25 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.PresLocal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 28 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml"
           Write(Html.LabelFor(p => p.PresDateEvent,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 29 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml"
           Write(Html.EditorFor(p => p.PresDateEvent, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 33 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.PresDateEvent));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 36 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml"
           Write(Html.LabelFor(p => p.PresTimeEvent,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 37 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml"
           Write(Html.EditorFor(p => p.PresTimeEvent, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 41 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.PresTimeEvent));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td></td>\n            <td><input type=\"submit\" value=\"Add\" name=\"actionType\"/></td>\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\n\n        </tr>\n    </table>\n    </div>\n");
#nullable restore
#line 51 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PreCreate.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TPPresen> Html { get; private set; }
    }
}
#pragma warning restore 1591
