#pragma checksum "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a77d97e3e2cd5839677cdcd9e604c8d61b17228"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TSuplier_ProEdit), @"mvc.1.0.view", @"/Views/TSuplier/ProEdit.cshtml")]
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
#line 1 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a77d97e3e2cd5839677cdcd9e604c8d61b17228", @"/Views/TSuplier/ProEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TSuplier_ProEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TSProduct>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"cont-titles\">\n<h1>Edit a Product record</h1>\n</div>\n");
#nullable restore
#line 6 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\n    ");
#nullable restore
#line 8 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
Write(Html.HiddenFor(p => p.ProdId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 9 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
Write(Html.HiddenFor(p => p.ProdSupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 10 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <table class=\"table-norm\" border =\"1\">\n        <tr>\n            <input type=\"hidden\" name=\"ProdSupId\"");
            BeginWriteAttribute("value", " value=\"", 367, "\"", 411, 1);
#nullable restore
#line 13 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
WriteAttributeValue("", 375, ((TSuplier)ViewBag.Suplier).SupId, 375, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\n            <td>Suplier:</td>\n            <td>");
#nullable restore
#line 15 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
            Write(((TSuplier)ViewBag.Suplier).SupRasoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td> </td>\n            <td>");
#nullable restore
#line 19 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
            Write(((TSuplier)ViewBag.Suplier).SupNif);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </table>\n    <table class=\"table-norm\" border =\"1\">\n        <hr style=\"width:100%;text-align:left;margin-left:0\">\n        <tr>\n            <td>");
#nullable restore
#line 25 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
           Write(Html.LabelFor(p => p.ProdRefer,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 26 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
           Write(Html.EditorFor(p => p.ProdRefer, new { htmlAttributes = new { @class = "norm-num", @style = "width:220px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 29 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.ProdRefer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 32 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
           Write(Html.LabelFor(p => p.ProdDescr,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 33 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
           Write(Html.EditorFor(p => p.ProdDescr, new { htmlAttributes = new { @class = "norm-num", @style = "width:420px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 36 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.ProdDescr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 39 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
           Write(Html.LabelFor(p => p.ProdCrDate,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 40 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
           Write(Html.EditorFor(p => p.ProdCrDate, new { htmlAttributes = new { @class = "norm-num" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 43 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.ProdCrDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 46 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
           Write(Html.LabelFor(p => p.ProdStatus,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 47 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
           Write(Html.EditorFor(p => p.ProdStatus, new { htmlAttributes = new { @class = "norm-num", @style = "width:120px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 50 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.ProdStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>");
#nullable restore
#line 53 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
           Write(Html.LabelFor(p => p.ProdStDate,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 54 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
           Write(Html.EditorFor(p => p.ProdStDate, new { htmlAttributes = new { @class = "norm-num"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <tr>\n            <td></td>\n            <td>");
#nullable restore
#line 57 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
           Write(Html.ValidationMessageFor(p => p.ProdStDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n         <tr>\n            <td></td>\n            <td><input type=\"submit\" value=\"Update\"  name=\"actionType\"/></td>\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\n\n        </tr>\n    </table>\n    </div>\n");
#nullable restore
#line 67 "/home/manuel-gabriel/Azure_PRJ/MyErp/Views/TSuplier/ProEdit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TSProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591
