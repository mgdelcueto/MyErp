#pragma checksum "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/ConEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a614e2100fed215431c77fede5732ec7fdf027f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TPerson_ConEdit), @"mvc.1.0.view", @"/Views/TPerson/ConEdit.cshtml")]
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
#line 1 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/ConEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a614e2100fed215431c77fede5732ec7fdf027f", @"/Views/TPerson/ConEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TPerson_ConEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TPContract>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"visicont-titlesble\">\n<h1>Edit a Career record</h1>\n</div>\n");
#nullable restore
#line 6 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/ConEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\n    ");
#nullable restore
#line 8 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/ConEdit.cshtml"
Write(Html.HiddenFor(p => p.ConId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 9 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/ConEdit.cshtml"
Write(Html.HiddenFor(p => p.ConPerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 10 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/ConEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <table class=\"table-norm\" border=\"1\">\n        <tr>\n            <td>Nombre</td>\n            <td>");
#nullable restore
#line 14 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/ConEdit.cshtml"
            Write(((TPerson)ViewBag.Person).PerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Apellidos</td>\n            <td>");
#nullable restore
#line 18 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/ConEdit.cshtml"
            Write(((TPerson)ViewBag.Person).PerName1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </table>\n    <table class=\"table-norm\" border=\"1\">\n        <hr style=\"width:100%;text-align:left;margin-left:0\">\n        <tr>\n            <td>");
#nullable restore
#line 24 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/ConEdit.cshtml"
           Write(Html.LabelFor(p => p.ConRevDate,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 25 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/ConEdit.cshtml"
           Write(Html.EditorFor(p => p.ConRevDate, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 29 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/ConEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.ConRevDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 32 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/ConEdit.cshtml"
           Write(Html.LabelFor(p => p.ConObs,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 33 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/ConEdit.cshtml"
           Write(Html.EditorFor(p => p.ConObs, new { htmlAttributes = new { @class = "norm-text", @style = "width:455px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 37 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/ConEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.ConObs));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td></td>\n            <td><input type=\"submit\" value=\"Update\"  name=\"actionType\"/></td>\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\n        </tr>\n    </table>\n    </div>\n");
#nullable restore
#line 46 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/ConEdit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TPContract> Html { get; private set; }
    }
}
#pragma warning restore 1591
