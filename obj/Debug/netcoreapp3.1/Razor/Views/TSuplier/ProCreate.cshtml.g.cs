#pragma checksum "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbfb30280132c07e66247ac45fe58f85ccabb4ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TSuplier_ProCreate), @"mvc.1.0.view", @"/Views/TSuplier/ProCreate.cshtml")]
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
#line 1 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
using MyErp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
using MyErp.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbfb30280132c07e66247ac45fe58f85ccabb4ba", @"/Views/TSuplier/ProCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d609814d212c9728dbea809f21ddf96f133c51f2", @"/Views/_ViewImports.cshtml")]
    public class Views_TSuplier_ProCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TSProduct>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"cont-titles\">\r\n<h2>");
#nullable restore
#line 6 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("AddProdRecord"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>\r\n");
#nullable restore
#line 8 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
 using (Html.BeginForm()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"visible\">\r\n    ");
#nullable restore
#line 10 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table-norm\" border =\"1\">\r\n        <tr>\r\n            <input type=\"hidden\" name=\"ProdSupId\"");
            BeginWriteAttribute("value", " value=\"", 399, "\"", 443, 1);
#nullable restore
#line 13 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
WriteAttributeValue("", 407, ((TSuplier)ViewBag.Suplier).SupId, 407, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Suplier"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
            Write(((TSuplier)ViewBag.Suplier).SupRasoc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td> </td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
            Write(((TSuplier)ViewBag.Suplier).SupNif);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n    <table class=\"table-norm\" border =\"1\">\r\n        <hr style=\"width:100%;text-align:left;margin-left:0\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
           Write(Html.LabelFor(p => p.ProdRefer,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
           Write(Html.EditorFor(p => p.ProdRefer, new { htmlAttributes = new { @class = "norm-num", @style = "width:220px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.ProdRefer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
           Write(Html.LabelFor(p => p.ProdDescr,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
           Write(Html.EditorFor(p => p.ProdDescr, new { htmlAttributes = new { @class = "norm-num", @style = "width:420px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.ProdDescr));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
           Write(Html.LabelFor(p => p.ProdCrDate,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
           Write(Html.EditorFor(p => p.ProdCrDate, new { htmlAttributes = new { @class = "norm-num" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.ProdCrDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 46 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
           Write(Html.LabelFor(p => p.ProdStatus,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 47 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
           Write(Html.EditorFor(p => p.ProdStatus, new { htmlAttributes = new { @class = "norm-num", @style = "width:120px" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 50 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.ProdStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 53 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
           Write(Html.LabelFor(p => p.ProdStDate,new { @class = "norm-text",}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 54 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
           Write(Html.EditorFor(p => p.ProdStDate, new { htmlAttributes = new { @class = "norm-num"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <tr>\r\n            <td></td>\r\n            <td>");
#nullable restore
#line 57 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
           Write(Html.ValidationMessageFor(p => p.ProdStDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td><input type=\"submit\" value=\"Add\"  name=\"actionType\"/></td>\r\n            <td><input type=\"submit\" value=\"Cancel\" name=\"actionType\"/></td>\r\n        </tr>\r\n    </table>\r\n    </div>\r\n");
#nullable restore
#line 66 "C:\Users\mgdel\VSProjects\MyErp\Views\TSuplier\ProCreate.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TSProduct> Html { get; private set; }
    }
}
#pragma warning restore 1591
