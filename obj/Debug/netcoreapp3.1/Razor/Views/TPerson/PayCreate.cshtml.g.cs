#pragma checksum "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23a25233d23bf5b00491bf565a2a765cfae2d1da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TPerson_PayCreate), @"mvc.1.0.view", @"/Views/TPerson/PayCreate.cshtml")]
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
#line 1 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23a25233d23bf5b00491bf565a2a765cfae2d1da", @"/Views/TPerson/PayCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TPerson_PayCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TPPay>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"cont-titles\">\n<h1>Add a New Pay record</h1>\n</div>\n");
#nullable restore
#line 6 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\n    ");
#nullable restore
#line 8 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <table class=\"table-norm\" border=\"1\">\n        <tr>\n            <input type=\"hidden\" name=\"PayPerId\"");
            BeginWriteAttribute("value", " value=\"", 287, "\"", 329, 1);
#nullable restore
#line 11 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
WriteAttributeValue("", 295, ((TPerson)ViewBag.Person).PerId, 295, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\n            <td>Nombre :</td>\n            <td>");
#nullable restore
#line 13 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
            Write(((TPerson)ViewBag.Person).PerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td> </td>\n            <td>");
#nullable restore
#line 15 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
            Write(((TPerson)ViewBag.Person).PerName1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </table>\n    <table class=\"table-norm\" border=\"1\">\n        <hr style=\"width:100%;text-align:left;margin-left:0\">\n        <tr>\n            <td>");
#nullable restore
#line 21 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
           Write(Html.LabelFor(p => p.PayStDate,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 22 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
           Write(Html.EditorFor(p => p.PayStDate, new { htmlAttributes = new { @class = "norm-text"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 26 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.PayStDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 29 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
           Write(Html.LabelFor(p => p.PayType,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 30 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
           Write(Html.EditorFor(p => p.PayType, new { htmlAttributes = new { @class = "norm-text", @style = "width:175px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 34 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.PayType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 37 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
           Write(Html.LabelFor(p => p.PayRet,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 38 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
           Write(Html.EditorFor(p => p.PayRet, new { htmlAttributes = new { @class = "norm-text", @style = "width:175px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 42 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.PayRet));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 45 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
           Write(Html.LabelFor(p => p.PayAccount,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 46 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
           Write(Html.EditorFor(p => p.PayAccount, new { htmlAttributes = new { @class = "norm-text", @style = "width:225px"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 50 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.PayAccount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td></td>\n            <td><input type=\"submit\" value=\"Add\"  name=\"actionType\"/></td>\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\n\n        </tr>\n    </table>\n    </div>\n");
#nullable restore
#line 60 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TPerson/PayCreate.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TPPay> Html { get; private set; }
    }
}
#pragma warning restore 1591
